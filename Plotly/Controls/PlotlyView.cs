using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

using Plotly.Models;

using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;

//https://github.com/cefsharp/CefSharp
//https://github.com/cefsharp/CefSharp.MinimalExample/tree/master/CefSharp.MinimalExample.Wpf


[assembly: XmlnsPrefix("http://www.plotly.com", "plotly")]
[assembly: XmlnsDefinition("http://www.plotly.com", "Plotly")]

namespace Plotly
{
    [TemplatePart(Name        = "WebViewElement", Type  = typeof(WebView2))]
    //[TemplateVisualState(Name = "Navigating", GroupName = "ValueStates")]
    //[TemplateVisualState(Name = "Waiting", GroupName    = "ValueStates")]
    //[TemplateVisualState(Name = "Focused", GroupName    = "FocusedStates")]
    //[TemplateVisualState(Name = "Unfocused", GroupName  = "FocusedStates")]
    public class PlotlyView : Control
    {
        private static readonly string Plotly_folder;
        static PlotlyView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlotlyView), new FrameworkPropertyMetadata(typeof(PlotlyView)));
            
            Plotly_folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plotly");

            if(!Directory.Exists(Plotly_folder))
            {
                Directory.CreateDirectory(Plotly_folder);
            }
        }

        #region DataSource Property

        public Dictionary<string, (string type, object[] array)> DataSource
        {
            get { return (Dictionary<string, (string type, object[] array)>)GetValue(DataSourceProperty); }
            set { SetValue(DataSourceProperty, value); }
        }

        public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register("DataSource",
                                                                                                   typeof(Dictionary<string, (string type, object[] array)>),
                                                                                                   typeof(PlotlyView),
                                                                                                   new FrameworkPropertyMetadata(null, OnDataSourcePropertyChanged));

        private static void OnDataSourcePropertyChanged(DependencyObject                   sender,
                                                        DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnDataSourcePropertyChanged");

            if(sender is PlotlyView plotlyView && e.NewValue is Dictionary<string, (string type, object[] array)> data_source)
            {
                plotlyView.CsPlotlyPlot.DataSource = data_source;

                if(!plotlyView.IsNavigating)
                {
                    PlotlyEvent @event = new(plotlyView.Id, "DataSourceUpdated");
                    plotlyView.WebViewElement?.CoreWebView2?.PostWebMessageAsJson(@event.ToJson());
                }
            }
        }

        #endregion

        #region PlotData Property

        public List<ITrace> PlotData
        {
            get { return (List<ITrace>)GetValue(PlotDataProperty); }
            set { SetValue(PlotDataProperty, value); }
        }

        public static readonly DependencyProperty PlotDataProperty =
            DependencyProperty.Register("PlotData", typeof(List<ITrace>), typeof(PlotlyView), new FrameworkPropertyMetadata(default, OnPlotDataPropertyChanged));

        private static void OnPlotDataPropertyChanged(DependencyObject                   sender,
                                                      DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnPlotDataPropertyChanged");

            if(sender is PlotlyView plotlyView && e.NewValue is List<ITrace> plotData)
            {
                plotlyView.CsPlotlyPlot.PlotData = plotData;

                if(!plotlyView.IsNavigating)
                {
                    PlotlyEvent @event = new(plotlyView.Id, "PlotDataUpdated");
                    plotlyView.WebViewElement?.CoreWebView2?.PostWebMessageAsJson(@event.ToJson());
                }
            }
        }

        #endregion

        #region PlotLayout Property

        public Layout PlotLayout
        {
            get { return (Layout)GetValue(PlotLayoutProperty); }
            set { SetValue(PlotLayoutProperty, value); }
        }

        public static readonly DependencyProperty PlotLayoutProperty =
            DependencyProperty.Register("PlotLayout", typeof(Layout), typeof(PlotlyView), new FrameworkPropertyMetadata(default, OnPlotLayoutPropertyChanged));

        private static void OnPlotLayoutPropertyChanged(DependencyObject                   sender,
                                                        DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnPlotLayoutPropertyChanged");

            if(sender is PlotlyView plotlyView && e.NewValue is Layout layout)
            {
                plotlyView.CsPlotlyPlot.PlotLayout = layout;

                if(!plotlyView.IsNavigating)
                {
                    PlotlyEvent @event = new(plotlyView.Id, "PlotLayoutUpdated");
                    plotlyView.WebViewElement?.CoreWebView2?.PostWebMessageAsJson(@event.ToJson());
                }
            }
        }

        #endregion

        #region SelectedItems Property

        public SelectedData[]? SelectedItems
        {
            get { return (SelectedData[]?)GetValue(SelectedItemsProperty); }
            set { SetValue(SelectedItemsProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register("SelectedItems", typeof(SelectedData[]), typeof(PlotlyView), new FrameworkPropertyMetadata(null, OnSelectedItemsPropertyChanged));

        private static void OnSelectedItemsPropertyChanged(DependencyObject                   sender,
                                                           DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnSelectedItemsPropertyChanged");

            if(sender is PlotlyView plotlyView && e.NewValue is SelectedData[] selectedData)
            {
            }
        }

        #endregion

        private WebView2? webViewElement;

        private WebView2? WebViewElement
        {
            get { return webViewElement; }

            set
            {
                if(webViewElement != null)
                {
                    webViewElement.NavigationStarting  -= WebView_OnNavigationStarting;
                    webViewElement.NavigationCompleted -= WebView_OnNavigationCompleted;
                }

                webViewElement = value;

                if(webViewElement != null)
                {
                    webViewElement.NavigationStarting  += WebView_OnNavigationStarting;
                    webViewElement.NavigationCompleted += WebView_OnNavigationCompleted;
                }
            }
        }

        public CsPlotlyPlot CsPlotlyPlot { get; set; }

        public bool IsNavigating { get; set; }

        private readonly Guid _id;

        private readonly string Plotly_html_file;

        private readonly Uri SourceUri;

        public string Id { get; }

        private static Guid MakeGuid(string guid)
        {
            if(Guid.TryParse(guid, out Guid newGuid))
            {
                return newGuid;
            }

            return Guid.NewGuid();
        }

        public PlotlyView():this(Guid.NewGuid())
        {}

        public PlotlyView(string guid):this(MakeGuid(guid))
        {}

        public PlotlyView(Guid guid)
        {
            _id = guid;
            Id  = _id.ToString().Replace("-", "_");

            Plotly_html_file = Path.Combine(Plotly_folder, $"Plotly_{Id}.html");

            if(!File.Exists(Plotly_html_file))
            {
                using(StreamWriter sw = new StreamWriter(Plotly_html_file))
                {
                    sw.Write(Plotly.Resources.Plotly_html.Replace("{ID}", Id));
                }
            }
            
            SourceUri = new Uri(Path.Combine("file:///", Plotly_html_file));

            CsPlotlyPlot = new CsPlotlyPlot();

            Dispatcher.ShutdownStarted += Shutdown;
        }

        ~PlotlyView()
        {
            Shutdown(this, new EventArgs());
        }

        private void Shutdown(object?   sender,
                              EventArgs e)
        {
            string Plotly_folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plotly");

            string Plotly_html_file = Path.Combine(Plotly_folder, $"Plotly_{Id}.html");

            if(File.Exists(Plotly_html_file))
            {
                File.Delete(Plotly_html_file);
            }
        }

        private void WebView_OnNavigationStarting(object?                                 sender,
                                                  CoreWebView2NavigationStartingEventArgs e)
        {
            IsNavigating = true;
        }

        private void WebView_OnNavigationCompleted(object?                                  sender,
                                                   CoreWebView2NavigationCompletedEventArgs e)
        {
            IsNavigating = false;

            UpdatePlot();
        }

        private void WebView_CoreWebView2Ready(object?   sender,
                                               EventArgs e)
        {
            if(WebViewElement.CoreWebView2 is not null)
            {
                //if(Debugger.IsAttached)
                //{
                //    WebViewElement.CoreWebView2.OpenDevToolsWindow();
                //}

                WebViewElement.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;

                if(DataSource is null)
                {
                    throw new NullReferenceException(nameof(DataSource));
                }
                if(PlotData is null)
                {
                    throw new NullReferenceException(nameof(PlotData));
                }
                if(PlotLayout is null)
                {
                    throw new NullReferenceException(nameof(PlotLayout));
                }

                CsPlotlyPlot = new CsPlotlyPlot(DataSource, PlotData, PlotLayout);

                WebViewElement.CoreWebView2.AddHostObjectToScript($"CsPlotlyPlot_{Id}", CsPlotlyPlot);
            }
        }

        private void CoreWebView2_WebMessageReceived(object?                                 sender,
                                                     CoreWebView2WebMessageReceivedEventArgs e)
        {
            ProcessCallbackMessage(e.WebMessageAsJson);
        }

        public void ProcessCallbackMessage(string json)
        {
            PlotlyEvent? @event = PlotlyEvent.FromJson(json);

            if(@event != null)
            {
                switch(@event.Event)
                {
                    case "DOMContentLoaded":
                    {
                        //if (shouldUpdatePlot)
                        //{
                        //    UpdatePlot();
                        //}

                        break;
                    }
                    case "PlotlySelected":
                    {
                        if(@event.Selected is not null)
                        {
                            SelectedItems = @event.Selected;
                        }

                        break;
                    }
                    case "PlotlyDeselect":
                    {
                        SelectedItems = Array.Empty<SelectedData>();

                        break;
                    }
                    case "PlotlyAfterPlot":
                    case "PlotlyBeforePlot":
                    case "PlotlyRedraw":
                    case "PlotlyRelayout":
                    case "PlotlyRelayouting":
                    case "PlotlyEvent":
                    case "PlotlyAnimated":
                    case "PlotlyAutosize":
                    case "PlotlyBeforeHover":
                    case "PlotlyClickAnnotation":
                    case "PlotlyDoubleClick":
                    case "PlotlyLegendClick":
                    case "PlotlyLegendDoubleClick":
                    case "PlotlyRestyle":
                    case "PlotlyWebglContextLost":
                    default:
                    {
                        Debug.WriteLine(@event.Event);

                        break;
                    }
                }
            }
        }

        private void UpdatePlot()
        {
            if(!IsNavigating)
            {
                PlotlyEvent @event = new(Id, "PlotUpdated");

                WebViewElement.CoreWebView2?.PostWebMessageAsJson(@event.ToJson());
            }
        }

        //private void UpdateStates(bool useTransitions)
        //{
        //    if(IsNavigating)
        //    {
        //        VisualStateManager.GoToState(this, "Navigating", useTransitions);
        //    }
        //    else
        //    {
        //        VisualStateManager.GoToState(this, "Waiting", useTransitions);
        //    }

        //    if(IsFocused)
        //    {
        //        VisualStateManager.GoToState(this, "Focused", useTransitions);
        //    }
        //    else
        //    {
        //        VisualStateManager.GoToState(this, "Unfocused", useTransitions);
        //    }
        //}

        public override void OnApplyTemplate()
        {
            WebViewElement = GetTemplateChild("WebView") as WebView2;

            InitializeAsync();
        }

        public async void InitializeAsync()
        {
            WebViewElement.Source = SourceUri;

            WebViewElement.CoreWebView2Ready += WebView_CoreWebView2Ready;

            CoreWebView2Environment? env = await CoreWebView2Environment.CreateAsync();

            await WebViewElement.EnsureCoreWebView2Async(env);
        }

        //protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        //{
        //    base.OnMouseLeftButtonDown(e);
        //    Focus();
        //}

        //protected override void OnGotFocus(RoutedEventArgs e)
        //{
        //    base.OnGotFocus(e);
        //    //UpdateStates(true);
        //}

        //protected override void OnLostFocus(RoutedEventArgs e)
        //{
        //    base.OnLostFocus(e);
        //    //UpdateStates(true);
        //}

        public static string ArrayToString(List<object> values)
        {
            StringBuilder data = new(values.Count * 8);

            data.Append($"{values[0]:F8}");

            for(int i = 1; i < values.Count; ++i)
            {
                data.Append($", {values[i]:F8}");
            }

            return data.ToString();
        }

        public static readonly Regex javaScriptObjectRegex = new("\"data_source\\[\"(\\w)\"\\]\"", RegexOptions.Compiled);

        public static string GetFullPath(string relativePath)
        {
            string? basePath = Assembly.GetEntryAssembly()?.GetName().CodeBase;

            if(basePath is null)
            {
                return "";
            }

            Uri location = new(basePath);

            DirectoryInfo? absolutePath = new FileInfo(location.AbsolutePath).Directory;

            return absolutePath is null ? "" : Path.Combine(absolutePath.FullName, relativePath);
        }
    }
}
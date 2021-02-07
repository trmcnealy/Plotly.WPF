using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
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

        public ObservableDictionary<string, (string type, object[] array)> DataSource
        {
            get { return (ObservableDictionary<string, (string type, object[] array)>)GetValue(DataSourceProperty); }
            set
            {
                SetValue(DataSourceProperty, value);

                void DataSource_CollectionChanged(object?                                                         sender,
                                                  System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    DependencyPropertyChangedEventArgs args = new(PlotDataProperty, e.OldItems, e.NewItems);

                    if(sender is DependencyObject dependencyObject)
                    {
                        OnDataSourcePropertyChanged(dependencyObject, args);
                    }
                    else
                    {
                        OnDataSourcePropertyChanged(this, args);
                    }
                }

                DataSource.CollectionChanged -= DataSource_CollectionChanged;
                DataSource.CollectionChanged += DataSource_CollectionChanged;
            }
        }


        public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register("DataSource",
                                                                                                   typeof(ObservableDictionary<string, (string type, object[] array)>),
                                                                                                   typeof(PlotlyView),
                                                                                                   new FrameworkPropertyMetadata(null, OnDataSourcePropertyChanged));

        private static void OnDataSourcePropertyChanged(DependencyObject                   sender,
                                                        DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnDataSourcePropertyChanged");

            if(sender is PlotlyView plotlyView && plotlyView.CsPlotlyPlot is not null && e.NewValue is ObservableDictionary<string, (string type, object[] array)> data_source)
            {
                plotlyView.CsPlotlyPlot.DataSource = data_source.ToDictionary();

                if(!plotlyView.IsNavigating)
                {
                    PlotlyEvent @event = new(plotlyView.Id, "DataSourceUpdated");
                    plotlyView.WebViewElement?.CoreWebView2?.PostWebMessageAsJson(@event.ToJson());
                }
            }
        }

        #endregion

        #region PlotData Property

        public ObservableCollection<ITrace> PlotData
        {
            get { return (ObservableCollection<ITrace>)GetValue(PlotDataProperty); }
            set
            {
                SetValue(PlotDataProperty, value);

                void PlotData_CollectionChanged(object?                                                         sender,
                                                System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    DependencyPropertyChangedEventArgs args = new(PlotDataProperty, e.OldItems, e.NewItems);

                    if(sender is DependencyObject dependencyObject)
                    {
                        OnPlotDataPropertyChanged(dependencyObject, args);
                    }
                    else
                    {
                        OnPlotDataPropertyChanged(this, args);
                    }
                }

                PlotData.CollectionChanged -= PlotData_CollectionChanged;
                PlotData.CollectionChanged += PlotData_CollectionChanged;
            }
        }

        public static readonly DependencyProperty PlotDataProperty =
            DependencyProperty.Register("PlotData", typeof(ObservableCollection<ITrace>), typeof(PlotlyView), new FrameworkPropertyMetadata(default, OnPlotDataPropertyChanged));

        private static void OnPlotDataPropertyChanged(DependencyObject                   sender,
                                                      DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnPlotDataPropertyChanged");

            if(sender is PlotlyView plotlyView && plotlyView.CsPlotlyPlot is not null && e.NewValue is ObservableCollection<ITrace> plotData)
            {
                plotlyView.CsPlotlyPlot.PlotData = plotData.ToList();

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

            if(sender is PlotlyView plotlyView && plotlyView.CsPlotlyPlot is not null && e.NewValue is Layout layout)
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

        #region PlotConfig Property

        public Config? PlotConfig
        {
            get { return (Config?)GetValue(PlotConfigProperty); }
            set { SetValue(PlotConfigProperty, value); }
        }

        public static readonly DependencyProperty PlotConfigProperty =
            DependencyProperty.Register("PlotConfig", typeof(Config), typeof(PlotlyView), new FrameworkPropertyMetadata(default, OnPlotConfigPropertyChanged));

        private static void OnPlotConfigPropertyChanged(DependencyObject                   sender,
                                                        DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnPlotConfigPropertyChanged");

            if(sender is PlotlyView plotlyView && plotlyView.CsPlotlyPlot is not null && e.NewValue is Config config)
            {
                plotlyView.CsPlotlyPlot.PlotConfig = config;

                if(!plotlyView.IsNavigating)
                {
                    PlotlyEvent @event = new(plotlyView.Id, "PlotConfigUpdated");
                    plotlyView.WebViewElement?.CoreWebView2?.PostWebMessageAsJson(@event.ToJson());
                }
            }
        }

        #endregion

        #region PlotFrames Property

        public ObservableCollection<Frames> PlotFrames
        {
            get { return (ObservableCollection<Frames>)GetValue(PlotFramesProperty); }
            set
            {
                SetValue(PlotFramesProperty, value);

                void PlotFrames_CollectionChanged(object?                                                         sender,
                                                  System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    DependencyPropertyChangedEventArgs args = new(PlotFramesProperty, e.OldItems, e.NewItems);

                    if(sender is DependencyObject dependencyObject)
                    {
                        OnPlotFramesPropertyChanged(dependencyObject, args);
                    }
                    else
                    {
                        OnPlotFramesPropertyChanged(this, args);
                    }
                }

                PlotFrames.CollectionChanged -= PlotFrames_CollectionChanged;
                PlotFrames.CollectionChanged += PlotFrames_CollectionChanged;
            }
        }

        public static readonly DependencyProperty PlotFramesProperty =
            DependencyProperty.Register("PlotFrames", typeof(ObservableCollection<Frames>), typeof(PlotlyView), new FrameworkPropertyMetadata(default, OnPlotFramesPropertyChanged));

        private static void OnPlotFramesPropertyChanged(DependencyObject                   sender,
                                                        DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnPlotFramesPropertyChanged");

            if(sender is PlotlyView plotlyView && plotlyView.CsPlotlyPlot is not null && e.NewValue is ObservableCollection<Frames> frames)
            {
                plotlyView.CsPlotlyPlot.PlotFrames = frames.ToList();

                if(!plotlyView.IsNavigating)
                {
                    PlotlyEvent @event = new(plotlyView.Id, "PlotFramesUpdated");
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

            //if(sender is PlotlyView plotlyView && e.NewValue is SelectedData[] selectedData)
            //{
            //}
        }

        #endregion

        public bool EnableLogging
        {
            get { return (bool)GetValue(EnableLoggingProperty); }
            set { SetValue(EnableLoggingProperty, value); }
        }
        
        public static readonly DependencyProperty EnableLoggingProperty = DependencyProperty.Register("EnableLogging", typeof(bool), typeof(PlotlyView), new PropertyMetadata(false));

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

        public CsPlotlyPlot? CsPlotlyPlot { get; set; }

        public bool IsNavigating { get; set; }

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
            Id  = guid.ToString().Replace("-", "_");

            string plotlyHtmlFile = Path.Combine(Plotly_folder, $"Plotly_{Id}.html");

            if(!File.Exists(plotlyHtmlFile))
            {
                using StreamWriter sw = new(plotlyHtmlFile);

                sw.Write(Plotly.Resources.Plotly_html.Replace("%ID%", Id));
            }
            
            SourceUri = new Uri(Path.Combine("file:///", plotlyHtmlFile));

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
            string plotlyFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plotly");

            string plotlyHtmlFile = Path.Combine(plotlyFolder, $"Plotly_{Id}.html");

            if(File.Exists(plotlyHtmlFile))
            {
                File.Delete(plotlyHtmlFile);
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
            if(WebViewElement?.CoreWebView2 is null)
            {
                return;
            }

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

            if(PlotConfig is not null && PlotFrames is null)
            {
                CsPlotlyPlot = new CsPlotlyPlot(EnableLogging, DataSource.ToDictionary(), PlotData.ToList(), PlotLayout, PlotConfig);
            }
            else if(PlotConfig is not null && PlotFrames is not null)
            {
                CsPlotlyPlot = new CsPlotlyPlot(EnableLogging, DataSource.ToDictionary(), PlotData.ToList(), PlotLayout, PlotConfig, PlotFrames.ToList());
            }
            else
            {
                CsPlotlyPlot = new CsPlotlyPlot(EnableLogging, DataSource.ToDictionary(), PlotData.ToList(), PlotLayout);
            }

            WebViewElement.CoreWebView2.AddHostObjectToScript($"CsPlotlyPlot_{Id}", CsPlotlyPlot);
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
                    //case "PlotlyAfterPlot":
                    //case "PlotlyBeforePlot":
                    //case "PlotlyRedraw":
                    //case "PlotlyRelayout":
                    //case "PlotlyRelayouting":
                    //case "PlotlyEvent":
                    //case "PlotlyAnimated":
                    //case "PlotlyAutosize":
                    //case "PlotlyBeforeHover":
                    //case "PlotlyClickAnnotation":
                    //case "PlotlyDoubleClick":
                    //case "PlotlyLegendClick":
                    //case "PlotlyLegendDoubleClick":
                    //case "PlotlyRestyle":
                    //case "PlotlyWebglContextLost":
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
            if(WebViewElement != null)
            {
                WebViewElement.Source = SourceUri;

                WebViewElement.CoreWebView2Ready += WebView_CoreWebView2Ready;

                string?                         browserExecutableFolder = null;
                string?                         userDataFolder          = null;

                //string                          localAppData            = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //string                          cacheFolder             = Path.Combine(localAppData, "WindowsFormsWebView2");

                CoreWebView2EnvironmentOptions? options                 = new ("--disk-cache-size=200");

                CoreWebView2Environment env = await CoreWebView2Environment.CreateAsync(browserExecutableFolder, userDataFolder, options);

                await WebViewElement.EnsureCoreWebView2Async(env);
            }
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
            string basePath = Assembly.GetEntryAssembly()?.GetName().CodeBase;

            if(basePath is null)
            {
                return "";
            }

            Uri location = new(basePath);

            DirectoryInfo absolutePath = new FileInfo(location.AbsolutePath).Directory;

            return absolutePath is null ? "" : Path.Combine(absolutePath.FullName, relativePath);
        }
    }
}
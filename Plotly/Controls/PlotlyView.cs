
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
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




//StaticMap
//https://api.mapbox.com/styles/v1/mapbox/{style_id}/static/{overlay}/{lon},{lat},{zoom},{bearing},{pitch}|{auto}|{bbox}/{width}x{height}{padding}{@2x}?access_token=



//https://github.com/cefsharp/CefSharp
//https://github.com/cefsharp/CefSharp.MinimalExample/tree/master/CefSharp.MinimalExample.Wpf

[assembly: XmlnsPrefix("http://www.plotly.com", "plotly")]
[assembly: XmlnsDefinition("http://www.plotly.com", "Plotly")]
namespace Plotly
{
    [TemplatePart(Name = "WebViewElement", Type = typeof(WebView2))]
    //[TemplateVisualState(Name = "Navigating", GroupName = "ValueStates")]
    //[TemplateVisualState(Name = "Waiting", GroupName    = "ValueStates")]
    //[TemplateVisualState(Name = "Focused", GroupName    = "FocusedStates")]
    //[TemplateVisualState(Name = "Unfocused", GroupName  = "FocusedStates")]
    public class PlotlyView : Control, IDisposable
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
            //Debug.WriteLine("OnDataSourcePropertyChanged");

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
            //Debug.WriteLine("OnPlotDataPropertyChanged");

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
            //Debug.WriteLine("OnPlotLayoutPropertyChanged");

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
            //Debug.WriteLine("OnPlotConfigPropertyChanged");

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

        public ObservableCollection<Frames>? PlotFrames
        {
            get { return (ObservableCollection<Frames>?)GetValue(PlotFramesProperty); }
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
            //Debug.WriteLine("OnPlotFramesPropertyChanged");

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
            //Debug.WriteLine("OnSelectedItemsPropertyChanged");

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

        public bool IsDisposed { get; private set; }

        private KeyGesture modifiers;

        private static Guid MakeGuid(string guid)
        {
            if(Guid.TryParse(guid, out Guid newGuid))
            {
                return newGuid;
            }

            return Guid.NewGuid();
        }

        public PlotlyView()
            : this(Guid.NewGuid())
        {
        }

        public PlotlyView(string guid)
            : this(MakeGuid(guid))
        {
        }

        public PlotlyView(Guid guid)
        {
            Id = guid.ToString().Replace("-", "_");

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
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (IsDisposed)
            {
                return;
            }

            if (disposing)
            {
                Shutdown(this, new EventArgs());

                if (WebViewElement.CoreWebView2 != null)
                {
                    WebViewElement.CoreWebView2.FrameNavigationStarting -= OnFrameNavigationStarting;
                    WebViewElement.CoreWebView2.WebResourceRequested    -= OnWebResourceRequested;
                    WebViewElement.CoreWebView2.NewWindowRequested      -= OnNewWindowRequested;
                    WebViewElement.CoreWebView2.ProcessFailed           -= OnWebViewProcessFailed;

                    //if (Microsoft.PowerBI.Client.Shared.PowerBIApplicationOptions.ForceTracing)
                    //{
                    //    WebViewElement.CoreWebView2.GetDevToolsProtocolEventReceiver("Log.entryAdded").DevToolsProtocolEventReceived           -= this.OnConsoleMessage;
                    //    WebViewElement.CoreWebView2.GetDevToolsProtocolEventReceiver("Runtime.consoleAPICalled").DevToolsProtocolEventReceived -= this.OnConsoleMessage;
                    //}
                }

                WebViewElement.NavigationCompleted -= OnWebViewNavigationCompleted;
                WebViewElement.NavigationStarting  -= OnWebViewNavigationStarting;
                WebViewElement.KeyDown             -= OnKeyDown;

                //this.interop.Dispose();
                //this.interopCoreWrapper.Dispose();
            }
            IsDisposed = true;
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
                        //Debug.WriteLine(@event.Event);

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

        public void CallJavascriptFunction()
        {
            //WebViewElement.CoreWebView2.ExecuteScriptAsync(script);
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

            if(!DesignerProperties.GetIsInDesignMode(this))
            {
                InitializeAsync();
            }
        }

        public async void InitializeAsync()
        {
            if(WebViewElement != null)
            {
                WebViewElement.CoreWebView2InitializationCompleted += WebView_CoreWebView2Ready;

                string? browserExecutableFolder = null;
                string? userDataFolder          = null;

                //string                          localAppData            = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //string                          cacheFolder             = Path.Combine(localAppData, "WindowsFormsWebView2");
                
                CoreWebView2EnvironmentOptions options = new("--disable-features=msSmartScreenProtection --js-flags=\"--max-old-space-size=8192\"", null, null, false);//"--service-sandbox-type=none --no-delay-for-dx12-vulkan-info-collection --webview-draw-functor-uses-vulkan --enable-gpu-rasterization --enable-unsafe-webgpu --enable-unsafe-fast-js-calls --embedded-browser-webview=1 --embedded-browser-webview-dpi-awareness=2 --noerrdialogs --webgl-antialiasing-mode=none --lang=en-US --unlimited-storage");//("--disk-cache-size=1073741824 --enable-features=enable-unsafe-webgpu,enable-gpu-rasterization");

                CoreWebView2Environment env = await CoreWebView2Environment.CreateAsync(browserExecutableFolder, userDataFolder, options);

                await WebViewElement.EnsureCoreWebView2Async(env);

                WebViewElement.NavigationStarting  += OnWebViewNavigationStarting;
                WebViewElement.NavigationCompleted += OnWebViewNavigationCompleted;
                WebViewElement.KeyDown             += OnKeyDown;
                WebViewElement.KeyUp               += OnKeyUp;
                WebViewElement.LostFocus           += OnLostFocus;

                WebViewElement.CoreWebView2.Navigate(SourceUri.AbsoluteUri);
                //WebViewElement.Source = SourceUri;
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

        private static ModifierKeys ToModifier(Key keyCode)
        {
            if (keyCode <= Key.Apps)
            {
                if ((keyCode == Key.LeftCtrl) | (keyCode == Key.RightCtrl))
                {
                    return ModifierKeys.Control;
                }
                if (keyCode != Key.Apps)
                {
                    return ModifierKeys.None;
                }
            }
            else
            {
                if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
                {
                    return ModifierKeys.Control;
                }
                if (keyCode != Key.Apps)
                {
                    return ModifierKeys.None;
                }
            }
            return ModifierKeys.Alt;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            //modifiers |= ToModifier(e.Key);

            //Key key = e.Key | modifiers;

            //if (this.host.PreProcessKeyEvent(key))
            //{
            //    e.Handled = true;
            //    return;
            //}
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            //modifiers &= ~ToModifier(e.Key);
        }

        private void OnLostFocus(object sender, RoutedEventArgs e)
        {
            //modifiers = Key.None;
        }

        private void OnNewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            if (!e.IsUserInitiated)
            {
                e.Handled = true;
                return;
            }
            //bool hasPopupProperties = !string.IsNullOrEmpty(e.Name) || e.WindowFeatures.HasSize || e.WindowFeatures.HasPosition || !e.WindowFeatures.ShouldDisplayMenuBar || !e.WindowFeatures.ShouldDisplayScrollBars || !e.WindowFeatures.ShouldDisplayStatus || !e.WindowFeatures.ShouldDisplayToolbar;
            //e.Handled = this.HandleOnNewWindowRequested(e.Uri, hasPopupProperties);
        }

        private void OnWebViewNavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            //if (this.navigationSuccessCount > 0)
            //{
            //    string webResourceUrl = this.GetWebResourceUrl(e.Uri);
            //    if (!this.Restrictions.CanBrowserNavigateTo(webResourceUrl))
            //    {
            //        if (e.IsUserInitiated && this.Restrictions.CanOpenExternalBrowser(webResourceUrl))
            //        {
            //            this.host.OpenExternalUrl(webResourceUrl, false);
            //        }
            //        e.Cancel = true;
            //        return;
            //    }
            //    this.internals.Init();
            //    EventHandler reloading = this.Reloading;
            //    if (reloading != null)
            //    {
            //        reloading(sender, new EventArgs());
            //    }
            //}
            //this.trace.LogInfo(FormattableString.Invariant(System.Runtime.CompilerServices.FormattableStringFactory.Create("{0} Url={1}", new object[]
            //{
            //    "OnWebViewNavigationStarting",
            //    e.Uri
            //})), null);
        }

        private void OnWebViewNavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs args)
        {
            //if (args.IsSuccess)
            //{
            //    if (this.navigationSuccessCount > 0)
            //    {
            //        EventHandler reloaded = this.Reloaded;
            //        if (reloaded != null)
            //        {
            //            reloaded(sender, new EventArgs());
            //        }
            //    }
            //    this.navigationSuccessCount++;
            //    if (Microsoft.PowerBI.Client.Shared.PowerBIApplicationOptions.ShowDevToolsAtStartup || Microsoft.PowerBI.Client.Shared.PowerBIApplicationOptions.ShowDevToolsForBrowsers.ToUpperInvariant().Contains(this.name.ToUpperInvariant()))
            //    {
            //        this.ShowDevTools();
            //    }
            //}
            //else if (args.WebErrorStatus != CoreWebView2WebErrorStatus.OperationCanceled && this.navigationFailedCount < 0xA)
            //{
            //    WebViewElement.Reload();
            //    this.navigationFailedCount++;
            //}
            //this.trace.LogInfo(FormattableString.Invariant(System.Runtime.CompilerServices.FormattableStringFactory.Create("{0} IsSuccess={1}, WebErrorStatus={2}", new object[]
            //{
            //    "OnWebViewNavigationCompleted",
            //    args.IsSuccess,
            //    args.WebErrorStatus
            //})), null);
        }

        private void OnWebViewProcessFailed(object sender, CoreWebView2ProcessFailedEventArgs args)
        {
            //this.Crashed = true;
            //Microsoft.PowerBI.Telemetry.PBIWinWebView2ProcessFailed telemetryEvent = new Microsoft.PowerBI.Telemetry.PBIWinWebView2ProcessFailed(args.ExitCode.ToString(System.Globalization.CultureInfo.InvariantCulture), args.ProcessDescription, args.ProcessFailedKind.ToString(), args.Reason.ToString(), this.name);
            //this.telemetryService.Log(telemetryEvent);
            //this.telemetryService.Flush();
            //try
            //{
            //    throw new Microsoft.PowerBI.Client.Windows.WebView2.WebView2ProcessCrashException(this.name, WebViewElement, args);
            //}
            //catch (Microsoft.PowerBI.Client.Windows.WebView2.WebView2ProcessCrashException ex)
            //{
            //    this.trace.LogError("OnWebViewProcessFailed", ex, null);
            //    bool flag = ex.IsFatal;
            //    if (ex.BrowserNeedsReload)
            //    {
            //        if (this.host.CanReload(this) && this.navigationFailedCount < 0xA)
            //        {
            //            WebViewElement.Reload();
            //            this.navigationFailedCount++;
            //        }
            //        else
            //        {
            //            flag = true;
            //        }
            //    }
            //    if (flag)
            //    {
            //        this.host.OnFatalError(ex, null, null);
            //    }
            //    else
            //    {
            //        this.telemetryService.LogHandledException(ex, "WebView2BrowserWrapper");
            //    }
            //}
        }

        private void OnFrameNavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            //string webResourceUrl = this.GetWebResourceUrl(e.Uri);

            //if (!this.Restrictions.CanFrameNavigateTo(webResourceUrl))
            //{
            //    if (e.IsUserInitiated && this.Restrictions.CanOpenExternalBrowser(webResourceUrl))
            //    {
            //        this.host.OpenExternalUrl(webResourceUrl, true);
            //    }

            //    e.Cancel = true;
            //}
        }

        private void OnWebResourceRequested(object sender, CoreWebView2WebResourceRequestedEventArgs args)
        {
            //Microsoft.PowerBI.Client.Windows.WebView2.WebView2BrowserWrapper.<>c__DisplayClass80_0 CS$<>8__locals1 = new Microsoft.PowerBI.Client.Windows.WebView2.WebView2BrowserWrapper.<>c__DisplayClass80_0();
            //CS$<>8__locals1.<>4__this = this;
            //CS$<>8__locals1.args = args;
            //this.exceptionHandler.HandleAsyncExceptions(async delegate
            //{
            //    using (CS$<>8__locals1.args.GetDeferral())
            //    {
            //        string uri = CS$<>8__locals1.args.Request.Uri;
            //        if (CS$<>8__locals1.<>4__this.pluggableProtocolScheme.HasHttpsPluggableDomain(uri))
            //        {
            //            Microsoft.PowerBI.Client.Windows.WebView2.WebView2BrowserWrapper.<>c__DisplayClass80_1 CS$<>8__locals2 = new Microsoft.PowerBI.Client.Windows.WebView2.WebView2BrowserWrapper.<>c__DisplayClass80_1();
            //            CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
            //            CS$<>8__locals2.requestUri = CS$<>8__locals1.<>4__this.pluggableProtocolScheme.GetWebResourceUri(uri);
            //            if (uri.EndsWith("/pbi/Web/ts/WebView2InteropServices.js", StringComparison.OrdinalIgnoreCase))
            //            {
            //                string dynamicInteropJs = CS$<>8__locals1.<>4__this.interop.GetDynamicInteropJs();
            //                CS$<>8__locals1.args.Response = CS$<>8__locals1.<>4__this.CreateOkWebResourceResponse(new MemoryStream(Encoding.UTF8.GetBytes(dynamicInteropJs)), "text/javascript");
            //                return;
            //            }
            //            CS$<>8__locals2.found = false;
            //            CS$<>8__locals2.contentType = null;
            //            CS$<>8__locals2.responseStream = null;
            //            await Task.Run(delegate()
            //            {
            //                bool flag = CS$<>8__locals2.CS$<>8__locals1.<>4__this.host.UIHost.PluggableProtocolRegistration.TryGetHandlerForUri(CS$<>8__locals2.requestUri, out CS$<>8__locals2.requestHandler, out CS$<>8__locals2.relativeUri);
            //                if (flag && CS$<>8__locals2.requestHandler != null && CS$<>8__locals2.relativeUri != null)
            //                {
            //                    flag = CS$<>8__locals2.requestHandler.TryHandleRequest(CS$<>8__locals2.relativeUri, CS$<>8__locals2.requestUri.Query, out CS$<>8__locals2.contentType, out CS$<>8__locals2.responseStream);
            //                    if (flag && CS$<>8__locals2.contentType != null && CS$<>8__locals2.responseStream != null)
            //                    {
            //                        CS$<>8__locals2.found = true;
            //                    }
            //                }
            //            });
            //            CS$<>8__locals1.args.Response = (CS$<>8__locals2.found ? CS$<>8__locals1.<>4__this.CreateOkWebResourceResponse(CS$<>8__locals2.responseStream, CS$<>8__locals2.contentType) : CS$<>8__locals1.<>4__this.CreateNotFoundWebResourceResponse());
            //            CS$<>8__locals2 = null;
            //        }
            //    }
            //    CoreWebView2Deferral coreWebView2Deferral = null;
            //});
        }

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

        public static readonly Regex JavaScriptObjectRegex = new("\"data_source\\[\"(\\w)\"\\]\"", RegexOptions.Compiled);

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

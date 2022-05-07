using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

using Plotly.Models;
using Plotly.Models.Configs;

[assembly: ComVisible(true)]

namespace Plotly
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ICsPlotlyPlot
    {
        bool GetEnableLogging();

        string GetDataSource();

        string GetDataSourceType(string variable);

        string GetData();

        string GetLayout();

        string GetConfig();

        string GetFrames();

        int Length(object[] array);

        [IndexerName("DataItems")]
        object[] this[string variable] { get; }
    }

    [ComVisible(true)]
    public sealed class CsPlotlyPlot : ICsPlotlyPlot
    {
        #region Internal Properties

        [ComVisible(       false)]
        [field: ComVisible(false)]
        internal Dictionary<string, (string type, object[] array)> DataSource { get; set; }

        [ComVisible(false)]
        private List<ITrace> _plotData;

        [ComVisible(false)]
        internal List<ITrace> PlotData
        {
            get { return _plotData; }
            set
            {
                if(_plotData != value)
                {
                    _plotData = value;

                    _data = JsonSerializer.Serialize(_plotData, Converter.SerializerOptions);

                    if(_enableLogging)
                    {
                        Trace.WriteLine(_data);
                    }
                }
            }
        }

        [ComVisible(false)]
        private Layout _plotLayout;

        [ComVisible(false)]
        internal Layout PlotLayout
        {
            get { return _plotLayout; }
            set
            {
                if(_plotLayout != value)
                {
                    _plotLayout = value;

                    _layout = JsonSerializer.Serialize(_plotLayout, Converter.SerializerOptions);

                    if(_enableLogging)
                    {
                        Trace.WriteLine(_layout);
                    }
                }
            }
        }

        [ComVisible(false)]
        private Config _plotConfig;

        [ComVisible(false)]
        internal Config PlotConfig
        {
            get { return _plotConfig; }
            set
            {
                if(_plotConfig != value)
                {
                    _plotConfig = value;

                    _config = JsonSerializer.Serialize(_plotConfig, Converter.SerializerOptions);

                    if(_enableLogging)
                    {
                        Trace.WriteLine(_config);
                    }
                }
            }
        }

        [ComVisible(false)]
        private List<Frames> _plotFrames;

        [ComVisible(false)]
        internal List<Frames> PlotFrames
        {
            get { return _plotFrames; }
            set
            {
                if(_plotFrames != value)
                {
                    _plotFrames = value;

                    _frames = JsonSerializer.Serialize(_plotFrames, Converter.SerializerOptions);

                    if(_enableLogging)
                    {
                        Trace.WriteLine(_frames);
                    }
                }
            }
        }

        [ComVisible(       false)]
        [field: ComVisible(false)]
        internal List<List<JsNumber>> SelectedData { get; set; }

        [ComVisible(false)]
        internal static Config DefaultConfig()
        {
            Config config = new()
            {
                ShowLink            = true,
                LinkText            = "https://trmcnealy.github.io",
                MapboxAccessToken   = "pk.eyJ1IjoidHJtY25lYWx5IiwiYSI6ImNrZDN3aGNvMzBxNjQycW16Zml2M2UwZmcifQ.aT8sIrXsA2pHPSjw_U-fUA",
                PlotGlPixelRatio    = 2,
                DisplayModeBar      = DisplayModeBarEnum.Hover,
                FrameMargins        = 0,
                DisplayLogo         = false,
                FillFrame           = true,
                Responsive          = true,
                ScrollZoom          = ScrollZoomFlag.True,
                Edits               = new(),
                ModeBarButtons      = false,
                ModeBarButtonsToAdd = Array.Empty<ModeBarButtons>(),
                ModeBarButtonsToRemove = new ModeBarButtons[]
                {
                    ModeBarButtons.HoverClosestCartesian, ModeBarButtons.HoverCompareCartesian
                },
                ToImageButtonOptions = new ImageButtonOptions
                {
                    Format   = "svg",
                    Filename = "custom_image",
                    Scale    = 1
                },
                Logging         = 1,
                NotifyOnLogging = 2
            };

            return config;
        }

        #endregion

        [ComVisible(false)]
        private bool _enableLogging;

        [ComVisible(false)]
        private string _data;

        [ComVisible(false)]
        private string _layout;

        [ComVisible(false)]
        private string _config;

        [ComVisible(false)]
        private string _frames;

        public CsPlotlyPlot()
        {
            _enableLogging = false;
            _plotData      = new();
            _plotLayout    = new();
            _plotConfig    = new();
            _plotFrames    = new();
            _data          = string.Empty;
            _layout        = string.Empty;
            _config        = string.Empty;
            _frames        = string.Empty;

            DataSource   = new Dictionary<string, (string type, object[] array)>();
            PlotData     = new List<ITrace>();
            PlotLayout   = new Layout();
            PlotConfig   = DefaultConfig();
            PlotFrames   = new List<Frames>();
            SelectedData = new List<List<JsNumber>>();
        }

        public CsPlotlyPlot(bool enableLogging)
        {
            _enableLogging = enableLogging;
            _plotData      = new();
            _plotLayout    = new();
            _plotConfig    = new();
            _plotFrames    = new();
            _data          = string.Empty;
            _layout        = string.Empty;
            _config        = string.Empty;
            _frames        = string.Empty;

            DataSource   = new Dictionary<string, (string type, object[] array)>();
            PlotData     = new List<ITrace>();
            PlotLayout   = new Layout();
            PlotConfig   = DefaultConfig();
            PlotFrames   = new List<Frames>();
            SelectedData = new List<List<JsNumber>>();
        }

        public CsPlotlyPlot(bool                                              enableLogging,
                            Dictionary<string, (string type, object[] array)> dataSource,
                            List<ITrace>                                      data,
                            Layout                                            layout)
        {
            _enableLogging = enableLogging;
            _plotData      = new();
            _plotLayout    = new();
            _plotConfig    = new();
            _plotFrames    = new();
            _data          = string.Empty;
            _layout        = string.Empty;
            _config        = string.Empty;
            _frames        = string.Empty;

            DataSource   = dataSource;
            PlotData     = data;
            PlotLayout   = layout;
            PlotConfig   = DefaultConfig();
            PlotFrames   = new List<Frames>();
            SelectedData = new List<List<JsNumber>>();
        }

        public CsPlotlyPlot(bool                                              enableLogging,
                            Dictionary<string, (string type, object[] array)> dataSource,
                            List<ITrace>                                      data,
                            Layout                                            layout,
                            Config                                            config)
        {
            _enableLogging = enableLogging;
            _plotData      = new();
            _plotLayout    = new();
            _plotConfig    = new();
            _plotFrames    = new();
            _data          = string.Empty;
            _layout        = string.Empty;
            _config        = string.Empty;
            _frames        = string.Empty;

            DataSource   = dataSource;
            PlotData     = data;
            PlotLayout   = layout;
            PlotConfig   = config;
            PlotFrames   = new List<Frames>();
            SelectedData = new List<List<JsNumber>>();
        }

        public CsPlotlyPlot(bool                                              enableLogging,
                            Dictionary<string, (string type, object[] array)> dataSource,
                            List<ITrace>                                      data,
                            Layout                                            layout,
                            List<Frames>                                      frames)
        {
            _enableLogging = enableLogging;
            _plotData      = new();
            _plotLayout    = new();
            _plotConfig    = new();
            _plotFrames    = new();
            _data          = string.Empty;
            _layout        = string.Empty;
            _config        = string.Empty;
            _frames        = string.Empty;

            DataSource   = dataSource;
            PlotData     = data;
            PlotLayout   = layout;
            PlotConfig   = DefaultConfig();
            PlotFrames   = frames;
            SelectedData = new List<List<JsNumber>>();
        }

        public CsPlotlyPlot(bool                                              enableLogging,
                            Dictionary<string, (string type, object[] array)> dataSource,
                            List<ITrace>                                      data,
                            Layout                                            layout,
                            Config                                            config,
                            List<Frames>                                      frames)
        {
            _enableLogging = enableLogging;
            _plotData      = new();
            _plotLayout    = new();
            _plotConfig    = new();
            _plotFrames    = new();
            _data          = string.Empty;
            _layout        = string.Empty;
            _config        = string.Empty;
            _frames        = string.Empty;

            DataSource   = dataSource;
            PlotData     = data;
            PlotLayout   = layout;
            PlotConfig   = config;
            PlotFrames   = frames;
            SelectedData = new List<List<JsNumber>>();
        }

        public string GetDataSource()
        {
            string data = JsonSerializer.Serialize(DataSource, Converter.SerializerOptions);

            if(_enableLogging)
            {
                Trace.WriteLine(data);
            }

            return data;
        }

        public string GetDataSourceType(string variable)
        {
            if(!DataSource.ContainsKey(variable))
            {
                return null;
            }

            return DataSource[variable].type;
        }

        public bool GetEnableLogging()
        {
            return _enableLogging;
        }

        public string GetData()
        {
            return _data;
        }

        public string GetLayout()
        {
            return _layout;
        }

        public string GetConfig()
        {
            return _config;
        }

        public string GetFrames()
        {
            return _frames;
        }

        public int Length(object[] array)
        {
            return array.Length;
        }

        [IndexerName("DataItems")]
        public object[] this[string variable]
        {
            get
            {
                if(!DataSource.ContainsKey(variable))
                {
                    return null;
                }

                return DataSource[variable].array;
            }
        }
    }
}

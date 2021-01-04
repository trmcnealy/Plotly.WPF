
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

using Plotly.Models;
using Plotly.Models.Configs;

[assembly:ComVisible(true)]
namespace Plotly
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ICsPlotlyPlot
    {
        string GetDataSource();

        string GetDataSourceType(string variable);

        string GetData();

        string GetLayout();

        string GetConfig();

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
                if (_plotData != value)
                {
                    _plotData = value;

                    _data = JsonSerializer.Serialize(PlotData, Converter.SerializerOptions);
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
                if (_plotLayout != value)
                {
                    _plotLayout = value;

                    _layout = JsonSerializer.Serialize(PlotLayout, Converter.SerializerOptions);
                }
            }
        }

        [ComVisible(false)]
        private Config _configuration;

        [ComVisible(false)]
        internal Config Configuration
        {
            get { return _configuration; }
            set
            {
                if (_configuration != value)
                {
                    _configuration = value;

                    _config = JsonSerializer.Serialize(Configuration, Converter.SerializerOptions);
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
                ShowLink = true,
                LinkText = "https://trmcnealy.github.io",
                MapboxAccessToken = null,
                PlotGlPixelRatio = 2,
                DisplayModeBar = DisplayModeBarEnum.Hover,
                FrameMargins = 0,
                DisplayLogo = false,
                FillFrame = true,
                Responsive = true,
                ScrollZoom = ScrollZoomFlag.True,
                Edits = new(),
                ModeBarButtons = false,
                ModeBarButtonsToAdd = Array.Empty<ModeBarButtons>(),
                ModeBarButtonsToRemove = new ModeBarButtons[]
                {
                    ModeBarButtons.HoverClosestCartesian, ModeBarButtons.HoverCompareCartesian
                },
                ToImageButtonOptions = new ImageButtonOptions
                {
                    Format = "svg",
                    Filename = "custom_image",
                    Scale = 1
                },
                Logging = 1,
                NotifyOnLogging = 2
            };

            return config;
        } 
        #endregion

        [ComVisible(false)]
        private string _data;
        
        [ComVisible(false)]
        private string _layout;
        
        [ComVisible(false)]
        private string _config;

        public CsPlotlyPlot()
        {
            DataSource    = new Dictionary<string, (string type, object[] array)>();
            PlotData      = new List<ITrace>();
            PlotLayout    = new Layout();
            Configuration = DefaultConfig();
            SelectedData  = new List<List<JsNumber>>();
        }

        public CsPlotlyPlot(Dictionary<string, (string type, object[] array)> dataSource,
                            List<ITrace>                     data,
                            Layout                           layout,
                            Config?                          config = null)
        {
            DataSource    = dataSource;
            PlotData      = data;
            PlotLayout    = layout;
            Configuration = config ?? DefaultConfig();
            SelectedData  = new List<List<JsNumber>>();
        }

        public string GetDataSource()
        {
            string data = JsonSerializer.Serialize(DataSource, Converter.SerializerOptions);

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
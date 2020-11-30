
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json;

using Plotly.Models;
using Plotly.Models.Configs;

namespace Plotly
{
    [ComVisible(true)]
    public class CsPlotlyPlot
    {
        internal Dictionary<string, (string type, List<object> array)> DataSource { get; set; }

        internal List<ITrace> PlotData { get; set; }

        internal Layout PlotLayout { get; set; }

        internal Config Configuration { get; set; }

        internal List<List<JsNumber>> SelectedData { get; set; }

        internal static Config DefaultConfig()
        {
            Config config = new()
            {
                ShowLink            = true,
                LinkText            = "https://trmcnealy.github.io",
                MapboxAccessToken   = null,
                PlotGlPixelRatio    = 2,
                DisplayModeBar      = DisplayModeBarEnum.Hover,
                FrameMargins        = 0,
                DisplayLogo         = false,
                FillFrame           = true,
                Responsive          = true,
                ScrollZoom          = ScrollZoomFlag.True,
                Edits               = new(){},
                ModeBarButtons      = false,
                ModeBarButtonsToAdd = Array.Empty<ModeBarButtons>(),
                ModeBarButtonsToRemove = new ModeBarButtons[]
                {
                    ModeBarButtons.ToggleSpikelines, ModeBarButtons.HoverClosestCartesian, ModeBarButtons.HoverCompareCartesian
                },
                ToImageButtonOptions = new ImageButtonOptions
                {
                    Format   = "svg",
                    Filename = "custom_image",
                    Scale = 1
                },
                Logging = 1,
                NotifyOnLogging = 2
            };

            return config;
        }

        public CsPlotlyPlot()
        {
            DataSource    = new Dictionary<string, (string type, List<object> array)>();
            PlotData      = new List<ITrace>();
            PlotLayout    = new Layout();
            Configuration = DefaultConfig();
            SelectedData  = new List<List<JsNumber>>();
        }

        public CsPlotlyPlot(Dictionary<string, (string type, List<object> array)> dataSource,
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

        public string? GetDataSourceType(string variable)
        {
            if(!DataSource.ContainsKey(variable))
            {
                return null;
            }

            return DataSource[variable].type;
        }

        public string GetData()
        {
            return JsonSerializer.Serialize(PlotData, Converter.SerializerOptions);
        }

        public string GetLayout()
        {
            return JsonSerializer.Serialize(PlotLayout, Converter.SerializerOptions);
        }

        public string GetConfig()
        {
            return JsonSerializer.Serialize(Configuration, Converter.SerializerOptions);
        }

        public object[]? this[string variable]
        {
            get
            {
                if(!DataSource.ContainsKey(variable))
                {
                    return null;
                }

                return DataSource[variable].array.ToArray();
            }
        }
    }
}
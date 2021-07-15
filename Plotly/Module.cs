using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Plotly
{
    internal static class Module
    {
        [ModuleInitializer]
        internal static void Initialize()
        {
            string Plotly_folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plotly");

            if(!Directory.Exists(Plotly_folder))
            {
                Directory.CreateDirectory(Plotly_folder);
            }
            else
            {
                Directory.Delete(Plotly_folder, true);
                Directory.CreateDirectory(Plotly_folder);
            }
            
            InitializeJavascriptFile(Plotly_folder, "plotly.min.js",       Resources.plotly_js);
            InitializeJavascriptFile(Plotly_folder, "PlotlyApp.min.js",    Resources.PlotlyApp_js);
            InitializeJavascriptFile(Plotly_folder, "PlotlyWorker.min.js", Resources.PlotlyWorker_js);
        }

        internal static void InitializeJavascriptFile(string output_folder,
                                                      string js_file_html_name,
                                                      string js_file_content)
        {
            string js_file = Path.Combine(output_folder, js_file_html_name);

            if(!File.Exists(js_file))
            {
                using(StreamWriter sw = new StreamWriter(js_file))
                {
                    sw.Write(js_file_content);
                }
            }
        }
    }
}

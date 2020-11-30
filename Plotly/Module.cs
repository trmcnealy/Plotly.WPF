using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Plotly.Plotly
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

            //string Plotly_html_file = Path.Combine(Plotly_folder, "Plotly.html");

            //if(!File.Exists(Plotly_html_file))
            //{
            //    using(StreamWriter sw = new StreamWriter(Plotly_html_file))
            //    {
            //        sw.Write(Resources.Plotly_html);
            //    }
            //}
            
            string Plotly_js_file = Path.Combine(Plotly_folder, "Plotly.js");

            if(!File.Exists(Plotly_js_file))
            {
                using(StreamWriter sw = new StreamWriter(Plotly_js_file))
                {
                    sw.Write(Resources.Plotly_js);
                }
            }
        }
    }
}

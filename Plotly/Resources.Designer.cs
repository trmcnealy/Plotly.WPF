﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plotly {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Plotly.Plotly.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE HTML&gt;
        ///&lt;html lang=&quot;en&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;meta charset=&quot;UTF-8&quot;/&gt;
        ///    &lt;style&gt;
        ///        html,
        ///        body,
        ///        #root {
        ///            padding: 0;
        ///            margin: 0;
        ///            width: 100%;
        ///            height: 100%;
        ///        }
        ///    &lt;/style&gt;
        ///    &lt;script src=&quot;https://cdn.plot.ly/plotly-latest.js&quot;&gt;&lt;/script&gt;
        ///    &lt;!--&lt;script src=&quot;https://cdn.plot.ly/plotly-latest.min.js&quot;&gt;&lt;/script&gt;--&gt;
        ///    &lt;script src=&quot;Plotly.js&quot;&gt;&lt;/script&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///&lt;div id=&quot;root&quot;&gt;
        ///    &lt;div id=&quot;%ID%&quot; style=&quot;width: 100%; height: 100%;&quot;&gt;&lt;/d [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Plotly_html {
            get {
                return ResourceManager.GetString("Plotly_html", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //&quot;use strict&quot;;
        ///
        ///window.addEventListener(&quot;dragover&quot;, function(e) {
        ///  e.preventDefault();
        ///}, false);
        ///
        ///window.addEventListener(&quot;drop&quot;, function(e) {
        ///  e.preventDefault();
        ///}, false);
        ///
        /////window.addEventListener(&quot;contextmenu&quot;, window =&gt; {
        /////  window.preventDefault();
        /////});
        ///
        ///let PlotlyApp = {
        ///  listenToAutosizeEvent: (div_container) =&gt; {
        ///    div_container.on(&quot;plotly_autosize&quot;, function() {
        ///      window.chrome.webview.postMessage({ &quot;event&quot;: &quot;PlotlyAutosize&quot; });
        ///    });
        ///    return div_container;
        ///  },
        ///  listenToEven [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Plotly_js {
            get {
                return ResourceManager.GetString("Plotly_js", resourceCulture);
            }
        }
    }
}

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class Module
{
    [ModuleInitializer]
    internal static void Initialize()
    {
        string webView2LoaderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WebView2Loader.dll");

        if(File.Exists(webView2LoaderFile))
        {
            NativeLibrary.Load(webView2LoaderFile);
        }
        else
        {
            switch(RuntimeInformation.OSArchitecture)
            {
                case Architecture.X86:
                {
                    if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        webView2LoaderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "runtimes", "win-x86", "native", "WebView2Loader.dll");

                        if(File.Exists(webView2LoaderFile))
                        {
                            NativeLibrary.Load(webView2LoaderFile);
                        }
                    }

                    break;
                }
                case Architecture.X64:
                {
                    if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        webView2LoaderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "runtimes", "win-x64", "native", "WebView2Loader.dll");

                        if(File.Exists(webView2LoaderFile))
                        {
                            NativeLibrary.Load(webView2LoaderFile);
                        }
                    }

                    break;
                }
                case Architecture.Arm:
                {
                    if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        webView2LoaderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "runtimes", "win-arm", "native", "WebView2Loader.dll");

                        if(File.Exists(webView2LoaderFile))
                        {
                            NativeLibrary.Load(webView2LoaderFile);
                        }
                    }

                    break;
                }
                case Architecture.Arm64:
                {
                    if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        webView2LoaderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "runtimes", "win-arm64", "native", "WebView2Loader.dll");

                        if(File.Exists(webView2LoaderFile))
                        {
                            NativeLibrary.Load(webView2LoaderFile);
                        }
                    }

                    break;
                }
            }
        }
    }
}

using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBrowser.Browser
{
    internal static class BrowserConfig
    {


        public static string Branding = "FesterBrowser";
        public static string AcceptLanguage = "en-US,en;q=0.9";
        public static string UserAgent = " Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36" + Cef.CefSharpVersion; // UserAgent to fix issue with Google account authentication		
        public static string HomepageURL = "https://www.startpage.com/";
        public static string NewTabURL = "https://www.startpage.com/";
        public static string InternalURL = "festerbrowser";
        public static string DownloadsURL = "festerbrowser://storage/downloads.html";
        public static string UpdateCenter = "https://pastebin.com/raw/8CXAreig";
        public static string FileNotFoundURL = "festerbrowser://storage/errors/notFound.html";
        public static string CannotConnectURL = "festerbrowser://storage/errors/cannotConnect.html";
        public static string SearchURL = "https:/www.startpage.com/do/search?query=";

        public static bool WebSecurity = true;
        public static bool CrossDomainSecurity = true;
        public static bool WebGL = true;
        public static bool ApplicationCache = true;

        public static bool Proxy = false;
        public static string ProxyIP = "2.56.119.93";
        public static int ProxyPort = 5074;
        public static string ProxyUsername = "pommetvh";
        public static string ProxyPassword = "o73b5ipcaqia";
        public static string ProxyBypassList = "";

    }
}

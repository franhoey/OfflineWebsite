using System;
using System.Configuration;
using System.Web;

namespace OfflineWebsite.Infrastructure
{
    public class CatchAllHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            SetCachingHeaders(context);
            OutputOfflinePageHtml(context);
        }

        public bool IsReusable => true;

        private void OutputOfflinePageHtml(HttpContext context)
        {
            context.Response.TransmitFile(ConfigurationManager.AppSettings["OfflinePageFileName"]);
        }

        private void SetCachingHeaders(HttpContext context)
        {
            context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            context.Response.Cache.SetNoStore();
            context.Response.Headers.Add("Pragma", "no-cache");
        }
    }
}
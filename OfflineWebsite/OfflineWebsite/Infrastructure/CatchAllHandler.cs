using System;
using System.Configuration;
using System.Web;

namespace OfflineWebsite.Infrastructure
{
    public class CatchAllHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpCacheUtil.SetNoCacheHeaders(context);
            OutputOfflinePageHtml(context);
        }

        public bool IsReusable => true;

        private void OutputOfflinePageHtml(HttpContext context)
        {
            context.Response.TransmitFile(ConfigurationManager.AppSettings["OfflinePageFileName"]);
        }
        
    }
}
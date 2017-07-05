using System.Web;

namespace OfflineWebsite.Infrastructure
{
    public static class HttpCacheUtil
    {
        public static void SetNoCacheHeaders(HttpContext context)
        {
            context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            context.Response.Cache.SetNoStore();
            context.Response.Headers.Add("Pragma", "no-cache");
        }
    }
}
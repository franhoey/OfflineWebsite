using System.IO;
using System.Web;

namespace OfflineWebsite.Infrastructure
{
    public class BypassHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpCacheUtil.SetNoCacheHeaders(context);

            var filePath = context.Server.MapPath(context.Request.Url.LocalPath);
            if (File.Exists(filePath))
                context.Response.TransmitFile(context.Request.Url.LocalPath);
            else
                throw new HttpException(404, "Not Found");


        }

        public bool IsReusable => true;
    }
}
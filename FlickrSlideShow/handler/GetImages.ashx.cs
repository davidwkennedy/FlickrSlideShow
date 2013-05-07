using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlickrNet;
using Newtonsoft.Json;
using FlickrSlideShow.Domain;
using FlickrSlideShow.Services;

namespace FlickrSlideShow.handler
{
    /// <summary>
    /// Summary description for GetImages
    /// </summary>
    public class GetImages : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            context.Response.Write(JsonConvert.SerializeObject(RetrieveImagesFromFlickr.Search("72157625685092574")));

                
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
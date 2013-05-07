using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlickrSlideShow.Domain
{
    public class Image
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CameraMake { get; set; }
        public string CameraModel { get; set; }
        public string DateTaken { get; set; }
        public string Iso { get; set; }
        public string Exposure { get; set; }
        public string Aperture { get; set; }
        public string Uri { get; set; }
    }
}
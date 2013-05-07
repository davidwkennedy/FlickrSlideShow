using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlickrSlideShow.Domain;
using FlickrNet;

namespace FlickrSlideShow.Services
{
    public static class RetrieveImagesFromFlickr
    {
        public static List<Image> Search(string SetId)
        {
            Flickr flickr = new Flickr(
                "abb460f674f726de1bcdce3c2af288ee", "58704b8f3bdd4634"
            );


            PhotosetPhotoCollection photoset = flickr.PhotosetsGetPhotos(SetId);

            var images = new List<Image>();

            foreach (Photo photo in photoset)
            {
                //var photoInfo = flickr.PhotosGetInfo(photo.PhotoId);
                //var photoExif = flickr.PhotosGetExif(photo.PhotoId);
                
                images.Add(new Image {
                    Title = photo.Title,
                    //Description = photoInfo.Description
                    Uri = photo.LargeUrl
                });
            }

            return images;

        }
    }
}
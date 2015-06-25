using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace VirtualScrapbook.Version5.Model
{
    public class Book
    {
        public Book()
        {
            Images = new List<Image>();
        }
        public string Title { get; set; }
        protected virtual List<Image> Images { get; set; }
        private IReadOnlyCollection<Image> _images;
        public IReadOnlyCollection<Image> ReadOnlyImages
        {
            get
            {
                return _images ?? (_images = new ReadOnlyCollection<Image>(Images));
            }
        }

        public Image GetCoverImage()
        {
            return _images.FirstOrDefault(i => i.IsCoverImage) ?? Image.Default;
        }

        public void SetCoverImage(string imagePath)
        {
            var imageToUpdate = _images.FirstOrDefault(i => i.ImagePath == imagePath);
            if(imageToUpdate == null)
            {
                throw new ApplicationException("Image not found.");
            }
            Images.ForEach(i => i.IsCoverImage = false);
            imageToUpdate.IsCoverImage = true;
        }

        public void AddImage(Image image)
        {
            if(image == null)
            {
                throw new ArgumentNullException("Image cannot be null");
            }
            if(_images.Any(i => i.ImagePath == image.ImagePath))
            {
                throw new ApplicationException("Image already exists in book.");
            }
            image.IsCoverImage = false; // newly added images always start this way
            Images.Add(image);
        }
    }

    public class Image
    {
        public static Image Default = new Image() { ImagePath = "defaultimage" };
        public string ImagePath { get; set; }
        public bool IsCoverImage { get; set; }
    }
}

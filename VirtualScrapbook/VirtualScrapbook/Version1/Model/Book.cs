using System.Collections.Generic;

namespace VirtualScrapbook.Version1.Model
{
    public class Book
    {
        public string Title { get; set; }
        public List<Image> Images { get; set; }
    }

    public class Image
    {
        public string ImagePath { get; set; }
    }
}

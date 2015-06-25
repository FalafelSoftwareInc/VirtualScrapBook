using System.Collections.Generic;

namespace VirtualScrapbook.Version2.Model
{
    public class Book
    {
        public Book()
        {
            Images = new List<Image>();
        }
        public string Title { get; set; }
        public List<Image> Images { get; private set; }
    }

    public class Image
    {
        public string ImagePath { get; set; }
    }
}

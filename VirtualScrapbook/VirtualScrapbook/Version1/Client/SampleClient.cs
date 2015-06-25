using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using VirtualScrapbook.Version1.Model;

namespace VirtualScrapbook.Version1.Client
{
    public class SampleClient
    {
        public void DisplayBook(Book book, StringBuilder sb)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book cannot be null.");
            }
            sb.AppendLine(book.Title);
            if(book.Images != null)
            {
                foreach(var image in book.Images)
                {
                    sb.AppendLine(image.ImagePath);
                }
            }
        }
    }
}

using System;
using System.Text;
using VirtualScrapbook.Version2.Model;

namespace VirtualScrapbook.Version2.Client
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
            foreach (var image in book.Images)
            {
                sb.AppendLine(image.ImagePath);
            }
        }
    }
}

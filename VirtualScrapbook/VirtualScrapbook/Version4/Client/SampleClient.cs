using System;
using System.Linq;
using System.Text;
using VirtualScrapbook.Version4.Model;

namespace VirtualScrapbook.Version4.Client
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
            var coverImage = book.GetCoverImage();
            sb.AppendLine("Cover Image: " + coverImage.ImagePath);
            foreach (var image in book.Images)
            {
                sb.AppendLine(image.ImagePath);
            }
        }

        public void SetCoverImage(Book book, string imagePath)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book cannot be null.");
            }
            book.SetCoverImage(imagePath);
        }
    }
}

using System;
using System.Linq;
using System.Text;
using VirtualScrapbook.Version3.Model;

namespace VirtualScrapbook.Version3.Client
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
            var coverImage = book.Images.Where(i => i.IsCoverImage).FirstOrDefault();
            if (coverImage != null)
            {
                sb.AppendLine("Cover Image: " + coverImage.ImagePath);
            }
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
            var imageToUpdate = book.Images.Where(i => i.ImagePath == imagePath).FirstOrDefault();
            if (imageToUpdate != null)
            {
                imageToUpdate.IsCoverImage = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Create a C# program to manage a photo book using object-oriented programming.

To start, create a class called PhotoBook with a private attribute numPages of type int. It must also have a public method GetNumberPages that will return the number of photo book pages.

The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.

There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

Finally create a PhotoBookTest class to perform the following actions:

Create a default photo book and show the number of pages
Create a photo book with 24 pages and show the number of pages
Create a large photo book and show the number of pages
Output
16
24
64 */
namespace c_training
{
    public class PhotoBook
    {
        private int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int pages)
        {
            numPages = pages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook() : base(64)
        {
        }
    }
}

// object 
PhotoBook defaultPhotoBook = new PhotoBook();
Console.WriteLine(defaultPhotoBook.GetNumberPages());

PhotoBook customPhotoBook = new PhotoBook(24);
Console.WriteLine(customPhotoBook.GetNumberPages());

BigPhotoBook bigPhotoBook = new BigPhotoBook();
Console.WriteLine(bigPhotoBook.GetNumberPages());

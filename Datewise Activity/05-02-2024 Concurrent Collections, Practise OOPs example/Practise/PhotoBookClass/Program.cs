using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
     class PhotoBook
    {
        private int numPages ;

       public PhotoBook()
        {
            this.numPages = 16;
        }

        public PhotoBook(int pages)
        {
            this.numPages = pages;
        }

        public int GetNumberPages()
        {
            return this.numPages;
        }
    }
    class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook():base(64)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            PhotoBook book = new PhotoBook();
            Console.WriteLine(book.GetNumberPages());
            
            PhotoBook book2 = new PhotoBook(24);
            Console.WriteLine(book2.GetNumberPages());


            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.GetNumberPages());

            Console.Read();
        }
    }
}

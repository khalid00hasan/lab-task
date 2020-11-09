using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask_6
{
    class Book
    {
        String bookName;
        String bookAuthor;
        String bookId;
        String bookType;
        int bookCopy;

        public string getBookName()
        {
            return bookName;
        }
        public void setBookName(string BookName)
        { bookName = BookName; }

        public string BookAuthor()
        { return bookAuthor; }

        public void setBookAuthor(string BookAuthor)
        { bookAuthor = BookAuthor; }

        public string getBookId()
        { return bookId; }

        public void setBookId(string BookId)
        { bookId = BookId; }

        public string BookType()
        { return bookType; }

        public void setBookType(string BookType)
        { bookType = BookType; }

        public int getBookCopy()
        { return bookCopy; }

        public void setBookCopy( int BookCopy )
        { bookCopy = BookCopy; }

        void ShowInfo()
        { }
        void AddBookCopy(int x)
        { }

        public string name;
        public List<Book> books = new List<Book>();

        void AddNewBook(string title, string author)
        {
            int bookQuantity;

            string btitle;
            string bauthor;

         
    }
        }
    }
    }


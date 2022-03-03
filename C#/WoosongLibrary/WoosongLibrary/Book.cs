using System;
using System.Collections.Generic;
using System.Text;

namespace WoosongLibrary
{
    class Book
    {
        private String bookname;
        private String author;
        private String publisher;

        private int bookID;
        private int bookcount;

        public String BookName { 
            get { return bookname; } 
            set { bookname = value; } 
        }

        public String Author
        {
            get { return author; }
            set { author = value; }
        }

        public String Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        public int BookCount {
            get { return bookcount; }
            set { bookcount = value; }
        }

        public Book(String _bookname, String _author, String _publisher, int _bookID, int _bookcount)
        {
            bookname = _bookname;
            author = _author;
            publisher = _publisher;
            bookID = _bookID;
            bookcount = _bookcount;
        }

        public override string ToString()
        {
            String str = "책이름 : " + bookname + "\n";
            str += "작가 : " + author + "\n";
            str += "출판사 : " + publisher + "\n";
            str += "책ID : " + bookID + "\n";
            str += "도서 수 : " + bookcount + "\n";


            return str;
        }
    }
}

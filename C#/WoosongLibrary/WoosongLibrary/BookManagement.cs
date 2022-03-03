using System;
using System.Collections.Generic;
using System.Text;

namespace WoosongLibrary
{
    class BookManagement
    {
        #region 변수 & get set
        
        private List<Book> allbooklist = new List<Book>();
        private List<Book> borrowbooklist = new List<Book>();
        private List<Book> returnbooklist = new List<Book>();
        private List<Book> remainingbooklist = new List<Book>();

        public List<Book> AllBookList
        {
            get { return allbooklist; }
            set { allbooklist = value; }
        }

        public List<Book> BorrowBookList
        {
            get { return borrowbooklist; }
            set { borrowbooklist = value; }
        }

        public List<Book> ReturnBookList
        {
            get { return returnbooklist; }
            set { returnbooklist = value; }
        }

        public List<Book> RemainingBookList
        {
            get { return remainingbooklist; }
            set { remainingbooklist = value; }
        }

        #endregion

        #region 싱글톤
        private BookManagement() { }

        static BookManagement()  //정적 생성자(최초 한번만)
        {
            Singleton = new BookManagement();//단일체 생성
        }
        static public BookManagement Singleton { get; private set; }

        #endregion

        #region 기능 메서드


        // 도서 추가
        public bool LibraryAddBook (String _bookname, String _author, String _publisher)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 도서 처분
        public bool LibraryDeleteBook(String _bookname, String _author, String _publisher)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 도서 대출
        public bool LibraryBorrowBook(String _bookname, String _author, String _publisher)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 도서 반납
        public bool LibraryRemainingBook(String _bookname, String _author, String _publisher)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }


        #endregion

    }
}
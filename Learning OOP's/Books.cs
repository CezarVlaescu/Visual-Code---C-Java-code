using Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Books
    {
        string _bookName;
        string _author;
        int _pages;

        public Books(string bookName, string author, int pages)
        {
            _bookName = bookName;
            _author = author;
            _pages = pages;
        }

        public string maxPages()
        {
            if (_pages < 10)
            {
                return "The book is not avaliable";
            }
            else
            {
                return $"The book has {_pages} pages";
            }
        }

        public string GetDescription()
        {
            return $"Book: {_bookName}, Author : {_author}, Pages: {_pages}";
        }

        public string GetbookName()
        {
            return _bookName;
        }

        public void SetName(string name)
        {
            _bookName = name;
        }
    }
}


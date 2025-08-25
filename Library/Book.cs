using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Book
    {
        //constructor
        public Book(string title,string author) 
        { 
            this.title = title;
            this.author = author;
           
        }
        private string title;
        private string author;
        private  bool isBorrowed=false;

        
       

        public string Title   // property
        {
            get { return title; }   // get title method
            set { title = value; }  // set title method
        }
       
        public string Author  // property
        {
            get { return author; }   // get author method
            set { author = value; }  // set author method
        }

        public bool IsBorrowed { 
            get { return isBorrowed; }
        }
       
       
        public void Borrow()
        {
           isBorrowed=true;
        }
        public void Return()
        {
            isBorrowed = false;
        }
    }
}

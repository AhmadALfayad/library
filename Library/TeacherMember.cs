using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class TeacherMember : Member,IBorrowable
    {
        public TeacherMember(int memberId, string name) : base(memberId, name)
        {
        }
        private double penalty;
        public override double CalculateLateFee(int daysLate)
        {
            penalty = daysLate * 0.2;
            return penalty;
        }

        public void BorrowBook(Book book)
        {
            if (book.IsBorrowed==false)
            {
                book.Borrow();
                Console.WriteLine($"Teacher {name} borrowed '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"Teacher {name} try to borrow '{book.Title}' but it is already borrowed.");
            }
        }

        public void ReturnBook(Book book)
        {
            book.Return();
            Console.WriteLine($"Teacher {name} returned '{book.Title}'.");
        }
        
    }
}

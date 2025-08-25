using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StudentMember : Member,IBorrowable
    {
        public StudentMember(int memberId, string name) : base(memberId, name)
        {
        }
       
        public override double CalculateLateFee(int daysLate)
        {
            double penalty = daysLate * 0.5;
            return penalty;
        }

        public void BorrowBook(Book book)
        {
            if (book.IsBorrowed==false)
            {
                book.Borrow();
                Console.WriteLine($"Student {name} borrowed '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"Student {name} try to borrow '{book.Title}' but it is already borrowed.");
            }
        }

        public void ReturnBook(Book book)
        {
            book.Return();
            Console.WriteLine($"Student {name} returned '{book.Title}'.");
            
        }

      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Member
    {
        public Member(int memberId,string name) 
        {
            this.memberId = memberId;
            this.name = name;
        }
        protected int memberId;
        protected string name;

        public string Name
        {
            get { return name; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Member Id: {0}\nName: {1}",memberId,name);
        }

        public  abstract double CalculateLateFee(int daysLate);
    }
}

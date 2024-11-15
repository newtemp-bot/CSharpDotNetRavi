using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Static_ToString
{
    public class ToStringEx
    {
        public int number = 100;
        public int n2 = 100;
        public void dis()
        {
            Console.WriteLine(n2.ToString()+number.ToString());
            Console.WriteLine(n2+number);
        }
        public override string ToString()
        {
            return "N2 = "+n2+"Number = "+number;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is ToStringEx))
            {
                return false;
            }
            return (this.n2 == ((ToStringEx)obj).n2) && (this.number == ((ToStringEx)obj).number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class BankNotes
    {
        public int Notes()
        {
            Console.WriteLine("Enter the amount");
            int amt = Convert.ToInt32(Console.ReadLine());

            int[] possiblenotes = { 100, 50, 20, 10, 5, 2, 1 };

            for(int i=0;i<possiblenotes.Length;i++)
            {
                int count = amt / possiblenotes[i];
                amt = amt % possiblenotes[i];
                Console.WriteLine(count + " nota(s) de R$ " + possiblenotes[i].ToString("F2"));
            }
            
            return amt;
            
        }
    }
}

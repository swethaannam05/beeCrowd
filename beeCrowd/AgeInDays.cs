using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class AgeInDays
    {
        public int Age()
        {
            Console.WriteLine("Enetr persons age in days");
            int ageindays=Convert.ToInt32(Console.ReadLine());

            // DateTime days= DateTime.MinValue.AddDays(ageindays);
            // Console.WriteLine(days);
            int years = ageindays / 365;
            int months = (ageindays % 365) / 30;
            int days=(ageindays%365)%30;
            Console.WriteLine(years + " ano(s)" + Environment.NewLine + months  + " mes(es)" + Environment.NewLine + days+ " dia(s)");
            Console.ReadLine(); 
            return ageindays;
        }
    }
}

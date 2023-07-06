using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class BanknotesAndCoins
    {
        public double Coins()
        {
            Console.WriteLine("Enter a amount with decimal piont");
            double amount=Convert.ToSingle(Console.ReadLine());

            int[] note = { 100, 50, 20, 10, 5, 2 };
            double[] coin = { 1, 0.50, 0.25, 0.10, 0.01 };

            //for(int i=0;i<note.Length;i++)
            //{
            //    int count = (int)(amount / note[i]);
            //    amount = amount % note[i];
            //    Console.WriteLine("NOTAS: "+Environment.NewLine +count + " nota(s) de R$ " + note[i]);
            //    Console.ReadLine();
            //}
            foreach(int notes in note)
            {
                int count = (int)(amount / notes);
                amount = amount % notes;
                Console.WriteLine("NOTAS: " + Environment.NewLine + count + " nota(s) de R$ " + notes);

            }
            foreach (double coins in coin)
            {
                int count = (int)(amount / coins);
                amount = amount % coins;
                Console.WriteLine("MOEDAS: " + Environment.NewLine + count + " nota(s) de R$ " + coins);

            }

            Console.ReadLine();
            return amount;
        }
    }
}

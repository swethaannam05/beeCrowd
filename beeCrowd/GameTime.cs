using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace beeCrowd
{
    public class GameTime
    {
        public int Game()
        {
            int gamehours = 24;
            Console.WriteLine("Enter a starttime in hours");
            int starttime=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a endtime in hours");
            int endtime = Convert.ToInt32(Console.ReadLine());

            if(starttime < endtime)
            {
                gamehours = endtime - starttime;
            }
            else if(starttime > endtime)
            {
                gamehours = 24 - starttime + endtime;
            }
         

            Console.WriteLine("O JOGO DUROU " + gamehours + " HORA(S)");
            Console.ReadLine();
            return gamehours;
        }
    }
}

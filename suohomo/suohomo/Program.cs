using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suohomo
{
    class HeppaProgram
    {
        static void Main(string[] args)
        {
            SiitosoriHelper Jorma = new SiitosoriHelper();
            Jorma.Hirnuminen();
        }
    }

    public class SiitosoriHelper //Sieltä se ori tulee jeesaamaan takavasemmalta, et saadaan hirnumiset kondikseen :D
    {
        public void Hirnuminen ()
        {
            //string laidun = "multa"; (VILLE SÖSSI!!! Ei oo mun vika)
            Random rnd = new Random();
            //Heppa voi hirnua randomisti kolmella eri tavalla sattumanvaraisessa järjestyksessä
            int typeOfNeigh = rnd.Next(1, 4); //Ville lottosi että toimiikohan vaiko eikö. Huhhuh saatana, onneks toimi!
            if (typeOfNeigh == 1)
            {
                Console.WriteLine("Heppa sanoo hihi");
            }
            else if (typeOfNeigh == 2)
            {
                Console.WriteLine("Heppa sanoo haha");
            }
            else if (typeOfNeigh == 3)
            {
                Console.WriteLine("Heppa sanoo hehe");
            }
            else { }
            //return laidun; (VILLE SÖSSI!!! Ei oo mun vika)
        }
    }
}
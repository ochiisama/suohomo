using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suohomo
{
    class HeppaProgram
    {
        static void Kirmaaminen()
        {
            Console.WriteLine("Huomenta! Onpas aivan helvetin hieno päivä. Siitosori Jorma ja tuima tamma Jaana kirmaavat laitumella ja nauttivat säästä sekä toisistaan.");
        }
        static void Main(string[] args)
        {
            SiitosoriHelper Jorma = new SiitosoriHelper();
            TuimaTamma Jaana = new TuimaTamma();
            Kirmaaminen();
            Console.WriteLine("Jorma ja Jaana haluavat sanoa sinulle jotain. Paina Enter!");
            Console.ReadLine();
            Jorma.Hirnuminen();
            Jaana.Hirnuminen();
            Console.WriteLine("Jaana näyttää suunnittelevan jotain epäilyttävää... Ota selvää painamalla Enter!");
            Console.ReadLine();
            Jaana.Jump();
        }
    }

    public class SiitosoriHelper //Sieltä se Jorma tulee jeesaamaan takavasemmalta, et saadaan hirnumiset kondikseen :D
    {
        public void Hirnuminen ()
        {
            //string laidun = "multa"; (VILLE SÖSSI!!! Ei oo mun vika)
            Random rnd = new Random();
            //Heppa voi hirnua randomisti kolmella eri tavalla sattumanvaraisessa järjestyksessä
            int typeOfNeigh = rnd.Next(1, 4); //Ville lottosi että toimiikohan vaiko eikö. Huhhuh saatana, onneks toimi!
            if (typeOfNeigh == 1)
            {
                Console.WriteLine("Jorma sanoo hihi");
            }
            else if (typeOfNeigh == 2)
            {
                Console.WriteLine("Jorma sanoo haha");
            }
            else if (typeOfNeigh == 3)
            {
                Console.WriteLine("Jorma sanoo hehe");
            }
            else { }
            //return laidun; (VILLE SÖSSI!!! Ei oo mun vika)
        }
    }
    public class TuimaTamma //Heppa karkaa tai pysyy aitauksessa
    {
        public void Hirnuminen()
        {
            //string laidun = "multa"; (VILLE SÖSSI!!! Ei oo mun vika)
            Random rnd = new Random();
            //Heppa voi hirnua randomisti kolmella eri tavalla sattumanvaraisessa järjestyksessä
            int typeOfNeigh = rnd.Next(5, 8); //Ville lottosi että toimiikohan vaiko eikö. Huhhuh saatana, onneks toimi!
            if (typeOfNeigh == 5)
            {
                Console.WriteLine("Jaana sanoo hihi");
            }
            else if (typeOfNeigh == 6)
            {
                Console.WriteLine("Jaana sanoo haha");
            }
            else if (typeOfNeigh == 7)
            {
                Console.WriteLine("Jaana sanoo hehe");
            }
            else { }
            //return laidun; (VILLE SÖSSI!!! Ei oo mun vika)
        }
        public void Jump()
        {
            Random rnd = new Random();
            //Jaana joko pääsee aidan yli tai ei
            int jumpOverFenceOrNot = rnd.Next(8, 10);
            if (jumpOverFenceOrNot == 8)
            {
                Console.WriteLine("Jaana saa päättömän idean: 'Olisi jännää hypätä aidan yli vapauteen!' Jaana kuitenkin failaa surkeasti ja etujalat kolisevat aidan yläreunaan. Jaana ei päässyt karkuun.");
            }
            else if (jumpOverFenceOrNot == 9)
            {
                Console.WriteLine("Jaana saa päättömän idean: 'Olisi jännää hypätä aidan yli vapauteen!' Jaana hyppää mad skillseillä komeasti aidan toiselle puolelle. Lisäksi aidan yläreunan ja Jaanan mahan väliin jää vielä reilusti tilaa! Awesome! Jaana pääsi karkuun.");
            }
        }
    }
} // To be continued...
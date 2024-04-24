using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entrez votre poids (en kg): ");
            double poids = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez votre taille (en mètres): ");
            double taille = Convert.ToDouble(Console.ReadLine());

            double imc = poids / (taille * taille);
          

            string categorie = "";

            if (imc < 18.5)

            {
                categorie = "Poids normal";
            }

            else if (imc <30)

            {
                categorie = "Surpoids";
            }

            else

            {
                categorie = "Obésité";
            }

            Console.WriteLine("Votre IMC est: " + imc + " (" + categorie + ")");

        }
    }
}


        


    
    

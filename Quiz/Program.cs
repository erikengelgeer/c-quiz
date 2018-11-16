using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Vraag vraag1 = new Vraag(1, "Wiskunde", "Hoeveel is 10x12?", "120");
            Vraag vraag2 = new Vraag(3, "Biologie", "Van welke proteïne krijgt bloed de rode kleur?", "hemoglobin");
            Vraag vraag3 = new Vraag(1, "Wiskunde", "Hoeveel is -2 + 2", "0");
            Vraag vraag4 = new Vraag(1, "Topografie", "Wat is de hoofdstad van Nederland", "Amsterdam");
            Vraag vraag5 = new Vraag(2, "Wiskunde", "Hoeveel is (156-86)+13*7?", "161");
            Vraag vraag6 = new Vraag(2, "Biologie", "De aanpassing van het dna in een organisme word een ? genoemd", "mutatie");

            List<Vraag> QuizVragen = new List<Vraag>();

            QuizVragen.Add(vraag1);
            QuizVragen.Add(vraag2);
            QuizVragen.Add(vraag3);
            QuizVragen.Add(vraag4);
            QuizVragen.Add(vraag5);
            QuizVragen.Add(vraag6);

            var SortedQuestions = QuizVragen.OrderBy(o => o.graad);

            foreach(Vraag v in SortedQuestions)
            {
                VraagWeergeven(v.vraag, v.ant);
            }
        }

        static void VraagWeergeven(string v, string a)
        {
            string response;
            Console.WriteLine(v);
            Console.WriteLine("Jouw antwoord: ");
            response = Console.ReadLine();
            AntwoordNakijken(response, a);
        }

        static void AntwoordNakijken(string r, string a)
        {
            if (r.Equals(a))
            {
                Console.WriteLine("Dat klopt.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Niet correct");
                Console.ReadLine();
            }
        }
    }

    class Vraag
    {
        public int graad { get; set; }
        public string cat { get; set; }
        public string vraag { get; set; }
        public string ant { get; set; }

        public Vraag(int graad, string cat, string vraag, string ant)
        {
            this.graad = graad;
            this.cat = cat;
            this.vraag = vraag;
            this.ant = ant;
        }
    }
}

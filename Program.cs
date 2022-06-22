using System;

namespace Ex._1_Laborator7_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 1 – poker
            Scrieți un program care va modela o mână de poker.
            Mâna e poker conține 5 cărți.Cărțile vor avea valori de la 1 la 14 și vor putea fi de mai multe tipuri
            • Inimă roșie
            • Inimă neagră
            • Romb
            • Trifoi
            Creați o metoda prin intermediul căreia mâna de poker va putea fi tipărită pe ecran.
            Creați o metodă care va determina tipul mâinii de poker.
            • Dacă toate cărțile sunt inimă neagră, vom avea un royal flush, dacă toate cărțile sunt inimă roșie, mâna va fi de tipul
            straight flush, iar dacă va conține 4 carți cu aceiași valoare vom mâna va fi four of a kind. In orice altă situație, mâna va fi
            comună.
            Hint: folosiți enumerații
            În metoda main creeați mai multe mâini de poker, tipăriți - le, determinați - le tipul și afișați - l pe ecran.*/


            //// INTRODUCERE MAINI DE LA TASTATURA

            Console.WriteLine("Introduceti numarul de maini pe care vreti sa-l introduceti:");
            int n = int.Parse(Console.ReadLine());
            Mana[] manaVector = new Mana[n];
            for (int i = 0; i < n; i++)
            {
                Mana manaNoua = CreareMana();
                manaVector[i] = manaNoua;
            }

            for (int i = 0; i < manaVector.Length; i++)
            {
                manaVector[i].Tipareste();
                manaVector[i].GetTipMana();
            }



            ////MAINI GATA FORMATE

            //Carte inimaNeagra1 = new Carte(Carte.SimbolCarte.InimaNeagra, 1);
            //Carte inimaRosie2 = new Carte(Carte.SimbolCarte.InimaRosie, 2);
            //Carte romb3 = new Carte(Carte.SimbolCarte.Romb, 3);
            //Carte trefla4 = new Carte(Carte.SimbolCarte.Trefla, 4);

            //Carte[] inimaNeagra = new Carte[5];
            //for (int i = 0; i < inimaNeagra.Length; i++)
            //{
            //    inimaNeagra[i] = inimaNeagra1;
            //}
            //Mana royalFlush = new Mana(inimaNeagra);

            //Carte[] inimaRosie = new Carte[5];
            //for (int i = 0; i < inimaRosie.Length; i++)
            //{
            //    inimaRosie[i] = inimaRosie2;
            //}
            //Mana straightFlush = new Mana(inimaRosie);

            //Carte[] careu = new Carte[5];
            //for (int i = 0; i < careu.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        careu[i] = romb3;
            //    }
            //    else
            //    {
            //        careu[i] = trefla4;
            //    }
            //}
            //Mana fourOfAKind = new Mana(careu);

            //Carte[] comuna = new Carte[5];
            //comuna[0] = inimaRosie2;
            //comuna[1] = inimaNeagra1;
            //comuna[2] = trefla4;
            //comuna[3] = romb3;
            //comuna[4] = inimaRosie2;
            //Mana manaComuna = new Mana(comuna);

            //Mana[] vectorDeMaini = new Mana[4];
            //vectorDeMaini[0] = royalFlush;
            //vectorDeMaini[1] = straightFlush;
            //vectorDeMaini[2] = fourOfAKind;
            //vectorDeMaini[3] = manaComuna;

            //for (int i = 0; i < vectorDeMaini.Length; i++)
            //{
            //    vectorDeMaini[i].Tipareste();
            //    vectorDeMaini[i].GetTipMana();
            //}
        }

        public static Carte CreareCarte()
        {
            Console.WriteLine("Introduceti simbolul cartii: IN(Inima neagra), IR(Inima rosie), R(Romb), T(Trefla):");
            string introducereSimbol = Console.ReadLine().ToUpper();
            while (introducereSimbol != "IN" && introducereSimbol != "IR" && introducereSimbol != "R" && introducereSimbol != "T")
            {
                Console.WriteLine("INPUT GRESIT!");
                Console.WriteLine("Introduceti simbolul cartii: IN(Inima neagra), IR(Inima rosie), R(Romb), T(Trefla):");
                introducereSimbol = Console.ReadLine().ToUpper(); ;
            }
            Carte.SimbolCarte simbol = new Carte.SimbolCarte();
            if (introducereSimbol == "IN")
            {
                simbol = Carte.SimbolCarte.InimaNeagra;
            }
            else if (introducereSimbol == "IR")
            {
                simbol = Carte.SimbolCarte.InimaRosie;
            }
            else if (introducereSimbol == "R")
            {
                simbol = Carte.SimbolCarte.Romb;
            }
            else
            {
                simbol = Carte.SimbolCarte.Trefla;
            }
            Console.WriteLine("Introduceti numarul cartii cu valoare intre 1 si 14");
            int numar = int.Parse(Console.ReadLine());
            while (numar < 1 || numar > 14)
            {
                Console.WriteLine("introduceti valori intre 1 si 14");
                numar = int.Parse(Console.ReadLine());
            }
            Carte carte = new Carte(simbol, numar);
            return carte;
        }

        public static Mana CreareMana()
        {
            Console.WriteLine("Introduceti 5 carti pentru a crea o mana.");
            Carte[] carteVector = new Carte[5];
            Mana mana = new Mana(carteVector);
            Carte[] carteVectorVerificare = new Carte[5];
            for (int i = 0; i < carteVector.Length; i++)
            {
                Console.WriteLine($"Introduceti cartea {i + 1} ");
                carteVector[i] = CreareCarte();
                for (int j = 0; j < carteVector.Length; j++)
                {
                    if (carteVector[i]!=null&&carteVector[j]!=null)
                    {
                        if (j != i && carteVector[i].GetSimbol() == carteVector[j].GetSimbol() && carteVector[j].GetNumar() == carteVector[i].GetNumar())
                        {
                            Console.WriteLine("Cartile trebuie sa fie diferite!");
                            if (i>0)
                            {
                                i--;
                            }
                            else
                            {
                                i = 0;
                            }
                            break;
                        }
                    }
                    
                }
            }
            return mana;
        }
    }
}

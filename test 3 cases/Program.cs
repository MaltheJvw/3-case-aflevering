using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool debug = Debugmetode.Debugcheck();

            while (true)
            {
                Console.Clear();
                Debugmetode.UdskrivBesked("MENU", debug, true);
                Debugmetode.UdskrivBesked("Hvis du ønsker at bruge debug, skal du oprette en debug fil\n", debug, true);
                Debugmetode.UdskrivBesked("Login tast L\n", debug, true);
                Debugmetode.UdskrivBesked("Opret tast O\n", debug, true);

                string bruger = Console.ReadLine().ToUpper();

                switch (bruger)
                {
                    case "L":
                        Login(debug);
                        break;

                    case "O":
                        Opret(debug);
                        break;

                    default:
                        Debugmetode.UdskrivBesked($"{bruger} er ikke muligt", debug, true);
                        break;
                }

                Debugmetode.UdskrivBesked("Vil du forsætte? [J/N]", debug, false);
                string fortsæt = Console.ReadLine().ToUpper();
                if (fortsæt != "J")
                {
                    break;
                }
            }
        }

        static bool ValiderKodeord(string kodeord, string brugernavn)
        {
            bool krav1 = kodeord.Length >= 12;
            bool krav2 = false;
            bool krav3 = false;
            bool krav4 = false;
            bool krav5 = !kodeord.Contains(" ");
            bool krav6 = brugernavn.ToLower() != kodeord.ToLower();
            bool krav7 = false;
            bool krav8 = !char.IsDigit(kodeord[0]) && !char.IsDigit(kodeord[kodeord.Length - 1]);
            string special = "!@#$%^&*()_+[]{}|;':,.<>?";

            foreach (char c in kodeord)
            {
                if (char.IsUpper(c))
                {
                    krav2 = true;
                }
                else if (char.IsLower(c))
                {
                    krav3 = true;
                }
                else if (char.IsDigit(c) || char.IsPunctuation(c) || special.Contains(c))
                {
                    krav4 = true;
                    if (special.Contains(c))
                    {
                        krav7 = true;
                    }
                }

            }

            return krav1 && krav2 && krav3 && krav4 && krav5 && krav6 && krav7 && krav8;
        }

        static void BrugerData(string brugernavn, string kodeord)
        {
            string filnavn = "brugere.txt";

            using (StreamWriter writer = new StreamWriter(filnavn, false))
            {
                writer.WriteLine(brugernavn);
                writer.WriteLine(kodeord);
            }
        }
        static void Login(bool debug)
        {

            Console.Clear();
            List<string> skrevetlogin = new List<string>();
            string[] gemtlogin = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "brugere.txt"));

            Debugmetode.UdskrivBesked("brugernavn: ", debug, false);

            string bruger = Console.ReadLine().ToLower();

            Debugmetode.UdskrivBesked("Kodeord: ", debug, false);

            string kodeordlogin = Console.ReadLine();
            skrevetlogin.Add(bruger);
            skrevetlogin.Add(kodeordlogin);
            if (gemtlogin.SequenceEqual(skrevetlogin.ToArray()))
            {
                do
                {
                    Console.Clear();
                    Debugmetode.UdskrivBesked("1. Dansekonkurrence programmet\n", debug, false);
                    Debugmetode.UdskrivBesked("2. Fodbold progammet\n", debug, false);
                    Debugmetode.UdskrivBesked("3. afslut\n", debug, false);

                    string menu2 = Console.ReadLine();

                    switch (menu2)
                    {
                        case "1":
                            Dansekonkurrense.Start(debug);
                            break;


                        case "2":
                            Fodbold.Start(debug);
                            break;

                        case "3":
                            Environment.Exit(0);
                            break;
                    }

                } while (true);
            }

        }
        static void Opret(bool debug)
        {
            Console.Clear();
            Debugmetode.UdskrivBesked("opret bruger", debug, true);
            Debugmetode.UdskrivBesked("brugernavn: ", debug, false);

            string brugernavn = Console.ReadLine();
            string Kodeord;
            do
            {
                Debugmetode.UdskrivBesked("Kodeord: ", debug, false);
                Kodeord = Console.ReadLine();

                if (!ValiderKodeord(Kodeord, brugernavn))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Debugmetode.UdskrivBesked("Kodeordet opfylder ikke kravene, prøv igen", debug, true);
                    Console.ResetColor();
                }
            } while (!ValiderKodeord(Kodeord, brugernavn));

            BrugerData(brugernavn, Kodeord);

            Console.WriteLine("Bruger oprettet succesfuldt");
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Cases
{
    public class Fodbold
    {
        public static void Start(bool debug)
        {
            do
            {
                Console.Clear();

                Debugmetode.UdskrivBesked("Velkommen til vores fodbold program! Her vil du lære hvordan du jubler for dit lokale fodboldt hold\n", debug, true);
                Debugmetode.UdskrivBesked("jubelen vil tage hensyn til hvor mange afleveringer der bliver spillet, og om der bliver mål eller ej", debug, true);

                Debugmetode.UdskrivBesked("Ønsker du at spille? [J/N]", debug, false);

                string spil = Console.ReadLine().ToLower();

                if (spil == "j")
                {




                    int antalAfleveringer;

                    do
                    {
                        try
                        {
                            Debugmetode.UdskrivBesked(" ", debug, true);
                            Debugmetode.UdskrivBesked("\nIndtast antal afleveringer: ", debug, false);
                            antalAfleveringer = Convert.ToInt32(Console.ReadLine());
                            break;

                        }
                        catch (FormatException)
                        {
                            Debugmetode.UdskrivBesked("Input skal være et tal", debug, true);
                            continue;
                        }
                        catch (Exception ex)
                        {
                            Debugmetode.UdskrivBesked(ex.Message, debug, true);
                            continue;
                        }
                    } while (true);

                    Debugmetode.UdskrivBesked("Er der mål? [J/N]", debug, false);

                    string mål = Console.ReadLine().ToLower();

                    if (mål == "n")
                    {

                        if (antalAfleveringer <= 9 && antalAfleveringer >= 1)
                        {
                            for (int i = 0; i < antalAfleveringer; i++)
                            {
                                Debugmetode.UdskrivBesked("HUH!", debug, true);

                            }
                            Console.ReadKey();
                        }
                        else if (antalAfleveringer > 10)
                        {
                            Debugmetode.UdskrivBesked("High Five - Jubel", debug, true);
                            Console.ReadKey();
                        }
                        else if (antalAfleveringer == 0)
                        {
                            Debugmetode.UdskrivBesked("Shh", debug, true);
                            Console.ReadKey();
                        }
                    }
                    else if (mål == "j")
                    {
                        Debugmetode.UdskrivBesked("ole ole ole", debug, true);
                        Console.ReadKey();
                    }
                    else if (mål != "n" && mål != "j")
                    {
                        Debugmetode.UdskrivBesked("Du kan kun bruge J eller N, som input", debug, true);
                        Console.ReadKey();
                    }
                }
                else if (spil == "n")
                {
                    return;
                }

            } while (true);
        }
    }
}


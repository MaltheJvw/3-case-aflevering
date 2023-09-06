using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Cases
{
    public class Dansekonkurrense
    {
        public static void Start(bool debug)
        {
            do
            {
                Console.Clear();
                Debugmetode.UdskrivBesked("Velkommen til danseprogrammet", debug, true);

                string danser1, danser2;
                int dansepoint1, dansepoint2;

                Debugmetode.UdskrivBesked("Første danser: ", debug, false);

                danser1 = Console.ReadLine();

                do
                {
                    try
                    {
                        Debugmetode.UdskrivBesked("Hvor mange points: ", debug, false);

                        dansepoint1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Debugmetode.UdskrivBesked("Du skal give et tal", debug, true);
                        continue;

                    }
                    catch (Exception ex)
                    {
                        Debugmetode.UdskrivBesked(ex.Message, debug, true);
                        continue;

                    }
                } while (true);

                Debugmetode.UdskrivBesked("Anden danser: ", debug, false);
                danser2 = Console.ReadLine();

                do
                {
                    try
                    {
                        Debugmetode.UdskrivBesked("Hvor mange points: ", debug, false);

                        dansepoint2 = Convert.ToInt32(Console.ReadLine());
                        break;

                    }
                    catch (FormatException)
                    {
                        Debugmetode.UdskrivBesked("Du skal give et tal", debug, true);
                        continue;

                    }
                    catch (Exception ex)
                    {
                        Debugmetode.UdskrivBesked(ex.Message, debug, true);
                        continue;

                    }

                } while (true);

                dansepoints dancer1 = new dansepoints(danser1, dansepoint1);
                dansepoints dancer2 = new dansepoints(danser2, dansepoint2);
                dansepoints dansertotal = dancer1 + dancer2;

                Debugmetode.UdskrivBesked($"{dansertotal.navn} totale point er {dansertotal.points}\n", debug, false);
                Debugmetode.UdskrivBesked("tryk for at forsætte", debug, false);

                Console.ReadKey();

            } while (true);

        }
    }
}

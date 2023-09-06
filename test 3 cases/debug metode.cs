using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3_Cases
{
    internal class Debugmetode
    {
        public static void UdskrivBesked(string brugerbesked, bool debug, bool WriteLine)
        {
            if (debug)
            {

                if (WriteLine)
                {
                    System.Diagnostics.Debug.WriteLine(brugerbesked);
                }
                else
                {
                    System.Diagnostics.Debug.Write(brugerbesked);
                }
            }
            else
            {
                if (WriteLine)
                {
                    Console.WriteLine(brugerbesked);
                }
                else
                {
                    Console.Write(brugerbesked);
                }
            }
        }
        public static bool Debugcheck()
        {
            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "debug")))
            {
                return true;
            }
            else return false;
        }

    }
}


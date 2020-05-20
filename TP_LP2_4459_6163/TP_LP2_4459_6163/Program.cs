using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using BR;

namespace TP_LP2_4459_6163
{
    class Program
    {
        static void Main(string[] args)
        {
            Cao c = new Cao("Bolinhas", "terrier", "macho", DateTime.Today, "médio", "meigo");
            Cao c2 = new Cao("Bolinhas", "terrier", "macho", DateTime.Today, "médio", "meigo");
            Console.WriteLine(c.ToString());
            c2.Id = -1;
            Console.WriteLine(c2.ToString());
            try
            {
                if (RegrasParque.InsereCao(c) == true)
                    Console.WriteLine("ID: " + c.Id);
                else
                    Console.WriteLine("Insucesso");

            }
            catch (Exception e)
            {
                throw e;
            }
            Console.ReadKey();
        }
    }
}

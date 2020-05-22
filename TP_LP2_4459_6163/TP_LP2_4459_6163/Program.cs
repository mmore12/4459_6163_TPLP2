using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using BR;
using Excecoes;

namespace TP_LP2_4459_6163
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Cao
            Cao c = new Cao("Bolinhas", "terrier", "macho", DateTime.Today, "médio", "meigo");
            Cao c2 = new Cao("Pateco", "labrador", "macho", DateTime.Today, "médio", "brincalhao");
            
            try
            {
                RegrasParque.InsereCao(c);
                RegrasParque.InsereCao(c2);
                if (RegrasParque.InsereCao(c) == true)
                    Console.WriteLine("ID: " + c.Id + "\n");
                else
                    Console.WriteLine("Insucesso");
            }
            catch (Excecao e)
            {
               
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(c.ToString());
            Console.WriteLine(c2.ToString());

            if (RegrasParque.ProcuraCao(5) != null)
            {
                Console.WriteLine("O cão existe!");
            }
            #endregion

            #region Boletim Sanitario

            //Vacinas disponiveis
            RegrasParque.ProcuraTodasVacinas();
               

           
            #endregion


            Console.ReadKey();
        }
    }
}

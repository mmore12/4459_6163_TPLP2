using BO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class DadosParque
    {

        private static List<Cao> caes;
        private static List<BoletimSanitario> boletins;
        private static List<Vacina> vacinas;
        /// <summary>
        /// 
        /// </summary>
        static DadosParque()
        {

            caes = new List<Cao>();
            boletins = new List<BoletimSanitario>();
            vacinas = new List<Vacina>() {
            new Vacina("Primeira vacina", "Vacina das 6 semanas"),
            new Vacina("Vacina polivalente", "Vacina das 8 semanas"),
            new Vacina("Vacina antirrábica", "Imunológica"),
            new Vacina("Vacina Leishmaniose", "Imunológica")
            };

        }

        #region Dados para gerir caes
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool AddCao(Cao c)
        {
            foreach (Cao cao in caes)
            {
                //valida se o cao já existe
                if (cao.Id == c.Id)
                {
                    return false;
                }
            }
            caes.Add(c);

            return true;
        }

        /// <summary>
        /// Procura um cao
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Cao> GetCao(int id)
        {
            if (id >= 0)
            {
                List<Cao> find = new List<Cao>();
                //procura se o ID do cao existe
                if (caes.Find(c => c.Id == id) != null)
                {
                    find.Add(caes.Find(c => c.Id == id));
                    return find;
                }
            }
            return null;
        }

        #endregion

        /// <summary>
        /// Adicionar uma vacina
        /// </summary>
        /// <param name="vacina"></param>
        /// <returns></returns>
        public static bool AddVacina(Vacina vacina)
        {
            foreach (Vacina vacina1 in vacinas)
            {
                //valida se a vacina já existe
                if (vacina1.Id == vacina.Id)
                {
                    return false;
                }
            }
            vacinas.Add(vacina);
            return true;
        }

        /// <summary>
        /// Mostra todas as vacinas
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetAllVacinas()
        {
            //verifica se a lista tem vacinas
            if (vacinas != null)
            {
                for(int i = 0; i < vacinas.Count; i++)
                {
                    //imprime na consola todas as vacinas disponiveis.
                    Console.WriteLine(vacinas[i]);
                }
            }
            return null;
            
        }
        /// <summary>
        /// Adicionar um boletim sanitario
        /// </summary>
        /// <param name="boletim"></param>
        /// <returns></returns>
        public static bool AddBoletim(BoletimSanitario bol)
        {
            foreach (BoletimSanitario boletimSanitario in boletins)
            {
                //valida se o boletim daquele animal já existe
                if (boletimSanitario.Id_Animal == bol.Id_Animal)
                {
                    return false;
                }
            }
            boletins.Add(bol);

            return true;
        }
    }
}

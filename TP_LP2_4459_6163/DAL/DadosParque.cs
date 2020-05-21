using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class DadosParque
    {
<<<<<<< HEAD
        private static List<Cao> caes;

=======
        private static ArrayList caes;
        private static ArrayList boletins;
        private static ArrayList vacinas;
>>>>>>> 0c14115a33d80b60e4f23ab16b740953663d7e90
        /// <summary>
        /// 
        /// </summary>
        static DadosParque()
        {
<<<<<<< HEAD
            caes = new List<Cao>();
=======
            caes = new ArrayList();
            boletins = new ArrayList();
            vacinas = new ArrayList();
>>>>>>> 0c14115a33d80b60e4f23ab16b740953663d7e90
        }
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
                if(cao.Id == c.Id)
                { 
                    return false; 
                }
            }
            caes.Add(c);
<<<<<<< HEAD
=======
            return true;
        }
        #endregion

        #region Dados relacionados com BoletimSanitario
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
>>>>>>> 0c14115a33d80b60e4f23ab16b740953663d7e90
            return true;
        }
    }
}

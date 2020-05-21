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
        private static List<Cao> caes;

        /// <summary>
        /// 
        /// </summary>
        static DadosParque()
        {
            caes = new List<Cao>();
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
            return true;
        }
    }
}

using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR
{
    /// <summary>
    /// Regras negocio para gerir o parque
    /// </summary>
    public class RegrasParque
    {
        #region Regras para gerir caes
        /// <summary>
        /// Regra negocio para inserir um cao
        /// </summary>
        /// <param name="c">cão a inserir</param>
        /// <returns>adiciona o cao e retorna verdadeiro, caso contrario retorna falso</returns>
        public static bool InsereCao (Cao c)
        {
            if(c.Id < 0)
               return false;
            else
               return DadosParque.AddCao(c);
        }
        #endregion
    }
}

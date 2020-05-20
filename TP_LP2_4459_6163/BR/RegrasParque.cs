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
    /// 
    /// </summary>
    public class RegrasParque
    {
        public static bool InsereCao (Cao c)
        {
            try
            {
                
                return DadosParque.AddCao(c);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}

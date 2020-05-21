using BO;
using System;
using System.Collections;
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
        private static ArrayList dados;
        /// <summary>
        /// 
        /// </summary>
        static DadosParque()
        {
            dados = new ArrayList();
        }

        #region Dados relacionados com caes
        /// <summary>
        /// Metodo para adicionar um cao ao array de dados
        /// </summary>
        /// <param name="c">cao a adicionar</param>
        /// <returns>retorna true se o cão não existir e insere o mesmo no arraylist</returns>
        public static bool AddCao(Cao c)
        {
            foreach (Cao cao in dados)
            {
                //valida se o cao já existe
                if(cao.Id == c.Id)
                { 
                    return false; 
                }
            }
            dados.Add(c);
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
            foreach (Vacina vacina1 in dados)
            {
                //valida se a vacina já existe
                if (vacina1.Id == vacina.Id)
                {
                    return false;
                }
            }
            dados.Add(vacina);
            return true;
        }
        /// <summary>
        /// Adicionar um boletim sanitario
        /// </summary>
        /// <param name="boletim"></param>
        /// <returns></returns>
        public static bool AddBoletim(BoletimSanitario boletim)
        {
            foreach (BoletimSanitario boletimSanitario in dados)
            {
                //valida se o boletim daquele animal já existe
                if (boletimSanitario.Id_Animal == boletim.Id_Animal)
                {
                    return false;
                }
            }
            dados.Add(boletim);
            return true;
        }
        #endregion
    }
}

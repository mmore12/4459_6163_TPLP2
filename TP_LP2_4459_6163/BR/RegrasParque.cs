/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Aurélien Bouça e Elden Carones</author>
*   <date>5/19/2020</date>
*	<description>Gerir um canil</description>
**/
using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excecoes;

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
               return DadosCao.AddCao(c);
        }


        public static string ProcuraCao(int id)
        {
            if(id >= 0)
            {
                return DadosCao.GetCao(id);
            }
            return null;
        }
        #endregion

        

        #region Regras para gerir um boletim sanitario

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool InsereVacina(Vacina v)
        {
            //apenas adiciona caso o ID seja positivo, não é permitido ID's negativos
            if (v.Id >= 0)
                return DadosBoletim.AddVacina(v);
            else return false;
          
        }
        /// <summary>
        /// Procura todas as vacinas
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string ProcuraTodasVacinas()
        {
           return DadosBoletim.GetAllVacinas();        
        }
        #endregion
    }
}

/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>CaronesE</author>
*   <date>5/19/2020 11:15:21 PM</date>
*	<description></description>
**/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    /// <summary>
    /// Purpose:
    /// Created by: CaronesE
    /// Created on: 5/19/2020 11:15:21 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class BoletimSanitario
    {
        #region Attributes
        DateTime data_Vacina;
        int n_Ordem, id_Animal;
        //Arraylist para poder inserir tratamentos (vacinas, desparasitaçao, banhos)
        ArrayList tratamentos = new ArrayList();
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public BoletimSanitario()
        {

        }
        /// <summary>
        /// Construtor com vacinas
        /// </summary>
        /// <param name="id_Animal"></param>
        /// <param name="n_ordem"></param>
        /// <param name="vacinas"></param>
        /// <param name="data_Vacina"></param>
        public BoletimSanitario(int id_Animal, int n_Ordem, Vacina vacinas, DateTime data_Vacina)
        {
            this.id_Animal = id_Animal;
            this.n_Ordem = n_Ordem;
            this.tratamentos.Add(vacinas);
            this.data_Vacina = data_Vacina;
        }

        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public DateTime Data_Vacina
        {
            get { return data_Vacina; }
            set { data_Vacina = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int N_Ordem
        {
            get { return n_Ordem; }
            set { n_Ordem = value; }
        }
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~BoletimSanitario()
        {
        }
        #endregion

        #endregion
    }
}

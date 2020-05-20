/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>CaronesE</author>
*   <date>5/19/2020 11:10:24 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    /// <summary>
    /// Purpose:
    /// Created by: CaronesE
    /// Created on: 5/19/2020 11:10:24 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Funcionario : Pessoa
    {
        #region Attributes
        DateTime dataAdmissao;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Funcionario()
        {
        }
        /// <summary>
        /// Criar um funcionario
        /// </summary>
        /// <param name="data">data de admissao</param>
        /// <param name="n">nome do funcionario herdado da classe pessoas</param>
        /// <param name="i">idade do funcionario herdado da classe pessoas</param>
        /// <param name="f">funcao do funcionario herdado da classe pessoas</param>
        public Funcionario(DateTime data, string n, DateTime i, string f) : base(n, f, i)
        {
            dataAdmissao = data;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Manipula o atributo Data de admissao
        /// </summary>
        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
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
        ~Funcionario()
        {
        }
        #endregion

        #endregion
    }
}

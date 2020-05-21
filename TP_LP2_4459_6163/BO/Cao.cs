﻿/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>CaronesE</author>
*   <date>5/19/2020 11:09:01 PM</date>
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
    /// Created on: 5/19/2020 11:09:01 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Cao : Animal
    {
        #region Attributes
        string porte, personalidade;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Cao()
        {
        }
        /// <summary>
        /// Constructor with all elements of animal and a dog 
        /// </summary>
        /// <param name="n">animal name</param>
        /// <param name="r">animal breed</param>
        /// <param name="g">animal genre</param>
        /// <param name="d">animal birth date</param>
        /// <param name="p">animal port</param>
        /// <param name="per">animal personality</param>
        public Cao(string n, string r, string g, DateTime d, string p, string per) : base(n, r, g, d)
        {
            porte = p;
            personalidade = per;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propertie to manage the animal port
        /// </summary>
        public string Porte
        {
            get { return porte; }
            set { porte = value; }
        }
        /// <summary>
        /// Propertie to manage the animal personality
        /// </summary>
        public string Personalidade
        {
            get { return personalidade; }
            set { personalidade = value; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string aux = ("ID: " + base.Id + " Nome: " + base.Nome + " Raça: " + base.Raca + " Gênero: " + base.Genero + " Data de Nascimento: " 
                + base.Data_Nasc + " Porte: " + porte + " Personalidade: " + personalidade);
            return aux;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Cao()
        {
        }
        #endregion

        #endregion
    }
}

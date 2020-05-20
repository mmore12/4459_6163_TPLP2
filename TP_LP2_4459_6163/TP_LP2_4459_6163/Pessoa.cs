using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LP2_4459_6163
{
    /// <summary>
    /// Purpose:
    /// Created by: CaronesE
    /// Created on: 5/17/2020 11:19:12 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        string nome;
        DateTime idade;
        string funcao;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
        }
        /// <summary>
        /// Construtor para criar uma pessoa com nome, idade e função
        /// </summary>
        /// <param name="n">nome pessoa</param>
        /// <param name="i">idade da pessoa</param>
        /// <param name="f">funcao da pessoa</param>
        public Pessoa(string n, DateTime i, string f)
        {
            nome = n;
            idade = i;
            funcao = f;

        }
        #endregion

        #region Properties
        /// <summary>
        /// Propertie para obter ou colocar nome da pessoa
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obter ou colocar idade da pessoa
        /// </summary>
        public DateTime Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        /// <summary>
        /// Obter ou colocar funcao da pessoa
        /// </summary>
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
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
        ~Pessoa()
        {
        }
        #endregion

        #endregion
    }
}

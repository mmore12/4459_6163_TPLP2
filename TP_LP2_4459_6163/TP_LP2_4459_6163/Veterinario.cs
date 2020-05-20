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
    /// Created on: 5/19/2020 10:09:55 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veterinario : Pessoa
    {
        #region Attributes
        DateTime dataAdmissao;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veterinario()
        {
        }
        /// <summary>
        /// Criar um veterinário
        /// </summary>
        /// <param name="data">data admissao</param>
        /// <param name="n">nome proveniente da classe pessoas</param>
        /// <param name="i">idade proveniente da classe pessoas</param>
        /// <param name="f">funcao proveniente da classe pessoas</param>
        public Veterinario(DateTime data, string n, DateTime i, string f) : base(n, i, f)
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
        ~Veterinario()
        {
        }
        #endregion

        #endregion
    }
}

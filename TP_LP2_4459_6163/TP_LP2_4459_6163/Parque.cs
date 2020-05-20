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
    /// Created on: 5/17/2020 11:23:08 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Parque
    {
        #region Attributes

        int idParque = 0;
        string nome;
        int capacidade;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Parque()
        {
        }

        public Parque(string nome, int capacidade)
        {
            this.nome = nome;
            this.capacidade = capacidade;

            idParque = ++idParque;
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Parque()
        {
        }
        #endregion

        #endregion
    }
}

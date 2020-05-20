using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LP2_4459_6163
{
    /// <summary>
    /// Classe para gerir as vacinas
    /// </summary>
    class Vacina
    {
        #region Estado
        string nome;
        string tipo;
        int id;
        #endregion

        #region Properties
        /// <summary>
        /// Nome da vacina
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Tipo de vacina
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Id da vacina
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Contrutores
        /// <summary>
        /// Criar uma vacina com nome, tipo e quantidade
        /// </summary>
        /// <param name="n">nome da vacina</param>
        /// <param name="t">tipo de vacina</param>
        /// <param name="q">quantidade de vacina</param>
        public Vacina(string n, string t, int i)
        {
            nome = n;
            tipo = t;
            id = i;
        }
        #endregion
    }
}

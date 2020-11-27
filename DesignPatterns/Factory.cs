using ProvaNET.DesignPatterns.Classes;
using System.Collections.Generic;

namespace ProvaNET.DesignPatterns
{
    /// <summary>
    /// Classe abstrata Factory (implementa o método abstrato para criar)
    /// </summary>
    abstract class Factory
    {
        List<Passaro> _Passaros = new List<Passaro>();

        /// <summary>
        /// Construtor que chama o método factory abstrato
        /// </summary>
        public Factory()
        {
            this.CriarPassaros();
        }

        public List<Passaro> Passaros
        {
            get { return _Passaros; }
        }

        /// <summary>
        /// Método Factory
        /// </summary>
        public abstract void CriarPassaros();
    }
}

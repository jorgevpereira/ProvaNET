namespace ProvaNET.DesignPatterns.Classes
{
    /// <summary>
    /// Classe concreta que representa pássaros da familia Psitacídeos
    /// </summary>
    class Psitacideos : Factory
    {
        /// <summary>
        /// Implementação do método Factory
        /// Cria as classes de pássaros da familia específica
        /// </summary>
        public override void CriarPassaros()
        {
            Passaros.Add(new Arara());
            Passaros.Add(new Calopsita());
            Passaros.Add(new Papagaio());
        }
    }
}

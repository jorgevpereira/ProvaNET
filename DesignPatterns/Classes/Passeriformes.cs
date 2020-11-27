namespace ProvaNET.DesignPatterns.Classes
{
    /// <summary>
    /// Classe concreta que representa pássaros da familia Passeriformes
    /// </summary>
    class Passeriformes : Factory
    {
        public override void CriarPassaros()
        {
            Passaros.Add(new Bicudo());
            Passaros.Add(new Canario());
            Passaros.Add(new Curio());
        }
    }
}

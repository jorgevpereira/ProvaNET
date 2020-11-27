namespace ProvaNET.DesignPatterns
{
    // Classe no modelo Singleton simples
    public sealed class Singleton
    {
        static readonly Singleton instance = new Singleton();

        public int Identificador { get; set; }

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}

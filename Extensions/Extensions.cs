namespace ProvaNET.Extensions
{
    public static class Extensions
    {
        public static string CaixaAltaPrimeiraLetra(this string valor)
        {
            // Põe a primeira letra em caixa alta
            if (valor?.Length > 0)
            {
                char[] array = valor.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return valor;
        }
    }
}

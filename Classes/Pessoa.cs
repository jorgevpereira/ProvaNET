﻿using System;

namespace ProvaNET.Classes
{
    /// <summary>
    /// Classe que representa uma pessoa
    /// </summary>
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Empresa Empresa { get; set; }
    }
}

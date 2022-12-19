using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations;

namespace Cadastro_Pessoa
{
    public class Pessoa
    {
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }

        public Pessoa(bool ativo, string nome, string sobrenome, DateTime dataNascimento, decimal altura)
        {
            Ativo = ativo;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }
    }
}

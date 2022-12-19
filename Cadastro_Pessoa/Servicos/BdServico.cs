using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Cadastro_Pessoa.Servicos;
using Cadastro_Pessoa;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure.Interception;

namespace Cadastro_Pessoa.Servicos
{
    public class BdServico
    {
        private readonly SQLiteConnection _connection;

        public BdServico()
        {
            _connection = new SQLiteConnection("Data Source=.\\BdDesafio");

            CriarTabelaPessoaSeNaoExistir();
        }

        private void CriarTabelaPessoaSeNaoExistir()
        {
            string sqliteCommandText = @"CREATE TABLE IF NOT EXISTS pessoa(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                ativo INTEGER NOT NULL,
                nome VARCHAR(20) NOT NULL,
                sobrenome VARCHAR(60) NOT NULL,
                data_nascimento DATETIME NOT NULL,
                altura REAL NOT NULL
            )";

            SQLiteCommand command = _connection.CreateCommand();

            command.CommandText = sqliteCommandText;

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public DataTable ObterTodasAsPessoas()
        {
            string sqliteCommandText = "SELECT * FROM pessoa";

            SQLiteCommand command = _connection.CreateCommand();

            command.CommandText = sqliteCommandText;

            DataTable dataTable = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

            adapter.Fill(dataTable);

            return dataTable;
        }

        public Pessoa ObterPessoa(int id)
        {
            string sqliteCommandText = "SELECT * FROM pessoa WHERE id = @id";

            SQLiteCommand command = _connection.CreateCommand();

            command.CommandText = sqliteCommandText;

            command.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

            adapter.Fill(dataTable);

            DataRow row = dataTable.Rows[0];

            return new Pessoa(
                int.Parse(row["ativo"].ToString()!) != 0,
                row["nome"].ToString()!,
                row["sobrenome"].ToString()!,
                DateTime.Parse(row["data_nascimento"].ToString()!),
                decimal.Parse(row["altura"].ToString()!));
        }

        public void InserirPessoa(Pessoa pessoa)
        {
            string sqliteCommandText = @"INSERT INTO pessoa (ativo, nome, sobrenome, data_nascimento, altura) VALUES (
                @ativo, @nome, @sobrenome, @data_nascimento, @altura)";

            SQLiteCommand command = _connection.CreateCommand();

            command.CommandText = sqliteCommandText;

            command.Parameters.AddWithValue("@ativo", pessoa.Ativo);
            command.Parameters.AddWithValue("@nome", pessoa.Nome);
            command.Parameters.AddWithValue("@sobrenome", pessoa.Sobrenome);
            command.Parameters.AddWithValue("@data_nascimento", pessoa.DataNascimento);
            command.Parameters.AddWithValue("@altura", pessoa.Altura);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void EditarPessoa(Pessoa pessoa, int id)
        {
            string sqliteCommandText = @"UPDATE pessoa SET ativo = @ativo, nome = @nome, 
                sobrenome = @sobrenome, data_nascimento = @data_nascimento, altura = @altura 
                WHERE id = @id" ;

            SQLiteCommand command = _connection.CreateCommand();

            command.CommandText = sqliteCommandText;

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ativo", pessoa.Ativo);
            command.Parameters.AddWithValue("@nome", pessoa.Nome);
            command.Parameters.AddWithValue("@sobrenome", pessoa.Sobrenome);
            command.Parameters.AddWithValue("@data_nascimento", pessoa.DataNascimento);
            command.Parameters.AddWithValue("@altura", pessoa.Altura);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void ExcluirPessoa(int id)
        {                              
            string sqliteCommandText = "DELETE FROM pessoa WHERE id = @id";

            SQLiteCommand command = _connection.CreateCommand();

            command.CommandText = sqliteCommandText;

            command.Parameters.AddWithValue("@id", id);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}

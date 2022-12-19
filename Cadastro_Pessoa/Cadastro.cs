using Cadastro_Pessoa.Servicos;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;

namespace Cadastro_Pessoa
{
    public partial class Cadastro : Form
    {
        private readonly BdServico _bdServico;
        private readonly int? _id;

        public Cadastro()
        {
            InitializeComponent();

            _bdServico = new BdServico();
        }

        public Cadastro(int id) : this()
        {
            _id = id;

            Pessoa pessoa = _bdServico.ObterPessoa(id);

            campoId.Text = id.ToString();
            botaoAtivo.Checked = pessoa.Ativo;
            botaoInativo.Checked = !pessoa.Ativo;
            campoTextoNome.Text = pessoa.Nome;
            campoTextoSobrenome.Text = pessoa.Sobrenome;
            campoDataNascimento.Value = pessoa.DataNascimento;
            campoAltura.Value = pessoa.Altura;
        }

        private void button_Save(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(
                botaoAtivo.Checked,
                campoTextoNome.Text,
                campoTextoSobrenome.Text,
                campoDataNascimento.Value,
                campoAltura.Value);

            if (_id.HasValue)
            {
                _bdServico.EditarPessoa(pessoa, _id.Value);
            }
            else
            {
                _bdServico.InserirPessoa(pessoa);
            }

            VoltarParaTelaInformacoesCadastrais();
        }

        private void VoltarParaTelaInformacoesCadastrais()
        {
            Hide();
            new InformacoesCadastrais().ShowDialog();
            Close();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            VoltarParaTelaInformacoesCadastrais();
        }
    }
}

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
using System.Drawing.Text;
using Cadastro_Pessoa;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Reflection;


namespace Cadastro_Pessoa
{
    public partial class InformacoesCadastrais : Form
    {
        private readonly BdServico _bdServico;

        public InformacoesCadastrais()
        {
            InitializeComponent();

            _bdServico = new BdServico();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Hide();
            new Cadastro().ShowDialog();
            Close();
        }
      
        private void InformacoesCadastrais_Load(object sender, EventArgs e)
        {
            FormatarDataNascimento();

            foreach (DataRow row in _bdServico.ObterTodasAsPessoas().Rows)
            {
                int indice = gridPessoas.Rows.Add();

                foreach (DataGridViewColumn coluna in gridPessoas.Columns)
                {
                    gridPessoas.Rows[indice].Cells[coluna.Name].Value = row[coluna.Name];
                }
            }
        }

        private void FormatarDataNascimento()
        {
            gridPessoas.Columns["data_nascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void EditarSelecionado_Click(object sender, EventArgs e)
        {
            if (gridPessoas.SelectedRows.Count > 0)
            {
                int id = ObterIdPessoaSelecionada();

                Hide();
                new Cadastro(id).ShowDialog();
                Close();                
            }
        }

        private void ExcluirSelecionado_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("Confirmar exclusão da Pessoa?", "Responda",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                return;
            }

            if (gridPessoas.SelectedRows.Count > 0)
            {
                _bdServico.ExcluirPessoa(ObterIdPessoaSelecionada());

                gridPessoas.Rows.RemoveAt(gridPessoas.CurrentRow.Index);

                MessageBox.Show("Pessoa excluida com sucesso!", "Sucesso",
                  MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private int ObterIdPessoaSelecionada()
        {
            int linha = gridPessoas.CurrentRow.Index;
            int id = int.Parse(gridPessoas.Rows[linha].Cells[0].Value.ToString()!);
            return id;
        }     
    }
}

namespace Cadastro_Pessoa
{
    partial class InformacoesCadastrais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacoesCadastrais));
            this.gridPessoas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.EditarSelecionado = new System.Windows.Forms.Button();
            this.ExcluirSelecionado = new System.Windows.Forms.Button();
            this.Pessoascadastradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPessoas
            // 
            this.gridPessoas.AllowUserToAddRows = false;
            this.gridPessoas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridPessoas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPessoas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPessoas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ativo,
            this.nome,
            this.sobrenome,
            this.data_nascimento,
            this.altura});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPessoas.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPessoas.Location = new System.Drawing.Point(12, 51);
            this.gridPessoas.Name = "gridPessoas";
            this.gridPessoas.ReadOnly = true;
            this.gridPessoas.RowTemplate.Height = 25;
            this.gridPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPessoas.Size = new System.Drawing.Size(705, 248);
            this.gridPessoas.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 61;
            // 
            // ativo
            // 
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ativo.Width = 60;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 130;
            // 
            // sobrenome
            // 
            this.sobrenome.HeaderText = "Sobrenome";
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.ReadOnly = true;
            this.sobrenome.Width = 160;
            // 
            // data_nascimento
            // 
            this.data_nascimento.HeaderText = "Data de Nascimento";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.ReadOnly = true;
            this.data_nascimento.Width = 150;
            // 
            // altura
            // 
            this.altura.HeaderText = "Altura";
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(357, 12);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 1;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // EditarSelecionado
            // 
            this.EditarSelecionado.Location = new System.Drawing.Point(447, 12);
            this.EditarSelecionado.Name = "EditarSelecionado";
            this.EditarSelecionado.Size = new System.Drawing.Size(127, 23);
            this.EditarSelecionado.TabIndex = 2;
            this.EditarSelecionado.Text = "Editar Selecionado";
            this.EditarSelecionado.UseVisualStyleBackColor = true;
            this.EditarSelecionado.Click += new System.EventHandler(this.EditarSelecionado_Click);
            // 
            // ExcluirSelecionado
            // 
            this.ExcluirSelecionado.Location = new System.Drawing.Point(590, 12);
            this.ExcluirSelecionado.Name = "ExcluirSelecionado";
            this.ExcluirSelecionado.Size = new System.Drawing.Size(127, 23);
            this.ExcluirSelecionado.TabIndex = 3;
            this.ExcluirSelecionado.Text = "Excluir Selecionado";
            this.ExcluirSelecionado.UseVisualStyleBackColor = true;
            this.ExcluirSelecionado.Click += new System.EventHandler(this.ExcluirSelecionado_Click_1);
            // 
            // Pessoascadastradas
            // 
            this.Pessoascadastradas.AutoSize = true;
            this.Pessoascadastradas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pessoascadastradas.Location = new System.Drawing.Point(12, 18);
            this.Pessoascadastradas.Name = "Pessoascadastradas";
            this.Pessoascadastradas.Size = new System.Drawing.Size(134, 17);
            this.Pessoascadastradas.TabIndex = 4;
            this.Pessoascadastradas.Text = "Pessoas Cadastradas";
            // 
            // InformacoesCadastrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 328);
            this.Controls.Add(this.gridPessoas);
            this.Controls.Add(this.Pessoascadastradas);
            this.Controls.Add(this.ExcluirSelecionado);
            this.Controls.Add(this.EditarSelecionado);
            this.Controls.Add(this.Cadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformacoesCadastrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Cadastrais";
            this.Load += new System.EventHandler(this.InformacoesCadastrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridPessoas;
        private Button Cadastrar;
        private Button EditarSelecionado;
        private Button ExcluirSelecionado;
        private Label Pessoascadastradas;
        private DataGridViewTextBoxColumn id;
        private DataGridViewCheckBoxColumn ativo;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn sobrenome;
        private DataGridViewTextBoxColumn data_nascimento;
        private DataGridViewTextBoxColumn altura;
    }
}
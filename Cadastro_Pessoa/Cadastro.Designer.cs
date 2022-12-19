namespace Cadastro_Pessoa
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoId = new System.Windows.Forms.TextBox();
            this.campoTextoNome = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.campoDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.campoAltura = new System.Windows.Forms.NumericUpDown();
            this.campoSituacao = new System.Windows.Forms.Panel();
            this.botaoInativo = new System.Windows.Forms.RadioButton();
            this.botaoAtivo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.campoTextoSobrenome = new System.Windows.Forms.TextBox();
            this.botaoCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.campoAltura)).BeginInit();
            this.campoSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informações Pessoais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(257, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sobrenome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(172, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Altura";
            // 
            // campoId
            // 
            this.campoId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.campoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoId.Enabled = false;
            this.campoId.Location = new System.Drawing.Point(27, 75);
            this.campoId.Name = "campoId";
            this.campoId.ReadOnly = true;
            this.campoId.Size = new System.Drawing.Size(87, 23);
            this.campoId.TabIndex = 7;
            // 
            // campoTextoNome
            // 
            this.campoTextoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoTextoNome.Location = new System.Drawing.Point(27, 137);
            this.campoTextoNome.Name = "campoTextoNome";
            this.campoTextoNome.Size = new System.Drawing.Size(208, 23);
            this.campoTextoNome.TabIndex = 8;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSalvar.Location = new System.Drawing.Point(520, 231);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.button_Save);
            // 
            // campoDataNascimento
            // 
            this.campoDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.campoDataNascimento.Location = new System.Drawing.Point(27, 201);
            this.campoDataNascimento.Name = "campoDataNascimento";
            this.campoDataNascimento.Size = new System.Drawing.Size(114, 23);
            this.campoDataNascimento.TabIndex = 15;
            // 
            // campoAltura
            // 
            this.campoAltura.AllowDrop = true;
            this.campoAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoAltura.DecimalPlaces = 2;
            this.campoAltura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.campoAltura.Location = new System.Drawing.Point(172, 204);
            this.campoAltura.Name = "campoAltura";
            this.campoAltura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoAltura.Size = new System.Drawing.Size(63, 23);
            this.campoAltura.TabIndex = 16;
            this.campoAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // campoSituacao
            // 
            this.campoSituacao.Controls.Add(this.botaoInativo);
            this.campoSituacao.Controls.Add(this.botaoAtivo);
            this.campoSituacao.Location = new System.Drawing.Point(257, 201);
            this.campoSituacao.Name = "campoSituacao";
            this.campoSituacao.Size = new System.Drawing.Size(131, 24);
            this.campoSituacao.TabIndex = 17;
            // 
            // botaoInativo
            // 
            this.botaoInativo.AutoSize = true;
            this.botaoInativo.Location = new System.Drawing.Point(62, 3);
            this.botaoInativo.Name = "botaoInativo";
            this.botaoInativo.Size = new System.Drawing.Size(61, 19);
            this.botaoInativo.TabIndex = 18;
            this.botaoInativo.TabStop = true;
            this.botaoInativo.Text = "Inativo";
            this.botaoInativo.UseVisualStyleBackColor = true;
            // 
            // botaoAtivo
            // 
            this.botaoAtivo.AutoSize = true;
            this.botaoAtivo.Location = new System.Drawing.Point(3, 4);
            this.botaoAtivo.Name = "botaoAtivo";
            this.botaoAtivo.Size = new System.Drawing.Size(53, 19);
            this.botaoAtivo.TabIndex = 0;
            this.botaoAtivo.TabStop = true;
            this.botaoAtivo.Text = "Ativo";
            this.botaoAtivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(257, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Situação";
            // 
            // campoTextoSobrenome
            // 
            this.campoTextoSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoTextoSobrenome.Location = new System.Drawing.Point(257, 137);
            this.campoTextoSobrenome.Name = "campoTextoSobrenome";
            this.campoTextoSobrenome.Size = new System.Drawing.Size(338, 23);
            this.campoTextoSobrenome.TabIndex = 20;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botaoCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoCancelar.Location = new System.Drawing.Point(439, 231);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 21;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 274);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.campoTextoSobrenome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoSituacao);
            this.Controls.Add(this.campoAltura);
            this.Controls.Add(this.campoDataNascimento);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.campoTextoNome);
            this.Controls.Add(this.campoId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.campoAltura)).EndInit();
            this.campoSituacao.ResumeLayout(false);
            this.campoSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel campoSituacao;
        private Label label7;
        public TextBox campoId;
        public TextBox campoTextoNome;
        public Button BtnSalvar;
        public DateTimePicker campoDataNascimento;
        public NumericUpDown campoAltura;
        public RadioButton botaoInativo;
        public RadioButton botaoAtivo;
        public TextBox campoTextoSobrenome;
        public Button botaoCancelar;
    }
}
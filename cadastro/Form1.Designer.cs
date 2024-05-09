namespace cadastro
{
    partial class frmPrinc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.GrpGenero = new System.Windows.Forms.GroupBox();
            this.rbOutros = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.mtbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cmbEndereco = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.GrpGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // pbFoto
            // 
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(12, 10);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(165, 193);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nº";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-mail";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(45, 542);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(129, 41);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(180, 542);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(129, 41);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(632, 542);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 41);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(498, 549);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(62, 26);
            this.cbAtivo.TabIndex = 3;
            this.cbAtivo.TabStop = false;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Situação Cadastral:";
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(6, 22);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(96, 26);
            this.rbMasc.TabIndex = 0;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // GrpGenero
            // 
            this.GrpGenero.Controls.Add(this.rbOutros);
            this.GrpGenero.Controls.Add(this.rbFem);
            this.GrpGenero.Controls.Add(this.rbMasc);
            this.GrpGenero.Location = new System.Drawing.Point(396, 71);
            this.GrpGenero.Name = "GrpGenero";
            this.GrpGenero.Size = new System.Drawing.Size(384, 55);
            this.GrpGenero.TabIndex = 5;
            this.GrpGenero.TabStop = false;
            this.GrpGenero.Text = "Genero";
            // 
            // rbOutros
            // 
            this.rbOutros.AutoSize = true;
            this.rbOutros.Location = new System.Drawing.Point(282, 26);
            this.rbOutros.Name = "rbOutros";
            this.rbOutros.Size = new System.Drawing.Size(73, 26);
            this.rbOutros.TabIndex = 4;
            this.rbOutros.TabStop = true;
            this.rbOutros.Text = "Outros";
            this.rbOutros.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(137, 26);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(91, 26);
            this.rbFem.TabIndex = 4;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(183, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(92, 27);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(319, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(480, 27);
            this.txtNome.TabIndex = 1;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(183, 96);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(193, 27);
            this.txtDoc.TabIndex = 3;
            // 
            // btnFoto
            // 
            this.btnFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.Image")));
            this.btnFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoto.Location = new System.Drawing.Point(12, 211);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(103, 41);
            this.btnFoto.TabIndex = 2;
            this.btnFoto.TabStop = false;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(118, 211);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(56, 41);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.TabStop = false;
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(662, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Data Nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estado Civil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Endereço";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(6, 284);
            this.mtbCEP.Mask = "00,000,000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(97, 27);
            this.mtbCEP.TabIndex = 9;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(184, 70);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(59, 26);
            this.rbCPF.TabIndex = 2;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(249, 70);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(67, 26);
            this.rbCNPJ.TabIndex = 4;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.Location = new System.Drawing.Point(663, 173);
            this.mtbDataNasc.Mask = "00,00,0000";
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(136, 27);
            this.mtbDataNasc.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(680, 284);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(81, 27);
            this.txtNumero.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bairro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Estado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Celular";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(249, 415);
            this.mtbCelular.Mask = "(00)-0-000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(187, 27);
            this.mtbCelular.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(489, 415);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 27);
            this.txtEmail.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 452);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Observação";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(180, 163);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(196, 27);
            this.txtRG.TabIndex = 6;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 479);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(774, 57);
            this.txtObs.TabIndex = 17;
            // 
            // cmbEndereco
            // 
            this.cmbEndereco.FormattingEnabled = true;
            this.cmbEndereco.Location = new System.Drawing.Point(132, 286);
            this.cmbEndereco.Name = "cmbEndereco";
            this.cmbEndereco.Size = new System.Drawing.Size(492, 30);
            this.cmbEndereco.TabIndex = 10;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownWidth = 100;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(426, 163);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(198, 30);
            this.cmbEstadoCivil.TabIndex = 7;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownWidth = 100;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbEstado.Location = new System.Drawing.Point(6, 405);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(198, 30);
            this.cbEstado.TabIndex = 14;
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(344, 342);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(363, 30);
            this.cbCidade.TabIndex = 13;
            // 
            // cbBairro
            // 
            this.cbBairro.FormattingEnabled = true;
            this.cbBairro.Location = new System.Drawing.Point(6, 342);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(269, 30);
            this.cbBairro.TabIndex = 12;
            // 
            // frmPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 653);
            this.Controls.Add(this.cbBairro);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.cmbEndereco);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbDataNasc);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.rbCNPJ);
            this.Controls.Add(this.rbCPF);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.GrpGenero);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AD&M CONTROLLER";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrinc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.GrpGenero.ResumeLayout(false);
            this.GrpGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.GroupBox GrpGenero;
        private System.Windows.Forms.RadioButton rbOutros;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbDataNasc;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cmbEndereco;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbBairro;
    }
}


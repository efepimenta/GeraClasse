namespace GeraClasse
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtNomeClasse = new System.Windows.Forms.TextBox();
            this.edtEntradaFeia = new System.Windows.Forms.TextBox();
            this.edtEntradaBunita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAjudante = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pgbMain = new System.Windows.Forms.ToolStripProgressBar();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConsertar = new System.Windows.Forms.Button();
            this.edtSaida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSempreVisivel = new System.Windows.Forms.CheckBox();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.rdEntradaSaida = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.edtDescricaoDaClasse = new System.Windows.Forms.TextBox();
            this.rdSaida = new System.Windows.Forms.RadioButton();
            this.chkSoString = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGerar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNova = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Classe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrada Feia:";
            // 
            // edtNomeClasse
            // 
            this.edtNomeClasse.Location = new System.Drawing.Point(12, 87);
            this.edtNomeClasse.MaxLength = 100;
            this.edtNomeClasse.Name = "edtNomeClasse";
            this.edtNomeClasse.Size = new System.Drawing.Size(353, 20);
            this.edtNomeClasse.TabIndex = 0;
            this.edtNomeClasse.Text = "Registro_";
            // 
            // edtEntradaFeia
            // 
            this.edtEntradaFeia.Location = new System.Drawing.Point(12, 191);
            this.edtEntradaFeia.Multiline = true;
            this.edtEntradaFeia.Name = "edtEntradaFeia";
            this.edtEntradaFeia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtEntradaFeia.Size = new System.Drawing.Size(459, 247);
            this.edtEntradaFeia.TabIndex = 2;
            // 
            // edtEntradaBunita
            // 
            this.edtEntradaBunita.Location = new System.Drawing.Point(12, 457);
            this.edtEntradaBunita.Multiline = true;
            this.edtEntradaBunita.Name = "edtEntradaBunita";
            this.edtEntradaBunita.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtEntradaBunita.Size = new System.Drawing.Size(459, 307);
            this.edtEntradaBunita.TabIndex = 5;
            this.edtEntradaBunita.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saída:";
            // 
            // chkAjudante
            // 
            this.chkAjudante.AutoSize = true;
            this.chkAjudante.Location = new System.Drawing.Point(722, 71);
            this.chkAjudante.Name = "chkAjudante";
            this.chkAjudante.Size = new System.Drawing.Size(71, 17);
            this.chkAjudante.TabIndex = 10;
            this.chkAjudante.TabStop = false;
            this.chkAjudante.Text = "Ajudante:";
            this.chkAjudante.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgbMain,
            this.LblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 772);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(973, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pgbMain
            // 
            this.pgbMain.Name = "pgbMain";
            this.pgbMain.Size = new System.Drawing.Size(150, 16);
            this.pgbMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // LblStatus
            // 
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(123, 17);
            this.LblStatus.Text = "Ponto para começar...";
            // 
            // btnConsertar
            // 
            this.btnConsertar.Location = new System.Drawing.Point(371, 87);
            this.btnConsertar.Name = "btnConsertar";
            this.btnConsertar.Size = new System.Drawing.Size(100, 33);
            this.btnConsertar.TabIndex = 3;
            this.btnConsertar.Text = "Consertar";
            this.btnConsertar.UseVisualStyleBackColor = true;
            this.btnConsertar.Click += new System.EventHandler(this.btnConsertar_Click);
            // 
            // edtSaida
            // 
            this.edtSaida.Location = new System.Drawing.Point(480, 126);
            this.edtSaida.Multiline = true;
            this.edtSaida.Name = "edtSaida";
            this.edtSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtSaida.Size = new System.Drawing.Size(481, 638);
            this.edtSaida.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Entrada Bunita...";
            // 
            // chkSempreVisivel
            // 
            this.chkSempreVisivel.AutoSize = true;
            this.chkSempreVisivel.Location = new System.Drawing.Point(616, 71);
            this.chkSempreVisivel.Name = "chkSempreVisivel";
            this.chkSempreVisivel.Size = new System.Drawing.Size(100, 17);
            this.chkSempreVisivel.TabIndex = 15;
            this.chkSempreVisivel.TabStop = false;
            this.chkSempreVisivel.Text = "Sempre Visível:";
            this.chkSempreVisivel.UseVisualStyleBackColor = true;
            this.chkSempreVisivel.CheckedChanged += new System.EventHandler(this.chkSempreVisivel_CheckedChanged);
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Checked = true;
            this.rdNormal.Location = new System.Drawing.Point(142, 67);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(58, 17);
            this.rdNormal.TabIndex = 7;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "Normal";
            this.rdNormal.UseVisualStyleBackColor = true;
            // 
            // rdEntradaSaida
            // 
            this.rdEntradaSaida.AutoSize = true;
            this.rdEntradaSaida.Location = new System.Drawing.Point(206, 67);
            this.rdEntradaSaida.Name = "rdEntradaSaida";
            this.rdEntradaSaida.Size = new System.Drawing.Size(181, 17);
            this.rdEntradaSaida.TabIndex = 8;
            this.rdEntradaSaida.Text = "Sem Entrada ou Entrada / Saída";
            this.rdEntradaSaida.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Descricao da Classe:";
            // 
            // edtDescricaoDaClasse
            // 
            this.edtDescricaoDaClasse.Location = new System.Drawing.Point(12, 126);
            this.edtDescricaoDaClasse.Multiline = true;
            this.edtDescricaoDaClasse.Name = "edtDescricaoDaClasse";
            this.edtDescricaoDaClasse.Size = new System.Drawing.Size(459, 46);
            this.edtDescricaoDaClasse.TabIndex = 1;
            // 
            // rdSaida
            // 
            this.rdSaida.AutoSize = true;
            this.rdSaida.Location = new System.Drawing.Point(393, 67);
            this.rdSaida.Name = "rdSaida";
            this.rdSaida.Size = new System.Drawing.Size(78, 17);
            this.rdSaida.TabIndex = 9;
            this.rdSaida.TabStop = true;
            this.rdSaida.Text = "Sem Saída";
            this.rdSaida.UseVisualStyleBackColor = true;
            // 
            // chkSoString
            // 
            this.chkSoString.AutoSize = true;
            this.chkSoString.Checked = true;
            this.chkSoString.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoString.Location = new System.Drawing.Point(497, 71);
            this.chkSoString.Name = "chkSoString";
            this.chkSoString.Size = new System.Drawing.Size(113, 17);
            this.chkSoString.TabIndex = 22;
            this.chkSoString.TabStop = false;
            this.chkSoString.Text = "Tudo como String:";
            this.chkSoString.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerar,
            this.toolStripSeparator1,
            this.btnCopiar,
            this.toolStripSeparator2,
            this.btnNova,
            this.toolStripSeparator3,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(973, 53);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGerar
            // 
            this.btnGerar.AutoSize = false;
            this.btnGerar.Enabled = false;
            this.btnGerar.Image = global::GeraClasse.Properties.Resources.imgGerar;
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(80, 50);
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // btnCopiar
            // 
            this.btnCopiar.AutoSize = false;
            this.btnCopiar.Enabled = false;
            this.btnCopiar.Image = global::GeraClasse.Properties.Resources.imgCopiar;
            this.btnCopiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(80, 50);
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopiar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // btnNova
            // 
            this.btnNova.AutoSize = false;
            this.btnNova.Image = ((System.Drawing.Image)(resources.GetObject("btnNova.Image")));
            this.btnNova.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNova.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(80, 50);
            this.btnNova.Text = "Nova";
            this.btnNova.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNova.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 53);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.AutoSize = false;
            this.btnSair.Image = global::GeraClasse.Properties.Resources.imgSair;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 50);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 794);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chkSoString);
            this.Controls.Add(this.rdSaida);
            this.Controls.Add(this.edtDescricaoDaClasse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdEntradaSaida);
            this.Controls.Add(this.rdNormal);
            this.Controls.Add(this.chkSempreVisivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtSaida);
            this.Controls.Add(this.btnConsertar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chkAjudante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtEntradaBunita);
            this.Controls.Add(this.edtEntradaFeia);
            this.Controls.Add(this.edtNomeClasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Gerador de Classe [Sped Contabil / Fiscal] - by DigitalJobs";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtNomeClasse;
        private System.Windows.Forms.TextBox edtEntradaFeia;
        private System.Windows.Forms.TextBox edtEntradaBunita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAjudante;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.ToolStripProgressBar pgbMain;
        private System.Windows.Forms.Button btnConsertar;
        private System.Windows.Forms.TextBox edtSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSempreVisivel;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.RadioButton rdEntradaSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtDescricaoDaClasse;
        private System.Windows.Forms.RadioButton rdSaida;
        private System.Windows.Forms.CheckBox chkSoString;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGerar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCopiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNova;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSair;
    }
}


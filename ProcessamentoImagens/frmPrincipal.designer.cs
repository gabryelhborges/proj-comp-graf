namespace ProcessamentoImagens
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControlOpcoes = new System.Windows.Forms.TabControl();
            this.tabRetas = new System.Windows.Forms.TabPage();
            this.radioDDA = new System.Windows.Forms.RadioButton();
            this.radioGeneralEquation = new System.Windows.Forms.RadioButton();
            this.radioMidpoint = new System.Windows.Forms.RadioButton();
            this.buttonLimparImg = new System.Windows.Forms.Button();
            this.tabPoligonos = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.bttAplicaTranslacao = new System.Windows.Forms.Button();
            this.numTranslacaoY = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewPontos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPoligonos = new System.Windows.Forms.ListBox();
            this.tabOvais = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.numTranslacaoX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numEscalaX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numEscalaY = new System.Windows.Forms.NumericUpDown();
            this.numRotacionar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bttRotacionar = new System.Windows.Forms.Button();
            this.comboBoxReflexao = new System.Windows.Forms.ComboBox();
            this.bttReflexao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numCisalhamentoX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.bttCisalhamento = new System.Windows.Forms.Button();
            this.numCisalhamentoY = new System.Windows.Forms.NumericUpDown();
            this.tabControlOpcoes.SuspendLayout();
            this.tabRetas.SuspendLayout();
            this.tabPoligonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslacaoY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslacaoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEscalaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEscalaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisalhamentoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisalhamentoY)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOpcoes
            // 
            this.tabControlOpcoes.Controls.Add(this.tabRetas);
            this.tabControlOpcoes.Controls.Add(this.tabPoligonos);
            this.tabControlOpcoes.Controls.Add(this.tabOvais);
            this.tabControlOpcoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlOpcoes.Location = new System.Drawing.Point(728, 0);
            this.tabControlOpcoes.Name = "tabControlOpcoes";
            this.tabControlOpcoes.SelectedIndex = 0;
            this.tabControlOpcoes.Size = new System.Drawing.Size(252, 638);
            this.tabControlOpcoes.TabIndex = 103;
            // 
            // tabRetas
            // 
            this.tabRetas.Controls.Add(this.radioDDA);
            this.tabRetas.Controls.Add(this.radioGeneralEquation);
            this.tabRetas.Controls.Add(this.radioMidpoint);
            this.tabRetas.Controls.Add(this.buttonLimparImg);
            this.tabRetas.Location = new System.Drawing.Point(4, 22);
            this.tabRetas.Name = "tabRetas";
            this.tabRetas.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetas.Size = new System.Drawing.Size(244, 508);
            this.tabRetas.TabIndex = 0;
            this.tabRetas.Text = "Retas";
            // 
            // radioDDA
            // 
            this.radioDDA.AutoSize = true;
            this.radioDDA.Checked = true;
            this.radioDDA.Location = new System.Drawing.Point(18, 62);
            this.radioDDA.Name = "radioDDA";
            this.radioDDA.Size = new System.Drawing.Size(48, 17);
            this.radioDDA.TabIndex = 2;
            this.radioDDA.TabStop = true;
            this.radioDDA.Text = "DDA";
            // 
            // radioGeneralEquation
            // 
            this.radioGeneralEquation.AutoSize = true;
            this.radioGeneralEquation.Location = new System.Drawing.Point(18, 85);
            this.radioGeneralEquation.Name = "radioGeneralEquation";
            this.radioGeneralEquation.Size = new System.Drawing.Size(130, 17);
            this.radioGeneralEquation.TabIndex = 3;
            this.radioGeneralEquation.Text = "Equação geral da reta";
            // 
            // radioMidpoint
            // 
            this.radioMidpoint.AutoSize = true;
            this.radioMidpoint.Location = new System.Drawing.Point(18, 108);
            this.radioMidpoint.Name = "radioMidpoint";
            this.radioMidpoint.Size = new System.Drawing.Size(84, 17);
            this.radioMidpoint.TabIndex = 4;
            this.radioMidpoint.Text = "Ponto médio";
            // 
            // buttonLimparImg
            // 
            this.buttonLimparImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLimparImg.Location = new System.Drawing.Point(18, 32);
            this.buttonLimparImg.Name = "buttonLimparImg";
            this.buttonLimparImg.Size = new System.Drawing.Size(215, 23);
            this.buttonLimparImg.TabIndex = 1;
            this.buttonLimparImg.Text = "Limpar Imagem";
            this.buttonLimparImg.UseVisualStyleBackColor = true;
            this.buttonLimparImg.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tabPoligonos
            // 
            this.tabPoligonos.Controls.Add(this.label6);
            this.tabPoligonos.Controls.Add(this.numCisalhamentoX);
            this.tabPoligonos.Controls.Add(this.label7);
            this.tabPoligonos.Controls.Add(this.bttCisalhamento);
            this.tabPoligonos.Controls.Add(this.numCisalhamentoY);
            this.tabPoligonos.Controls.Add(this.bttReflexao);
            this.tabPoligonos.Controls.Add(this.comboBoxReflexao);
            this.tabPoligonos.Controls.Add(this.bttRotacionar);
            this.tabPoligonos.Controls.Add(this.label5);
            this.tabPoligonos.Controls.Add(this.numRotacionar);
            this.tabPoligonos.Controls.Add(this.label3);
            this.tabPoligonos.Controls.Add(this.numEscalaX);
            this.tabPoligonos.Controls.Add(this.label4);
            this.tabPoligonos.Controls.Add(this.button2);
            this.tabPoligonos.Controls.Add(this.numEscalaY);
            this.tabPoligonos.Controls.Add(this.label1);
            this.tabPoligonos.Controls.Add(this.numTranslacaoX);
            this.tabPoligonos.Controls.Add(this.label2);
            this.tabPoligonos.Controls.Add(this.bttAplicaTranslacao);
            this.tabPoligonos.Controls.Add(this.numTranslacaoY);
            this.tabPoligonos.Controls.Add(this.dataGridViewPontos);
            this.tabPoligonos.Controls.Add(this.button1);
            this.tabPoligonos.Controls.Add(this.listBoxPoligonos);
            this.tabPoligonos.Location = new System.Drawing.Point(4, 22);
            this.tabPoligonos.Name = "tabPoligonos";
            this.tabPoligonos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoligonos.Size = new System.Drawing.Size(244, 612);
            this.tabPoligonos.TabIndex = 1;
            this.tabPoligonos.Text = "Polígonos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // bttAplicaTranslacao
            // 
            this.bttAplicaTranslacao.Location = new System.Drawing.Point(127, 389);
            this.bttAplicaTranslacao.Name = "bttAplicaTranslacao";
            this.bttAplicaTranslacao.Size = new System.Drawing.Size(109, 20);
            this.bttAplicaTranslacao.TabIndex = 5;
            this.bttAplicaTranslacao.Text = "Translação";
            this.bttAplicaTranslacao.UseVisualStyleBackColor = true;
            this.bttAplicaTranslacao.Click += new System.EventHandler(this.bttAplicaTranslacao_Click);
            // 
            // numTranslacaoY
            // 
            this.numTranslacaoY.Location = new System.Drawing.Point(67, 389);
            this.numTranslacaoY.Name = "numTranslacaoY";
            this.numTranslacaoY.Size = new System.Drawing.Size(54, 20);
            this.numTranslacaoY.TabIndex = 4;
            this.numTranslacaoY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // dataGridViewPontos
            // 
            this.dataGridViewPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPontos.Location = new System.Drawing.Point(7, 201);
            this.dataGridViewPontos.Name = "dataGridViewPontos";
            this.dataGridViewPontos.Size = new System.Drawing.Size(230, 172);
            this.dataGridViewPontos.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Excluir Polígono";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // listBoxPoligonos
            // 
            this.listBoxPoligonos.FormattingEnabled = true;
            this.listBoxPoligonos.Location = new System.Drawing.Point(7, 6);
            this.listBoxPoligonos.Name = "listBoxPoligonos";
            this.listBoxPoligonos.Size = new System.Drawing.Size(230, 160);
            this.listBoxPoligonos.TabIndex = 0;
            this.listBoxPoligonos.SelectedIndexChanged += new System.EventHandler(this.listBoxPoligonos_SelectedIndexChanged);
            // 
            // tabOvais
            // 
            this.tabOvais.Location = new System.Drawing.Point(4, 22);
            this.tabOvais.Name = "tabOvais";
            this.tabOvais.Padding = new System.Windows.Forms.Padding(3);
            this.tabOvais.Size = new System.Drawing.Size(244, 508);
            this.tabOvais.TabIndex = 2;
            this.tabOvais.Text = "Ovais";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(728, 638);
            this.panel.TabIndex = 104;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // numTranslacaoX
            // 
            this.numTranslacaoX.Location = new System.Drawing.Point(7, 389);
            this.numTranslacaoX.Name = "numTranslacaoX";
            this.numTranslacaoX.Size = new System.Drawing.Size(54, 20);
            this.numTranslacaoX.TabIndex = 8;
            this.numTranslacaoX.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "X";
            // 
            // numEscalaX
            // 
            this.numEscalaX.DecimalPlaces = 2;
            this.numEscalaX.Location = new System.Drawing.Point(7, 429);
            this.numEscalaX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEscalaX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEscalaX.Name = "numEscalaX";
            this.numEscalaX.Size = new System.Drawing.Size(54, 20);
            this.numEscalaX.TabIndex = 13;
            this.numEscalaX.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "Escala";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bttAplicaEscala_Click);
            // 
            // numEscalaY
            // 
            this.numEscalaY.DecimalPlaces = 2;
            this.numEscalaY.Location = new System.Drawing.Point(67, 429);
            this.numEscalaY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEscalaY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEscalaY.Name = "numEscalaY";
            this.numEscalaY.Size = new System.Drawing.Size(54, 20);
            this.numEscalaY.TabIndex = 10;
            this.numEscalaY.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numRotacionar
            // 
            this.numRotacionar.Location = new System.Drawing.Point(7, 469);
            this.numRotacionar.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numRotacionar.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numRotacionar.Name = "numRotacionar";
            this.numRotacionar.Size = new System.Drawing.Size(114, 20);
            this.numRotacionar.TabIndex = 15;
            this.numRotacionar.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Graus";
            // 
            // bttRotacionar
            // 
            this.bttRotacionar.Location = new System.Drawing.Point(127, 467);
            this.bttRotacionar.Name = "bttRotacionar";
            this.bttRotacionar.Size = new System.Drawing.Size(109, 20);
            this.bttRotacionar.TabIndex = 17;
            this.bttRotacionar.Text = "Rotacionar";
            this.bttRotacionar.UseVisualStyleBackColor = true;
            this.bttRotacionar.Click += new System.EventHandler(this.bttRotacionar_Click);
            // 
            // comboBoxReflexao
            // 
            this.comboBoxReflexao.FormattingEnabled = true;
            this.comboBoxReflexao.Items.AddRange(new object[] {
            "Eixo X",
            "Eixo Y",
            "Ambos"});
            this.comboBoxReflexao.Location = new System.Drawing.Point(7, 496);
            this.comboBoxReflexao.Name = "comboBoxReflexao";
            this.comboBoxReflexao.Size = new System.Drawing.Size(114, 21);
            this.comboBoxReflexao.TabIndex = 18;
            // 
            // bttReflexao
            // 
            this.bttReflexao.Location = new System.Drawing.Point(127, 496);
            this.bttReflexao.Name = "bttReflexao";
            this.bttReflexao.Size = new System.Drawing.Size(109, 20);
            this.bttReflexao.TabIndex = 19;
            this.bttReflexao.Text = "Reflexão";
            this.bttReflexao.UseVisualStyleBackColor = true;
            this.bttReflexao.Click += new System.EventHandler(this.bttReflexao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "X";
            // 
            // numCisalhamentoX
            // 
            this.numCisalhamentoX.DecimalPlaces = 1;
            this.numCisalhamentoX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCisalhamentoX.Location = new System.Drawing.Point(7, 535);
            this.numCisalhamentoX.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCisalhamentoX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numCisalhamentoX.Name = "numCisalhamentoX";
            this.numCisalhamentoX.Size = new System.Drawing.Size(54, 20);
            this.numCisalhamentoX.TabIndex = 23;
            this.numCisalhamentoX.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Y";
            // 
            // bttCisalhamento
            // 
            this.bttCisalhamento.Location = new System.Drawing.Point(127, 535);
            this.bttCisalhamento.Name = "bttCisalhamento";
            this.bttCisalhamento.Size = new System.Drawing.Size(109, 20);
            this.bttCisalhamento.TabIndex = 21;
            this.bttCisalhamento.Text = "Cisalhamento";
            this.bttCisalhamento.UseVisualStyleBackColor = true;
            this.bttCisalhamento.Click += new System.EventHandler(this.bttCisalhamento_Click);
            // 
            // numCisalhamentoY
            // 
            this.numCisalhamentoY.DecimalPlaces = 1;
            this.numCisalhamentoY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCisalhamentoY.Location = new System.Drawing.Point(67, 535);
            this.numCisalhamentoY.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCisalhamentoY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numCisalhamentoY.Name = "numCisalhamentoY";
            this.numCisalhamentoY.Size = new System.Drawing.Size(54, 20);
            this.numCisalhamentoY.TabIndex = 20;
            this.numCisalhamentoY.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 638);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tabControlOpcoes);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.tabControlOpcoes.ResumeLayout(false);
            this.tabRetas.ResumeLayout(false);
            this.tabRetas.PerformLayout();
            this.tabPoligonos.ResumeLayout(false);
            this.tabPoligonos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslacaoY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslacaoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEscalaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEscalaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisalhamentoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisalhamentoY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControlOpcoes;
        private System.Windows.Forms.TabPage tabRetas;
        private System.Windows.Forms.TabPage tabPoligonos;
        private System.Windows.Forms.TabPage tabOvais;
        private System.Windows.Forms.RadioButton radioDDA;
        private System.Windows.Forms.RadioButton radioGeneralEquation;
        private System.Windows.Forms.RadioButton radioMidpoint;
        private System.Windows.Forms.Button buttonLimparImg;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListBox listBoxPoligonos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPontos;
        private System.Windows.Forms.Button bttAplicaTranslacao;
        private System.Windows.Forms.NumericUpDown numTranslacaoY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTranslacaoX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numEscalaX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numEscalaY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRotacionar;
        private System.Windows.Forms.Button bttRotacionar;
        private System.Windows.Forms.Button bttReflexao;
        private System.Windows.Forms.ComboBox comboBoxReflexao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCisalhamentoX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttCisalhamento;
        private System.Windows.Forms.NumericUpDown numCisalhamentoY;
    }
}
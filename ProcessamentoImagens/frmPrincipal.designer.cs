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
            this.pictBoxImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.comboBoxAlgoritmos = new System.Windows.Forms.ComboBox();
            this.buttonLimparImg = new System.Windows.Forms.Button();
            this.buttonAbrirImg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg)).BeginInit();
            this.panelOpcoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBoxImg
            // 
            this.pictBoxImg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBoxImg.Location = new System.Drawing.Point(0, 0);
            this.pictBoxImg.Name = "pictBoxImg";
            this.pictBoxImg.Size = new System.Drawing.Size(725, 509);
            this.pictBoxImg.TabIndex = 102;
            this.pictBoxImg.TabStop = false;
            this.pictBoxImg.Click += new System.EventHandler(this.pictBoxImg_Click);
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelOpcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpcoes.Controls.Add(this.label1);
            this.panelOpcoes.Controls.Add(this.comboBoxAlgoritmos);
            this.panelOpcoes.Controls.Add(this.buttonLimparImg);
            this.panelOpcoes.Controls.Add(this.buttonAbrirImg);
            this.panelOpcoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOpcoes.Location = new System.Drawing.Point(725, 0);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(255, 509);
            this.panelOpcoes.TabIndex = 103;
            // 
            // comboBoxAlgoritmos
            // 
            this.comboBoxAlgoritmos.FormattingEnabled = true;
            this.comboBoxAlgoritmos.Items.AddRange(new object[] {
            "DDA",
            "Equação geral da reta",
            "Ponto médio"});
            this.comboBoxAlgoritmos.Location = new System.Drawing.Point(75, 62);
            this.comboBoxAlgoritmos.Name = "comboBoxAlgoritmos";
            this.comboBoxAlgoritmos.Size = new System.Drawing.Size(159, 21);
            this.comboBoxAlgoritmos.TabIndex = 2;
            // 
            // buttonLimparImg
            // 
            this.buttonLimparImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLimparImg.Location = new System.Drawing.Point(19, 32);
            this.buttonLimparImg.Name = "buttonLimparImg";
            this.buttonLimparImg.Size = new System.Drawing.Size(215, 23);
            this.buttonLimparImg.TabIndex = 1;
            this.buttonLimparImg.Text = "Limpar Imagem";
            this.buttonLimparImg.UseVisualStyleBackColor = true;
            this.buttonLimparImg.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // buttonAbrirImg
            // 
            this.buttonAbrirImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAbrirImg.Location = new System.Drawing.Point(19, 3);
            this.buttonAbrirImg.Name = "buttonAbrirImg";
            this.buttonAbrirImg.Size = new System.Drawing.Size(215, 23);
            this.buttonAbrirImg.TabIndex = 0;
            this.buttonAbrirImg.Text = "Abrir imagem";
            this.buttonAbrirImg.UseVisualStyleBackColor = true;
            this.buttonAbrirImg.Click += new System.EventHandler(this.btnAbrirImg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pictBoxImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 509);
            this.panel1.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Algoritmo:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpcoes);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg)).EndInit();
            this.panelOpcoes.ResumeLayout(false);
            this.panelOpcoes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.Button buttonAbrirImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLimparImg;
        private System.Windows.Forms.ComboBox comboBoxAlgoritmos;
        private System.Windows.Forms.Label label1;
    }
}
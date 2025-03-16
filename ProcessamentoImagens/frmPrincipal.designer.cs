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
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAlgoritmos = new System.Windows.Forms.ComboBox();
            this.buttonLimparImg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelOpcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpcoes.Controls.Add(this.label1);
            this.panelOpcoes.Controls.Add(this.comboBoxAlgoritmos);
            this.panelOpcoes.Controls.Add(this.buttonLimparImg);
            this.panelOpcoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOpcoes.Location = new System.Drawing.Point(728, 0);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(252, 509);
            this.panelOpcoes.TabIndex = 103;
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
            this.buttonLimparImg.Location = new System.Drawing.Point(18, 32);
            this.buttonLimparImg.Name = "buttonLimparImg";
            this.buttonLimparImg.Size = new System.Drawing.Size(215, 23);
            this.buttonLimparImg.TabIndex = 1;
            this.buttonLimparImg.Text = "Limpar Imagem";
            this.buttonLimparImg.UseVisualStyleBackColor = true;
            this.buttonLimparImg.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 509);
            this.panel1.TabIndex = 104;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.panelOpcoes.ResumeLayout(false);
            this.panelOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLimparImg;
        private System.Windows.Forms.ComboBox comboBoxAlgoritmos;
        private System.Windows.Forms.Label label1;
    }
}
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
            this.listBoxPoligonos = new System.Windows.Forms.ListBox();
            this.tabOvais = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.tabControlOpcoes.SuspendLayout();
            this.tabRetas.SuspendLayout();
            this.tabPoligonos.SuspendLayout();
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
            this.tabControlOpcoes.Size = new System.Drawing.Size(252, 509);
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
            this.tabRetas.Size = new System.Drawing.Size(244, 483);
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
            this.tabPoligonos.Controls.Add(this.listBoxPoligonos);
            this.tabPoligonos.Location = new System.Drawing.Point(4, 22);
            this.tabPoligonos.Name = "tabPoligonos";
            this.tabPoligonos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoligonos.Size = new System.Drawing.Size(244, 483);
            this.tabPoligonos.TabIndex = 1;
            this.tabPoligonos.Text = "Polígonos";
            // 
            // listBoxPoligonos
            // 
            this.listBoxPoligonos.FormattingEnabled = true;
            this.listBoxPoligonos.Location = new System.Drawing.Point(6, 6);
            this.listBoxPoligonos.Name = "listBoxPoligonos";
            this.listBoxPoligonos.Size = new System.Drawing.Size(230, 160);
            this.listBoxPoligonos.TabIndex = 0;
            // 
            // tabOvais
            // 
            this.tabOvais.Location = new System.Drawing.Point(4, 22);
            this.tabOvais.Name = "tabOvais";
            this.tabOvais.Padding = new System.Windows.Forms.Padding(3);
            this.tabOvais.Size = new System.Drawing.Size(244, 483);
            this.tabOvais.TabIndex = 2;
            this.tabOvais.Text = "Ovais";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(728, 509);
            this.panel.TabIndex = 104;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 509);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tabControlOpcoes);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.tabControlOpcoes.ResumeLayout(false);
            this.tabRetas.ResumeLayout(false);
            this.tabRetas.PerformLayout();
            this.tabPoligonos.ResumeLayout(false);
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
    }
}
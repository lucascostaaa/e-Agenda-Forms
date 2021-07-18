
namespace e_agenda.WindowsApp.TelasCompromisso.CRUD
{
    partial class VisualizarCompromissos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarCompromissos));
            this.gpEagenda = new System.Windows.Forms.GroupBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.btCompromissosPasados = new System.Windows.Forms.Button();
            this.btPendente = new System.Windows.Forms.Button();
            this.gpEagenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEagenda
            // 
            this.gpEagenda.BackColor = System.Drawing.Color.Transparent;
            this.gpEagenda.Controls.Add(this.buttonVoltar);
            this.gpEagenda.Controls.Add(this.btCompromissosPasados);
            this.gpEagenda.Controls.Add(this.btPendente);
            this.gpEagenda.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEagenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpEagenda.Location = new System.Drawing.Point(12, 17);
            this.gpEagenda.Name = "gpEagenda";
            this.gpEagenda.Size = new System.Drawing.Size(777, 417);
            this.gpEagenda.TabIndex = 5;
            this.gpEagenda.TabStop = false;
            this.gpEagenda.Text = "E-Agenda";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Brown;
            this.buttonVoltar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVoltar.Location = new System.Drawing.Point(28, 301);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonVoltar.Size = new System.Drawing.Size(187, 93);
            this.buttonVoltar.TabIndex = 3;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // btCompromissosPasados
            // 
            this.btCompromissosPasados.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btCompromissosPasados.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompromissosPasados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCompromissosPasados.Location = new System.Drawing.Point(251, 114);
            this.btCompromissosPasados.Name = "btCompromissosPasados";
            this.btCompromissosPasados.Size = new System.Drawing.Size(280, 93);
            this.btCompromissosPasados.TabIndex = 0;
            this.btCompromissosPasados.Text = "Compromissos Passados";
            this.btCompromissosPasados.UseVisualStyleBackColor = false;
            this.btCompromissosPasados.Click += new System.EventHandler(this.btCompromissosPasados_Click);
            // 
            // btPendente
            // 
            this.btPendente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btPendente.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPendente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPendente.Location = new System.Drawing.Point(251, 232);
            this.btPendente.Name = "btPendente";
            this.btPendente.Size = new System.Drawing.Size(280, 93);
            this.btPendente.TabIndex = 1;
            this.btPendente.Text = "Compromissos Futuros";
            this.btPendente.UseVisualStyleBackColor = false;
            this.btPendente.Click += new System.EventHandler(this.btPendente_Click);
            // 
            // VisualizarCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpEagenda);
            this.MaximizeBox = false;
            this.Name = "VisualizarCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Compromissos";
            this.gpEagenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEagenda;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button btCompromissosPasados;
        private System.Windows.Forms.Button btPendente;
    }
}

namespace e_agenda.WindowsApp
{
    partial class Telaprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telaprincipal));
            this.btContato = new System.Windows.Forms.Button();
            this.btCompromisso = new System.Windows.Forms.Button();
            this.btTarefa = new System.Windows.Forms.Button();
            this.gpEagenda = new System.Windows.Forms.GroupBox();
            this.gpEagenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btContato
            // 
            this.btContato.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btContato.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btContato.Location = new System.Drawing.Point(251, 180);
            this.btContato.Name = "btContato";
            this.btContato.Size = new System.Drawing.Size(280, 93);
            this.btContato.TabIndex = 1;
            this.btContato.Text = "Contato";
            this.btContato.UseVisualStyleBackColor = false;
            this.btContato.Click += new System.EventHandler(this.btContato_Click);
            // 
            // btCompromisso
            // 
            this.btCompromisso.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btCompromisso.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompromisso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCompromisso.Location = new System.Drawing.Point(251, 301);
            this.btCompromisso.Name = "btCompromisso";
            this.btCompromisso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCompromisso.Size = new System.Drawing.Size(280, 93);
            this.btCompromisso.TabIndex = 2;
            this.btCompromisso.Text = "Compromisso";
            this.btCompromisso.UseVisualStyleBackColor = false;
            this.btCompromisso.Click += new System.EventHandler(this.btCompromisso_Click);
            // 
            // btTarefa
            // 
            this.btTarefa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btTarefa.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTarefa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTarefa.Location = new System.Drawing.Point(251, 59);
            this.btTarefa.Name = "btTarefa";
            this.btTarefa.Size = new System.Drawing.Size(280, 93);
            this.btTarefa.TabIndex = 0;
            this.btTarefa.Text = "Tarefa";
            this.btTarefa.UseVisualStyleBackColor = false;
            this.btTarefa.Click += new System.EventHandler(this.btTarefa_Click);
            // 
            // gpEagenda
            // 
            this.gpEagenda.BackColor = System.Drawing.Color.Transparent;
            this.gpEagenda.Controls.Add(this.btTarefa);
            this.gpEagenda.Controls.Add(this.btCompromisso);
            this.gpEagenda.Controls.Add(this.btContato);
            this.gpEagenda.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEagenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpEagenda.Location = new System.Drawing.Point(11, 12);
            this.gpEagenda.Name = "gpEagenda";
            this.gpEagenda.Size = new System.Drawing.Size(777, 417);
            this.gpEagenda.TabIndex = 3;
            this.gpEagenda.TabStop = false;
            this.gpEagenda.Text = "E-Agenda";
            this.gpEagenda.Enter += new System.EventHandler(this.gpEagenda_Enter);
            // 
            // Telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpEagenda);
            this.MaximizeBox = false;
            this.Name = "Telaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.gpEagenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btContato;
        private System.Windows.Forms.Button btCompromisso;
        private System.Windows.Forms.Button btTarefa;
        private System.Windows.Forms.GroupBox gpEagenda;
    }
}


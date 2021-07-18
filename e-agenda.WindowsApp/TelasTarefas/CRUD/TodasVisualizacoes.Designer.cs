
namespace e_agenda.WindowsApp.TelasTarefas.CRUD
{
    partial class TodasVisualizacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodasVisualizacoes));
            this.gpEagenda = new System.Windows.Forms.GroupBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.btVisualizartodos = new System.Windows.Forms.Button();
            this.btConcluido = new System.Windows.Forms.Button();
            this.btPendente = new System.Windows.Forms.Button();
            this.gpEagenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEagenda
            // 
            this.gpEagenda.BackColor = System.Drawing.Color.Transparent;
            this.gpEagenda.Controls.Add(this.buttonVoltar);
            this.gpEagenda.Controls.Add(this.btVisualizartodos);
            this.gpEagenda.Controls.Add(this.btConcluido);
            this.gpEagenda.Controls.Add(this.btPendente);
            this.gpEagenda.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEagenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpEagenda.Location = new System.Drawing.Point(12, 17);
            this.gpEagenda.Name = "gpEagenda";
            this.gpEagenda.Size = new System.Drawing.Size(777, 417);
            this.gpEagenda.TabIndex = 4;
            this.gpEagenda.TabStop = false;
            this.gpEagenda.Text = "E-Agenda";
            this.gpEagenda.Enter += new System.EventHandler(this.gpEagenda_Enter);
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
            // btVisualizartodos
            // 
            this.btVisualizartodos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btVisualizartodos.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualizartodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVisualizartodos.Location = new System.Drawing.Point(251, 59);
            this.btVisualizartodos.Name = "btVisualizartodos";
            this.btVisualizartodos.Size = new System.Drawing.Size(280, 93);
            this.btVisualizartodos.TabIndex = 0;
            this.btVisualizartodos.Text = "Visualizar Todos";
            this.btVisualizartodos.UseVisualStyleBackColor = false;
            this.btVisualizartodos.Click += new System.EventHandler(this.btVisualizartodos_Click);
            // 
            // btConcluido
            // 
            this.btConcluido.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btConcluido.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConcluido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btConcluido.Location = new System.Drawing.Point(251, 301);
            this.btConcluido.Name = "btConcluido";
            this.btConcluido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btConcluido.Size = new System.Drawing.Size(280, 93);
            this.btConcluido.TabIndex = 2;
            this.btConcluido.Text = "Visualizar Concluido";
            this.btConcluido.UseVisualStyleBackColor = false;
            this.btConcluido.Click += new System.EventHandler(this.btConcluido_Click);
            // 
            // btPendente
            // 
            this.btPendente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btPendente.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPendente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPendente.Location = new System.Drawing.Point(251, 180);
            this.btPendente.Name = "btPendente";
            this.btPendente.Size = new System.Drawing.Size(280, 93);
            this.btPendente.TabIndex = 1;
            this.btPendente.Text = "Visualizar Pendente";
            this.btPendente.UseVisualStyleBackColor = false;
            this.btPendente.Click += new System.EventHandler(this.btPendente_Click);
            // 
            // TodasVisualizacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpEagenda);
            this.MaximizeBox = false;
            this.Name = "TodasVisualizacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizacoes";
            this.gpEagenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEagenda;
        private System.Windows.Forms.Button btVisualizartodos;
        private System.Windows.Forms.Button btConcluido;
        private System.Windows.Forms.Button btPendente;
        private System.Windows.Forms.Button buttonVoltar;
    }
}
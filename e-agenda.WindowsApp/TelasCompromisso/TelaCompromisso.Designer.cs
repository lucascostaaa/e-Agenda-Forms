
namespace e_agenda.WindowsApp.TelasCompromisso
{
    partial class TelaCompromisso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCompromisso));
            this.gpEagenda = new System.Windows.Forms.GroupBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btVisualizar = new System.Windows.Forms.Button();
            this.gpEagenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEagenda
            // 
            this.gpEagenda.BackColor = System.Drawing.Color.Transparent;
            this.gpEagenda.Controls.Add(this.buttonVoltar);
            this.gpEagenda.Controls.Add(this.btExcluir);
            this.gpEagenda.Controls.Add(this.btCadastro);
            this.gpEagenda.Controls.Add(this.btEditar);
            this.gpEagenda.Controls.Add(this.btVisualizar);
            this.gpEagenda.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEagenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpEagenda.Location = new System.Drawing.Point(12, 6);
            this.gpEagenda.Name = "gpEagenda";
            this.gpEagenda.Size = new System.Drawing.Size(777, 438);
            this.gpEagenda.TabIndex = 6;
            this.gpEagenda.TabStop = false;
            this.gpEagenda.Text = "Escolha uma Opção";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Brown;
            this.buttonVoltar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVoltar.Location = new System.Drawing.Point(6, 320);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonVoltar.Size = new System.Drawing.Size(244, 65);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btExcluir.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExcluir.Location = new System.Drawing.Point(273, 320);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btExcluir.Size = new System.Drawing.Size(244, 65);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btCadastro.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastro.Location = new System.Drawing.Point(273, 76);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(244, 65);
            this.btCadastro.TabIndex = 0;
            this.btCadastro.Text = "Cadastrar";
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btEditar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEditar.Location = new System.Drawing.Point(273, 240);
            this.btEditar.Name = "btEditar";
            this.btEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btEditar.Size = new System.Drawing.Size(244, 65);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btVisualizar
            // 
            this.btVisualizar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btVisualizar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVisualizar.Location = new System.Drawing.Point(273, 162);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(244, 65);
            this.btVisualizar.TabIndex = 1;
            this.btVisualizar.Text = "Visualizar";
            this.btVisualizar.UseVisualStyleBackColor = false;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // TelaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpEagenda);
            this.MaximizeBox = false;
            this.Name = "TelaCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Compromissos";
            this.gpEagenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEagenda;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btVisualizar;
    }
}
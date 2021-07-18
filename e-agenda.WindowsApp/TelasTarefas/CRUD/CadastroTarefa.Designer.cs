
namespace e_agenda.WindowsApp
{
    partial class CadastroTarefa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbPrioridade = new System.Windows.Forms.Label();
            this.TbTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.buttonVoltar);
            this.groupBox1.Controls.Add(this.comboBoxPrioridade);
            this.groupBox1.Controls.Add(this.btCadastrar);
            this.groupBox1.Controls.Add(this.lbPrioridade);
            this.groupBox1.Controls.Add(this.TbTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Tarefa";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(386, 247);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(208, 54);
            this.buttonVoltar.TabIndex = 10;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(328, 174);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(305, 40);
            this.comboBoxPrioridade.TabIndex = 9;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(172, 247);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(208, 54);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbPrioridade
            // 
            this.lbPrioridade.AutoSize = true;
            this.lbPrioridade.BackColor = System.Drawing.Color.Transparent;
            this.lbPrioridade.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrioridade.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbPrioridade.Location = new System.Drawing.Point(166, 174);
            this.lbPrioridade.Name = "lbPrioridade";
            this.lbPrioridade.Size = new System.Drawing.Size(156, 35);
            this.lbPrioridade.TabIndex = 4;
            this.lbPrioridade.Text = "Prioridade:";
            // 
            // TbTitulo
            // 
            this.TbTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTitulo.Location = new System.Drawing.Point(328, 120);
            this.TbTitulo.Multiline = true;
            this.TbTitulo.Name = "TbTitulo";
            this.TbTitulo.Size = new System.Drawing.Size(305, 35);
            this.TbTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(166, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // CadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CadastroTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrioridade;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Button buttonVoltar;
    }
}
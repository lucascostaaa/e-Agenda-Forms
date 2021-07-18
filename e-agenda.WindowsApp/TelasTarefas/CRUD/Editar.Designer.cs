
namespace e_agenda.WindowsApp.TelasTarefas.CRUD
{
    partial class Editar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxEditar = new System.Windows.Forms.GroupBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.textBoxPercentualEditar = new System.Windows.Forms.TextBox();
            this.labelPercentual = new System.Windows.Forms.Label();
            this.textBoxTituloEditar = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxIdEditar = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridViewEditar = new System.Windows.Forms.DataGridView();
            this.groupBoxEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEditar
            // 
            this.groupBoxEditar.BackColor = System.Drawing.Color.Silver;
            this.groupBoxEditar.Controls.Add(this.buttonEditar);
            this.groupBoxEditar.Controls.Add(this.buttonVoltar);
            this.groupBoxEditar.Controls.Add(this.comboBoxPrioridade);
            this.groupBoxEditar.Controls.Add(this.labelPrioridade);
            this.groupBoxEditar.Controls.Add(this.textBoxPercentualEditar);
            this.groupBoxEditar.Controls.Add(this.labelPercentual);
            this.groupBoxEditar.Controls.Add(this.textBoxTituloEditar);
            this.groupBoxEditar.Controls.Add(this.labelTitulo);
            this.groupBoxEditar.Controls.Add(this.textBoxIdEditar);
            this.groupBoxEditar.Controls.Add(this.labelID);
            this.groupBoxEditar.Controls.Add(this.dataGridViewEditar);
            this.groupBoxEditar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxEditar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEditar.Name = "groupBoxEditar";
            this.groupBoxEditar.Size = new System.Drawing.Size(776, 426);
            this.groupBoxEditar.TabIndex = 0;
            this.groupBoxEditar.TabStop = false;
            this.groupBoxEditar.Text = "Editar";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(538, 293);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(152, 41);
            this.buttonEditar.TabIndex = 12;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Brown;
            this.buttonVoltar.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.Color.Azure;
            this.buttonVoltar.Location = new System.Drawing.Point(538, 357);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(152, 40);
            this.buttonVoltar.TabIndex = 11;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
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
            this.comboBoxPrioridade.Location = new System.Drawing.Point(129, 357);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(317, 40);
            this.comboBoxPrioridade.TabIndex = 10;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioridade.Location = new System.Drawing.Point(14, 364);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(106, 23);
            this.labelPrioridade.TabIndex = 7;
            this.labelPrioridade.Text = "Prioridade:";
            // 
            // textBoxPercentualEditar
            // 
            this.textBoxPercentualEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPercentualEditar.Location = new System.Drawing.Point(129, 328);
            this.textBoxPercentualEditar.Multiline = true;
            this.textBoxPercentualEditar.Name = "textBoxPercentualEditar";
            this.textBoxPercentualEditar.Size = new System.Drawing.Size(317, 23);
            this.textBoxPercentualEditar.TabIndex = 6;
            // 
            // labelPercentual
            // 
            this.labelPercentual.AutoSize = true;
            this.labelPercentual.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentual.Location = new System.Drawing.Point(14, 328);
            this.labelPercentual.Name = "labelPercentual";
            this.labelPercentual.Size = new System.Drawing.Size(109, 23);
            this.labelPercentual.TabIndex = 5;
            this.labelPercentual.Text = "Percentual:";
            // 
            // textBoxTituloEditar
            // 
            this.textBoxTituloEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloEditar.Location = new System.Drawing.Point(82, 293);
            this.textBoxTituloEditar.Multiline = true;
            this.textBoxTituloEditar.Name = "textBoxTituloEditar";
            this.textBoxTituloEditar.Size = new System.Drawing.Size(364, 23);
            this.textBoxTituloEditar.TabIndex = 4;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(14, 293);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(62, 23);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Titulo:";
            // 
            // textBoxIdEditar
            // 
            this.textBoxIdEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdEditar.Location = new System.Drawing.Point(404, 254);
            this.textBoxIdEditar.Multiline = true;
            this.textBoxIdEditar.Name = "textBoxIdEditar";
            this.textBoxIdEditar.Size = new System.Drawing.Size(42, 23);
            this.textBoxIdEditar.TabIndex = 2;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(14, 254);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(384, 23);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Digite o Id que da tarefa que deseja Editar";
            // 
            // dataGridViewEditar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEditar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEditar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEditar.Location = new System.Drawing.Point(18, 50);
            this.dataGridViewEditar.Name = "dataGridViewEditar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEditar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEditar.Size = new System.Drawing.Size(741, 187);
            this.dataGridViewEditar.TabIndex = 0;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxEditar);
            this.MaximizeBox = false;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Tarefa";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.groupBoxEditar.ResumeLayout(false);
            this.groupBoxEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditar;
        private System.Windows.Forms.DataGridView dataGridViewEditar;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.TextBox textBoxPercentualEditar;
        private System.Windows.Forms.Label labelPercentual;
        private System.Windows.Forms.TextBox textBoxTituloEditar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxIdEditar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
    }
}

namespace e_agenda.WindowsApp.TelasCompromisso.CRUD
{
    partial class ExcluirCompromisso
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
            this.groupBoxExcluir = new System.Windows.Forms.GroupBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxIDExcluir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewExcluir = new System.Windows.Forms.DataGridView();
            this.groupBoxExcluir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxExcluir
            // 
            this.groupBoxExcluir.BackColor = System.Drawing.Color.Silver;
            this.groupBoxExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxExcluir.Controls.Add(this.buttonVoltar);
            this.groupBoxExcluir.Controls.Add(this.buttonExcluir);
            this.groupBoxExcluir.Controls.Add(this.textBoxIDExcluir);
            this.groupBoxExcluir.Controls.Add(this.label1);
            this.groupBoxExcluir.Controls.Add(this.dataGridViewExcluir);
            this.groupBoxExcluir.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExcluir.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxExcluir.Location = new System.Drawing.Point(12, 12);
            this.groupBoxExcluir.Name = "groupBoxExcluir";
            this.groupBoxExcluir.Size = new System.Drawing.Size(776, 426);
            this.groupBoxExcluir.TabIndex = 2;
            this.groupBoxExcluir.TabStop = false;
            this.groupBoxExcluir.Text = "Excluir Compromisso";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Maroon;
            this.buttonVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonVoltar.Location = new System.Drawing.Point(16, 358);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(153, 51);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(304, 358);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(153, 51);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxIDExcluir
            // 
            this.textBoxIDExcluir.Location = new System.Drawing.Point(670, 296);
            this.textBoxIDExcluir.Multiline = true;
            this.textBoxIDExcluir.Name = "textBoxIDExcluir";
            this.textBoxIDExcluir.Size = new System.Drawing.Size(100, 41);
            this.textBoxIDExcluir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o ID do Compromisso que deseja Excluir:";
            // 
            // dataGridViewExcluir
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExcluir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExcluir.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExcluir.Location = new System.Drawing.Point(6, 50);
            this.dataGridViewExcluir.Name = "dataGridViewExcluir";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExcluir.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewExcluir.Size = new System.Drawing.Size(764, 215);
            this.dataGridViewExcluir.TabIndex = 0;
            // 
            // ExcluirCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxExcluir);
            this.MaximizeBox = false;
            this.Name = "ExcluirCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exluir Compromisso";
            this.Load += new System.EventHandler(this.ExcluirCompromisso_Load);
            this.groupBoxExcluir.ResumeLayout(false);
            this.groupBoxExcluir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcluir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxExcluir;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxIDExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewExcluir;
    }
}
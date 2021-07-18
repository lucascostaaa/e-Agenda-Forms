
namespace e_agenda.WindowsApp.TelasCompromisso.CRUD
{
    partial class CompromissosFuturos
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
            this.groupBoxCompromissosFurutos = new System.Windows.Forms.GroupBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.dataGridViewCompromissosFuturos = new System.Windows.Forms.DataGridView();
            this.groupBoxCompromissosFurutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromissosFuturos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCompromissosFurutos
            // 
            this.groupBoxCompromissosFurutos.Controls.Add(this.buttonVoltar);
            this.groupBoxCompromissosFurutos.Controls.Add(this.dataGridViewCompromissosFuturos);
            this.groupBoxCompromissosFurutos.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCompromissosFurutos.Location = new System.Drawing.Point(12, 17);
            this.groupBoxCompromissosFurutos.Name = "groupBoxCompromissosFurutos";
            this.groupBoxCompromissosFurutos.Size = new System.Drawing.Size(776, 417);
            this.groupBoxCompromissosFurutos.TabIndex = 1;
            this.groupBoxCompromissosFurutos.TabStop = false;
            this.groupBoxCompromissosFurutos.Text = "Compromissos Futuros";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Maroon;
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVoltar.Location = new System.Drawing.Point(20, 339);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(212, 58);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // dataGridViewCompromissosFuturos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompromissosFuturos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCompromissosFuturos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCompromissosFuturos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCompromissosFuturos.Location = new System.Drawing.Point(20, 49);
            this.dataGridViewCompromissosFuturos.Name = "dataGridViewCompromissosFuturos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompromissosFuturos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCompromissosFuturos.Size = new System.Drawing.Size(735, 249);
            this.dataGridViewCompromissosFuturos.TabIndex = 0;
            // 
            // CompromissosFuturos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCompromissosFurutos);
            this.MaximizeBox = false;
            this.Name = "CompromissosFuturos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compromissos Futuros";
            this.Load += new System.EventHandler(this.CompromissosFuturos_Load);
            this.groupBoxCompromissosFurutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromissosFuturos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCompromissosFurutos;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.DataGridView dataGridViewCompromissosFuturos;
    }
}
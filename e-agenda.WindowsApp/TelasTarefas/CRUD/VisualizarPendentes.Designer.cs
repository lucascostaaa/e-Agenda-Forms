
namespace e_agenda.WindowsApp.TelasTarefas.CRUD
{
    partial class VisualizarPendentes
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
            this.gpEagenda = new System.Windows.Forms.GroupBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.dataGridPendentes = new System.Windows.Forms.DataGridView();
            this.gpEagenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpEagenda
            // 
            this.gpEagenda.BackColor = System.Drawing.Color.Transparent;
            this.gpEagenda.Controls.Add(this.buttonVoltar);
            this.gpEagenda.Controls.Add(this.dataGridPendentes);
            this.gpEagenda.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEagenda.ForeColor = System.Drawing.Color.SteelBlue;
            this.gpEagenda.Location = new System.Drawing.Point(12, 17);
            this.gpEagenda.Name = "gpEagenda";
            this.gpEagenda.Size = new System.Drawing.Size(777, 417);
            this.gpEagenda.TabIndex = 6;
            this.gpEagenda.TabStop = false;
            this.gpEagenda.Text = "Visualizar Tarefas Pendentes";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Brown;
            this.buttonVoltar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVoltar.Location = new System.Drawing.Point(25, 353);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonVoltar.Size = new System.Drawing.Size(224, 58);
            this.buttonVoltar.TabIndex = 5;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // dataGridPendentes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPendentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPendentes.Location = new System.Drawing.Point(25, 59);
            this.dataGridPendentes.Name = "dataGridPendentes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPendentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPendentes.Size = new System.Drawing.Size(729, 262);
            this.dataGridPendentes.TabIndex = 0;
            // 
            // VisualizarPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpEagenda);
            this.MaximizeBox = false;
            this.Name = "VisualizarPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VisualizarPendentes_Load);
            this.gpEagenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEagenda;
        private System.Windows.Forms.DataGridView dataGridPendentes;
        private System.Windows.Forms.Button buttonVoltar;
    }
}

namespace Kucni_budzet_VS
{
    partial class Administrator_transakcije
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
            this.grid_promet = new System.Windows.Forms.DataGridView();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_vreme = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_promet)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_promet
            // 
            this.grid_promet.AllowUserToAddRows = false;
            this.grid_promet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_promet.Location = new System.Drawing.Point(12, 362);
            this.grid_promet.Name = "grid_promet";
            this.grid_promet.RowHeadersWidth = 51;
            this.grid_promet.RowTemplate.Height = 24;
            this.grid_promet.Size = new System.Drawing.Size(1237, 348);
            this.grid_promet.TabIndex = 0;
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(96, 30);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(54, 17);
            this.lbl_datum.TabIndex = 1;
            this.lbl_datum.Text = "Датум:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbl_vreme
            // 
            this.lbl_vreme.AutoSize = true;
            this.lbl_vreme.Location = new System.Drawing.Point(338, 30);
            this.lbl_vreme.Name = "lbl_vreme";
            this.lbl_vreme.Size = new System.Drawing.Size(54, 17);
            this.lbl_vreme.TabIndex = 3;
            this.lbl_vreme.Text = "Време:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Administrator_transakcije
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1261, 722);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_vreme);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.grid_promet);
            this.Name = "Administrator_transakcije";
            this.Text = "Администратор - трансакције";
            this.Load += new System.EventHandler(this.Administrator_transakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_promet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_promet;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_vreme;
        private System.Windows.Forms.TextBox textBox1;
    }
}
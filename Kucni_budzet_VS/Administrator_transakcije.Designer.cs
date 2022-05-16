
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
            this.grid_promet.Size = new System.Drawing.Size(1433, 348);
            this.grid_promet.TabIndex = 0;
            // 
            // Administrator_transakcije
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1457, 722);
            this.Controls.Add(this.grid_promet);
            this.Name = "Administrator_transakcije";
            this.Text = "Администратор - трансакције";
            this.Load += new System.EventHandler(this.Administrator_transakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_promet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_promet;
    }
}
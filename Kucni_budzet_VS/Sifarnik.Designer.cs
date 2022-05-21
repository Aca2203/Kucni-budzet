
namespace Kucni_budzet_VS
{
    partial class Sifarnik
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
            this.grid_podaci = new System.Windows.Forms.DataGridView();
            this.btn_izmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_podaci)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_podaci
            // 
            this.grid_podaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_podaci.Location = new System.Drawing.Point(12, 12);
            this.grid_podaci.Name = "grid_podaci";
            this.grid_podaci.Size = new System.Drawing.Size(310, 189);
            this.grid_podaci.TabIndex = 0;
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(58, 250);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(219, 52);
            this.btn_izmeni.TabIndex = 13;
            this.btn_izmeni.Text = "Измени податке";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // Sifarnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 342);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.grid_podaci);
            this.Name = "Sifarnik";
            this.Load += new System.EventHandler(this.Sifarnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_podaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_podaci;
        private System.Windows.Forms.Button btn_izmeni;
    }
}
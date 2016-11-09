namespace magasin
{
    partial class frmPanier
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
            this.lsbListPanier = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbListPanier
            // 
            this.lsbListPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbListPanier.FormattingEnabled = true;
            this.lsbListPanier.ItemHeight = 20;
            this.lsbListPanier.Location = new System.Drawing.Point(12, 12);
            this.lsbListPanier.Name = "lsbListPanier";
            this.lsbListPanier.Size = new System.Drawing.Size(274, 164);
            this.lsbListPanier.TabIndex = 0;
            // 
            // frmPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 255);
            this.Controls.Add(this.lsbListPanier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPanier";
            this.Text = "frmPanier";
            this.Load += new System.EventHandler(this.frmPanier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbListPanier;
    }
}
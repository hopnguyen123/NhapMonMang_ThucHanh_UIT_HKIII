
namespace Lab02_19521555_NguyenNgocHop
{
    partial class Lab02_Bai03_19521555
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
            this.btnEnTer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnTer
            // 
            this.btnEnTer.Location = new System.Drawing.Point(68, 103);
            this.btnEnTer.Name = "btnEnTer";
            this.btnEnTer.Size = new System.Drawing.Size(250, 117);
            this.btnEnTer.TabIndex = 0;
            this.btnEnTer.Text = "EnTer";
            this.btnEnTer.UseVisualStyleBackColor = true;
            this.btnEnTer.Click += new System.EventHandler(this.btnEnTer_Click);
            // 
            // Lab02_Bai03_19521555
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnTer);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Lab02_Bai03_19521555";
            this.Text = "Lab02_Bai03_19521555";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnTer;
    }
}
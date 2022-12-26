namespace VTYS
{
    partial class AnaForm
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
            this.lblHg = new System.Windows.Forms.Label();
            this.btnBireysel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHg
            // 
            this.lblHg.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblHg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHg.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHg.Location = new System.Drawing.Point(148, 10);
            this.lblHg.Margin = new System.Windows.Forms.Padding(1);
            this.lblHg.Name = "lblHg";
            this.lblHg.Size = new System.Drawing.Size(518, 97);
            this.lblHg.TabIndex = 0;
            this.lblHg.Text = "HOŞGELDİNİZ\r\n";
            this.lblHg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHg.Click += new System.EventHandler(this.lblHg_Click);
            // 
            // btnBireysel
            // 
            this.btnBireysel.BackColor = System.Drawing.Color.OldLace;
            this.btnBireysel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBireysel.Location = new System.Drawing.Point(249, 174);
            this.btnBireysel.Name = "btnBireysel";
            this.btnBireysel.Size = new System.Drawing.Size(343, 126);
            this.btnBireysel.TabIndex = 1;
            this.btnBireysel.Text = "Bireysel İşlemler";
            this.btnBireysel.UseVisualStyleBackColor = false;
            this.btnBireysel.Click += new System.EventHandler(this.btnBireysel_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(843, 415);
            this.Controls.Add(this.btnBireysel);
            this.Controls.Add(this.lblHg);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTYS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHg;
        private System.Windows.Forms.Button btnBireysel;
    }
}


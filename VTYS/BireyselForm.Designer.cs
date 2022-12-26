
namespace VTYS
{
    partial class BireyselForm
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
            this.btnBiletAlBireysel = new System.Windows.Forms.Button();
            this.btnSeyahatlerim = new System.Windows.Forms.Button();
            this.GrpBoxSeyahatlerim = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnacik = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.GrpBoxSeyahatlerim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBiletAlBireysel
            // 
            this.btnBiletAlBireysel.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBiletAlBireysel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiletAlBireysel.Location = new System.Drawing.Point(43, 116);
            this.btnBiletAlBireysel.Name = "btnBiletAlBireysel";
            this.btnBiletAlBireysel.Size = new System.Drawing.Size(267, 122);
            this.btnBiletAlBireysel.TabIndex = 0;
            this.btnBiletAlBireysel.Text = "Bilet Al";
            this.btnBiletAlBireysel.UseVisualStyleBackColor = false;
            this.btnBiletAlBireysel.Click += new System.EventHandler(this.btnBiletAlBireysel_Click);
            // 
            // btnSeyahatlerim
            // 
            this.btnSeyahatlerim.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSeyahatlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeyahatlerim.Location = new System.Drawing.Point(765, 116);
            this.btnSeyahatlerim.Name = "btnSeyahatlerim";
            this.btnSeyahatlerim.Size = new System.Drawing.Size(267, 122);
            this.btnSeyahatlerim.TabIndex = 0;
            this.btnSeyahatlerim.Text = "Seyahatlerim";
            this.btnSeyahatlerim.UseVisualStyleBackColor = false;
            this.btnSeyahatlerim.Click += new System.EventHandler(this.btnSeyahatlerim_Click);
            // 
            // GrpBoxSeyahatlerim
            // 
            this.GrpBoxSeyahatlerim.Controls.Add(this.dataGridView1);
            this.GrpBoxSeyahatlerim.Location = new System.Drawing.Point(43, 244);
            this.GrpBoxSeyahatlerim.Name = "GrpBoxSeyahatlerim";
            this.GrpBoxSeyahatlerim.Size = new System.Drawing.Size(989, 322);
            this.GrpBoxSeyahatlerim.TabIndex = 1;
            this.GrpBoxSeyahatlerim.TabStop = false;
            this.GrpBoxSeyahatlerim.Visible = false;
            this.GrpBoxSeyahatlerim.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnacik
            // 
            this.btnacik.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnacik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacik.Location = new System.Drawing.Point(328, 174);
            this.btnacik.Name = "btnacik";
            this.btnacik.Size = new System.Drawing.Size(196, 64);
            this.btnacik.TabIndex = 0;
            this.btnacik.Text = "Biletimi Açığa Al";
            this.btnacik.UseVisualStyleBackColor = false;
            this.btnacik.Click += new System.EventHandler(this.btnacik_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.LavenderBlush;
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniptal.Location = new System.Drawing.Point(554, 174);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(196, 64);
            this.btniptal.TabIndex = 0;
            this.btniptal.Text = "Biletimi İptal Et";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // BireyselForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1066, 586);
            this.Controls.Add(this.GrpBoxSeyahatlerim);
            this.Controls.Add(this.btnSeyahatlerim);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnacik);
            this.Controls.Add(this.btnBiletAlBireysel);
            this.Name = "BireyselForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BireyselForm";
            this.Load += new System.EventHandler(this.BireyselForm_Load);
            this.GrpBoxSeyahatlerim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBiletAlBireysel;
        private System.Windows.Forms.Button btnSeyahatlerim;
        private System.Windows.Forms.GroupBox GrpBoxSeyahatlerim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnacik;
        private System.Windows.Forms.Button btniptal;
    }
}
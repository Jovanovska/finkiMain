namespace finkiMain
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kopce1 = new Main.Kopce();
            this.btnStart = new Main.Kopce();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::finkiMain.Properties.Resources.finkiman;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kopce1
            // 
            this.kopce1.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kopce1.ForeColor = System.Drawing.Color.Gainsboro;
            this.kopce1.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kopce1.GradientTop = System.Drawing.Color.DarkOrange;
            this.kopce1.Location = new System.Drawing.Point(223, 458);
            this.kopce1.Name = "kopce1";
            this.kopce1.Size = new System.Drawing.Size(126, 57);
            this.kopce1.TabIndex = 2;
            this.kopce1.Text = "E x i t";
            this.kopce1.UseVisualStyleBackColor = true;
            this.kopce1.Click += new System.EventHandler(this.kopce1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStart.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.GradientTop = System.Drawing.Color.DarkOrange;
            this.btnStart.Location = new System.Drawing.Point(223, 271);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 57);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "S t a r t";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.Controls.Add(this.kopce1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Main.Kopce btnStart;
        private Main.Kopce kopce1;
    }
}


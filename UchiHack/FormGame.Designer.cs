namespace UchiHack
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.picGame = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRed4 = new System.Windows.Forms.RadioButton();
            this.rbRed3 = new System.Windows.Forms.RadioButton();
            this.rbRed2 = new System.Windows.Forms.RadioButton();
            this.rbRed1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBlue4 = new System.Windows.Forms.RadioButton();
            this.rbBlue3 = new System.Windows.Forms.RadioButton();
            this.rbBlue2 = new System.Windows.Forms.RadioButton();
            this.rbBlue1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbGreen4 = new System.Windows.Forms.RadioButton();
            this.rbGreen3 = new System.Windows.Forms.RadioButton();
            this.rbGreen2 = new System.Windows.Forms.RadioButton();
            this.rbGreen1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbRose4 = new System.Windows.Forms.RadioButton();
            this.rbRose3 = new System.Windows.Forms.RadioButton();
            this.rbRose2 = new System.Windows.Forms.RadioButton();
            this.rbRose1 = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.picGame);
            this.groupBox1.Location = new System.Drawing.Point(8, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 360);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Карта игры";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(6, 326);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(79, 29);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // picGame
            // 
            this.picGame.Location = new System.Drawing.Point(6, 19);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(680, 300);
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRed4);
            this.groupBox2.Controls.Add(this.rbRed3);
            this.groupBox2.Controls.Add(this.rbRed2);
            this.groupBox2.Controls.Add(this.rbRed1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(8, 507);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 131);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Красные";
            // 
            // rbRed4
            // 
            this.rbRed4.AutoSize = true;
            this.rbRed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRed4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbRed4.Location = new System.Drawing.Point(10, 110);
            this.rbRed4.Name = "rbRed4";
            this.rbRed4.Size = new System.Drawing.Size(14, 13);
            this.rbRed4.TabIndex = 3;
            this.rbRed4.UseVisualStyleBackColor = true;
            // 
            // rbRed3
            // 
            this.rbRed3.AutoSize = true;
            this.rbRed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRed3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbRed3.Location = new System.Drawing.Point(10, 85);
            this.rbRed3.Name = "rbRed3";
            this.rbRed3.Size = new System.Drawing.Size(14, 13);
            this.rbRed3.TabIndex = 2;
            this.rbRed3.UseVisualStyleBackColor = true;
            // 
            // rbRed2
            // 
            this.rbRed2.AutoSize = true;
            this.rbRed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRed2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbRed2.Location = new System.Drawing.Point(10, 57);
            this.rbRed2.Name = "rbRed2";
            this.rbRed2.Size = new System.Drawing.Size(14, 13);
            this.rbRed2.TabIndex = 1;
            this.rbRed2.UseVisualStyleBackColor = true;
            // 
            // rbRed1
            // 
            this.rbRed1.AutoSize = true;
            this.rbRed1.Checked = true;
            this.rbRed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRed1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbRed1.Location = new System.Drawing.Point(10, 31);
            this.rbRed1.Name = "rbRed1";
            this.rbRed1.Size = new System.Drawing.Size(14, 13);
            this.rbRed1.TabIndex = 0;
            this.rbRed1.TabStop = true;
            this.rbRed1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBlue4);
            this.groupBox3.Controls.Add(this.rbBlue3);
            this.groupBox3.Controls.Add(this.rbBlue2);
            this.groupBox3.Controls.Add(this.rbBlue1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Location = new System.Drawing.Point(198, 507);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 131);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Синие";
            // 
            // rbBlue4
            // 
            this.rbBlue4.AutoSize = true;
            this.rbBlue4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBlue4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbBlue4.Location = new System.Drawing.Point(10, 110);
            this.rbBlue4.Name = "rbBlue4";
            this.rbBlue4.Size = new System.Drawing.Size(14, 13);
            this.rbBlue4.TabIndex = 3;
            this.rbBlue4.UseVisualStyleBackColor = true;
            // 
            // rbBlue3
            // 
            this.rbBlue3.AutoSize = true;
            this.rbBlue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBlue3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbBlue3.Location = new System.Drawing.Point(10, 85);
            this.rbBlue3.Name = "rbBlue3";
            this.rbBlue3.Size = new System.Drawing.Size(14, 13);
            this.rbBlue3.TabIndex = 2;
            this.rbBlue3.UseVisualStyleBackColor = true;
            // 
            // rbBlue2
            // 
            this.rbBlue2.AutoSize = true;
            this.rbBlue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBlue2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbBlue2.Location = new System.Drawing.Point(10, 57);
            this.rbBlue2.Name = "rbBlue2";
            this.rbBlue2.Size = new System.Drawing.Size(14, 13);
            this.rbBlue2.TabIndex = 1;
            this.rbBlue2.UseVisualStyleBackColor = true;
            // 
            // rbBlue1
            // 
            this.rbBlue1.AutoSize = true;
            this.rbBlue1.Checked = true;
            this.rbBlue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBlue1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbBlue1.Location = new System.Drawing.Point(10, 31);
            this.rbBlue1.Name = "rbBlue1";
            this.rbBlue1.Size = new System.Drawing.Size(14, 13);
            this.rbBlue1.TabIndex = 0;
            this.rbBlue1.TabStop = true;
            this.rbBlue1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbGreen4);
            this.groupBox4.Controls.Add(this.rbGreen3);
            this.groupBox4.Controls.Add(this.rbGreen2);
            this.groupBox4.Controls.Add(this.rbGreen1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox4.Location = new System.Drawing.Point(382, 507);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 131);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Зеленые";
            // 
            // rbGreen4
            // 
            this.rbGreen4.AutoSize = true;
            this.rbGreen4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGreen4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbGreen4.Location = new System.Drawing.Point(10, 110);
            this.rbGreen4.Name = "rbGreen4";
            this.rbGreen4.Size = new System.Drawing.Size(14, 13);
            this.rbGreen4.TabIndex = 3;
            this.rbGreen4.UseVisualStyleBackColor = true;
            // 
            // rbGreen3
            // 
            this.rbGreen3.AutoSize = true;
            this.rbGreen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGreen3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbGreen3.Location = new System.Drawing.Point(10, 85);
            this.rbGreen3.Name = "rbGreen3";
            this.rbGreen3.Size = new System.Drawing.Size(14, 13);
            this.rbGreen3.TabIndex = 2;
            this.rbGreen3.UseVisualStyleBackColor = true;
            // 
            // rbGreen2
            // 
            this.rbGreen2.AutoSize = true;
            this.rbGreen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGreen2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbGreen2.Location = new System.Drawing.Point(10, 57);
            this.rbGreen2.Name = "rbGreen2";
            this.rbGreen2.Size = new System.Drawing.Size(14, 13);
            this.rbGreen2.TabIndex = 1;
            this.rbGreen2.UseVisualStyleBackColor = true;
            // 
            // rbGreen1
            // 
            this.rbGreen1.AutoSize = true;
            this.rbGreen1.Checked = true;
            this.rbGreen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGreen1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbGreen1.Location = new System.Drawing.Point(10, 31);
            this.rbGreen1.Name = "rbGreen1";
            this.rbGreen1.Size = new System.Drawing.Size(14, 13);
            this.rbGreen1.TabIndex = 0;
            this.rbGreen1.TabStop = true;
            this.rbGreen1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbRose4);
            this.groupBox5.Controls.Add(this.rbRose3);
            this.groupBox5.Controls.Add(this.rbRose2);
            this.groupBox5.Controls.Add(this.rbRose1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.Color.Purple;
            this.groupBox5.Location = new System.Drawing.Point(561, 507);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 131);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Пурпурные";
            // 
            // rbRose4
            // 
            this.rbRose4.AutoSize = true;
            this.rbRose4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRose4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbRose4.Location = new System.Drawing.Point(10, 110);
            this.rbRose4.Name = "rbRose4";
            this.rbRose4.Size = new System.Drawing.Size(14, 13);
            this.rbRose4.TabIndex = 3;
            this.rbRose4.UseVisualStyleBackColor = true;
            // 
            // rbRose3
            // 
            this.rbRose3.AutoSize = true;
            this.rbRose3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRose3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbRose3.Location = new System.Drawing.Point(10, 85);
            this.rbRose3.Name = "rbRose3";
            this.rbRose3.Size = new System.Drawing.Size(14, 13);
            this.rbRose3.TabIndex = 2;
            this.rbRose3.UseVisualStyleBackColor = true;
            // 
            // rbRose2
            // 
            this.rbRose2.AutoSize = true;
            this.rbRose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRose2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbRose2.Location = new System.Drawing.Point(10, 57);
            this.rbRose2.Name = "rbRose2";
            this.rbRose2.Size = new System.Drawing.Size(14, 13);
            this.rbRose2.TabIndex = 1;
            this.rbRose2.UseVisualStyleBackColor = true;
            // 
            // rbRose1
            // 
            this.rbRose1.AutoSize = true;
            this.rbRose1.Checked = true;
            this.rbRose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRose1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbRose1.Location = new System.Drawing.Point(10, 31);
            this.rbRose1.Name = "rbRose1";
            this.rbRose1.Size = new System.Drawing.Size(14, 13);
            this.rbRose1.TabIndex = 0;
            this.rbRose1.TabStop = true;
            this.rbRose1.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.Location = new System.Drawing.Point(8, 644);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(703, 56);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 703);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox picGame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRed4;
        private System.Windows.Forms.RadioButton rbRed3;
        private System.Windows.Forms.RadioButton rbRed2;
        private System.Windows.Forms.RadioButton rbRed1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbBlue4;
        private System.Windows.Forms.RadioButton rbBlue3;
        private System.Windows.Forms.RadioButton rbBlue2;
        private System.Windows.Forms.RadioButton rbBlue1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbGreen4;
        private System.Windows.Forms.RadioButton rbGreen3;
        private System.Windows.Forms.RadioButton rbGreen2;
        private System.Windows.Forms.RadioButton rbGreen1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbRose4;
        private System.Windows.Forms.RadioButton rbRose3;
        private System.Windows.Forms.RadioButton rbRose2;
        private System.Windows.Forms.RadioButton rbRose1;
        private System.Windows.Forms.Button btnCheck;
    }
}
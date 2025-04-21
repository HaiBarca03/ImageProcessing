namespace DIP_Projects
{
    partial class frmSpaceIndependent
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
            this.btnBundle = new System.Windows.Forms.Button();
            this.txtBunchSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.Label();
            this.trbC = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackgroundSymmetry = new System.Windows.Forms.Button();
            this.cbThreshold = new System.Windows.Forms.RadioButton();
            this.cbBrightness = new System.Windows.Forms.RadioButton();
            this.btnAutoThreshold = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.btnContrastStretching = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNegative);
            this.groupBox1.Controls.Add(this.btnContrastStretching);
            this.groupBox1.Controls.Add(this.btnHistogram);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnHistogram, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnContrastStretching, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnNegative, 0);
            // 
            // btnBundle
            // 
            this.btnBundle.Location = new System.Drawing.Point(22, 55);
            this.btnBundle.Name = "btnBundle";
            this.btnBundle.Size = new System.Drawing.Size(112, 38);
            this.btnBundle.TabIndex = 2;
            this.btnBundle.Text = "Bó cụm";
            this.btnBundle.UseVisualStyleBackColor = true;
            this.btnBundle.Click += new System.EventHandler(this.btnBundle_Click);
            // 
            // txtBunchSize
            // 
            this.txtBunchSize.Location = new System.Drawing.Point(83, 21);
            this.txtBunchSize.Name = "txtBunchSize";
            this.txtBunchSize.Size = new System.Drawing.Size(51, 20);
            this.txtBunchSize.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "bunch size";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtC.Location = new System.Drawing.Point(24, 29);
            this.txtC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(67, 22);
            this.txtC.TabIndex = 6;
            this.txtC.Text = "0";
            this.txtC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbC
            // 
            this.trbC.Location = new System.Drawing.Point(16, 55);
            this.trbC.Margin = new System.Windows.Forms.Padding(2);
            this.trbC.Maximum = 255;
            this.trbC.Minimum = -255;
            this.trbC.Name = "trbC";
            this.trbC.Size = new System.Drawing.Size(267, 45);
            this.trbC.TabIndex = 5;
            this.trbC.ValueChanged += new System.EventHandler(this.trbC_ValueChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBackgroundSymmetry);
            this.groupBox2.Controls.Add(this.cbThreshold);
            this.groupBox2.Controls.Add(this.cbBrightness);
            this.groupBox2.Controls.Add(this.trbC);
            this.groupBox2.Controls.Add(this.btnAutoThreshold);
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Location = new System.Drawing.Point(185, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Độ sáng + Tách ngưỡng";
            // 
            // btnBackgroundSymmetry
            // 
            this.btnBackgroundSymmetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackgroundSymmetry.ForeColor = System.Drawing.Color.Red;
            this.btnBackgroundSymmetry.Location = new System.Drawing.Point(296, 55);
            this.btnBackgroundSymmetry.Name = "btnBackgroundSymmetry";
            this.btnBackgroundSymmetry.Size = new System.Drawing.Size(88, 38);
            this.btnBackgroundSymmetry.TabIndex = 12;
            this.btnBackgroundSymmetry.Text = "Background-Symmetry";
            this.btnBackgroundSymmetry.UseVisualStyleBackColor = true;
            this.btnBackgroundSymmetry.Click += new System.EventHandler(this.btnBackgroundSymmetry_Click);
            // 
            // cbThreshold
            // 
            this.cbThreshold.AutoSize = true;
            this.cbThreshold.Location = new System.Drawing.Point(185, 29);
            this.cbThreshold.Name = "cbThreshold";
            this.cbThreshold.Size = new System.Drawing.Size(89, 17);
            this.cbThreshold.TabIndex = 11;
            this.cbThreshold.TabStop = true;
            this.cbThreshold.Text = "Tách ngưỡng";
            this.cbThreshold.UseVisualStyleBackColor = true;
            // 
            // cbBrightness
            // 
            this.cbBrightness.AutoSize = true;
            this.cbBrightness.Location = new System.Drawing.Point(114, 29);
            this.cbBrightness.Name = "cbBrightness";
            this.cbBrightness.Size = new System.Drawing.Size(65, 17);
            this.cbBrightness.TabIndex = 10;
            this.cbBrightness.TabStop = true;
            this.cbBrightness.Text = "Độ sáng";
            this.cbBrightness.UseVisualStyleBackColor = true;
            // 
            // btnAutoThreshold
            // 
            this.btnAutoThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoThreshold.ForeColor = System.Drawing.Color.Red;
            this.btnAutoThreshold.Location = new System.Drawing.Point(296, 16);
            this.btnAutoThreshold.Name = "btnAutoThreshold";
            this.btnAutoThreshold.Size = new System.Drawing.Size(88, 35);
            this.btnAutoThreshold.TabIndex = 9;
            this.btnAutoThreshold.Text = "Auto - Isodata";
            this.btnAutoThreshold.UseVisualStyleBackColor = true;
            this.btnAutoThreshold.Click += new System.EventHandler(this.btnAutoThreshold_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBundle);
            this.groupBox3.Controls.Add(this.txtBunchSize);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(14, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bó cụm";
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(643, 22);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(101, 38);
            this.btnHistogram.TabIndex = 9;
            this.btnHistogram.Text = "Cân bằng histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // btnContrastStretching
            // 
            this.btnContrastStretching.Location = new System.Drawing.Point(643, 66);
            this.btnContrastStretching.Name = "btnContrastStretching";
            this.btnContrastStretching.Size = new System.Drawing.Size(101, 38);
            this.btnContrastStretching.TabIndex = 10;
            this.btnContrastStretching.Text = "Tăng độ tương phản";
            this.btnContrastStretching.UseVisualStyleBackColor = true;
            this.btnContrastStretching.Click += new System.EventHandler(this.btnContrastStretching_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(760, 22);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(101, 38);
            this.btnNegative.TabIndex = 11;
            this.btnNegative.Text = "Âm bản";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // frmSpaceIndependent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 614);
            this.Name = "frmSpaceIndependent";
            this.Text = "frmSpaceIndependent";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBundle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBunchSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trbC;
        private System.Windows.Forms.Label txtC;
        private System.Windows.Forms.Button btnAutoThreshold;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Button btnContrastStretching;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.RadioButton cbThreshold;
        private System.Windows.Forms.RadioButton cbBrightness;
        private System.Windows.Forms.Button btnBackgroundSymmetry;
    }
}
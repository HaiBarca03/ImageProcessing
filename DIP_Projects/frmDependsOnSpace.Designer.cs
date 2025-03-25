namespace DIP_Projects
{
    partial class frmDependsOnSpace
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
            this.btnVertical = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.btnFilterMid = new System.Windows.Forms.Button();
            this.btnFilterMean = new System.Windows.Forms.Button();
            this.btnFilterMidByNearK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.txtKValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnFilterMean);
            this.groupBox1.Controls.Add(this.btnFilterMid);
            this.groupBox1.Controls.Add(this.btnHorizontal);
            this.groupBox1.Controls.Add(this.btnVertical);
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(287, 43);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(101, 38);
            this.btnVertical.TabIndex = 1;
            this.btnVertical.Text = "Biên dọc";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Location = new System.Drawing.Point(459, 43);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(101, 38);
            this.btnHorizontal.TabIndex = 2;
            this.btnHorizontal.Text = "Biên ngang";
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btnFilterMid
            // 
            this.btnFilterMid.Location = new System.Drawing.Point(633, 43);
            this.btnFilterMid.Name = "btnFilterMid";
            this.btnFilterMid.Size = new System.Drawing.Size(101, 38);
            this.btnFilterMid.TabIndex = 3;
            this.btnFilterMid.Text = "Lọc trung vị";
            this.btnFilterMid.UseVisualStyleBackColor = true;
            this.btnFilterMid.Click += new System.EventHandler(this.btnFilterMid_Click);
            // 
            // btnFilterMean
            // 
            this.btnFilterMean.Location = new System.Drawing.Point(767, 43);
            this.btnFilterMean.Name = "btnFilterMean";
            this.btnFilterMean.Size = new System.Drawing.Size(101, 38);
            this.btnFilterMean.TabIndex = 4;
            this.btnFilterMean.Text = "Lọc trung bình";
            this.btnFilterMean.UseVisualStyleBackColor = true;
            this.btnFilterMean.Click += new System.EventHandler(this.btnFilterMean_Click);
            // 
            // btnFilterMidByNearK
            // 
            this.btnFilterMidByNearK.Location = new System.Drawing.Point(176, 19);
            this.btnFilterMidByNearK.Name = "btnFilterMidByNearK";
            this.btnFilterMidByNearK.Size = new System.Drawing.Size(43, 75);
            this.btnFilterMidByNearK.TabIndex = 5;
            this.btnFilterMidByNearK.Text = "Lọc trung bình theo k gần nhất";
            this.btnFilterMidByNearK.UseVisualStyleBackColor = true;
            this.btnFilterMidByNearK.Click += new System.EventHandler(this.btnFilterMidByNearK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtThreshold);
            this.groupBox2.Controls.Add(this.txtKValue);
            this.groupBox2.Controls.Add(this.btnFilterMidByNearK);
            this.groupBox2.Location = new System.Drawing.Point(29, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc TB Gần K";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ngưỡng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số K";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(71, 74);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(58, 20);
            this.txtThreshold.TabIndex = 7;
            // 
            // txtKValue
            // 
            this.txtKValue.Location = new System.Drawing.Point(71, 24);
            this.txtKValue.Name = "txtKValue";
            this.txtKValue.Size = new System.Drawing.Size(58, 20);
            this.txtKValue.TabIndex = 6;
            // 
            // frmDependsOnSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 616);
            this.Name = "frmDependsOnSpace";
            this.Text = "frmDependsOnSpace";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.Button btnFilterMid;
        private System.Windows.Forms.Button btnFilterMean;
        private System.Windows.Forms.Button btnFilterMidByNearK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.TextBox txtKValue;
        private System.Windows.Forms.Label label11;
    }
}
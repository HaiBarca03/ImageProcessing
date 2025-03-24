namespace DIP_Projects
{
    partial class frmThresholdSeparation
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
            this.txtC = new System.Windows.Forms.Label();
            this.trbC = new System.Windows.Forms.TrackBar();
            this.btnAutoThreshold = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnAutoThreshold);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.trbC);
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtC.Location = new System.Drawing.Point(346, 51);
            this.txtC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(67, 22);
            this.txtC.TabIndex = 5;
            this.txtC.Text = "0";
            this.txtC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbC
            // 
            this.trbC.Location = new System.Drawing.Point(438, 43);
            this.trbC.Margin = new System.Windows.Forms.Padding(2);
            this.trbC.Maximum = 255;
            this.trbC.Minimum = -255;
            this.trbC.Name = "trbC";
            this.trbC.Size = new System.Drawing.Size(321, 45);
            this.trbC.TabIndex = 4;
            this.trbC.ValueChanged += new System.EventHandler(this.trbC_ValueChanged);
            // 
            // btnAutoThreshold
            // 
            this.btnAutoThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoThreshold.ForeColor = System.Drawing.Color.Red;
            this.btnAutoThreshold.Location = new System.Drawing.Point(889, 19);
            this.btnAutoThreshold.Name = "btnAutoThreshold";
            this.btnAutoThreshold.Size = new System.Drawing.Size(98, 30);
            this.btnAutoThreshold.TabIndex = 6;
            this.btnAutoThreshold.Text = "Auto";
            this.btnAutoThreshold.UseVisualStyleBackColor = true;
            this.btnAutoThreshold.Click += new System.EventHandler(this.btnAutoThreshold_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(889, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 30);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmThresholdSeparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 612);
            this.Name = "frmThresholdSeparation";
            this.Text = "frmThresholdSeparation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtC;
        private System.Windows.Forms.TrackBar trbC;
        private System.Windows.Forms.Button btnAutoThreshold;
        private System.Windows.Forms.Button btnReset;
    }
}
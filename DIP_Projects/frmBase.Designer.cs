namespace DIP_Projects
{
    partial class frmBase
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
            this.txtY_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBlue_result = new System.Windows.Forms.TextBox();
            this.txtGreen_result = new System.Windows.Forms.TextBox();
            this.txtRed_result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.txtY_source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX_source = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblImgPath = new System.Windows.Forms.Label();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.txtBlue_source = new System.Windows.Forms.TextBox();
            this.txtGreen_source = new System.Windows.Forms.TextBox();
            this.txtRed_source = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnReconvert = new System.Windows.Forms.Button();
            this.btnLoadConvo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtY_result
            // 
            this.txtY_result.Location = new System.Drawing.Point(1064, 123);
            this.txtY_result.Name = "txtY_result";
            this.txtY_result.Size = new System.Drawing.Size(54, 20);
            this.txtY_result.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1041, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Y";
            // 
            // txtX_result
            // 
            this.txtX_result.Location = new System.Drawing.Point(1064, 87);
            this.txtX_result.Name = "txtX_result";
            this.txtX_result.Size = new System.Drawing.Size(54, 20);
            this.txtX_result.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1039, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "X";
            // 
            // txtBlue_result
            // 
            this.txtBlue_result.Location = new System.Drawing.Point(1064, 259);
            this.txtBlue_result.Name = "txtBlue_result";
            this.txtBlue_result.Size = new System.Drawing.Size(54, 20);
            this.txtBlue_result.TabIndex = 55;
            // 
            // txtGreen_result
            // 
            this.txtGreen_result.Location = new System.Drawing.Point(1064, 226);
            this.txtGreen_result.Name = "txtGreen_result";
            this.txtGreen_result.Size = new System.Drawing.Size(54, 20);
            this.txtGreen_result.TabIndex = 54;
            // 
            // txtRed_result
            // 
            this.txtRed_result.Location = new System.Drawing.Point(1064, 193);
            this.txtRed_result.Name = "txtRed_result";
            this.txtRed_result.Size = new System.Drawing.Size(54, 20);
            this.txtRed_result.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1039, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "R";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(1039, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "B";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1039, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "G";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnReconvert);
            this.groupBox1.Controls.Add(this.btnLoadConvo);
            this.groupBox1.Location = new System.Drawing.Point(30, 463);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 130);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(919, 382);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 45);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResult.Location = new System.Drawing.Point(596, 78);
            this.picResult.Margin = new System.Windows.Forms.Padding(4);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(428, 296);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 41;
            this.picResult.TabStop = false;
            this.picResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResult_MouseMove);
            // 
            // txtY_source
            // 
            this.txtY_source.Location = new System.Drawing.Point(489, 123);
            this.txtY_source.Name = "txtY_source";
            this.txtY_source.Size = new System.Drawing.Size(52, 20);
            this.txtY_source.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(466, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Y";
            // 
            // txtX_source
            // 
            this.txtX_source.Location = new System.Drawing.Point(489, 86);
            this.txtX_source.Name = "txtX_source";
            this.txtX_source.Size = new System.Drawing.Size(52, 20);
            this.txtX_source.TabIndex = 36;
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(464, 91);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(35, 24);
            this.lblX.TabIndex = 35;
            this.lblX.Text = "X";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(353, 387);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(105, 45);
            this.btnOpen.TabIndex = 34;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblImgPath
            // 
            this.lblImgPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImgPath.Location = new System.Drawing.Point(30, 38);
            this.lblImgPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImgPath.Name = "lblImgPath";
            this.lblImgPath.Size = new System.Drawing.Size(428, 28);
            this.lblImgPath.TabIndex = 33;
            // 
            // picSource
            // 
            this.picSource.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSource.Location = new System.Drawing.Point(30, 83);
            this.picSource.Margin = new System.Windows.Forms.Padding(4);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(428, 296);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSource.TabIndex = 32;
            this.picSource.TabStop = false;
            this.picSource.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSource_MouseMove);
            // 
            // txtBlue_source
            // 
            this.txtBlue_source.Location = new System.Drawing.Point(489, 259);
            this.txtBlue_source.Name = "txtBlue_source";
            this.txtBlue_source.Size = new System.Drawing.Size(52, 20);
            this.txtBlue_source.TabIndex = 45;
            // 
            // txtGreen_source
            // 
            this.txtGreen_source.Location = new System.Drawing.Point(489, 226);
            this.txtGreen_source.Name = "txtGreen_source";
            this.txtGreen_source.Size = new System.Drawing.Size(52, 20);
            this.txtGreen_source.TabIndex = 44;
            // 
            // txtRed_source
            // 
            this.txtRed_source.Location = new System.Drawing.Point(489, 193);
            this.txtRed_source.Name = "txtRed_source";
            this.txtRed_source.Size = new System.Drawing.Size(52, 20);
            this.txtRed_source.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(464, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "R";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(464, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "B";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(464, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "G";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnReconvert
            // 
            this.btnReconvert.Location = new System.Drawing.Point(987, 63);
            this.btnReconvert.Name = "btnReconvert";
            this.btnReconvert.Size = new System.Drawing.Size(101, 38);
            this.btnReconvert.TabIndex = 14;
            this.btnReconvert.Text = "ReConvert";
            this.btnReconvert.UseVisualStyleBackColor = true;
            this.btnReconvert.Click += new System.EventHandler(this.btnReconvert_Click);
            // 
            // btnLoadConvo
            // 
            this.btnLoadConvo.Location = new System.Drawing.Point(987, 19);
            this.btnLoadConvo.Name = "btnLoadConvo";
            this.btnLoadConvo.Size = new System.Drawing.Size(101, 38);
            this.btnLoadConvo.TabIndex = 13;
            this.btnLoadConvo.Text = "Convert";
            this.btnLoadConvo.UseVisualStyleBackColor = true;
            this.btnLoadConvo.Click += new System.EventHandler(this.btnLoadConvo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(883, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 38);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 605);
            this.Controls.Add(this.txtY_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtX_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBlue_result);
            this.Controls.Add(this.txtGreen_result);
            this.Controls.Add(this.txtRed_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.txtY_source);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX_source);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblImgPath);
            this.Controls.Add(this.picSource);
            this.Controls.Add(this.txtBlue_source);
            this.Controls.Add(this.txtGreen_source);
            this.Controls.Add(this.txtRed_source);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "frmBase";
            this.Text = "frmBase";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtY_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBlue_result;
        private System.Windows.Forms.TextBox txtGreen_result;
        private System.Windows.Forms.TextBox txtRed_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.TextBox txtY_source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX_source;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblImgPath;
        protected System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.TextBox txtBlue_source;
        private System.Windows.Forms.TextBox txtGreen_source;
        private System.Windows.Forms.TextBox txtRed_source;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnReconvert;
        private System.Windows.Forms.Button btnLoadConvo;
        private System.Windows.Forms.Button btnReset;
    }
}
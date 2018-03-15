namespace IUP_Lab1
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
            this.pb_Original = new System.Windows.Forms.PictureBox();
            this.pb_Modified = new System.Windows.Forms.PictureBox();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnThreshold = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThresh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Modified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Original
            // 
            this.pb_Original.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Original.Location = new System.Drawing.Point(46, 31);
            this.pb_Original.Name = "pb_Original";
            this.pb_Original.Size = new System.Drawing.Size(158, 147);
            this.pb_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Original.TabIndex = 0;
            this.pb_Original.TabStop = false;
            // 
            // pb_Modified
            // 
            this.pb_Modified.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Modified.Location = new System.Drawing.Point(416, 31);
            this.pb_Modified.Name = "pb_Modified";
            this.pb_Modified.Size = new System.Drawing.Size(158, 147);
            this.pb_Modified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Modified.TabIndex = 1;
            this.pb_Modified.TabStop = false;
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(254, 42);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(121, 23);
            this.btnGrayscale.TabIndex = 2;
            this.btnGrayscale.Text = "Gray Scale >>";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnThreshold
            // 
            this.btnThreshold.Location = new System.Drawing.Point(254, 83);
            this.btnThreshold.Name = "btnThreshold";
            this.btnThreshold.Size = new System.Drawing.Size(121, 23);
            this.btnThreshold.TabIndex = 3;
            this.btnThreshold.Text = "Threshold >>";
            this.btnThreshold.UseVisualStyleBackColor = true;
            this.btnThreshold.Click += new System.EventHandler(this.btnThreshold_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(254, 123);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(121, 23);
            this.btnNegative.TabIndex = 4;
            this.btnNegative.Text = "Negative >>";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(80, 193);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(416, 184);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(158, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 128;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Threshold: ";
            // 
            // txtThresh
            // 
            this.txtThresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThresh.Location = new System.Drawing.Point(496, 217);
            this.txtThresh.Name = "txtThresh";
            this.txtThresh.Size = new System.Drawing.Size(53, 20);
            this.txtThresh.TabIndex = 9;
            this.txtThresh.Text = "128";
            this.txtThresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtThresh_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 253);
            this.Controls.Add(this.txtThresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnThreshold);
            this.Controls.Add(this.btnGrayscale);
            this.Controls.Add(this.pb_Modified);
            this.Controls.Add(this.pb_Original);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Modified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Original;
        private System.Windows.Forms.PictureBox pb_Modified;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnThreshold;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThresh;
    }
}


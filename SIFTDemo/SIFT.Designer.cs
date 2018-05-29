namespace SIFTDemo
{
    partial class SIFT
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
            this.components = new System.ComponentModel.Container();
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.ibxModel = new Emgu.CV.UI.ImageBox();
            this.ibxResult = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoVideo = new System.Windows.Forms.RadioButton();
            this.rdoImages = new System.Windows.Forms.RadioButton();
            this.btnRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ibxModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Location = new System.Drawing.Point(11, 514);
            this.btnSelectImages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(642, 39);
            this.btnSelectImages.TabIndex = 0;
            this.btnSelectImages.Text = "Select Images";
            this.btnSelectImages.UseVisualStyleBackColor = true;
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);
            // 
            // ibxModel
            // 
            this.ibxModel.Location = new System.Drawing.Point(11, 24);
            this.ibxModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ibxModel.Name = "ibxModel";
            this.ibxModel.Size = new System.Drawing.Size(642, 465);
            this.ibxModel.TabIndex = 2;
            this.ibxModel.TabStop = false;
            // 
            // ibxResult
            // 
            this.ibxResult.Location = new System.Drawing.Point(657, 24);
            this.ibxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ibxResult.Name = "ibxResult";
            this.ibxResult.Size = new System.Drawing.Size(642, 465);
            this.ibxResult.TabIndex = 3;
            this.ibxResult.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Processed Image:";
            // 
            // rdoVideo
            // 
            this.rdoVideo.AutoSize = true;
            this.rdoVideo.Location = new System.Drawing.Point(657, 493);
            this.rdoVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoVideo.Name = "rdoVideo";
            this.rdoVideo.Size = new System.Drawing.Size(52, 17);
            this.rdoVideo.TabIndex = 1;
            this.rdoVideo.TabStop = true;
            this.rdoVideo.Text = "Video";
            this.rdoVideo.UseVisualStyleBackColor = true;
            this.rdoVideo.CheckedChanged += new System.EventHandler(this.rdoVideo_CheckedChanged);
            // 
            // rdoImages
            // 
            this.rdoImages.AutoSize = true;
            this.rdoImages.Location = new System.Drawing.Point(11, 493);
            this.rdoImages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoImages.Name = "rdoImages";
            this.rdoImages.Size = new System.Drawing.Size(59, 17);
            this.rdoImages.TabIndex = 0;
            this.rdoImages.TabStop = true;
            this.rdoImages.Text = "Images";
            this.rdoImages.UseVisualStyleBackColor = true;
            this.rdoImages.CheckedChanged += new System.EventHandler(this.rdoImages_CheckedChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(657, 514);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(642, 39);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Start Capture";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // SIFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoVideo);
            this.Controls.Add(this.ibxModel);
            this.Controls.Add(this.ibxResult);
            this.Controls.Add(this.rdoImages);
            this.Controls.Add(this.btnSelectImages);
            this.Controls.Add(this.btnRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SIFT";
            this.Text = "SIFT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ibxModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImages;
        private Emgu.CV.UI.ImageBox ibxModel;
        private Emgu.CV.UI.ImageBox ibxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.RadioButton rdoVideo;
        private System.Windows.Forms.RadioButton rdoImages;
    }
}
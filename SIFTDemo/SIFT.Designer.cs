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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoImages = new System.Windows.Forms.RadioButton();
            this.rdoVideo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ibxModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibxResult)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Location = new System.Drawing.Point(3, 711);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(1614, 48);
            this.btnSelectImages.TabIndex = 0;
            this.btnSelectImages.Text = "Select Images";
            this.btnSelectImages.UseVisualStyleBackColor = true;
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);
            // 
            // ibxModel
            // 
            this.ibxModel.Location = new System.Drawing.Point(3, 53);
            this.ibxModel.Name = "ibxModel";
            this.ibxModel.Size = new System.Drawing.Size(798, 593);
            this.ibxModel.TabIndex = 2;
            this.ibxModel.TabStop = false;
            // 
            // ibxResult
            // 
            this.ibxResult.Location = new System.Drawing.Point(807, 53);
            this.ibxResult.Name = "ibxResult";
            this.ibxResult.Size = new System.Drawing.Size(810, 593);
            this.ibxResult.TabIndex = 3;
            this.ibxResult.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.ibxModel);
            this.flowLayoutPanel1.Controls.Add(this.ibxResult);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnSelectImages);
            this.flowLayoutPanel1.Controls.Add(this.btnRecord);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1711, 945);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 44);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model Image:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(807, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 44);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Processed Image:";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(3, 765);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(1614, 48);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Start Capture";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoVideo);
            this.panel3.Controls.Add(this.rdoImages);
            this.panel3.Location = new System.Drawing.Point(3, 652);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1614, 53);
            this.panel3.TabIndex = 7;
            // 
            // rdoImages
            // 
            this.rdoImages.AutoSize = true;
            this.rdoImages.Location = new System.Drawing.Point(289, 17);
            this.rdoImages.Name = "rdoImages";
            this.rdoImages.Size = new System.Drawing.Size(74, 21);
            this.rdoImages.TabIndex = 0;
            this.rdoImages.TabStop = true;
            this.rdoImages.Text = "Images";
            this.rdoImages.UseVisualStyleBackColor = true;
            this.rdoImages.CheckedChanged += new System.EventHandler(this.rdoImages_CheckedChanged);
            // 
            // rdoVideo
            // 
            this.rdoVideo.AutoSize = true;
            this.rdoVideo.Location = new System.Drawing.Point(1160, 17);
            this.rdoVideo.Name = "rdoVideo";
            this.rdoVideo.Size = new System.Drawing.Size(65, 21);
            this.rdoVideo.TabIndex = 1;
            this.rdoVideo.TabStop = true;
            this.rdoVideo.Text = "Video";
            this.rdoVideo.UseVisualStyleBackColor = true;
            this.rdoVideo.CheckedChanged += new System.EventHandler(this.rdoVideo_CheckedChanged);
            // 
            // SIFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 969);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SIFT";
            this.Text = "SIFT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ibxModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibxResult)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImages;
        private Emgu.CV.UI.ImageBox ibxModel;
        private Emgu.CV.UI.ImageBox ibxResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoVideo;
        private System.Windows.Forms.RadioButton rdoImages;
    }
}
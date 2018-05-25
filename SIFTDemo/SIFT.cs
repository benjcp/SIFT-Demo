using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SIFTDemo
{
    public partial class SIFT : Form
    {
        private VideoCapture _capture = null;
        private bool _captureInProgress;
        private Mat _frame;
        private string ModelImage, OtherImage;
        

        public SIFT()
        {
            InitializeComponent();
            rdoImages.Checked = true;
            CvInvoke.UseOpenCL = false;
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            _frame = new Mat();
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);
                ibxModel.Image = _frame;
                long matchTime;
                Image<Bgr, Byte> rstImg = new Image<Bgr, Byte>(ibxModel.Image.Bitmap);
                using (Mat modelImage = rstImg.Mat)
                using (Mat observedImage = CvInvoke.Imread(ModelImage, ImreadModes.Color))
                {
                    Mat result = FeatureMatch.Draw(modelImage, observedImage, out matchTime);
                    ibxResult.Image = result;
                }
            }
        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private string getImage(string Image)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = $@"Select a {Image} Image";
            DialogResult result = ofd.ShowDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.png, *.tif, *.tiff) | *.jpg; *.jpeg; *.png; *.tif; *.tiff;";
            if (result == DialogResult.OK)
            {
                return ofd.FileName;
            }
            if(result == DialogResult.Cancel)
            {
                getImage(Image);
            }
            return null;
        }

        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            ModelImage = getImage("Model");
            ibxModel.Image = CvInvoke.Imread(ModelImage, ImreadModes.Color);
            OtherImage = getImage("Test");

            if(!String.IsNullOrEmpty(ModelImage) && !String.IsNullOrEmpty(OtherImage))
            {
                long matchTime;
                using (Mat modelImage = CvInvoke.Imread(ModelImage, ImreadModes.Color))
                using (Mat observedImage = CvInvoke.Imread(OtherImage, ImreadModes.Color))
                {
                    Mat result = FeatureMatch.Draw(modelImage, observedImage, out matchTime);
                    ibxResult.Image = result;
                }
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModelImage))
            {
                ModelImage = getImage("Model");
            }

            if (_capture != null)
            {
                if (_captureInProgress)
                {  //stop the capture
                    btnRecord.Text = "Start Capture";
                    _capture.Pause();
                }
                else
                {
                    //start the capture
                    btnRecord.Text = "Stop Capturing";
                    _capture.Start();
                }
                _captureInProgress = !_captureInProgress;
            }
        }

        private void rdoImages_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectImages.Visible = true;
            btnRecord.Visible = false;
        }

        private void rdoVideo_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectImages.Visible = false;
            btnRecord.Visible = true;
        }
    }
}

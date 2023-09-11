using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;

namespace cameraCaptureApp
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo devicelist in captureDevice)
            {
                cameraList.Items.Add(devicelist.Name);
            }
            cameraList.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                cameraBoxLeft.Image = null;
                cameraBoxLeft.Invalidate();
            }
            videoSource = new VideoCaptureDevice(captureDevice[cameraList.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraBoxLeft.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            cameraBoxRight.Image = (Bitmap)cameraBoxLeft.Image.Clone();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                cameraBoxLeft.Image = null;
                cameraBoxLeft.Invalidate();
                cameraBoxRight.Image = null;
                cameraBoxRight.Invalidate();
            }
            Application.Exit(null);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image As";
            saveFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                }

               // chat gpt
                if (cameraBoxRight.Image != null)
                {
                    cameraBoxRight.Image.Save(saveFileDialog.FileName, imageFormat);
                }
            }
        }

    }
}
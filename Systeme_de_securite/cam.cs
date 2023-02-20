using System;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Systeme_de_securite
{
    public partial class cam : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        
        public cam()
        {
            this.Text = "Camera";
            this.Size = new System.Drawing.Size(320, 240);
            this.StartPosition = FormStartPosition.CenterScreen;

            

            // Find available video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video sources found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add all available video devices to combobox
            foreach (FilterInfo device in videoDevices)
            {
                Console.WriteLine(device.Name);
            }

            // Set the first video device as the current device
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (System.Drawing.Bitmap)eventArgs.Frame.Clone();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

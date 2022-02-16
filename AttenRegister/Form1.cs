using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;

namespace AttenRegister
{
    public partial class frmAddStudent : Form
    {
        AttendanceDataContext dtbase = new AttendanceDataContext();
        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;
        public frmAddStudent()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                dgvStudent.DataSource = dtbase.Get_allStudent();
                CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor
                FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
                FinalFrame.VideoResolution = FinalFrame.VideoCapabilities[11];
                FinalFrame.Start();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
        {
            try { 
            camPreview.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!Directory.Exists(@"C:\attenTools\image"))
                {
                    Directory.CreateDirectory(@"C:\attenTools\image");
                }
                else
                {
                    Guid g = Guid.NewGuid();
                    camPreview.Image.Save($@"C:\attenTools\image\StudentImage-{g}.jpeg", ImageFormat.Jpeg);

                }
                    using (Bitmap bmb = new Bitmap(camPreview.Image))
                    {
                    
                        MemoryStream m = new MemoryStream();
                        bmb.Save(m, ImageFormat.Jpeg);
                        picPreview.Image = Image.FromStream(m);
                    }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void frmAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (FinalFrame.IsRunning) 
                    FinalFrame.Stop();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            var g = Guid.NewGuid();
                using (Image img = Image.FromFile($@"C:\attenTools\image\StudentImage-{g}.jpeg"))
                {
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    dtbase.Add_Student(txtBarCode.Text, txtName.Text, txtAge.Text, txtPhone.Text, txtGrade.Text, ms.ToArray());
                }

                dgvStudent.DataSource = dtbase.Get_allStudent();
                txtAge.Clear();
                txtBarCode.Clear();
                txtGrade.Clear();
                txtName.Clear();
                txtPhone.Clear();
                picPreview.Image = null;
            MessageBox.Show("Added Successfully");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this info...", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtbase.Del_Student(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                    dgvStudent.DataSource = dtbase.Get_allStudent();
                    MessageBox.Show("Deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Cancelled successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            FRMhistory form2 = new FRMhistory();
            form2.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void dgvStudent_Click(object sender, EventArgs e)
        {
            try 
            { 
            string b = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            AttendanceEntities3 att = new AttendanceEntities3();
            var item = att.Students.Where(a => a.BarCode == b).SingleOrDefault();
            byte[] arr = item.Picture;
            MemoryStream ms = new MemoryStream(arr);
            picPreview.Image = Image.FromStream(ms);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(@"C:\attenTools\backup"))
                {
                    Directory.CreateDirectory(@"C:\attenTools\backup");
                }
                else
                {
                    dtbase.backupdb(@"C:\attenTools\backup\Attendance.bak");
                    MessageBox.Show("baCkup Successfully", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\attenTools\backup\Attendance.bak";
                dtbase.ExecuteCommand(@"ALTER DATABASE Attendance SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                dtbase.ExecuteCommand(@"USE MASTER RESTORE DATABASE Attendance FROM DISK = '" + path + "' WITH REPLACE");
                dtbase.ExecuteCommand(@"ALTER DATABASE Attendance SET MULTI_USER");
                MessageBox.Show("Restored Successfully", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}

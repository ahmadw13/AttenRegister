using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AttenRegister
{

    public partial class del : Form
    {

        public del()
        {
            InitializeComponent();
        }

        private void del_Load(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        public string Path { get; set; } = @"C:\attenTools\image";

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(Path);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                DirectoryInfo source = new DirectoryInfo(Path);

             
                foreach (FileInfo fi in source.GetFiles())
                {
                    var creationTime = fi.CreationTime;
                    var today = (DateTime.Now - new TimeSpan(90, 0, 0, 0));
                    if (creationTime < today)
                    {
                        fi.Delete();
                    }
                }
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                DirectoryInfo source = new DirectoryInfo(Path);


                foreach (FileInfo fi in source.GetFiles())
                {
                    var creationTime = fi.CreationTime;
                    var today = (DateTime.Now - new TimeSpan(60, 0, 0, 0));
                    if (creationTime < today)
                    {
                        fi.Delete();
                    }
                }
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                DirectoryInfo source = new DirectoryInfo(Path);


                foreach (FileInfo fi in source.GetFiles())
                {
                    var creationTime = fi.CreationTime;
                    var today = (DateTime.Now - new TimeSpan(90, 0, 0, 0));
                    if (creationTime < today)
                    {
                        fi.Delete();
                    }
                }
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                DirectoryInfo source = new DirectoryInfo(Path);


                foreach (FileInfo fi in source.GetFiles())
                {
                    var creationTime = fi.CreationTime;
                    var today = DateTime.Now - new TimeSpan(120, 0, 0, 0);
                    if (creationTime < today)
                    {
                        try
                        {
                            fi.Delete();
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.ToString());
                        }
                    }
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }
    }
        }
    


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace AttenRegister
{
    public partial class FRMhistory : Form
    {
        AttendanceDataContext dtbase = new AttendanceDataContext();

        public FRMhistory()
        {
            InitializeComponent();
        }

        private void FRMhistory_Load(object sender, EventArgs e)
        {
            try { 
            dgvhistory.DataSource = dtbase.Get_allHistory();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void dgvhistory_Click(object sender, EventArgs e)
        {
            try { 
            int b = int.Parse(dgvhistory.CurrentRow.Cells[0].Value.ToString());
            AttendanceEntities3 att = new AttendanceEntities3();
                History item = att.Histories.Where(a => a.ID_History == b).SingleOrDefault();
            byte[] arr = item.picture;
            MemoryStream ms = new MemoryStream(arr);
            picPreview.Image = Image.FromStream(ms);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void datesearch_ValueChanged(object sender, EventArgs e)
        {
            try { 
            dgvhistory.DataSource = dtbase.Search_History(Convert.ToDateTime(datesearch.Value));
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            try { 
            dtbase.alter_history();
            dgvhistory.DataSource = dtbase.Get_allHistory();
            picPreview.Image = null;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_RPT report = new Frm_RPT();
                all_history rpd = new all_history();
                report.crystalReportViewer1.ReportSource = rpd;
                report.crystalReportViewer1.Refresh();
                report.ShowDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btndateprint_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_RPT report = new Frm_RPT();
                Search_history rpd = new Search_history();

                ParameterFieldDefinitions ParameterFieldDefinitions;
                ParameterFieldDefinition ParameterFieldDefinition;
                ParameterValues ParameterValues;
                ParameterDiscreteValue ParameterDiscreteValue = new ParameterDiscreteValue();

                ParameterDiscreteValue.Value = datesearch.Value.ToShortDateString();
                ParameterFieldDefinitions = rpd.DataDefinition.ParameterFields;
                ParameterFieldDefinition = ParameterFieldDefinitions["@date"];
                ParameterValues = ParameterFieldDefinition.CurrentValues;

                ParameterValues.Clear();
                ParameterValues.Add(ParameterDiscreteValue);
                ParameterFieldDefinition.ApplyCurrentValues(ParameterValues);


                report.crystalReportViewer1.ReportSource = rpd;
                report.crystalReportViewer1.Refresh();
                report.ShowDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
              del form2 = new del();
                form2.Show();
            
        }
    }
}

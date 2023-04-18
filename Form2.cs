using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShantakshProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        { if (e.KeyChar == (char)13)
            { if (string.IsNullOrEmpty(txtSearch.Text))
                { dataGridView.DataSource = employeedetailsBindingSource;
                }
                else
                {var query = from o in this.employeeDataSet.employeedetails
                                where o.EmployeeName.Contains(txtSearch.Text)
                                select o;
                    dataGridView.DataSource = query.ToList(); }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    employeedetailsBindingSource.RemoveCurrent();
            }

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtName.Focus();
                this.employeeDataSet.employeedetails.AddemployeedetailsRow(this.employeeDataSet.employeedetails.NewemployeedetailsRow());
                employeedetailsBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeedetailsBindingSource.ResetBindings(false);

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtName.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            employeedetailsBindingSource.ResetBindings(false);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                employeedetailsBindingSource.EndEdit();
                employeedetailsTableAdapter.Update(this.employeeDataSet.employeedetails);
                panel.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeedetailsBindingSource.ResetBindings(false);

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.employeedetails' table. You can move, or remove it, as needed.
            this.employeedetailsTableAdapter.Fill(this.employeeDataSet.employeedetails);
            employeeDataSetBindingSource.DataSource = this.employeeDataSet.employeedetails;
        }
    }
}

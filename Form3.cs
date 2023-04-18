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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtName.Focus();
                this.donorDatabaseDataSet.Donors.AddDonorsRow(this.donorDatabaseDataSet.Donors.NewDonorsRow());
                donorsBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                donorsBindingSource.ResetBindings(false);

            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            donorsBindingSource.ResetBindings(false);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                donorsBindingSource.EndEdit();
                donorsTableAdapter.Update(this.donorDatabaseDataSet.Donors);
                panel.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                donorsBindingSource.ResetBindings(false);

            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {

                    dataGridView.DataSource = donorsBindingSource;
                }
                else
                {
                    var query = from o in this.donorDatabaseDataSet.Donors
                                where o.FullName.Contains(txtSearch.Text)
                                select o;


                    dataGridView.DataSource = query.ToList();

                }
            }

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    donorsBindingSource.RemoveCurrent();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'donorDatabaseDataSet.Donors' table. You can move, or remove it, as needed.
            this.donorsTableAdapter.Fill(this.donorDatabaseDataSet.Donors);
            donorsBindingSource.DataSource = this.donorDatabaseDataSet.Donors;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

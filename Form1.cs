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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.Orphans' table. You can move, or remove it, as needed.
            this.orphansTableAdapter.Fill(this.mydbDataSet.Orphans);
            orphansBindingSource.DataSource = this.mydbDataSet.Orphans;

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text)) {
                    
                    dataGridView.DataSource = orphansBindingSource;
                }
                else
                {
                    var query = from o in this.mydbDataSet.Orphans
                                where  o.Orphan_Name.Contains(txtSearch.Text)
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
                    orphansBindingSource.RemoveCurrent();
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try {
                using(OpenFileDialog ofd=new OpenFileDialog(){Filter="JPEG|*.jpg",ValidateNames=true,Multiselect=false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                }

            } catch (Exception ex)
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
                this.mydbDataSet.Orphans.AddOrphansRow(this.mydbDataSet.Orphans.NewOrphansRow());
                orphansBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                orphansBindingSource.ResetBindings(false);

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
            orphansBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                orphansBindingSource.EndEdit();
                orphansTableAdapter.Update(this.mydbDataSet.Orphans);
                panel.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                orphansBindingSource.ResetBindings(false);

            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

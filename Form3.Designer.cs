
namespace ShantakshProject
{
    partial class Form3
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.txt_DateofDonation = new System.Windows.Forms.TextBox();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorDatabaseDataSet = new ShantakshProject.DonorDatabaseDataSet();
            this.txtDateofDonation = new System.Windows.Forms.Label();
            this.txtaddres = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtDonatedAmount = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.donorNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateOfDonationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.donorsTableAdapter = new ShantakshProject.DonorDatabaseDataSetTableAdapters.DonorsTableAdapter();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Yellow;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNew.Location = new System.Drawing.Point(144, 411);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(76, 26);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEdit.Location = new System.Drawing.Point(271, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 26);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancel.Location = new System.Drawing.Point(391, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.Location = new System.Drawing.Point(515, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.txt_DateofDonation);
            this.panel.Controls.Add(this.txtDateofDonation);
            this.panel.Controls.Add(this.txtaddres);
            this.panel.Controls.Add(this.txtAddress);
            this.panel.Controls.Add(this.txtamount);
            this.panel.Controls.Add(this.txtDonatedAmount);
            this.panel.Controls.Add(this.txtPhoneNumber);
            this.panel.Controls.Add(this.txtNumber);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.txtFullName);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.btnBrowse);
            this.panel.Location = new System.Drawing.Point(6, 17);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(744, 224);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_DateofDonation
            // 
            this.txt_DateofDonation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorsBindingSource, "DateOfDonation", true));
            this.txt_DateofDonation.Location = new System.Drawing.Point(385, 179);
            this.txt_DateofDonation.Name = "txt_DateofDonation";
            this.txt_DateofDonation.Size = new System.Drawing.Size(164, 20);
            this.txt_DateofDonation.TabIndex = 4;
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.donorDatabaseDataSet;
            // 
            // donorDatabaseDataSet
            // 
            this.donorDatabaseDataSet.DataSetName = "DonorDatabaseDataSet";
            this.donorDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDateofDonation
            // 
            this.txtDateofDonation.AutoSize = true;
            this.txtDateofDonation.BackColor = System.Drawing.Color.Yellow;
            this.txtDateofDonation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDateofDonation.Location = new System.Drawing.Point(233, 179);
            this.txtDateofDonation.Name = "txtDateofDonation";
            this.txtDateofDonation.Size = new System.Drawing.Size(123, 18);
            this.txtDateofDonation.TabIndex = 19;
            this.txtDateofDonation.Text = "Date Of Donation";
            // 
            // txtaddres
            // 
            this.txtaddres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorsBindingSource, "Address", true));
            this.txtaddres.Location = new System.Drawing.Point(385, 131);
            this.txtaddres.Multiline = true;
            this.txtaddres.Name = "txtaddres";
            this.txtaddres.Size = new System.Drawing.Size(261, 28);
            this.txtaddres.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.BackColor = System.Drawing.Color.Yellow;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAddress.Location = new System.Drawing.Point(233, 141);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(62, 18);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.Text = "Address";
            // 
            // txtamount
            // 
            this.txtamount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorsBindingSource, "Amount", true));
            this.txtamount.Location = new System.Drawing.Point(385, 93);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(164, 20);
            this.txtamount.TabIndex = 2;
            // 
            // txtDonatedAmount
            // 
            this.txtDonatedAmount.AutoSize = true;
            this.txtDonatedAmount.BackColor = System.Drawing.Color.Yellow;
            this.txtDonatedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDonatedAmount.Location = new System.Drawing.Point(233, 95);
            this.txtDonatedAmount.Name = "txtDonatedAmount";
            this.txtDonatedAmount.Size = new System.Drawing.Size(119, 18);
            this.txtDonatedAmount.TabIndex = 16;
            this.txtDonatedAmount.Text = "Amount Donated";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorsBindingSource, "PhoneNumber", true));
            this.txtPhoneNumber.Location = new System.Drawing.Point(385, 54);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(164, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.AutoSize = true;
            this.txtNumber.BackColor = System.Drawing.Color.Yellow;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNumber.Location = new System.Drawing.Point(233, 54);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(108, 18);
            this.txtNumber.TabIndex = 15;
            this.txtNumber.Text = "Phone Number";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorsBindingSource, "FullName", true));
            this.txtName.Location = new System.Drawing.Point(385, 10);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.BackColor = System.Drawing.Color.Yellow;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFullName.Location = new System.Drawing.Point(233, 18);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(75, 18);
            this.txtFullName.TabIndex = 13;
            this.txtFullName.Text = "Full Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorsBindingSource, "Image", true));
            this.pictureBox1.Location = new System.Drawing.Point(24, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Yellow;
            this.btnBrowse.Location = new System.Drawing.Point(43, 175);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(76, 26);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorNoDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.dateOfDonationDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.donorsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(8, 273);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(742, 132);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // donorNoDataGridViewTextBoxColumn
            // 
            this.donorNoDataGridViewTextBoxColumn.DataPropertyName = "DonorNo";
            this.donorNoDataGridViewTextBoxColumn.HeaderText = "DonorNo";
            this.donorNoDataGridViewTextBoxColumn.Name = "donorNoDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // dateOfDonationDataGridViewTextBoxColumn
            // 
            this.dateOfDonationDataGridViewTextBoxColumn.DataPropertyName = "DateOfDonation";
            this.dateOfDonationDataGridViewTextBoxColumn.HeaderText = "DateOfDonation";
            this.dateOfDonationDataGridViewTextBoxColumn.Name = "dateOfDonationDataGridViewTextBoxColumn";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(72, 247);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Search";
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(775, 449);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtaddres;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label txtDonatedAmount;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txt_DateofDonation;
        private System.Windows.Forms.Label txtDateofDonation;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private DonorDatabaseDataSet donorDatabaseDataSet;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private DonorDatabaseDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfDonationDataGridViewTextBoxColumn;
    }
}
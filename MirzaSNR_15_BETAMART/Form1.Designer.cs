namespace MirzaSNR_15_BETAMART
{
    partial class Form1
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
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarangMasuk = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new MirzaSNR_15_BETAMART.AppData();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStockBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarangKeluar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employeesTableAdapter = new MirzaSNR_15_BETAMART.AppDataTableAdapters.EmployeesTableAdapter();
            this.namaBaarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangKeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(227, 233);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(75, 23);
            this.btnBaru.TabIndex = 1;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(317, 233);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(314, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Beta Mart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barang Masuk";
            // 
            // txtBarangMasuk
            // 
            this.txtBarangMasuk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BarangMasuk", true));
            this.txtBarangMasuk.Location = new System.Drawing.Point(277, 140);
            this.txtBarangMasuk.Name = "txtBarangMasuk";
            this.txtBarangMasuk.Size = new System.Drawing.Size(100, 20);
            this.txtBarangMasuk.TabIndex = 7;
            this.txtBarangMasuk.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaBaarangDataGridViewTextBoxColumn,
            this.stockBarangDataGridViewTextBoxColumn,
            this.barangMasukDataGridViewTextBoxColumn,
            this.barangKeluarDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.employeesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(117, 323);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(595, 198);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStockBarang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBarangKeluar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNamaBarang);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBarangMasuk);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 215);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtStockBarang
            // 
            this.txtStockBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "StockBarang", true));
            this.txtStockBarang.Location = new System.Drawing.Point(473, 100);
            this.txtStockBarang.Name = "txtStockBarang";
            this.txtStockBarang.Size = new System.Drawing.Size(100, 20);
            this.txtStockBarang.TabIndex = 1;
            this.txtStockBarang.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stock Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBarangKeluar
            // 
            this.txtBarangKeluar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BarangKeluar", true));
            this.txtBarangKeluar.Location = new System.Drawing.Point(473, 137);
            this.txtBarangKeluar.Name = "txtBarangKeluar";
            this.txtBarangKeluar.Size = new System.Drawing.Size(100, 20);
            this.txtBarangKeluar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Barang Keluar";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "NamaBaarang", true));
            this.txtNamaBarang.Location = new System.Drawing.Point(277, 99);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(100, 20);
            this.txtNamaBarang.TabIndex = 0;
            this.txtNamaBarang.TextChanged += new System.EventHandler(this.txtNamaBarang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nama Barang";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(499, 233);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(227, 277);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(396, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // namaBaarangDataGridViewTextBoxColumn
            // 
            this.namaBaarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBaarang";
            this.namaBaarangDataGridViewTextBoxColumn.HeaderText = "NamaBaarang";
            this.namaBaarangDataGridViewTextBoxColumn.Name = "namaBaarangDataGridViewTextBoxColumn";
            this.namaBaarangDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockBarangDataGridViewTextBoxColumn
            // 
            this.stockBarangDataGridViewTextBoxColumn.DataPropertyName = "StockBarang";
            this.stockBarangDataGridViewTextBoxColumn.HeaderText = "StockBarang";
            this.stockBarangDataGridViewTextBoxColumn.Name = "stockBarangDataGridViewTextBoxColumn";
            // 
            // barangMasukDataGridViewTextBoxColumn
            // 
            this.barangMasukDataGridViewTextBoxColumn.DataPropertyName = "BarangMasuk";
            this.barangMasukDataGridViewTextBoxColumn.HeaderText = "BarangMasuk";
            this.barangMasukDataGridViewTextBoxColumn.Name = "barangMasukDataGridViewTextBoxColumn";
            this.barangMasukDataGridViewTextBoxColumn.Width = 150;
            // 
            // barangKeluarDataGridViewTextBoxColumn
            // 
            this.barangKeluarDataGridViewTextBoxColumn.DataPropertyName = "BarangKeluar";
            this.barangKeluarDataGridViewTextBoxColumn.HeaderText = "BarangKeluar";
            this.barangKeluarDataGridViewTextBoxColumn.Name = "barangKeluarDataGridViewTextBoxColumn";
            this.barangKeluarDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBaru);
            this.Name = "Form1";
            this.Text = "MirzaSNR_15_BETAMART";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarangMasuk;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStockBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarangKeluar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private AppData appData;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private AppDataTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBaarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangKeluarDataGridViewTextBoxColumn;
    }
}


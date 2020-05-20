namespace Super_Shop_Management_System
{
    partial class AdminInterface
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.txtPVendor = new System.Windows.Forms.TextBox();
            this.txtPQantity = new System.Windows.Forms.TextBox();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSelectedProduct = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnUpdatePQuantity = new System.Windows.Forms.Button();
            this.btnUpdatePPrice = new System.Windows.Forms.Button();
            this.txtUpdatePQuantity = new System.Windows.Forms.TextBox();
            this.txtUpdatePPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.btnLessQuantity = new System.Windows.Forms.Button();
            this.btnPView = new System.Windows.Forms.Button();
            this.bntAllpView = new System.Windows.Forms.Button();
            this.cmbPview = new System.Windows.Forms.ComboBox();
            this.gridViewProduct = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnEmployeeReject = new System.Windows.Forms.Button();
            this.btnEmployeeApprove = new System.Windows.Forms.Button();
            this.gridViewEmployee = new System.Windows.Forms.DataGridView();
            this.bntApprovalView = new System.Windows.Forms.Button();
            this.cmbEmployeeApprove = new System.Windows.Forms.ComboBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.btnEmployeeRemove = new System.Windows.Forms.Button();
            this.cmbEmployeeRemove = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPromoPercentage = new System.Windows.Forms.TextBox();
            this.txtPromoCode = new System.Windows.Forms.TextBox();
            this.btnAddPromo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(319, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(411, 257);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(403, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Location = new System.Drawing.Point(2, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(403, 234);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnPAdd);
            this.tabPage5.Controls.Add(this.txtPVendor);
            this.tabPage5.Controls.Add(this.txtPQantity);
            this.tabPage5.Controls.Add(this.txtPPrice);
            this.tabPage5.Controls.Add(this.txtPName);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(395, 208);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Add Product";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnPAdd
            // 
            this.btnPAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAdd.Location = new System.Drawing.Point(95, 162);
            this.btnPAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(112, 29);
            this.btnPAdd.TabIndex = 2;
            this.btnPAdd.Text = "Add Product";
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // txtPVendor
            // 
            this.txtPVendor.Location = new System.Drawing.Point(95, 123);
            this.txtPVendor.Margin = new System.Windows.Forms.Padding(2);
            this.txtPVendor.Name = "txtPVendor";
            this.txtPVendor.Size = new System.Drawing.Size(125, 20);
            this.txtPVendor.TabIndex = 1;
            // 
            // txtPQantity
            // 
            this.txtPQantity.Location = new System.Drawing.Point(94, 90);
            this.txtPQantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtPQantity.Name = "txtPQantity";
            this.txtPQantity.Size = new System.Drawing.Size(125, 20);
            this.txtPQantity.TabIndex = 1;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(94, 61);
            this.txtPPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(126, 20);
            this.txtPPrice.TabIndex = 1;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(95, 30);
            this.txtPName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(125, 20);
            this.txtPName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vendor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(this.cmbSelectedProduct);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(395, 208);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Remove Product";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(71, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSelectedProduct
            // 
            this.cmbSelectedProduct.FormattingEnabled = true;
            this.cmbSelectedProduct.Location = new System.Drawing.Point(50, 33);
            this.cmbSelectedProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectedProduct.Name = "cmbSelectedProduct";
            this.cmbSelectedProduct.Size = new System.Drawing.Size(144, 21);
            this.cmbSelectedProduct.TabIndex = 0;
            this.cmbSelectedProduct.Text = "Select Item";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnUpdatePQuantity);
            this.tabPage7.Controls.Add(this.btnUpdatePPrice);
            this.tabPage7.Controls.Add(this.txtUpdatePQuantity);
            this.tabPage7.Controls.Add(this.txtUpdatePPrice);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Controls.Add(this.cmbUpdate);
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(395, 208);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Update Product";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePQuantity
            // 
            this.btnUpdatePQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePQuantity.Location = new System.Drawing.Point(208, 149);
            this.btnUpdatePQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePQuantity.Name = "btnUpdatePQuantity";
            this.btnUpdatePQuantity.Size = new System.Drawing.Size(94, 33);
            this.btnUpdatePQuantity.TabIndex = 6;
            this.btnUpdatePQuantity.Text = "Update Quantity";
            this.btnUpdatePQuantity.UseVisualStyleBackColor = true;
            this.btnUpdatePQuantity.Click += new System.EventHandler(this.btnUpdatePQuantity_Click);
            // 
            // btnUpdatePPrice
            // 
            this.btnUpdatePPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePPrice.Location = new System.Drawing.Point(51, 149);
            this.btnUpdatePPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePPrice.Name = "btnUpdatePPrice";
            this.btnUpdatePPrice.Size = new System.Drawing.Size(88, 33);
            this.btnUpdatePPrice.TabIndex = 6;
            this.btnUpdatePPrice.Text = "Update Price";
            this.btnUpdatePPrice.UseVisualStyleBackColor = true;
            this.btnUpdatePPrice.Click += new System.EventHandler(this.btnUpdatePPrice_Click);
            // 
            // txtUpdatePQuantity
            // 
            this.txtUpdatePQuantity.Location = new System.Drawing.Point(208, 110);
            this.txtUpdatePQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdatePQuantity.Name = "txtUpdatePQuantity";
            this.txtUpdatePQuantity.Size = new System.Drawing.Size(95, 20);
            this.txtUpdatePQuantity.TabIndex = 5;
            // 
            // txtUpdatePPrice
            // 
            this.txtUpdatePPrice.Location = new System.Drawing.Point(51, 110);
            this.txtUpdatePPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdatePPrice.Name = "txtUpdatePPrice";
            this.txtUpdatePPrice.Size = new System.Drawing.Size(89, 20);
            this.txtUpdatePPrice.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price:";
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(99, 37);
            this.cmbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(144, 21);
            this.cmbUpdate.TabIndex = 1;
            this.cmbUpdate.Text = "Select Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.btnLessQuantity);
            this.tabPage10.Controls.Add(this.btnPView);
            this.tabPage10.Controls.Add(this.bntAllpView);
            this.tabPage10.Controls.Add(this.cmbPview);
            this.tabPage10.Controls.Add(this.gridViewProduct);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(395, 208);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "View";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // btnLessQuantity
            // 
            this.btnLessQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessQuantity.Location = new System.Drawing.Point(264, 17);
            this.btnLessQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnLessQuantity.Name = "btnLessQuantity";
            this.btnLessQuantity.Size = new System.Drawing.Size(101, 22);
            this.btnLessQuantity.TabIndex = 4;
            this.btnLessQuantity.Text = "Less Quantity";
            this.btnLessQuantity.UseVisualStyleBackColor = true;
            this.btnLessQuantity.Click += new System.EventHandler(this.btnLessQuantity_Click);
            // 
            // btnPView
            // 
            this.btnPView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPView.Location = new System.Drawing.Point(36, 46);
            this.btnPView.Margin = new System.Windows.Forms.Padding(2);
            this.btnPView.Name = "btnPView";
            this.btnPView.Size = new System.Drawing.Size(62, 20);
            this.btnPView.TabIndex = 3;
            this.btnPView.Text = "View";
            this.btnPView.UseVisualStyleBackColor = true;
            this.btnPView.Click += new System.EventHandler(this.btnPView_Click);
            // 
            // bntAllpView
            // 
            this.bntAllpView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAllpView.Location = new System.Drawing.Point(158, 17);
            this.bntAllpView.Margin = new System.Windows.Forms.Padding(2);
            this.bntAllpView.Name = "bntAllpView";
            this.bntAllpView.Size = new System.Drawing.Size(71, 20);
            this.bntAllpView.TabIndex = 2;
            this.bntAllpView.Text = "All Product";
            this.bntAllpView.UseVisualStyleBackColor = true;
            this.bntAllpView.Click += new System.EventHandler(this.bntAllpView_Click);
            // 
            // cmbPview
            // 
            this.cmbPview.FormattingEnabled = true;
            this.cmbPview.Location = new System.Drawing.Point(12, 18);
            this.cmbPview.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPview.Name = "cmbPview";
            this.cmbPview.Size = new System.Drawing.Size(117, 21);
            this.cmbPview.TabIndex = 1;
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProduct.Location = new System.Drawing.Point(5, 78);
            this.gridViewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.RowTemplate.Height = 28;
            this.gridViewProduct.Size = new System.Drawing.Size(389, 133);
            this.gridViewProduct.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(403, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Location = new System.Drawing.Point(0, 15);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(406, 224);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.btnEmployeeReject);
            this.tabPage8.Controls.Add(this.btnEmployeeApprove);
            this.tabPage8.Controls.Add(this.gridViewEmployee);
            this.tabPage8.Controls.Add(this.bntApprovalView);
            this.tabPage8.Controls.Add(this.cmbEmployeeApprove);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage8.Size = new System.Drawing.Size(398, 198);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Approval";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeReject
            // 
            this.btnEmployeeReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeReject.Location = new System.Drawing.Point(226, 161);
            this.btnEmployeeReject.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeeReject.Name = "btnEmployeeReject";
            this.btnEmployeeReject.Size = new System.Drawing.Size(65, 31);
            this.btnEmployeeReject.TabIndex = 4;
            this.btnEmployeeReject.Text = "Reject";
            this.btnEmployeeReject.UseVisualStyleBackColor = true;
            this.btnEmployeeReject.Click += new System.EventHandler(this.btnEmployeeReject_Click);
            // 
            // btnEmployeeApprove
            // 
            this.btnEmployeeApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeApprove.Location = new System.Drawing.Point(45, 161);
            this.btnEmployeeApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeeApprove.Name = "btnEmployeeApprove";
            this.btnEmployeeApprove.Size = new System.Drawing.Size(69, 31);
            this.btnEmployeeApprove.TabIndex = 3;
            this.btnEmployeeApprove.Text = "Approve";
            this.btnEmployeeApprove.UseVisualStyleBackColor = true;
            this.btnEmployeeApprove.Click += new System.EventHandler(this.btnEmployeeApprove_Click);
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewEmployee.Location = new System.Drawing.Point(1, 46);
            this.gridViewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewEmployee.Name = "gridViewEmployee";
            this.gridViewEmployee.RowTemplate.Height = 28;
            this.gridViewEmployee.Size = new System.Drawing.Size(394, 106);
            this.gridViewEmployee.TabIndex = 2;
            // 
            // bntApprovalView
            // 
            this.bntApprovalView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntApprovalView.Location = new System.Drawing.Point(195, 14);
            this.bntApprovalView.Margin = new System.Windows.Forms.Padding(2);
            this.bntApprovalView.Name = "bntApprovalView";
            this.bntApprovalView.Size = new System.Drawing.Size(76, 21);
            this.bntApprovalView.TabIndex = 1;
            this.bntApprovalView.Text = "View";
            this.bntApprovalView.UseVisualStyleBackColor = true;
            this.bntApprovalView.Click += new System.EventHandler(this.bntApprovalView_Click);
            // 
            // cmbEmployeeApprove
            // 
            this.cmbEmployeeApprove.FormattingEnabled = true;
            this.cmbEmployeeApprove.Location = new System.Drawing.Point(45, 17);
            this.cmbEmployeeApprove.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmployeeApprove.Name = "cmbEmployeeApprove";
            this.cmbEmployeeApprove.Size = new System.Drawing.Size(113, 21);
            this.cmbEmployeeApprove.TabIndex = 0;
            this.cmbEmployeeApprove.SelectedIndexChanged += new System.EventHandler(this.CmbEmployeeApprove_SelectedIndexChanged);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.btnEmployeeRemove);
            this.tabPage9.Controls.Add(this.cmbEmployeeRemove);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage9.Size = new System.Drawing.Size(398, 198);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Remove";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeRemove
            // 
            this.btnEmployeeRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRemove.Location = new System.Drawing.Point(97, 83);
            this.btnEmployeeRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeeRemove.Name = "btnEmployeeRemove";
            this.btnEmployeeRemove.Size = new System.Drawing.Size(115, 27);
            this.btnEmployeeRemove.TabIndex = 1;
            this.btnEmployeeRemove.Text = "Remove";
            this.btnEmployeeRemove.UseVisualStyleBackColor = true;
            this.btnEmployeeRemove.Click += new System.EventHandler(this.btnEmployeeRemove_Click);
            // 
            // cmbEmployeeRemove
            // 
            this.cmbEmployeeRemove.FormattingEnabled = true;
            this.cmbEmployeeRemove.Location = new System.Drawing.Point(73, 40);
            this.cmbEmployeeRemove.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmployeeRemove.Name = "cmbEmployeeRemove";
            this.cmbEmployeeRemove.Size = new System.Drawing.Size(154, 21);
            this.cmbEmployeeRemove.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtPromoPercentage);
            this.tabPage3.Controls.Add(this.txtPromoCode);
            this.tabPage3.Controls.Add(this.btnAddPromo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(403, 231);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Discount";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Percentage:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Promo Code:";
            // 
            // txtPromoPercentage
            // 
            this.txtPromoPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromoPercentage.Location = new System.Drawing.Point(161, 85);
            this.txtPromoPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.txtPromoPercentage.Name = "txtPromoPercentage";
            this.txtPromoPercentage.Size = new System.Drawing.Size(93, 23);
            this.txtPromoPercentage.TabIndex = 2;
            // 
            // txtPromoCode
            // 
            this.txtPromoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromoCode.Location = new System.Drawing.Point(161, 47);
            this.txtPromoCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.Size = new System.Drawing.Size(93, 23);
            this.txtPromoCode.TabIndex = 1;
            // 
            // btnAddPromo
            // 
            this.btnAddPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPromo.Location = new System.Drawing.Point(143, 146);
            this.btnAddPromo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPromo.Name = "btnAddPromo";
            this.btnAddPromo.Size = new System.Drawing.Size(109, 23);
            this.btnAddPromo.TabIndex = 0;
            this.btnAddPromo.Text = "Add Promo ";
            this.btnAddPromo.UseVisualStyleBackColor = true;
            this.btnAddPromo.Click += new System.EventHandler(this.btnAddPromo_Click);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 302);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminInterface";
            this.Text = "Shop Management System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPVendor;
        private System.Windows.Forms.TextBox txtPQantity;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbSelectedProduct;
        private System.Windows.Forms.Button btnUpdatePPrice;
        private System.Windows.Forms.TextBox txtUpdatePQuantity;
        private System.Windows.Forms.TextBox txtUpdatePPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdatePQuantity;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataGridView gridViewProduct;
        private System.Windows.Forms.Button btnEmployeeReject;
        private System.Windows.Forms.Button btnEmployeeApprove;
        private System.Windows.Forms.DataGridView gridViewEmployee;
        private System.Windows.Forms.Button bntApprovalView;
        private System.Windows.Forms.ComboBox cmbEmployeeApprove;
        private System.Windows.Forms.Button btnEmployeeRemove;
        private System.Windows.Forms.ComboBox cmbEmployeeRemove;
        private System.Windows.Forms.Button bntAllpView;
        private System.Windows.Forms.ComboBox cmbPview;
        private System.Windows.Forms.Button btnPView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPromoPercentage;
        private System.Windows.Forms.TextBox txtPromoCode;
        private System.Windows.Forms.Button btnAddPromo;
        private System.Windows.Forms.Button btnLessQuantity;
    }
}
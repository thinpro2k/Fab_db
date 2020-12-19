namespace ManageFabric
{
    partial class TableSupplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNewSup = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvCateToSup = new System.Windows.Forms.DataGridView();
            this.dtgvInfoSup = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListSupplier = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCateToSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoSup)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 531);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDel);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Location = new System.Drawing.Point(233, 442);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(864, 85);
            this.panel5.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(712, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(310, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 49);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNewSup);
            this.panel4.Location = new System.Drawing.Point(11, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 91);
            this.panel4.TabIndex = 2;
            // 
            // btnNewSup
            // 
            this.btnNewSup.Location = new System.Drawing.Point(22, 19);
            this.btnNewSup.Name = "btnNewSup";
            this.btnNewSup.Size = new System.Drawing.Size(156, 55);
            this.btnNewSup.TabIndex = 0;
            this.btnNewSup.Text = "Thêm nhà cung cấp";
            this.btnNewSup.UseVisualStyleBackColor = true;
            this.btnNewSup.Click += new System.EventHandler(this.btnNewSup_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtgvCateToSup);
            this.panel3.Controls.Add(this.dtgvInfoSup);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(233, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 421);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông tin  category từ nhà cung cấp";
            // 
            // dtgvCateToSup
            // 
            this.dtgvCateToSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCateToSup.Location = new System.Drawing.Point(9, 218);
            this.dtgvCateToSup.Name = "dtgvCateToSup";
            this.dtgvCateToSup.RowTemplate.Height = 24;
            this.dtgvCateToSup.Size = new System.Drawing.Size(846, 202);
            this.dtgvCateToSup.TabIndex = 3;
            // 
            // dtgvInfoSup
            // 
            this.dtgvInfoSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfoSup.Location = new System.Drawing.Point(3, 33);
            this.dtgvInfoSup.Name = "dtgvInfoSup";
            this.dtgvInfoSup.RowTemplate.Height = 24;
            this.dtgvInfoSup.Size = new System.Drawing.Size(852, 151);
            this.dtgvInfoSup.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin nhà cung cấp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListSupplier);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 421);
            this.panel2.TabIndex = 0;
            // 
            // ListSupplier
            // 
            this.ListSupplier.HideSelection = false;
            this.ListSupplier.Location = new System.Drawing.Point(16, 33);
            this.ListSupplier.Name = "ListSupplier";
            this.ListSupplier.Size = new System.Drawing.Size(176, 377);
            this.ListSupplier.TabIndex = 1;
            this.ListSupplier.UseCompatibleStateImageBehavior = false;
            this.ListSupplier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListSupplier_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhà cung cấp";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(103, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 49);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(511, 20);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(149, 49);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // TableSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 564);
            this.Controls.Add(this.panel1);
            this.Name = "TableSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.TableSupplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCateToSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoSup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNewSup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListSupplier;
        private System.Windows.Forms.DataGridView dtgvInfoSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvCateToSup;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDel;
    }
}
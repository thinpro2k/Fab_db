namespace ManageFabric
{
    partial class TableCategory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listCate = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvCatefromSup = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvCate = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNewCate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatefromSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCate)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listCate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 421);
            this.panel2.TabIndex = 1;
            // 
            // listCate
            // 
            this.listCate.HideSelection = false;
            this.listCate.Location = new System.Drawing.Point(17, 32);
            this.listCate.Name = "listCate";
            this.listCate.Size = new System.Drawing.Size(176, 377);
            this.listCate.TabIndex = 1;
            this.listCate.UseCompatibleStateImageBehavior = false;
            this.listCate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listCate_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvCatefromSup);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtgvCate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(230, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 421);
            this.panel3.TabIndex = 2;
            // 
            // dtgvCatefromSup
            // 
            this.dtgvCatefromSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCatefromSup.Location = new System.Drawing.Point(9, 195);
            this.dtgvCatefromSup.Name = "dtgvCatefromSup";
            this.dtgvCatefromSup.RowTemplate.Height = 24;
            this.dtgvCatefromSup.Size = new System.Drawing.Size(871, 213);
            this.dtgvCatefromSup.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin từ nhà cung cấp";
            // 
            // dtgvCate
            // 
            this.dtgvCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCate.Location = new System.Drawing.Point(5, 34);
            this.dtgvCate.Name = "dtgvCate";
            this.dtgvCate.RowTemplate.Height = 24;
            this.dtgvCate.Size = new System.Drawing.Size(876, 116);
            this.dtgvCate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNewCate);
            this.panel4.Location = new System.Drawing.Point(14, 445);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 91);
            this.panel4.TabIndex = 3;
            // 
            // btnNewCate
            // 
            this.btnNewCate.Location = new System.Drawing.Point(22, 19);
            this.btnNewCate.Name = "btnNewCate";
            this.btnNewCate.Size = new System.Drawing.Size(156, 55);
            this.btnNewCate.TabIndex = 0;
            this.btnNewCate.Text = "Thêm ";
            this.btnNewCate.UseVisualStyleBackColor = true;
            this.btnNewCate.Click += new System.EventHandler(this.btnNewCate_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDel);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Location = new System.Drawing.Point(241, 445);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(880, 85);
            this.panel5.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(549, 22);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(149, 49);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(97, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 49);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(726, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(371, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 49);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TableCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 548);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "TableCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableCategory";
            this.Load += new System.EventHandler(this.TableCategorys_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatefromSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCate)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNewCate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dtgvCatefromSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvCate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReset;
    }
}
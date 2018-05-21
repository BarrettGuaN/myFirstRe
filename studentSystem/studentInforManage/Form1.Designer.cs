namespace 学生信息管理
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelbyNo = new System.Windows.Forms.Button();
            this.btnSelAll = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(551, 78);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(475, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(399, 78);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnSelbyNo);
            this.groupBox1.Controls.Add(this.btnSelAll);
            this.groupBox1.Controls.Add(this.txtDept);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbSex);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnSelbyNo
            // 
            this.btnSelbyNo.Location = new System.Drawing.Point(323, 78);
            this.btnSelbyNo.Name = "btnSelbyNo";
            this.btnSelbyNo.Size = new System.Drawing.Size(75, 23);
            this.btnSelbyNo.TabIndex = 12;
            this.btnSelbyNo.Text = "按学号查询";
            this.btnSelbyNo.UseVisualStyleBackColor = true;
            this.btnSelbyNo.Click += new System.EventHandler(this.btnSelbyNo_Click);
            // 
            // btnSelAll
            // 
            this.btnSelAll.Location = new System.Drawing.Point(247, 78);
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelAll.TabIndex = 11;
            this.btnSelAll.Text = "查询全部";
            this.btnSelAll.UseVisualStyleBackColor = true;
            this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(80, 80);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(152, 21);
            this.txtDept.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "所在系：";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(396, 29);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(82, 20);
            this.cmbSex.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(559, 29);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(70, 21);
            this.txtAge.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "学生年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "学生性别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(245, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(70, 21);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "学生姓名：";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(94, 29);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(70, 21);
            this.txtNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生学号：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(645, 330);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "学生信息管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelbyNo;
        private System.Windows.Forms.Button btnSelAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtNo;
        public System.Windows.Forms.TextBox txtDept;
        public System.Windows.Forms.ComboBox cmbSex;
        public System.Windows.Forms.TextBox txtAge;
        public System.Windows.Forms.TextBox txtName;
    }
}


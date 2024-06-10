namespace csharp_tinhcvdthinhtron
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
            this.btndientich = new System.Windows.Forms.Button();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.lblbankinh = new System.Windows.Forms.Label();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbchuvi = new System.Windows.Forms.CheckBox();
            this.cbdientich = new System.Windows.Forms.CheckBox();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.btnloai1 = new System.Windows.Forms.Button();
            this.btnloai2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(92, 301);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(75, 23);
            this.btndientich.TabIndex = 0;
            this.btndientich.Text = "diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(92, 211);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 1;
            this.btnchuvi.Text = "chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // lblbankinh
            // 
            this.lblbankinh.AutoSize = true;
            this.lblbankinh.Location = new System.Drawing.Point(66, 51);
            this.lblbankinh.Name = "lblbankinh";
            this.lblbankinh.Size = new System.Drawing.Size(50, 13);
            this.lblbankinh.TabIndex = 2;
            this.lblbankinh.Text = "bán kính";
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(172, 48);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(100, 20);
            this.txtbankinh.TabIndex = 3;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(66, 116);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 4;
            this.lblkq.Text = "kết quả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Location = new System.Drawing.Point(367, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 186);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbdientich);
            this.groupBox2.Controls.Add(this.cbchuvi);
            this.groupBox2.Location = new System.Drawing.Point(566, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 183);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chọn chức năng";
            // 
            // cbchuvi
            // 
            this.cbchuvi.AutoSize = true;
            this.cbchuvi.Location = new System.Drawing.Point(43, 30);
            this.cbchuvi.Name = "cbchuvi";
            this.cbchuvi.Size = new System.Drawing.Size(55, 17);
            this.cbchuvi.TabIndex = 0;
            this.cbchuvi.Text = "chu vi";
            this.cbchuvi.UseVisualStyleBackColor = true;
            // 
            // cbdientich
            // 
            this.cbdientich.AutoSize = true;
            this.cbdientich.Location = new System.Drawing.Point(43, 83);
            this.cbdientich.Name = "cbdientich";
            this.cbdientich.Size = new System.Drawing.Size(68, 17);
            this.cbdientich.TabIndex = 1;
            this.cbdientich.Text = "diện tích";
            this.cbdientich.UseVisualStyleBackColor = true;
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(28, 32);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(55, 17);
            this.rdbchuvi.TabIndex = 0;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "Chu vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            this.rdbchuvi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(28, 85);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(67, 17);
            this.rdbdientich.TabIndex = 1;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "diện tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // btnloai1
            // 
            this.btnloai1.Location = new System.Drawing.Point(367, 269);
            this.btnloai1.Name = "btnloai1";
            this.btnloai1.Size = new System.Drawing.Size(75, 23);
            this.btnloai1.TabIndex = 7;
            this.btnloai1.Text = "tính loại 1";
            this.btnloai1.UseVisualStyleBackColor = true;
            this.btnloai1.Click += new System.EventHandler(this.btnloai1_Click);
            // 
            // btnloai2
            // 
            this.btnloai2.Location = new System.Drawing.Point(609, 269);
            this.btnloai2.Name = "btnloai2";
            this.btnloai2.Size = new System.Drawing.Size(75, 23);
            this.btnloai2.TabIndex = 8;
            this.btnloai2.Text = "tính loại 2";
            this.btnloai2.UseVisualStyleBackColor = true;
            this.btnloai2.Click += new System.EventHandler(this.btnloai2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnloai2);
            this.Controls.Add(this.btnloai1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.lblbankinh);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.btndientich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbdientich;
        private System.Windows.Forms.CheckBox cbchuvi;
        private System.Windows.Forms.Button btnloai1;
        private System.Windows.Forms.Button btnloai2;
    }
}


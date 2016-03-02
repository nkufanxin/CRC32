namespace CRC32
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
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("frame control(2 Bytes)");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Duration/ID(2 Bytes)");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("address1(6 Bytes)");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("address2(6 Bytes)");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("address3(6 Bytes)");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("address4(6 Bytes)");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Sequence control(2 Bytes)");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Mac header(24 Bytes)", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("frame body(0-2312 Bytes)");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("FCS(4 Bytes)");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("frame 802.11", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53,
            treeNode54});
            this.load_file_btn = new System.Windows.Forms.Button();
            this.frame_idx_lable = new System.Windows.Forms.Label();
            this.frame_body_show_box = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_file_btn
            // 
            this.load_file_btn.Location = new System.Drawing.Point(159, 48);
            this.load_file_btn.Name = "load_file_btn";
            this.load_file_btn.Size = new System.Drawing.Size(75, 23);
            this.load_file_btn.TabIndex = 0;
            this.load_file_btn.Text = "Load File";
            this.load_file_btn.UseVisualStyleBackColor = true;
            this.load_file_btn.Click += new System.EventHandler(this.load_file_btn_Click_1);
            // 
            // frame_idx_lable
            // 
            this.frame_idx_lable.AutoSize = true;
            this.frame_idx_lable.Location = new System.Drawing.Point(27, 54);
            this.frame_idx_lable.Name = "frame_idx_lable";
            this.frame_idx_lable.Size = new System.Drawing.Size(71, 12);
            this.frame_idx_lable.TabIndex = 9;
            this.frame_idx_lable.Text = "Frame (0/0)";
            this.frame_idx_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // frame_body_show_box
            // 
            this.frame_body_show_box.Location = new System.Drawing.Point(14, 93);
            this.frame_body_show_box.Multiline = true;
            this.frame_body_show_box.Name = "frame_body_show_box";
            this.frame_body_show_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.frame_body_show_box.Size = new System.Drawing.Size(220, 233);
            this.frame_body_show_box.TabIndex = 8;
            this.frame_body_show_box.TextChanged += new System.EventHandler(this.frame_body_show_box_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(15, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(6, 332);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(39, 23);
            this.prev_btn.TabIndex = 8;
            this.prev_btn.Text = "prev";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(148, 332);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(39, 23);
            this.next_btn.TabIndex = 9;
            this.next_btn.Text = "next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frame_idx_lable);
            this.groupBox2.Controls.Add(this.frame_body_show_box);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.load_file_btn);
            this.groupBox2.Location = new System.Drawing.Point(246, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 368);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "GO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.next_btn);
            this.groupBox1.Controls.Add(this.prev_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(35, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 368);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Frame";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 20);
            this.treeView1.Name = "treeView1";
            treeNode45.Name = "fc";
            treeNode45.Text = "frame control(2 Bytes)";
            treeNode46.Name = "di";
            treeNode46.Text = "Duration/ID(2 Bytes)";
            treeNode47.Name = "add1";
            treeNode47.Text = "address1(6 Bytes)";
            treeNode48.Name = "add2";
            treeNode48.Text = "address2(6 Bytes)";
            treeNode49.Name = "add3";
            treeNode49.Text = "address3(6 Bytes)";
            treeNode50.Name = "add4";
            treeNode50.Text = "address4(6 Bytes)";
            treeNode51.Name = "sc";
            treeNode51.Text = "Sequence control(2 Bytes)";
            treeNode52.Name = "header";
            treeNode52.Text = "Mac header(24 Bytes)";
            treeNode53.Name = "framebody";
            treeNode53.Text = "frame body(0-2312 Bytes)";
            treeNode54.Name = "FCS";
            treeNode54.Text = "FCS(4 Bytes)";
            treeNode55.Name = "treenoderoot";
            treeNode55.Text = "frame 802.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode55});
            this.treeView1.Size = new System.Drawing.Size(181, 298);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "/0";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "802.11 data frame";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_file_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox frame_body_show_box;
        private System.Windows.Forms.Label frame_idx_lable;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
    }
}


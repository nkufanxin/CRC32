using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRC32
{
    public partial class Form1 : Form
    {
        //实例化CRC32类
        CRC32 crc = new CRC32();
        int frame_idx = 0;
        public Form1()
        {
            InitializeComponent();
            treeView1.ExpandAll();
            textBox1.Text = "[Click button to Choose data file]";
            textBox1.ReadOnly = true;            
        }

        private void load_file_btn_Click(object sender, EventArgs e)
        {
           

        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //TreeView构建
            if (treeView1.SelectedNode.Name == "fc")
                frame_body_show_box.Text = "6c3f";
            if (treeView1.SelectedNode.Name == "di")
                frame_body_show_box.Text = "5a56";
            if (treeView1.SelectedNode.Name == "add1")
                frame_body_show_box.Text = "3e:45:7f:23:9a:33";
            if (treeView1.SelectedNode.Name == "add2")
                frame_body_show_box.Text = "15:a2:f5:d3:12:56";
            if (treeView1.SelectedNode.Name == "add3")
                frame_body_show_box.Text = "57:1a:69:fa:c5:1b";
            if (treeView1.SelectedNode.Name == "add4")
                frame_body_show_box.Text = "35:d0:b7:4d:f3:9b";
            if (treeView1.SelectedNode.Name == "sc")
            {
                frame_body_show_box.Text = "000"+(frame_idx+1).ToString();
            }
            if (treeView1.SelectedNode.Name == "FCS")
                frame_body_show_box.Text = "0x04c11db7";
            if (treeView1.SelectedNode.Name == "framebody")
            {
                frame_body_show_box.Text = crc.frameBody_list[frame_idx] + crc.crc32Code_list[frame_idx];
                frame_idx_lable.Text = "Frame" + "(" + (frame_idx + 1) + "/" + crc.crc32Code_list.Count + ")";
            }
            
        }
        
        private void next_btn_Click(object sender, EventArgs e)
        {
            //翻到下一个帧
            
            int n = crc.crc32Code_list.Count;
            if (n >= 2)
            {
                if (frame_idx + 1 < n )
                {
                    frame_idx++;
                    prev_btn.Enabled = true;
                    frame_body_show_box.Text = crc.frameBody_list[frame_idx] + crc.crc32Code_list[frame_idx];
                    frame_idx_lable.Text = "Frame("  + (frame_idx + 1) + "/" + crc.crc32Code_list.Count + ")";
                    textBox2.Text = Convert.ToString(frame_idx + 1);
                }
                else
                    next_btn.Enabled = false;
            }
        }
        
        private void prev_btn_Click(object sender, EventArgs e)
        {
            //返回上一个帧
            int n = crc.crc32Code_list.Count;
            if (n >= 2)
            {
                if (frame_idx + 1 > 1)
                {
                    frame_idx--;
                    next_btn.Enabled = true;
                    frame_body_show_box.Text =  crc.frameBody_list[frame_idx] + crc.crc32Code_list[frame_idx];
                    frame_idx_lable.Text = "Frame(" + (frame_idx + 1) + "/" + crc.crc32Code_list.Count + ")";
                    textBox2.Text = Convert.ToString(frame_idx + 1);

                }
                else
                    prev_btn.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void load_file_btn_Click_1(object sender, EventArgs e)
        {
            //读取文件
            string filename = "input.txt";
            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Filter = "text file|*.txt";
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                filename = open_file.FileName;
                textBox1.Text = filename;
            }
            crc.CRC32_cleanUp();
            frame_idx = 0;
            //分段，转化为ASCII码，结果存入crc.frameBody_list数组中
            //计算每段的CRC32校验码，结果存入crc.crc32Code_list数组中
            UInt32 crc_value = crc.calc_text_crc(filename);
            frame_body_show_box.Text = crc.frameBody_list[frame_idx] + crc.crc32Code_list[frame_idx];
            frame_idx_lable.Text = "Frame" + "(" + (frame_idx + 1) + "/" + crc.crc32Code_list.Count + ")";
            textBox2.Text = Convert.ToString(frame_idx + 1);
            
  
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frame_body_show_box_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "/" + Convert.ToString(crc.crc32Code_list.Count);
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //跳转到文本框中数字指向的那个帧
            
            string textstring = textBox2.Text;
            if (textstring.Length!=0)
            {
                frame_idx = int.Parse(textstring);
                --frame_idx;
                int n = crc.crc32Code_list.Count;

                if (frame_idx  >= 0 && frame_idx <= crc.crc32Code_list.Count-1)
                {
                    frame_body_show_box.Text = crc.frameBody_list[frame_idx] + crc.crc32Code_list[frame_idx];
                    frame_idx_lable.Text = "Frame(" + (frame_idx + 1) + "/" + crc.crc32Code_list.Count + ")";
                }
                else 
                {
                    frame_idx = 3;
                    frame_body_show_box.Text = crc.frameBody_list[frame_idx] + crc.crc32Code_list[frame_idx];
                    frame_idx_lable.Text = "Frame(" + (frame_idx + 1) + "/" + crc.crc32Code_list.Count + ")";
                }
            

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "/"+Convert.ToString(crc.crc32Code_list.Count);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

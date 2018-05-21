using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selectCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//添加课程功能
        {
            bool exit = false;

            if (textBox1.Text=="")
            {
                MessageBox.Show("添加课程不能为空");
                exit = true;
            }
            else
                for(int i=0;i<listBox1.Items.Count;i++)
                {
                    if(textBox1.Text==listBox1.Items[i].ToString())
                    {
                        MessageBox.Show("添加课程不能重复");
                        exit = true;
                        textBox1.Clear();
                        break;
                    }
                }    
            
            if(!exit)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i=listBox1.SelectedItems.Count;i>0;i--)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[i-1].ToString());
                    listBox1.Items.Remove(listBox1.SelectedItems[i-1].ToString());
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("选课不正确！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = listBox2.SelectedItems.Count; i > 0; i--)
                {
                    listBox1.Items.Add(listBox2.SelectedItems[i - 1].ToString());
                    listBox2.Items.Remove(listBox2.SelectedItems[i - 1].ToString());
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i= 0;i < listBox1.Items.Count;i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
            }
            listBox2.Items.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                button1.PerformClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "已选课程：";
            for (int i = 0; i < listBox2.Items.Count; i++)
                 textBox2.Text +=  " "+listBox2.Items[i];
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("CPU");
                    listBox1.Items.Add("显卡");
                    listBox1.Items.Add("主板");
                    listBox1.Items.Add("电源");
                    listBox1.Items.Add("内存");
                    listBox1.Items.Add("硬盘");
                    break;
                case 1:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("键盘");
                    listBox1.Items.Add("鼠标");
                    listBox1.Items.Add("耳机");
                    listBox1.Items.Add("显示器");
                    listBox1.Items.Add("手柄");
                    listBox1.Items.Add("摇杆");
                    break;
                case 2:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("《上海堡垒》");
                    listBox1.Items.Add("《此间的少年》");
                    listBox1.Items.Add("《奔跑吧，梅洛斯》");
                    listBox1.Items.Add("《起风了》");
                    listBox1.Items.Add("《黄金时代》");

                    break;
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            bool exit = false;
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                if (comboBox2.Items[i].ToString() == comboBox2.Text)
                    exit = true;
            }
            if (!exit)
                comboBox2.Items.Add(comboBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = listBox1.SelectedItems.Count; i > 0; i--)
                {
                    bool exit = false;
                    for (int j=0;j<listBox2.Items.Count;j++)
                    {
                        if (listBox1.SelectedItems[i-1] == listBox2.Items[j])
                            exit = true;
                    }
                    if(!exit)
                        listBox2.Items.Add(listBox1.SelectedItems[i - 1].ToString());
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = listBox2.SelectedItems.Count; i > 0; i--)
                {
                    listBox2.Items.Remove(listBox2.SelectedItems[i - 1].ToString());
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.Items.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userName = comboBox2.Text;
            string userNum = textBox2.Text;

            string items = "";
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
                items += listBox2.SelectedItems[i] + " ";

            string payment = "";
            {
                if (radioButton1.Checked)
                    payment = radioButton1.Text;
                if (radioButton2.Checked)
                    payment = radioButton2.Text;
                if (radioButton3.Checked)
                    payment = radioButton3.Text;
                if (radioButton4.Checked)
                    payment = radioButton4.Text;
                if (radioButton5.Checked)
                    payment = radioButton5.Text;
                if (radioButton6.Checked)
                    payment = radioButton6.Text;
            }

            string confirm = "";
            {
                if (checkBox1.Checked)
                    confirm += checkBox1.Text + " ";
                if (checkBox2.Checked)
                    confirm += checkBox2.Text + " ";
                if (checkBox3.Checked)
                    confirm += checkBox3.Text + " ";
            }

            textBox3.Text = "客户姓名：" + userName +"\r\n"+ 
                "电话：" + userNum + "\r\n" +
                "已选商品：" + items + "\r\n" +
                "支付方式：" + payment +"\r\n"+
                "确认方式：" + confirm;
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}

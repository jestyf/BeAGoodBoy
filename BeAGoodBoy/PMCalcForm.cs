/*
 * file: PMCalcForm.cs
 * brief: 加减(PM,Plus&Minus)计算出题工具
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeAGoodBoy
{
    public partial class PMCalcForm : Form
    {
        private int item_num;
        private int digits_num;
        private int num_range;
        private Random random;


        public PMCalcForm()
        {
            this.item_num = 50;
            this.digits_num = 3;
            this.num_range = 100;
            random = new Random();
            InitializeComponent();
        }

        private void PMCalcForm_Load(object sender, EventArgs e)
        {
            this.ProgressBar.Visible = false;
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Maximum = 100;
            this.ProgressBar.Value = 0;
            this.ItemNums.Text = this.item_num.ToString();
            this.DigitsBox.Items.Add("10以内");
            this.DigitsBox.Items.Add("100以内");
            this.DigitsBox.Items.Add("1000以内");
            this.NumberBox.Items.Add("2");
            this.NumberBox.Items.Add("3");
            this.NumberBox.Items.Add("4");
            this.DigitsBox.SelectedIndex = 1;
            this.NumberBox.SelectedIndex = 1;
        }

        private void A10_Click(object sender, EventArgs e)
        {
            this.item_num += 10;
            this.ItemNums.Text = this.item_num.ToString();
        }

        private void D10_Click(object sender, EventArgs e)
        {
            if (this.item_num - 10 > 0)
            {
                this.item_num -= 10;
                this.ItemNums.Text = this.item_num.ToString();
            }
            
        }

        private void ItemNums_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.item_num = Convert.ToInt32(this.ItemNums.Text);
            }
            catch
            {
                ;
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            this.ProgressBar.Visible = true;
            FileWriter fw = new FileWriter();
            for (int i = 0; i < this.item_num; i++)
            {
                switch (this.digits_num)
                {
                    case 2:
                        fw.WriteProblem(i, PMProblemGenerator.Generate2(this.num_range));
                        break;
                    case 3:
                        fw.WriteProblem(i, PMProblemGenerator.Generate3(this.num_range));
                        break;
                    case 4:
                        fw.WriteProblem(i, PMProblemGenerator.Generate4(this.num_range));
                        break;
                    default:
                        break;
                }
                
                this.ProgressBar.Value = (int)(100 * (i + 1) / this.item_num);
            }
            fw.CloseFile();
            MessageBox.Show("已生成，题目与答案保存在当前文件夹下！", "提示！");
            this.ProgressBar.Visible = false;
            this.ProgressBar.Value = 0;
        }

        private void DigitsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.DigitsBox.SelectedIndex)
            {
                case 0:
                    this.num_range = 10;
                    break;
                case 1:
                    this.num_range = 100;
                    break;
                case 2:
                    this.num_range = 1000;
                    break;
                default:
                    break;
            }
        }

        private void NumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.digits_num = this.NumberBox.SelectedIndex + 2;
        }
    }
}

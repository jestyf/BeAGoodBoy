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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.Show();
        }

        private void PMBtn_Click(object sender, EventArgs e)
        {
            PMCalcForm f = new PMCalcForm();
            f.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void MDBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者还没来得及实现这个功能！请等待！", "提示");
        }

        private void MixBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者还没来得及实现这个功能！请等待！", "提示");
        }
    }
}

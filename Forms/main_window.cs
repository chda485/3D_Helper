using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace _3D_helper
{
    public partial class MainWindow : Form
    {
        protected utils helper = new utils();
        protected int num;
        protected int stack_num;
        protected bool third_line = false;
        protected bool forth_line = false;
        public MainWindow()
        {
            InitializeComponent();
            Graphics g = Graphics.FromImage(pictureBox1.BackgroundImage);
            g.DrawString("Справочник 3D-печатника", new System.Drawing.Font("Times New Roman", 34, FontStyle.Bold), Brushes.Blue, 140, 8);
            this.home_button.Visible = false;
            this.nextp_button.Visible = false;
            this.prevp_button.Visible = false;
        }

        internal void Modeling_button_Click(object sender, EventArgs e)
        {
            modeling_win m_win = new modeling_win(helper.stack_range[this.Name][0]);
            m_win.Show();
            this.Hide();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Printing_button_Click(object sender, EventArgs e)
        {
            printing_windows p_win = new printing_windows(helper.stack_range[this.Name][0]);
            p_win.Show();
            this.Hide();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            helper.ShowMain(this);
        }

        private void Nextp_button_Click(object sender, EventArgs e)
        {
            helper.ShowPrev(this.num, this);
        }
    }
}

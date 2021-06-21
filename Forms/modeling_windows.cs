using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_helper
{
    public partial class modeling_win : _3D_helper.MainWindow
    {
        public modeling_win(int Code)
        {
            InitializeComponent();
            this.num = Code;
            this.label4.Visible = false;
            this.printing_button.Visible = false;
            this.modeling_button.Visible = false;
            this.home_button.Visible = true;
            this.inscription.Text = "3D-моделирование";
            if (helper.isThird(this.num) == true)
            {
                this.nextp_button.Visible = true;
            }
            else this.nextp_button.Visible = false;
            this.prevp_button.Visible = false;
        }

        private void Formats_button_Click(object sender, EventArgs e)
        {
            formats_win formats = new formats_win(helper.stack_range[this.Name][0]);
            formats.Show();
            this.Close();
        }
        private void Programms_button_Click(object sender, EventArgs e)
        {
            programs_win programs = new programs_win(helper.stack_range[this.Name][0]);
            programs.Show();
            this.Close();
        }

        private void Links_model_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("", "links_modeling", helper.stack_range[this.Name][0], this, 5);
        }
    }
}

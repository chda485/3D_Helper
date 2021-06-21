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
    public partial class slicers_win : _3D_helper.MainWindow
    {
        public slicers_win(int code)
        {
            InitializeComponent();
            this.num = code;
            this.label4.Visible = false;
            this.printing_button.Visible = false;
            this.modeling_button.Visible = false;
            this.home_button.Visible = true;
            this.inscription.Text = "Программы слайсеры";
            this.prevp_button.Visible = true;
            if (this.forth_line == true)
            {
                this.nextp_button.Visible = true;
            }
            this.third_line = true;
        }

        private void Slicer_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("3D Slicers", "dslicer_win", helper.stack_range[this.Name][0], this, 2);
        }

        private void Materialize_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Materialize Mimics", "materialize_win", helper.stack_range[this.Name][0], this, 2);
        }

        private void Mevislab_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("MeVisLab", "mevislab_win", helper.stack_range[this.Name][0], this, 2);
        }

        private void Invesalius_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("inVesalius", "invesalius_win", helper.stack_range[this.Name][0], this, 2);
        }

        private void Gimias_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("GIMIAS", "gimias_win", helper.stack_range[this.Name][0], this, 2);
        }

        private void Osirix_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("OsiriX", "osirix_win", helper.stack_range[this.Name][0], this, 2);
        }

        private void Prevp_button_Click(object sender, EventArgs e)
        {
            helper.ShowPrev(2, this);
        }
    }
}

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
    public partial class programs_win : _3D_helper.MainWindow
    {
        public programs_win(int code)
        {
            InitializeComponent();
            this.num = code;
            this.label4.Visible = false;
            this.printing_button.Visible = false;
            this.modeling_button.Visible = false;
            this.home_button.Visible = true;
            this.inscription.Text = "Программы для 3D-моделирования";
            this.prevp_button.Visible = true;
            if (helper.isForth(this.num) == true)
            {
                this.nextp_button.Visible = true;
            }
        }

        private void Solidworks_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("SolidWorks", "solidworks_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Compas_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Compas 3D", "compas_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Inventor_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Inventor", "inventor_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Blender_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Blender", "blender_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Dmax_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("3D Max", "dmax_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Maya_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Maya", "maya_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Nx_utton_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("NX", "nx_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Solidedge_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("SolidEdge", "solidedge_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Cinema_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Cinema 4D", "cinema_win", helper.stack_range[this.Name][0], this, 3);
        }

        private void Prevp_button_Click(object sender, EventArgs e)
        {
            helper.ShowPrev(1, this);
        }
    }
}

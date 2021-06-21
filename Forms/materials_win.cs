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
    public partial class materials_win : _3D_helper.MainWindow
    {
        public materials_win(int code)
        {
            InitializeComponent();
            this.num = code;
            this.label4.Visible = false;
            this.printing_button.Visible = false;
            this.modeling_button.Visible = false;
            this.home_button.Visible = true;
            this.inscription.Text = "Материалы для 3D-печати";
            this.prevp_button.Visible = true;
            if (this.forth_line == true)
            {
                this.nextp_button.Visible = true;
            }
            this.third_line = true;
        }

        private void Abs_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("ABS", "abs_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Pla_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("PLA", "pla_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Neylon_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Neylon", "neylon_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Psu_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("PSU", "psu_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Silicon_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Silicon", "silicon_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Hips_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("HIPS", "hips_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Petg_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("PETG", "petg_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Pp_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("PP", "pp_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Titan_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Titan", "titan_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Photop_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Фотополимеры", "photop_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Pva_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("PVA", "pva_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Tpe_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("TPE", "tpe_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Peek_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("PEEK", "peek_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Flex_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("FLEX", "flex_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Pc_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("PC", "pc_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Abs_pc_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("ABS-PC", "absPc_win", helper.stack_range[this.Name][0], this, 4);
        }

        private void Prevp_button_Click(object sender, EventArgs e)
        {
            helper.ShowPrev(2, this);
        }
    }
}

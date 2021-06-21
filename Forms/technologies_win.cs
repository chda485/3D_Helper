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
    public partial class technologies_win : _3D_helper.MainWindow
    {
        public technologies_win(int code)
        {
            InitializeComponent();
            this.num = code;
            this.label4.Visible = false;
            this.printing_button.Visible = false;
            this.modeling_button.Visible = false;
            this.home_button.Visible = true;
            this.inscription.Text = "Технологии 3D-печати";
            this.prevp_button.Visible = true;
            if (helper.isForth(this.num) == true)
            {
                this.nextp_button.Visible = true;
            }
        }

        private void Fdm_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("FDM-технология", "fdm_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void Sla_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Лазерная стереолитография", "sla_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void Polyjet_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("PolyJet-технология", "polyjet_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void Dlms_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Прямое лазерное спекание", "dlms_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void Lom_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("LOM-технология", "lom_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void Mjm_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("MJM-технология", "mjm_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void Sls_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Селективное лазерное спекание", "sls_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void DP_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("3DP-технология", "dp_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void Ebm_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("Электронно-лучевая плавка", "ebm_win", helper.stack_range[this.Name][0], this, 1);
        }

        private void Prevp_button_Click(object sender, EventArgs e)
        {
            helper.ShowPrev(2, this);
        }
    }
}

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
    public partial class printing_windows : _3D_helper.MainWindow
    {
        public printing_windows(int Code)
        {
            InitializeComponent();
            this.num = Code;
            this.label4.Visible = false;
            this.printing_button.Visible = false;
            this.modeling_button.Visible = false;
            this.home_button.Visible = true;
            this.inscription.Text = "3D-печать";
            if (helper.isThird(this.num) == true)
            {
                this.nextp_button.Visible = true;
            }
            else this.nextp_button.Visible = false;
            this.prevp_button.Visible = false;
        }

        private void Technologies_button_Click(object sender, EventArgs e)
        {
            technologies_win technologies = new technologies_win(helper.stack_range[this.Name][0]);
            technologies.Show();
            this.Close();
        }

        private void Slicers_button_Click(object sender, EventArgs e)
        {
            slicers_win slicers = new slicers_win(helper.stack_range[this.Name][0]);
            slicers.Show();
            this.Close();
        }

        private void Materials_button_Click(object sender, EventArgs e)
        {
            materials_win materials = new materials_win(helper.stack_range[this.Name][0]);
            materials.Show();
            this.Close();
        }

        private void Links_printing_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("", "links_printing", helper.stack_range[this.Name][0], this, 5);
        }
    }
}

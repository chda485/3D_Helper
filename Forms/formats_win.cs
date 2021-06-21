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
    public partial class formats_win : _3D_helper.MainWindow
    {
        public formats_win(int code)
        {
            InitializeComponent();
            this.num = code;
            this.label4.Visible = false;
            this.printing_button.Visible = false;
            this.modeling_button.Visible = false;
            this.home_button.Visible = true;
            this.inscription.Text = "Форматы 3D-моделей";
            this.prevp_button.Visible = true;
            if (helper.isForth(this.num) == true)
            {
                this.nextp_button.Visible = true;
            }
        }

        private void Stl_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("STL-формат", "stl_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Obj_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("OBJ-формат", "obj_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Mf_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("3MF-формат", "mf_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Vrml_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("VRML-формат", "vrml_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Step_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("STEP-формат", "step_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Iges_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("IGES-формат", "iges_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Amf_utton_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("AMF-формат", "amf_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Ds_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("3DS-формат", "ds_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Dxml_button_Click(object sender, EventArgs e)
        {
            helper.ShowTextWin("3DXML-формат", "dxml_win", helper.stack_range[this.Name][0], this, 0);
        }

        private void Prevp_button_Click(object sender, EventArgs e)
        {
            helper.ShowPrev(1, this);
        }
    }
}

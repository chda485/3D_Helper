using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace _3D_helper
{
    public partial class win_text : _3D_helper.MainWindow
    {

        public win_text(string Inscription, string Win_name, int Code, int pathNum)
        {
            InitializeComponent();
            this.num = Code;
            this.label4.Visible = false;
            this.printing_button.Visible = false;
            this.modeling_button.Visible = false;
            this.home_button.Visible = true;
            this.inscription.Text = Inscription;
            this.Name = Win_name;
            this.prevp_button.Visible = true;
            this.third_line = true;
            List<string> content;
            if (helper.stack_range[this.Name][0] == 13 || helper.stack_range[this.Name][0] == 24)
            {
                List<string> links_content = helper.Links(helper.paths[pathNum], helper.links[this.Name]);
                for (int i = 0; i < links_content.Count; i++)
                {
                    this.box_for_text.AppendText(links_content[i]);
                    this.box_for_text.AppendText("\n");
                }                   
                this.pictureBox1.Select();
            }
            else
            {
                if (helper.stack_range[this.Name][0] < 120)
                    content = helper.ReadText(helper.paths[pathNum], new int[] { helper.stack_range[this.Name][1], helper.stack_range[this.Name][2] }, Win_name.Split('_')[0]);
                else
                    content = helper.ReadText(helper.paths[pathNum], new int[] { helper.stack_range[this.Name][1], helper.stack_range[this.Name][2] });
                for (int i = 0; i < content.Count; i++)
                {
                    if (i == content.Count - 1)
                        this.box_for_text.Text = this.box_for_text.Text + "\t" + content[i];
                    else
                        this.box_for_text.Text = this.box_for_text.Text + "\t" + content[i] + "\n";
                }           
                this.box_for_text.ReadOnly = false;
                List<Image> listI = helper.ShowImages(helper.stack_range[this.Name][3], this.Name);
                foreach (Image picture in listI)
                {
                    this.box_for_text.SelectionStart = this.box_for_text.Text.Length;
                    Image img = picture;
                    Size s = img.Size;
                    double equal = (this.box_for_text.Width / (double)(img.Width));
                    s.Height = (int)(img.Height * equal);
                    s.Width = this.box_for_text.Width;
                    Bitmap img2 = new Bitmap(img, s);
                    Clipboard.SetImage(img2);
                    this.box_for_text.Paste();
                    this.box_for_text.AppendText("\n\n");
                }
                this.box_for_text.ReadOnly = true;
                if ((helper.stack_range[this.Name][0] > 120 && helper.stack_range[this.Name][0] < 200) ||
                    (helper.stack_range[this.Name][0] > 220 && helper.stack_range[this.Name][0] < 230))
                {
                    this.box_for_text.AppendText("\t\t\t\tСсылки\n");
                    List<string> links_content = helper.Links(helper.paths[pathNum], helper.links[this.Name]);
                    for (int i = 0; i < links_content.Count; i++)
                        this.box_for_text.AppendText(links_content[i]);
                }
                this.pictureBox1.Select();
            }
        }

        private void Prevp_button_Click(object sender, EventArgs e)
        {
            helper.ShowPrev(this.num, this);
        }

        private void Box_for_text_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}

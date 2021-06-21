using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Word = Microsoft.Office.Interop.Word;

namespace _3D_helper
{
    public class utils
    {
        internal Dictionary<string, int[]> stack_range = new Dictionary<string, int[]>
        {
            {"MainWindow", new int[] {0} },
            {"modeling_win", new int[] {1} }, {"printing_windows", new int[] {2} },
            {"history_modeling", new int[] {10} }, {"formats_win", new int[] {11} }, {"programs_win", new int[] {12} }, {"links_modeling", new int[] {13} },
            {"history_printing", new int[] {20} }, {"technologies_win", new int[] {21} }, {"slicers_win", new int[] {22} }, {"materials_win", new int[] {23} }, {"links_printing", new int[] {24} },
            {"stl_win", new int[] {111, 1, 26, 1} }, {"obj_win", new int[] {112, 27, 60, 1} }, {"mf_win", new int[] {113, 61, 104, 1} },
            {"vrml_win", new int[] {114, 105, 125, 1} }, {"iges_win", new int[] {116, 126, 128, 1} }, {"amf_win", new int[] {117, 129, 182, 1} },
            {"step_win", new int[] {115, 183, 205, 1} }, {"dxml_win", new int[] {119, 206, 211, 1} }, {"ds_win", new int[] {118, 211, 233, 1} }, 
            {"solidworks_win", new int[] {121, 1, 40, 4} }, {"compas_win", new int[] {122, 49, 87, 4} }, {"inventor_win", new int[] {123, 96, 130, 4} },
            {"blender_win", new int[] {124, 138, 188, 4} }, {"dmax_win", new int[] {125, 195, 252, 4} }, {"maya_win", new int[] {126, 258, 307, 4} },
            {"nx_win", new int[] {127, 312, 363, 4} }, {"solidedge_win", new int[] {128, 368, 411, 4} }, {"cinema_win", new int[] {129, 416, 442, 4} },
            {"fdm_win", new int[] {211, 1, 38, 3} }, {"sla_win", new int[] {212, 39, 60, 3} }, {"polyjet_win", new int[] {213, 61, 79, 3} },
            {"dlms_win", new int[] {214, 80, 97, 3} }, {"lom_win", new int[] {215, 98, 121, 3} }, {"mjm_win", new int[] {216, 122, 136, 3} },
            {"sls_win", new int[] {217, 137, 161, 3} }, {"dp_win", new int[] {218, 162, 183, 3} }, {"ebm_win", new int[] {219, 184, 202, 3} },           
            {"dslicer_win", new int[] {221, 1, 19, 4} }, {"materialize_win", new int[] {222, 24, 54, 4} }, {"mevislab_win", new int[] {223, 59, 87, 4} },
            {"invesalius_win", new int[] {224, 92, 114, 4} }, {"gimias_win", new int[] {225, 119, 142, 4} }, {"osirix_win", new int[] {226, 147, 159, 4} },
            {"abs_win", new int[] {231, 1, 49, 3} }, {"pla_win", new int[] {232, 50, 99, 3} }, {"neylon_win", new int[] {233, 100, 131, 3}}, {"psu_win", new int[] {234, 132, 162, 3} },
            {"silicon_win", new int[] {235, 163, 187, 3} }, {"hips_win", new int[] {236, 188, 225, 3} }, {"petg_win", new int[] {237, 226, 264, 3} },
            {"pp_win", new int[] {238, 265, 313, 3} }, {"titan_win", new int[] {239, 314, 344, 3} }, {"photop_win", new int[] {240, 345, 449, 3} }, {"pva_win", new int[] {241, 450, 469, 3} },
            {"tpe_win", new int[] {242, 470, 491, 3} }, {"peek_win", new int[] {243, 492, 528, 3} }, {"flex_win", new int[] {244, 529, 565, 3} }, {"pc_win", new int[] {245, 566, 592, 3} },
            {"absPc_win", new int[] {246, 593, 640, 3} }
        };
        internal List<string> paths = new List<string>
        {
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\docx\\форматы.docx",
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\docx\\технологии.docx",
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\docx\\слайсеры.docx",
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\docx\\по 3д-моделирование.docx",
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\docx\\материалы.docx",
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\docx\\ссылки.docx",
        };
        internal Dictionary<string, int[]> links = new Dictionary<string, int[]>
        {
            {"links_modeling", new int[] {1, 11} }, {"links_printing", new int[] {11, 21} },
            {"solidworks_win", new int[] {43, 46} }, {"compas_win", new int[] {90, 93} }, {"inventor_win", new int[] {134, 136} },
            {"blender_win", new int[] {191, 193} }, {"dmax_win", new int[] {254, 256} }, {"maya_win", new int[] {308, 310} },
            {"nx_win", new int[] {364, 366} }, {"solidedge_win", new int[] {412, 414} }, {"cinema_win", new int[] {443, 445} },
            {"dslicer_win", new int[] {20, 22} }, {"materialize_win", new int[] {55, 57} }, {"mevislab_win", new int[] {88, 90} },
            {"invesalius_win", new int[] {115, 117} }, {"gimias_win", new int[] {143, 145} }, {"osirix_win", new int[] {160, 162} }
        };
        internal void ShowMain(Form window)
        {
            MainWindow mainw = new MainWindow();
            mainw.Show();
            window.Close();
        }
        internal void ShowPrev(int ClassCode, Form this_win)
        {
            switch(ClassCode)
            {
                case 1:
                    {
                        modeling_win win = new modeling_win(stack_range[this_win.Name][0]);
                        win.Show();
                        this_win.Close();
                    }break;
                case 2:
                    {
                        printing_windows win = new printing_windows(stack_range[this_win.Name][0]);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 11:
                    {
                        formats_win win = new formats_win(stack_range[this_win.Name][0]);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 12:
                    {
                        programs_win win = new programs_win(stack_range[this_win.Name][0]);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 21:
                    {
                        technologies_win win = new technologies_win(stack_range[this_win.Name][0]);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 22:
                    {
                        slicers_win win = new slicers_win(stack_range[this_win.Name][0]);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 23:
                    {
                        materials_win win = new materials_win(stack_range[this_win.Name][0]);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 111:
                    {
                        win_text win = new win_text("STL-формат", "stl_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 112:
                    {
                        win_text win = new win_text("OBJ-формат", "obj_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 113:
                    {
                        win_text win = new win_text("3MF-формат", "mf_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 114:
                    {
                        win_text win = new win_text("VRML-формат", "vrml_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 115:
                    {
                        win_text win = new win_text("STEP-формат", "step_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 116:
                    {
                        win_text win = new win_text("IGES-формат", "iges_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 117:
                    {
                        win_text win = new win_text("AMF-формат", "amf_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 118:
                    {
                        win_text win = new win_text("3DS-формат", "ds_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 119:
                    {
                        win_text win = new win_text("3DXML-формат", "dxml_win", stack_range[this_win.Name][0], 0);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 121:
                    {
                        win_text win = new win_text("SolidWorks", "solidworks_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 122:
                    {
                        win_text win = new win_text("Compas 3D", "compas_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 123:
                    {
                        win_text win = new win_text("Inventor", "inventor_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 124:
                    {
                        win_text win = new win_text("Blender", "blender_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 125:
                    {
                        win_text win = new win_text("3D Max", "dmax_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 126:
                    {
                        win_text win = new win_text("Maya", "maya_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 127:
                    {
                        win_text win = new win_text("NX", "nx_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 128:
                    {
                        win_text win = new win_text("SolidEdge", "solidedge_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 129:
                    {
                        win_text win = new win_text("Cinema 4D", "cinema_win", stack_range[this_win.Name][0], 3);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 211:
                    {
                        win_text win = new win_text("Cinema 4D", "fdm_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 212:
                    {
                        win_text win = new win_text("Лазерная стереолитография", "sla_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 213:
                    {
                        win_text win = new win_text("PolyJet-технология", "polyjet_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 214:
                    {
                        win_text win = new win_text("Прямое лазерное спекание", "dlms_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 215:
                    {
                        win_text win = new win_text("LOM-технология", "lom_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 216:
                    {
                        win_text win = new win_text("MJM-технология", "mjm_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 217:
                    {
                        win_text win = new win_text("Селективное лазерное спекание", "sls_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 218:
                    {
                        win_text win = new win_text("3DP-технология", "dp_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 219:
                    {
                        win_text win = new win_text("Электронно-лучевая плавка", "ebm_win", stack_range[this_win.Name][0], 1);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 221:
                    {
                        win_text win = new win_text("3D Slicers", "dslicer_win", stack_range[this_win.Name][0], 2);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 222:
                    {
                        win_text win = new win_text("Materialize Mimics", "materialize_win", stack_range[this_win.Name][0], 2);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 223:
                    {
                        win_text win = new win_text("MeVisLab", "mevislab_win", stack_range[this_win.Name][0], 2);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 224:
                    {
                        win_text win = new win_text("inVesalius", "invesalius_win", stack_range[this_win.Name][0], 2);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 225:
                    {
                        win_text win = new win_text("GIMIAS", "gimias_win", stack_range[this_win.Name][0], 2);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 226:
                    {
                        win_text win = new win_text("OsiriX", "osirix_win", stack_range[this_win.Name][0], 2);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 231:
                    {
                        win_text win = new win_text("ABS", "abs_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 232:
                    {
                        win_text win = new win_text("PLA", "pla_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 233:
                    {
                        win_text win = new win_text("Neylon", "neylon_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 234:
                    {
                        win_text win = new win_text("PSU", "psu_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 235:
                    {
                        win_text win = new win_text("Silicon", "silicon_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 236:
                    {
                        win_text win = new win_text("HIPS", "hips_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 237:
                    {
                        win_text win = new win_text("PETG", "petg_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 238:
                    {
                        win_text win = new win_text("PP", "pp_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 239:
                    {
                        win_text win = new win_text("Titan", "titan_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 240:
                    {
                        win_text win = new win_text("Фотополимеры", "photop_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 241:
                    {
                        win_text win = new win_text("PVA", "pva_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 242:
                    {
                        win_text win = new win_text("TPE", "tpe_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 243:
                    {
                        win_text win = new win_text("PEEK", "peek_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 244:
                    {
                        win_text win = new win_text("FLEX", "flex_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 245:
                    {
                        win_text win = new win_text("PC", "pc_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
                case 246:
                    {
                        win_text win = new win_text("ABS-PC", "absPc_win", stack_range[this_win.Name][0], 4);
                        win.Show();
                        this_win.Close();
                    }
                    break;
            }
        }
        internal List<Image> ShowImages(int length, string name)
        {
            List<Image> listI = new List<Image>();
            if (length == 1)
            {
                listI.Add((Image)(Properties.Resources.ResourceManager.GetObject(name.Split('_')[0])));
                return listI;
            }
            int i = 1;
            while(i <= length)
            {
                listI.Add((Image)(Properties.Resources.ResourceManager.GetObject(name.Split('_')[0]+"_" + i.ToString())));
                i++;
            }
            return listI;
        }
        internal void ShowTextWin(string inscription, string stack, int code, Form win, int pathNum)
        {
            win_text text_win = new win_text(inscription, stack, code, pathNum);
            text_win.Show();
            win.Close();
        }
        internal bool isForth(int code) => code > 100 ? true : false;
        internal bool isThird(int code) => code < 100 && code >= 10 ? true : false;
        internal List<string> ReadText(object docPath, int[] range, string format=null)
        {
            List<string> list = new List<string>();
            Word.Application app = new Word.Application();
            app.Documents.Open(ref docPath, ReadOnly:true);
            Word.Document doc = app.ActiveDocument;
            app.Visible = false;
            for(int i = range[0]; i <= range[1]; i++)
            {
                    
                list.Add(doc.Paragraphs[i].Range.Text);
            }
            if (format != null)
                list.Add("\n\tПример модели в " + format + "-формате\n");
            doc.Close();
            app.Quit();
            return list;
        }
        internal List<string> Links(object docPath, int[] range)
        {
            List<string> links = new List<string>();
            Word.Application app = new Word.Application();
            app.Documents.Open(ref docPath, ReadOnly: true);
            Word.Document doc = app.ActiveDocument;
            app.Visible = false;
            int i = range[0];
            while(i != range[1])
            {
                links.Add(doc.Paragraphs[i].Range.Text);
                i++;
            }
            doc.Close();
            app.Quit();
            return links;
        }
    }
}

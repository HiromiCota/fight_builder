using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_builder
{
    public partial class fight_builder_main : Form
    {
        public fight_builder_main()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fight_builder_main_Load(object sender, EventArgs e)
        {
            //Load up those combo boxes!
            loadBox(cboAct1Limb, typeof(Limb));
            loadBox(cboAct2Limb, typeof(Limb));
            loadBox(cboAct1AttOptions, typeof(Modifier));
            loadBox(cboAct2AttOptions, typeof(Modifier));
        }

        private static void loadBox(ComboBox box, Type type)
        {
            foreach (var item in Enum.GetValues(type))
                box.Items.Add(item);
        }
    }
}

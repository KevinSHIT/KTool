using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTool.View
{
    public partial class CpuCoreControl : MaterialForm
    {
        public CpuCoreControl()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE
                );
            txbNum.Hint = "Interger Only";
        }

        private void ckbEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEnable.Checked)
            {
                txbNum.Enabled = true;
            }
            else
            {
                txbNum.Enabled = false;
            }
        }
    }
}

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

using KTool.Controller;

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
            txbNum.Hint = "Integer Only";

            var _current = CoreControl.GetCurrentStatus();
            if (_current == 0)
            {
                ckbEnable.Checked = txbNum.Enabled = false;
                txbNum.Text = Environment.ProcessorCount.ToString();
            }
            else
            {
                ckbEnable.Checked = txbNum.Enabled = true;
                txbNum.Text = _current.ToString();
            }
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbNum.Text, out int x))
            {
                if (CoreControl.Set(x))
                {
                    // Failed
                }
                else
                {
                    // Success
                }
            }
            else
            {
                // Not a valid integer
            }
        }
    }
}

using MaterialSkin;
using MaterialSkin.Controls;

using System;

namespace KTool.View
{
    public partial class MainWindow : MaterialForm
    {
        public MainWindow()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE
                );

        }

        private void btnCpuCoreControl_Click(object sender, EventArgs e)
        {
            var _cpuCoreControl = new CpuCoreControl();
            _cpuCoreControl.ShowDialog();
        }
    }
}

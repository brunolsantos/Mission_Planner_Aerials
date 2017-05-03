using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigOptional : UserControl, IActivate
    {
        public ConfigOptional()
        {
            InitializeComponent();
        }

        public void Activate()
        {
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            MainV2.instance.MenuFlightData_doClick();
            MainV2.instance.enableConfigTunning();
        }
    }
}
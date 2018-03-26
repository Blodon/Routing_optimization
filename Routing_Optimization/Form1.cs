using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Routing_Optimization
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InformationForm infos = new InformationForm();
            infos.ShowDialog();

        }

        private void trackBarMaxPath_ValueChanged(object sender, EventArgs e)
        {
            labelMaxPathValue.Text = trackBarMaxPath.Value.ToString();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            labelMaxPathValue.Text = trackBarMaxPath.Value.ToString();
        }

        private void groupBoxGenerate_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGenerateMap_Click(object sender, EventArgs e)
        {
            buttonSimulation.Enabled = true;
        }

        private void buttonEditor_Click(object sender, EventArgs e)
        {
            TopologyEditorForm editor = new TopologyEditorForm();
            editor.ShowDialog();
        }
    }
}

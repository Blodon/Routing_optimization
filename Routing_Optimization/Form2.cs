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
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            InfoLabelTopic.Text = "Optymalizacja trasy w ruchu sieciowym\nz wykorzystaniem algorytmow\nprotokołów routingu";
            InfoLabelSubject.Text = "Systemy wspomagania decyzji\ni symulacja komputerowa\n\nProwadzacy:\nDr inz. Wojciech Kmiecik";
            InfoLabelAutors.Text = "Autorzy:\n";
            InfoLabelAutors.Text += "Damian Głowacki 219328\n";
            InfoLabelAutors.Text += "Jakub Bartyzel 219135\n";
            InfoLabelAutors.Text += "Miłosz Dunikowski 219162\n";
            InfoLabelAutors.Text += "Michał Młynarz 223554";
        }

        private void InfoButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

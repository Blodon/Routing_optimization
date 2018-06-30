﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Routing_Optimization.TopologyElements
{
    public partial class SettingBandwidthForm : Form
    {
        public bool ready;
        private bool refused;
        private int bandwidth;

        public SettingBandwidthForm()
        {
            refused = false;
            InitializeComponent();
        }

        private void buttonSetBandwidthApply_Click(object sender, EventArgs e)
        {

            if (radioButtonSetBandwidthStandard.Checked) ;
            else if (radioButtonSetBandwidthType.Checked) setBandwidth();

            this.Hide();
            ready = true;
        }

        private void setBandwidth()
        {
            bandwidth = Convert.ToInt32(textBoxSetBandwidthType.Text);
        }

        public int getBandwidth() => bandwidth;

        private void SettingBandwidthForm_Load(object sender, EventArgs e)
        {
            ready = false;
        }

        private void buttonSetBandwidthRefuse_Click(object sender, EventArgs e)
        {
            refused = true;
            this.Hide();
            ready = true;
        }

        public bool isRefused()
        {
            if (refused)
            {
                refused = false;
                return true;
            } else return false;
        }

        private void comboBoxSetBandwidthStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeBandwidthStandard(comboBoxSetBandwidthStandard.Text);
        }

        private void changeBandwidthStandard(String standard)
        {

            if (standard == "100BaseT") bandwidth = 100;
            else if (standard == "10BaseT") bandwidth = 10;

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Routing_Optimization.Algorithms;

namespace Routing_Optimization
{
    public partial class MainMenu : Form
    {
        TopologyEditorForm editor;
        private Algorithm algorithms;


        public MainMenu()
        {
            editor = new TopologyEditorForm();
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
            labelRouterNumberValue.Text = trackBarRandomRoutersNumber.Value.ToString();
        }

        private void groupBoxGenerate_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGenerateMap_Click(object sender, EventArgs e)
        {
           
            int routers = 0;
            int links = 0;
            int minBandwidth = 0;
            int maxBandwidth = 0;
            int minDelay = 0;
            int maxDelay = 0;

            routers = trackBarRandomRoutersNumber.Value;
            links = trackBarMaxPath.Value;
            minBandwidth = int.Parse(textBoxMinimalBandWidth.Text);
            maxBandwidth = int.Parse(textBoxMaximalBandWidth.Text);
            minDelay = int.Parse(textBoxRandomDelayMin.Text);
            maxDelay = int.Parse(textBoxRandomDelayMax.Text);

            buttonSimulation.Enabled = true;

            editor.newRandomTopology(trackBarRandomRoutersNumber.Value, trackBarMaxPath.Value, minBandwidth, maxBandwidth, minDelay, maxDelay);

            pictureBoxGraph.Image = editor.getDrawing();

        }

        private void buttonEditor_Click(object sender, EventArgs e)
        {
            
            editor.ShowDialog();

            //// ready event handler
            while (!editor.ready);
            editor.ready = false;


            pictureBoxGraph.Image = editor.getDrawing();
        }

        private void buttonLoadConnections_Click(object sender, EventArgs e)
        {
            openFileDialogLoadFile.ShowDialog();          
        }

        private void buttonShowGenerator_Click(object sender, EventArgs e)
        {
            buttonShowGenerator.Hide();
            groupBoxGenerateRandom.Show();
        }

        private void trackBarRandomRoutersNumber_ValueChanged(object sender, EventArgs e)
        {
            labelRouterNumberValue.Text = trackBarRandomRoutersNumber.Value.ToString();
            int maxLinks = (trackBarRandomRoutersNumber.Value * (trackBarRandomRoutersNumber.Value - 1) / 2);
            trackBarMaxPath.SetRange(trackBarRandomRoutersNumber.Value-1, maxLinks);
            trackBarMaxPath.Value = trackBarRandomRoutersNumber.Value-1;
            labelMaxPathValue.Text = trackBarMaxPath.Value.ToString();

        }

        private void openFileDialogLoadFile_FileOk(object sender, CancelEventArgs e)
        {
            editor.loadTopology(openFileDialogLoadFile.FileName);
            pictureBoxGraph.Image = editor.getDrawing();
        }

        private void buttonSimulation_Click(object sender, EventArgs e)
        {

            algorithms = new Algorithm(editor.getTopology(), int.Parse(textBoxSourceRouter.Text), int.Parse(textBoxDestinationRouter.Text));
           
            algorithms.FloydWarshall();
            algorithms.BellmanFord();
            algorithms.dijkstraAlgorithm();
            algorithms.BFSAlgorithm();

            chartRouts.Series.Clear();
            chartRouts.Series.Add("RIP");
            chartRouts.Series.Add("OSPF");
            chartRouts.Series.Add("IGRP");
            chartRouts.Series.Add("F-W");


            reloadChartButtons();
            reloadTraceButtons();

            

            labelTimeBFSData.Text = "(RIP)BFS:   " + (System.Convert.ToDouble(algorithms.getBFSTimeData().Ticks) / 1000).ToString() + "ms";
            labelTimeBellmanData.Text = "(IGRP)Bellman:   " + (System.Convert.ToDouble(algorithms.getBellmanTimeData().Ticks) / 1000).ToString() + "ms";
            labelTimeDijkstraData.Text = "(OSPF)Dijkstra: " + (System.Convert.ToDouble(algorithms.getDijkstraTimeData().Ticks) / 1000).ToString() + "ms";
            labelTimeWarshallData.Text = "Warshall:  " + (System.Convert.ToDouble(algorithms.getWarshallTimeData().Ticks) / 1000).ToString() + "ms";

            labelTimeBFS.Text = "(RIP)BFS:   " + (System.Convert.ToDouble(algorithms.getBFSTime().Ticks) / 1000).ToString() + "ms";
            labelTimeBellman.Text = "(IGRP)Bellman:   " + (System.Convert.ToDouble(algorithms.getBellmanTime().Ticks) / 1000).ToString() + "ms";
            labelTimeDijkstra.Text = "(OSPF)Dijkstra: " + (System.Convert.ToDouble(algorithms.getDijkstraTime().Ticks) / 1000).ToString() + "ms";
            labelTimeWarshall.Text = "Warshall:  " + (System.Convert.ToDouble(algorithms.getWarshallTime().Ticks) / 1000).ToString() + "ms";


            labelTimeBFSSummary.Text = "(RIP)BFS:   " + (System.Convert.ToDouble(algorithms.getBFSTime().Ticks + algorithms.getBFSTimeData().Ticks) / 1000).ToString() + "ms";
            labelTimeBellmanSummary.Text = "(IGRP)Bellman:   " + (System.Convert.ToDouble(algorithms.getBellmanTime().Ticks + algorithms.getBellmanTimeData().Ticks) / 1000).ToString() + "ms";
            labelTimeDijkstraSummary.Text = "(OSPF)Dijkstra: " + (System.Convert.ToDouble(algorithms.getDijkstraTime().Ticks + algorithms.getDijkstraTimeData().Ticks) / 1000).ToString() + "ms";
            labelTimeWarshallSummary.Text = "Warshall:  " + (System.Convert.ToDouble(algorithms.getWarshallTime().Ticks + algorithms.getWarshallTimeData().Ticks) / 1000).ToString() + "ms";

            //algorithms.dataToCSV("abc.txt");

            groupBoxSimulationInformations.Visible = true;


            if (checkBoxCreateCSV.Checked)
            {

                algorithms.colorLinksBFS();
                algorithms.colorLinksDijkstra();
                algorithms.colorLinksBellman();
                algorithms.colorLinksWarshall();

                String filename;

                filename = "Single " + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-"
                   + " " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString()
                   + " " + textBoxSourceRouter.Text + " do " + textBoxDestinationRouter.Text + ".csv";

                FileStream fileStream = File.Open(filename, FileMode.Create, FileAccess.Write);
                StreamWriter fileWriter = new StreamWriter(fileStream, System.Text.Encoding.UTF8);

                fileWriter.Write(editor.getTopology().printAllLinksToOneStringWithParams());

                ///Column
                String header = "Source Router;" +   ///1
                "Destination router;" +          ///2
                "Path for F-W;" +                ///3
                "Path cost F-W;" +               ///4
                "Time of F-W [ms];" +            ///5
                "Path for IGRP;" +               ///6
                "Path cost IGRP;" +              ///7
                "Time of Bellman-Ford [ms];" +   ///8
                "Path for OSPF;" +               ///9
                "Path cost OSPF;" +              ///10
                "Time of dijkstra [ms];" +       ///11
                "Path for RIP;" +                ///12
                "Path cost RIP;" +               ///13
                "Time of BFS [ms];" +            ///14
                "Number of different paths;" +   ///15
                "\n";                            ///endl

                fileWriter.Write(header);
                fileWriter.Write(algorithms.resultToCSV());

                fileWriter.Flush();
                fileWriter.Close();

            }

        }




        /// Show trace buttons

        private void buttonTraceRIP_Click(object sender, EventArgs e)
        {
            reloadTraceButtons();
            buttonTraceRIP.ForeColor = System.Drawing.Color.Green;
            algorithms.colorLinksBFS();
            pictureBoxGraph.Image = algorithms.getTopology().drawGraph();
            algorithms.getTopology().resetLinkColor();
            textBoxShowRoute.Text = algorithms.showBFSPath();

        }

        private void buttonTraceOSPF_Click(object sender, EventArgs e)
        {
            reloadTraceButtons();
            buttonTraceOSPF.ForeColor = System.Drawing.Color.Green;
            algorithms.colorLinksDijkstra();
            pictureBoxGraph.Image = algorithms.getTopology().drawGraph();
            algorithms.getTopology().resetLinkColor();
            textBoxShowRoute.Text = algorithms.showDijkstraPath();
        }

        private void buttonTraceEIGRP_Click(object sender, EventArgs e)
        {
            reloadTraceButtons();
            buttonTraceEIGRP.ForeColor = System.Drawing.Color.Green;
            algorithms.colorLinksBellman();
            pictureBoxGraph.Image = algorithms.getTopology().drawGraph();
            algorithms.getTopology().resetLinkColor();
            textBoxShowRoute.Text = algorithms.showBellmanPath();
        }

        private void buttonTraceWarshall_Click(object sender, EventArgs e)
        {
            reloadTraceButtons();
            buttonTraceWarshall.ForeColor = System.Drawing.Color.Green;
            algorithms.colorLinksWarshall();
            pictureBoxGraph.Image = algorithms.getTopology().drawGraph();
            algorithms.getTopology().resetLinkColor();
            textBoxShowRoute.Text = algorithms.showWarshallPath();
        }


        private void reloadTraceButtons()
        {
            buttonTraceRIP.ForeColor = System.Drawing.Color.Black;
            buttonTraceOSPF.ForeColor = System.Drawing.Color.Black;
            buttonTraceEIGRP.ForeColor = System.Drawing.Color.Black;
            buttonTraceWarshall.ForeColor = System.Drawing.Color.Black;
        }

        /// Show charts buttons

        private void buttonChartRIP_Click(object sender, EventArgs e)
        {
            reloadChartButtons();
            buttonChartRIP.ForeColor = System.Drawing.Color.Green;

            int[] BFSPaths = algorithms.getBFSPaths();


            for (int i = 0; i < algorithms.getTopology().getRouterNumber(); i++)
                chartRouts.Series.FindByName("RIP").Points.AddY(System.Convert.ToDouble(BFSPaths[i]));

        }

        private void buttonChartOSPF_Click(object sender, EventArgs e)
        {
            reloadChartButtons();
            buttonChartOSPF.ForeColor = System.Drawing.Color.Green;

            int[] dijkstraPaths = algorithms.getDijktraPaths();
         

            for (int i = 0; i < algorithms.getTopology().getRouterNumber(); i++)
                chartRouts.Series.FindByName("OSPF").Points.AddY(System.Convert.ToDouble(dijkstraPaths[i]));
        }

        private void buttonChartEIGP_Click(object sender, EventArgs e)
        {
            reloadChartButtons();
            buttonChartEIGP.ForeColor = System.Drawing.Color.Green;

            int[] bellmanPaths = algorithms.getBellmanPaths();

            for (int i = 0; i < algorithms.getTopology().getRouterNumber(); i++)
                chartRouts.Series.FindByName("IGRP").Points.AddY(System.Convert.ToDouble(bellmanPaths[i]));

        }

        private void buttonChartWarshall_Click(object sender, EventArgs e)
        {
            reloadChartButtons();
            buttonChartWarshall.ForeColor = System.Drawing.Color.Green;

            int[] warshallPaths = algorithms.getWarshallPaths();


            for (int i = 0; i < algorithms.getTopology().getRouterNumber(); i++)
                chartRouts.Series.FindByName("F-W").Points.AddY(System.Convert.ToDouble(warshallPaths[i]));

        }


        private void reloadChartButtons()
        {
            buttonChartRIP.ForeColor = System.Drawing.Color.Black;
            buttonChartOSPF.ForeColor = System.Drawing.Color.Black;
            buttonChartEIGP.ForeColor = System.Drawing.Color.Black;
            buttonChartWarshall.ForeColor = System.Drawing.Color.Black;

            chartRouts.Series.FindByName("RIP").Points.Clear();
            chartRouts.Series.FindByName("OSPF").Points.Clear();
            chartRouts.Series.FindByName("IGRP").Points.Clear();
            chartRouts.Series.FindByName("F-W").Points.Clear();

        }

        private void buttonTestAll_Click(object sender, EventArgs e)
        {

            String filename;
            String fileTime;

            fileTime = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-"
               + " " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();

            filename = "Topology " + fileTime + ".tpl";
            editor.getTopology().WriteTextToFile(filename);  /// Save Topology to file

            filename = "Results " + fileTime + ".csv";
            FileStream fileStream = File.Open(filename, FileMode.Create, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream, System.Text.Encoding.UTF8);

            fileWriter.Write(editor.getTopology().printAllLinksToOneStringWithParams());

            ///Column
            String header = "Source Router;" +   ///1
                "Destination router;" +          ///2
                "Path for F-W;" +                ///3
                "Path cost F-W;" +               ///4
                "Time of F-W [ms];" +            ///5
                "Path for IGRP;" +               ///6
                "Path cost IGRP;" +              ///7
                "Time of Bellman-Ford [ms];" +   ///8
                "Path for OSPF;" +               ///9
                "Path cost OSPF;" +              ///10
                "Time of dijkstra [ms];" +       ///11
                "Path for RIP;" +                ///12
                "Path cost RIP;" +               ///13
                "Time of BFS [ms];" +            ///14
                "Number of different paths;" +   ///15
                "\n";                            ///endl

            fileWriter.Write(header);



            for (int j = 0; j < editor.getTopology().getRouterNumber(); j++)
                for (int i = 0; i < editor.getTopology().getRouterNumber(); i++)
                {
                    algorithms = new Algorithm(editor.getTopology(), (j + 1), (i + 1));

                    algorithms.FloydWarshall();
                    algorithms.BellmanFord();
                    algorithms.dijkstraAlgorithm();
                    algorithms.BFSAlgorithm();

                    algorithms.colorLinksWarshall();
                    algorithms.colorLinksBellman();
                    algorithms.colorLinksDijkstra();
                    algorithms.colorLinksBFS();

                    fileWriter.Write(algorithms.resultToCSV());
                }

            fileWriter.Flush();
            fileWriter.Close();
            

            //FileStream fileStream = File.Open("superPlik.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter fileWriter = new StreamWriter(fileStream);

            //fileWriter.Write("Number of routers: ");
            //fileWriter.Write(editor.getTopology().getRouterNumber().ToString());
            //fileWriter.WriteLine();
            //fileWriter.Write("Number of links: ");
            //fileWriter.Write(editor.getTopology().getLinkList().Count.ToString());
            //fileWriter.WriteLine();
            ////fileWriter.Write("Topology graph (bandwidth): ");
            ////fileWriter.Write(editor.getTopology().getLinkList().Count.ToString());
            ////fileWriter.WriteLine();



            //for (int j = 0; j < editor.getTopology().getRouterNumber(); j++)
            //{

            //    fileWriter.WriteLine();
            //    fileWriter.Write("Source router: ");
            //    fileWriter.Write((j+1).ToString());
            //    fileWriter.WriteLine();
            //    fileWriter.WriteLine();

            //    for (int i = 0; i < editor.getTopology().getRouterNumber(); i++)
            //    {
            //        algorithms = new Algorithm(editor.getTopology(), (j + 1), (i + 1));

            //        algorithms.FloydWarshall();
            //        algorithms.BellmanFord();
            //        algorithms.dijkstraAlgorithm();
            //        algorithms.BFSAlgorithm();

            //        algorithms.colorLinksWarshall();
            //        algorithms.colorLinksBellman();
            //        algorithms.colorLinksDijkstra();
            //        algorithms.colorLinksBFS();

            //        algorithms.dataToCSV(fileStream, fileWriter);

            //    }

            //}
            //fileWriter.Flush();
            //fileWriter.Close();




        }

        private void labelDestinationRouter_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetNewParameters_Click(object sender, EventArgs e)
        {

            int minBandwidth = 0;
            int maxBandwidth = 0;
            int minDelay = 0;
            int maxDelay = 0;

            minBandwidth = int.Parse(textBoxMinimalBandWidth.Text);
            maxBandwidth = int.Parse(textBoxMaximalBandWidth.Text);
            minDelay = int.Parse(textBoxRandomDelayMin.Text);
            maxDelay = int.Parse(textBoxRandomDelayMax.Text);


            if (editor.getTopology().getLinkList().Count > 0)
            {
                editor.getTopology().setNewLinkParameters(minBandwidth, maxBandwidth, minDelay, maxDelay);
            }
        }
    }
}

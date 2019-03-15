using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Windows.Forms;
using Microsoft.Glee.Drawing;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeGraph(String[] node)
        {
            //int total = int.Parse(node[0]);
            Microsoft.Glee.GraphViewerGdi.GViewer viewer = new Microsoft.Glee.GraphViewerGdi.GViewer();

            //create a graph object
            Microsoft.Glee.Drawing.Graph graph = new Microsoft.Glee.Drawing.Graph("graph");

            String[] s;
            Microsoft.Glee.Drawing.Node n;
            
            for (int i = 1; i < node.Length; i++)
            {
                s = node[i].Split(' ');
                graph.AddEdge(s[0], s[1]);
                n = graph.FindNode(s[0]);
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
                n.Attr.Shape = Microsoft.Glee.Drawing.Shape.DoubleCircle;
                n = graph.FindNode(s[1]);
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
                n.Attr.Shape = Microsoft.Glee.Drawing.Shape.DoubleCircle;
            }
            graph.GraphAttr.EdgeAttr.ArrowHeadAtTarget = ArrowStyle.None;
            //bind the graph to the viewer
            viewer.Graph = graph;

            //associate the viewer with the form
            grafPanel.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            grafPanel.Controls.Add(viewer);
            grafPanel.ResumeLayout();
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                grafDir.Text = openFileDialog1.FileName;                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (grafDir.Text == "")
            {
                MessageBox.Show("Direktori tidak boleh kosong");
            }
            else {
                var sr = new StreamReader(grafDir.Text);
                grafText.Text = sr.ReadToEnd();
                InitializeGraph(grafText.Lines);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileDir.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fileDir.Text == "")
            {
                MessageBox.Show("Direktori tidak boleh kosong");
            }
            else
            {
                var sr = new StreamReader(fileDir.Text);
                questText.Text = sr.ReadToEnd();
            }
        }
    }
}

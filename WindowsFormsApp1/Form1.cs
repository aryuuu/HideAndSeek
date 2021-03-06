﻿using System;
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
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{

    public partial class Form1 : MaterialForm
    {
        //Variabel global

        //private List<List<int>> vertex = new List<List<int>>(); 
        private List<int>[] vertex;
        //Representasi graf menggunakan array of list (Adjacency List)

        private int TotalNode;
        private int[] path; //penelusuran jalur (ibarat stack)
        private int length; //ibarat top of stack
        private bool found;
        private bool[] visited;
        private int[,] langkahGraf; //langkahGraf[i,] menyimpan langkah quest ke-i jika terdapat jalur yg benar, jika tidak isinya 0
                                    //Belum diterapkan dalam visualisasi penampilan jalur tiap quest yg berhasil

        private Graph graph;
        private Microsoft.Glee.GraphViewerGdi.GViewer viewer;
        public Form1()
        {
            InitializeComponent();
        }

        public void solve(string[] quest)
        {
            string[] s;
            path = new int[Int32.Parse(quest[0]) + 1];
            langkahGraf = new int[Int32.Parse(quest[0]) + 1, TotalNode + 1];            
            int l = 0;
            AnswerQuest.Items.Add("Answer:");
            for (int i = 1; i < quest.Length; i++)
            {
                markAllVisited(false);
                found = false;
                s = quest[i].Split(' ');
                //Apabila mendekat telusuri jalur dari simpul 1-simpul ferdiant apakah melalui simpul jose 
                if (Int32.Parse(s[0]) == 0)                 
                {
                    DFS(1, Int32.Parse(s[2]), Int32.Parse(s[1]), l);
                }
                else
                //Apabila menjauh telusuri jalur dari simpul 1-simpul jose apakah melalui simpul ferdiant
                if (Int32.Parse(s[0]) == 1)
                {
                    DFS(1, Int32.Parse(s[1]), Int32.Parse(s[2]), l);
                }                
                if (found)
                {
                    if (Int32.Parse(s[0]) == 1)
                    {
                        for (int j = 0; j <= length; j++)
                        {
                            langkahGraf[i, j] = path[j];
                        }
                    }
                    else
                    {
                        int k = 0;
                        for (int j = length; j >= 0; j--)
                        {
                            langkahGraf[i, k] = path[j];
                            k++;
                        }
                    }
                    AnswerQuest.Items.Add(quest[i]+" YA");
                }
                else
                {
                    AnswerQuest.Items.Add(quest[i]+" TIDAK");
                }

            }
        }

        private void markAllVisited(bool val)
        {
            for (int i=0;i < visited.Length; i++)
            {
                visited[i] = val;
            }
        }

        private bool noSucc(int s)
        {
            bool found = true;
            int i = 0;
            while (found  && i < vertex[s].Count)
            {
                if (!visited[vertex[s][i]]) found = false;
                else i++;
            }
            return found;
        }

        private bool isAllVisited()
        {
            bool found = true;
            int i = 0;
            while (found && i < visited.Length)
            {
                if (!visited[i]) found = false;
                else i++;
            }
            return found;
        }

        public void DFS(int src, int dest, int searchNode, int l) 
        {
            visited[src] = true;
            if (src == searchNode)
            {
                found = true;
            }
            //Basis 1: apabila nilai simpul src == dest
            if (src == dest )            
            {
                if (found)
                {
                    length = l;
                    path[l] = src;
                }
                markAllVisited(true);                
            }
            else
            //Basis 2: apabila tidak ada simpul lain yg bisa dikunjungi dari src
            if (noSucc(src))
            {
                // Do Nothing
            }
            else
            {
                int j = l;                 
                if (found)
                {
                    path[l] = src;
                    j++;
                }
                for (int i = 0; i < vertex[src].Count; i++)
                {                    
                    if (!visited[vertex[src][i]])
                    {
                        DFS(vertex[src][i], dest, searchNode, j);
                    }
                }
                if (found && !isAllVisited())
                {
                    found = false;
                    markAllVisited(true);
                }
            }
        }

        private void InitializeGraph(String[] node)
        {
            try
            {
                viewer = new Microsoft.Glee.GraphViewerGdi.GViewer();

                //create a graph object
                graph = new Microsoft.Glee.Drawing.Graph("graph");

                String[] s;                

                //inisialisasi
                TotalNode = Int32.Parse(node[0]);
                vertex = new List<int>[TotalNode + 1];
                visited = new bool[TotalNode + 1];
                Node n;
                for (int i = 1; i <= TotalNode; i++)
                {
                    vertex[i] = new List<int>();
                }

                //Menampilkan visualisasi graf
                for (int i = 1; i < node.Length; i++)
                {
                    s = node[i].Split(' ');
                    graph.AddEdge(s[0], s[1]);                    
                    //Memasukkan graf kedalam list ketetanggaannya
                    vertex[Int32.Parse(s[0])].Add(Int32.Parse(s[1]));
                    vertex[Int32.Parse(s[1])].Add(Int32.Parse(s[0]));

                    n = graph.FindNode(s[0]);
                    n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.DarkSlateGray;
                    n.Attr.Shape = Microsoft.Glee.Drawing.Shape.Circle;
                    n = graph.FindNode(s[1]);
                    n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.DarkSlateGray;
                    n.Attr.Shape = Microsoft.Glee.Drawing.Shape.Circle;
                }

                graph.GraphAttr.EdgeAttr.ArrowHeadAtTarget = ArrowStyle.None;
                //bind the graph to the viewer
                viewer.Graph = graph;

                //associate the viewer with the form
                //grafPanel.Controls.Remove(viewer);
                grafPanel.Controls.Clear();
                grafPanel.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                grafPanel.Controls.Add(viewer);
                grafPanel.ResumeLayout();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                grafDir.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {                
                if (checkBox1.Checked)
                {
                    InitializeGraph(grafText.Lines);
                }
                else {
                    var sr = new StreamReader(grafDir.Text);
                    grafText.Text = sr.ReadToEnd();
                    InitializeGraph(grafText.Lines);
                    sr.Close();
                }                
                button6.Visible = true;                
                //button6.BringToFront();
                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            try
            {
                var sr = new StreamReader(fileDir.Text);
                //string[] temp = sr.ReadToEnd().Split('\n');
                //AnswerQuest.DataSource = temp;
                questText.Text = sr.ReadToEnd();
                //solve(questText.Lines);
                button5.Enabled = true;
                AnswerQuest.Enabled = false;                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (questText.Text == "")
                {
                    throw new ArgumentNullException("Question", "No answer found");
                }
                solve(questText.Lines);
                AnswerQuest.Enabled = true;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }  
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }  
        }

        private void questText_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (path[length] != 0)
            {
                Node n = graph.FindNode(path[length].ToString());
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.Azure;
                viewer.Graph = graph;
                grafPanel.Controls.Remove(viewer);
                grafPanel.SuspendLayout();
                grafPanel.Controls.Add(viewer);
                grafPanel.ResumeLayout();
                length++;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String[] s;
            Node n;           

            //Menampilkan visualisasi graf
            for (int i = 1; i < grafText.Lines.Length; i++)
            {
                s = grafText.Lines[i].Split(' ');
                n = graph.FindNode(s[0]);
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.DarkSlateGray;
                n = graph.FindNode(s[1]);
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.DarkSlateGray;
            }
            //bind the graph to the viewer
            viewer.Graph = graph;

            //associate the viewer with the form
            grafPanel.Controls.Remove(viewer); 
            //grafPanel.Controls.Clear();
            grafPanel.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            grafPanel.Controls.Add(viewer);
            grafPanel.ResumeLayout(); 
        }

        private void AnswerQuest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (AnswerQuest.SelectedIndex == 0)
            {
                MessageBox.Show("Bukan pertanyaan!");
            }
            else
            if (langkahGraf[AnswerQuest.SelectedIndex, 0] == 0)
            {
                MessageBox.Show("Tidak ada solusi");
            }
            else
            {
                int i = 0;
                while (langkahGraf[AnswerQuest.SelectedIndex, i] != 0 && i <= langkahGraf.GetUpperBound(1))
                {
                    path[i] = langkahGraf[AnswerQuest.SelectedIndex, i];
                    i++;
                }
                path[i] = 0; //Terminate
                length = 0;
                timer1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                grafDir.Enabled = false;
                button1.Enabled = false;
                grafText.ReadOnly = false;
            }
            else
            {
                grafDir.Enabled = true;
                button1.Enabled = true;
                grafText.ReadOnly = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fileDir.Enabled = false;
                button4.Enabled = false;
                button2.Enabled = false;
                questText.ReadOnly = false;
                button5.Enabled = true;
            }
            else
            {
                fileDir.Enabled = true;
                button4.Enabled = true;
                button2.Enabled = true;
                questText.ReadOnly = true;

            }
        }
    }
}

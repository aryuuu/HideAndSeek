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
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{

    public partial class Form1 : MaterialForm
    {
        //Variabel global

        private List<int>[] vertex;
        //Representasi graf menggunakan array of list (Adjacency List)

        private int TotalNode;
        private int[] path; // stack
        private int length; // top of stack
        private bool found;
        private int[] visited = new int[100001];
        private int[] depth = new int[100001];


        private Graph graph;
        private Microsoft.Glee.GraphViewerGdi.GViewer viewer;
        public Form1()
        {
            InitializeComponent();
        }

        public void setDepth(int now, int l)
        //Menghitung kedalaman tiap simpul graf dari simpul 1    
        {
            visited[now] = 1;
            depth[now] = l;
            for (int i = 0; i < vertex[now].Count; i++)
            {
                if (visited[vertex[now][i]] == 0)
                {
                    setDepth(vertex[now][i], l + 1);
                }
            }
        }

        public void clearVisited()
        {
            for (int i = 0; i < TotalNode; i++)
            {
                visited[i] = 0;
            }
        }

        public void solve(string[] quest)
        {
            string[] s;
            path = new int[Int32.Parse(quest[0]) + 1];

            int l = 0;
            AnswerQuest.Items.Add("Answer:");
            //questText.Text = "Answer :" + Environment.NewLine;
            for (int i = 1; i < quest.Length; i++)
            {
                found = false;
                s = quest[i].Split(' ');
                Searching(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2]), l);
                if (found)
                {
                    AnswerQuest.Items.Add(quest[i] + " YA");
                    //questText.Text = questText.Text + "YA" + Environment.NewLine;
                }
                else
                {
                    AnswerQuest.Items.Add(quest[i] + " TIDAK");
                    //questText.Text = questText.Text + "TIDAK" + Environment.NewLine;
                }

            }
        }

        public void Searching(int arah, int x, int y, int l) //1 9 1
        {
            if (x == y) 
            {
                found = true;
                length = l;
                path[l] = y;
            }
            else
            {
                for (int i = 0; i < vertex[y].Count && !found; i++)
                {
                    if (arah == 0) //Mendekat
                    {
                        if (depth[y] > depth[vertex[y][i]])
                        {
                            path[l] = y;
                            Searching(arah, x, vertex[y][i], l + 1);
                        }
                    }
                    else if (arah == 1) //Menjauh
                    {
                        if (depth[y] < depth[vertex[y][i]])
                        {
                            path[l] = y;
                            Searching(arah, x, vertex[y][i], l + 1);
                        }
                    }
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
                clearVisited();

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

                setDepth(1, 0);
                clearVisited();

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
                else
                {
                    var sr = new StreamReader(grafDir.Text);
                    grafText.Text = sr.ReadToEnd();
                    InitializeGraph(grafText.Lines);
                    sr.Close();
                }
                button6.Visible = true;
                button6.BringToFront();

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
                questText.Text = sr.ReadToEnd();
                button5.Enabled = true;
                AnswerQuest.Enabled = false;
                sr.Close();
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
                AnswerQuest.Items.Clear();
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
            String[] s;
            int l = 0;
            if (AnswerQuest.SelectedIndex == 0)
            {
                MessageBox.Show("Bukan pertanyaan!");
            }
            else

            {
                s = questText.Lines[AnswerQuest.SelectedIndex].Split(' ');
                found = false;
                Searching(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2]), l);
                if (!found)
                {
                    MessageBox.Show("Tidak ada solusi");
                }
                else
                {
                    path[length + 1] = 0; //Terminate
                    length = 0;
                    timer1.Enabled = true;
                }
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

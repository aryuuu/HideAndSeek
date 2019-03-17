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
        //Variabel global

        //private List<List<int>> vertex = new List<List<int>>(); 
        private List<int>[] vertex;
        //Representasi graf menggunakan array of list (Adjacency List)

        private int TotalNode;
        private int[] depth; //Kedalaman tiap simpul lain dari simpul 1
        private int[] path; //penelusuran jalur (ibarat stack)
        private int length; //ibarat top of stack
        private bool found;
        private int[] visited;
        private int[,] langkahGraf; //langkahGraf[i,] menyimpan langkah quest ke-i jika terdapat jalur yg benar, jika tidak isinya 0
                                    //Belum diterapkan dalam visualisasi penampilan jalur tiap quest yg berhasil

        private Graph graph;
        private Microsoft.Glee.GraphViewerGdi.GViewer viewer;
        public Form1()
        {
            InitializeComponent();
        }

        public void kedalaman(int now, int l)
        //Menghitung kedalaman tiap simpul graf dari simpul 1    
        {
            visited[now] = 1;
            depth[now] = l;
            for (int i = 0; i < vertex[now].Count; i++)
            {
                if (visited[vertex[now][i]] == 0)
                {
                    kedalaman(vertex[now][i], l + 1);
                }
            }
        }

        public void solve(string[] quest)
        {
            string[] s;
            path = new int[Int32.Parse(quest[0]) + 1];
            langkahGraf = new int[Int32.Parse(quest[0]) + 1, TotalNode + 1];
            int l = 0;
            AnswerQuest.Text = "Answer :" + Environment.NewLine;
            for (int i = 1; i < quest.Length; i++)
            {
                found = false;
                s = quest[i].Split(' ');
                DFS(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2]), l);
                if (found)
                {
                    int j;
                    for (j = 0; j <= length; j++)
                    {
                        langkahGraf[i, j] = path[j];
                    }
                    AnswerQuest.Text = AnswerQuest.Text + "YA" + Environment.NewLine;
                }
                else
                {
                    AnswerQuest.Text = AnswerQuest.Text + "TIDAK" + Environment.NewLine;
                }

            }
        }

        public void DFS(int arah, int x, int y, int l) //1 9 1
        {
            if (x == y ) //apabila x == y di awal maka false/tidak (?)
            //Basis apabila nilai x == y (Ferdiant menemukan Jose)
            {
                found = true;
                length = l;
                path[l] = y;
            }
            else
            {// 1 9 1
                for (int i = 0; i < vertex[y].Count && !found; i++)
                {                    
                    if (arah == 0) //Mendekat
                    {
                        if (depth[y] > depth[vertex[y][i]])
                        {
                            path[l] = y;
                            DFS(arah, x, vertex[y][i], l + 1);
                        }
                    }
                    else if (arah == 1) //Menjauh
                    {
                        if (depth[y] < depth[vertex[y][i]]) 
                        {
                            path[l] = y;
                            DFS(arah, x, vertex[y][i], l + 1);
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
                depth = new int[TotalNode + 1];
                visited = new int[TotalNode + 1];
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
                    n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
                    n.Attr.Shape = Microsoft.Glee.Drawing.Shape.DoubleCircle;
                    n = graph.FindNode(s[1]);
                    n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
                    n.Attr.Shape = Microsoft.Glee.Drawing.Shape.DoubleCircle;
                }
                //Menghitung kedalaman tiap-tiap simpul dari graf dari simpul 1
                int now = 1; int l = 0;
                kedalaman(now, l);

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
                var sr = new StreamReader(grafDir.Text);
                grafText.Text = sr.ReadToEnd();
                InitializeGraph(grafText.Lines);
                button6.Visible = true;
                sr.Close();
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
                string[] temp = sr.ReadToEnd().Split('\n');
                questText.DataSource = temp;
                button5.Enabled = true;
                questText.Enabled = false;
                //questText.Text = sr.ReadToEnd();
                //solve(questText.Lines);
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
                if (questText.Items.Count == 0)
                {
                    throw new ArgumentNullException("File", "No answer found");
                }
                solve(questText.Items.OfType<string>().ToArray());
                questText.Enabled = true;
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
            if (questText.SelectedIndex == 0)
            {
                MessageBox.Show("Bukan pertanyaan!");
            }
            else
            if (langkahGraf[questText.SelectedIndex, 0] == 0)
            {
                MessageBox.Show("Tidak ada solusi");
            }
            else
            {
                int i = 0;
                while (langkahGraf[questText.SelectedIndex, i] != 0 && i <= langkahGraf.GetUpperBound(1))
                {
                    path[i] = langkahGraf[questText.SelectedIndex , i];
                    i++;
                }
                path[i] = 0; //Terminate
                length = 0;
                timer1.Enabled = true;
            }
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
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
                n = graph.FindNode(s[1]);
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
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
    }
}

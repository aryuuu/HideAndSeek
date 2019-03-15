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
        //Menggunakan array of list

        private int TotalNode;
        private int[] depth; //Kedalaman tiap simpul lain dari simpul 1
        private int[] path; //penelusuran jalur (ibarat stack)
        private int length; //ibarat top of stack
        private bool found;
        private int[] visited;
        private int[,] langkahGraf; //langkahGraf[i,] menyimpan langkah quest ke-i jika terdapat jalur yg benar, jika tidak isinya 0
                                    //Belum diterapkan dalam visualisasi penampilan jalur tiap quest yg berhasil
        public Form1()
        {
            InitializeComponent();
        }

        public void kedalaman(int now, int l)
        {
            visited[now] = 1;
            for(int i=0;i< vertex[now].Count; i++)
            {
                if (visited[vertex[now][i]] == 0)
                {
                    depth[now] = l;
                    kedalaman(vertex[now][i], l + 1);
                }
            }
        }

        public void DFS(int arah, int x, int y, int l)
        {
           for(int i=0; i< vertex[y].Count; i++)
            {
                if (x==y)
                {
                    found = true;
                    length = l;
                    path[l] = y;
                    break;
                }
                else
                {
                    path[l] = y;
                    if (arah == 0)
                    {
                        if (depth[y] < depth[vertex[y][i]])
                        {
                            DFS(arah, x, vertex[y][i], l + 1);
                        }
                    } else if(arah == 1)
                    {
                        if (depth[y] > depth[vertex[y][i]])
                        {
                            DFS(arah, x, vertex[y][i], l + 1);
                        }
                    }
                    
                }
            }

           
        }

        private void InitializeGraph(String[] node)
        {
            
 
            Microsoft.Glee.GraphViewerGdi.GViewer viewer = new Microsoft.Glee.GraphViewerGdi.GViewer();

            //create a graph object
            Microsoft.Glee.Drawing.Graph graph = new Microsoft.Glee.Drawing.Graph("graph");

            String[] s;
            Microsoft.Glee.Drawing.Node n;

            //inisialisasi
            TotalNode = Int32.Parse(node[0]);
            vertex = new List<int>[TotalNode+1];
            depth = new int[TotalNode + 1];
            path = new int[TotalNode];
            visited = new int[TotalNode + 1];
            langkahGraf = new int[TotalNode + 1, TotalNode + 1];

            for (int i = 1; i <= TotalNode; i++)
            {
                vertex[i] = new List<int>();
            }

            for (int i = 1; i < node.Length; i++)
            {
                s = node[i].Split(' ');
                graph.AddEdge(s[0], s[1]);
                vertex[Int32.Parse(s[0])].Add(Int32.Parse(s[1]));
                vertex[Int32.Parse(s[1])].Add(Int32.Parse(s[0]));

                n = graph.FindNode(s[0]);
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
                n.Attr.Shape = Microsoft.Glee.Drawing.Shape.DoubleCircle;
                n = graph.FindNode(s[1]);
                n.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
                n.Attr.Shape = Microsoft.Glee.Drawing.Shape.DoubleCircle;
            }
            int now = 1;int l = 0;
            kedalaman(now, l);

            graph.GraphAttr.EdgeAttr.ArrowHeadAtTarget = ArrowStyle.None;
            //bind the graph to the viewer
            viewer.Graph = graph;

            //associate the viewer with the form
            grafPanel.Controls.Clear();
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
                //solve(questText.Lines);

            }
        }

        public void solve(string [] quest)
        {
            string[] s;
   
            int l=0;
            //  Answer.Lines[jumlah] = "";
            AnswerQuest.Text = "Answer :" + Environment.NewLine;
            for (int i = 1; i < quest.Length; i++)
            {
                found = false;
                s = quest[i].Split(' ');
                DFS(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2]), l);
                if (found)
                {
             
                    for(int j = 0; j <= length; j++)
                    {
                        langkahGraf[i,j] = path[j];
                    }
                    AnswerQuest.Text = AnswerQuest.Text +"YA"+ Environment.NewLine;
                }else
                {
                    AnswerQuest.Text = AnswerQuest.Text + "TIDAK" + Environment.NewLine;
                }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fileDir.Text == "")
            {
                MessageBox.Show("Direktori tidak boleh kosong");
            }
            else
            {
                var sr = new StreamReader(fileDir.Text);
                questText.Text = sr.ReadToEnd();
                solve(questText.Lines);

            }
        }

    }
}

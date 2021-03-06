﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BattleShip.Model;
using System.Runtime.InteropServices;

namespace BattleShip.View
{

    public partial class Highscores : Form
    {
        List<Label> lblList;
        List<Score> hiScores;
        Point p;
        public Highscores()
        {
            p = new Point { X = 70, Y = 100 };
            lblList = new List<Label>();
            InitializeComponent();
            hiScores = new List<Score>();
              readFile();
            this.Cursor = LoadCursorFromResource();
            //  MessageBox.Show(lblList.Count.ToString());
            
        }

        public static Cursor LoadCursorFromResource()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/curs.cur";
            File.WriteAllBytes(path, Properties.Resources.AOM_Titans_Cursor);
            Cursor result = new Cursor(LoadCursorFromFile(path));
            File.Delete(path);

            return result;
        }
        [DllImport("User32.dll", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        private static extern IntPtr LoadCursorFromFile(String str);

        private void Highscores_Load(object sender, EventArgs e)
        {
            foreach (Label l in lblList)
            {
            //    MessageBox.Show(l.ToString());
                l.Location = p;
                l.Font = new Font("Comic Sans", 10, FontStyle.Regular);
                l.Width = 150;

                this.Controls.Add(l);
                p = new Point { X = p.X, Y = p.Y+25 };
                
             }

        }
        public void readFile()
        {
            var fs = File.OpenRead(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\highscores.csv");
            var reader = new StreamReader(fs);
            var line="";
            while (( line=reader.ReadLine())!=null)
            { 
                if (line == "")
                {
                    break;
                }
                var values = line.Split(';');
                int p;
                int.TryParse(values[1], out p);
                Score s = new Score(values[0], p);
                hiScores.Add(s);
            }
           
            Sort();
            reader.Dispose();

        }
        private void Sort() {
            for(int i = 0; i < hiScores.Count; i++)
            {
                for(int j = 0; j < hiScores.Count - 1; j++)
                {
                    if (hiScores[j].Hiscore < hiScores[j + 1].Hiscore) {
                        Score tmp = hiScores[j];
                        hiScores[j] = hiScores[j + 1];
                        hiScores[j + 1] = tmp;
                            }
                }
            }
            int z = 0;
            if (hiScores.Count >= 5)
            {
                z = 5;
            }
            else{
                z = hiScores.Count;
            }

            if(hiScores.Count > 0)
            {
                btnReset.Enabled = true;
                for (int i = 0; i < z; i++)
                {
                    Label l = new Label();
                    if (i == 0)
                    {
                        PictureBox pb = new PictureBox()
                        {
                            Size = new Size(25, 20),
                            Location = new Point(l.Location.X + 2 * l.Width + 30, 98),
                            Image = Properties.Resources._5929ca2696f6a272985558
                        };
                        this.Controls.Add(pb);
                    }

                    l.Text = (i + 1) + ". " + hiScores[i].ToString();
                    l.BackColor = Color.Transparent;


                    lblList.Add(l);
                }
            }
            
            else
            {
                Label l = new Label();
                l.Text = "No Highscores!";
                l.BackColor = Color.Transparent;
                btnReset.Enabled = false;
                lblList.Add(l);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void removeControls()
        {
            foreach(Label l in lblList)
            {
                Controls.Remove(l);
            }
            foreach(Control control in Controls)
            {
                if(control is PictureBox)
                {
                    Controls.Remove(control);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to reset scores? You can't undo this", 
                "Reset Score", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\highscores.csv";
                using (File.Create(path)) { }
                Label l = new Label();
                l.Text = "No Highscores!";
                l.BackColor = Color.Transparent;

                removeControls();
                l.Location = new Point { X = 70, Y = 100 };
                l.Font = new Font("Comic Sans", 10, FontStyle.Regular);
                l.Width = 150;
                Controls.Add(l);
                btnReset.Enabled = false;
            }            
        }
    }
}

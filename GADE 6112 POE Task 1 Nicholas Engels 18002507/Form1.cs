using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_6112_POE_Task_1_Nicholas_Engels_18002507
{
    // Nicholas Engels 18002507 otu5l
    public partial class Form1 : Form
    {
        Map map = new Map(20, 20, 20);
        const int START_X = 20;
        const int START_Y = 20;
        const int SPACING = 10;
        const int SIZE = 20;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayMap();
        }

        private void DisplayMap()
        {
            groupBox1.Controls.Clear();
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeleeUnit))
                {
                    int start_x, start_y;
                    start_x = groupBox1.Location.X;
                    start_y = groupBox1.Location.Y;
                    MeleeUnit m = (MeleeUnit)u;
                    Button b = new Button();
                    b.Size = new Size(SIZE, SIZE);
                    b.Location = new Point(start_x + (m.xPos * SIZE), start_y + (m.yPos * SIZE));
                    b.Text = m.image;
                    if (m.faction == 1)
                    {
                        b.ForeColor = Color.Red;
                    }
                    else
                    {
                        b.ForeColor = Color.Green;
                    }
                    b.Click += new EventHandler(Start1_Click);
                    groupBox1.Controls.Add(b);
                }
            }
        }

        private void UpdateMap()
        {
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeleeUnit))
                {
                    MeleeUnit m = (MeleeUnit)u;
                    if (m.health < 25)
                    {
                        switch (r.Next(0, 4))
                        {
                            case 0: m.Move(Direction.North); break;
                            case 1: m.Move(Direction.East); break;
                            case 2: m.Move(Direction.South); break;
                            case 3: m.Move(Direction.West); break;
                        }
                    }
                    else
                    {
                        bool InCombat = false;
                        foreach (Unit e in map.Units)
                        {
                            if (u.InRange(e))
                            {
                                u.Combat(e);
                            }
                        }
                        if (!InCombat)
                        {
                            Unit c = m.Closest(map.Units);
                            m.Move(m.DirectionTo(c));
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateMap();
            DisplayMap();
            txt.Text = (++turn).ToString();
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Stop1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button_click(object sender, EventArgs e)
        {
            int X = (((Button)sender).Location.X - groupBox1.Location.X) / SIZE;
            int Y = (((Button)sender).Location.Y - groupBox1.Location.Y) / SIZE;
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeleeUnit))
                {
                    MeleeUnit m = (MeleeUnit)u;
                    if (m.xPos == X && m.yPos == Y)
                    {
                        txt.Text = "Button clicked at: " + map.ToString();
                    }
                }
            }
        }
    }
}

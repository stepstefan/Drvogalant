 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drvogalant
{
    public partial class Adding : Form
    {
        ComboBox orientation = new ComboBox
        {
            Location = new Point(90, 120),
            Size = new Size(60,10),
            AutoCompleteMode = AutoCompleteMode.SuggestAppend,
            AutoCompleteSource = AutoCompleteSource.ListItems
        };
        TextBox width = new TextBox
        {
            Location = new Point(100, 50),
            Size = new Size(40, 10)
        };
        TextBox height = new TextBox
        {
            Location = new Point(181, 155),
            Size = new Size(40, 10)
        };
        TextBox depth = new TextBox
        {
            Location = new Point(210, 63),
            Size = new Size(30, 10)
        };
        Button add = new Button
        {
            Text = "Dodaj vrata"
        };
        CheckBox glass = new CheckBox
        {
            Location = new Point(100, 0),
            Text = "Staklena"
        };
        public Adding()
        {
            this.Paint += new PaintEventHandler(this.Adding_Paint);
            this.Size = new Size(350, 350);
            this.BackColor = Color.White;
            orientation.Items.Add("Leva");
            orientation.Items.Add("Desna");
            orientation.SelectedIndex = 0;
            this.Controls.Add(orientation);
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, 0, 0, 100, 100);
            this.Controls.Add(width);
            this.Controls.Add(height);
            this.Controls.Add(depth);
            this.Controls.Add(add);
            add.Click += new EventHandler(add_Click);
            this.Controls.Add(glass);

        }
        private void add_Click(object sender, EventArgs e)
        {
            if (height.Text == "" || width.Text == "" || depth.Text == "") { }
            else
            {
                double h = Convert.ToDouble(height.Text);
                double w = Convert.ToDouble(width.Text);
                double d = Convert.ToDouble(depth.Text);
                bool r = false;
                bool staklo = glass.Checked; 
                if (orientation.Text == "Desna")
                    r = true;
                int t = Form1.gettype();
                if (t == 3)
                {
                    Form1.allDoors.Add(new Form1.Furnirana(h, w, d, r, staklo));
                    Form1.drawAll();
                    Form1.krilaAll();
                    Form1.mdf28All();
                    Form1.mdf18All();
                    Form1.trakeAll();
                    Form1.mdf22All();

                }
                else
                {
                    if (t == 0)
                        Form1.allDoors.Add(new Form1.Falcovana(h, w, d, r, staklo));
                    if (t == 1)
                        Form1.allDoors.Add(new Form1.Brodska(h, w, d, r, staklo));
                    if (t == 2)
                        Form1.allDoors.Add(new Form1.Zaobljena(h, w, d, r, staklo));
                    Form1.drawAll();
                    Form1.krilaAll();
                    Form1.mdf28All();
                    Form1.mdf18All();
                    Form1.mdf16All();
                    Form1.hdf4All();
                    Form1.mdf22All();
                }
                this.Close();
            }
            
            
        }
        private void Adding_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            draw_standard(g);
        }
        private void draw_standard(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, new Point(60, 70), new Point(60, 250));
            g.DrawLine(p, new Point(60, 70), new Point(180, 70));
            g.DrawLine(p, new Point(180, 70), new Point(180, 250));
            g.DrawLine(p, new Point(180, 70), new Point(250, 50));
        }
    }
}

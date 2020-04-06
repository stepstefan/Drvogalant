using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LatexDocument;
using ScintillaNET;


namespace Drvogalant
{
    public partial class Form1 : Form
    {
        public class Door
        {
            public double height, width, depth;
            public bool right;
            public bool glass;
            public Door(double height, double width, double depth, bool right, bool glass)
            {
                this.height = height;
                this.depth = depth;
                this.width = width;
                this.right = right;
                this.glass = glass;
            }
            public virtual Tuple<double, double, double> Krila()
            {
                return null;
            }
            public virtual Tuple<Tuple<double, double, double>, Tuple<double, double, double>> mdf28()
            {
                return null;
            }
            public virtual Tuple<Tuple<double, double, double>, Tuple<double, double, double>> mdf18()
            {
                double H = height + 7;
                double W = width + 8;
                Tuple<double, double, double> output1;
                Tuple<double, double, double> output2;
                if (H <= 214 && W <= 107)
                {
                    output1 = new Tuple<double, double, double>(2.5, 214, 6.6);
                    output2 = new Tuple<double, double, double>(0, 0, 6.6);
                }
                else
                {
                    if (H < 214 && W > 107)
                    {
                        output1 = new Tuple<double, double, double>(2, 214, 6.6);
                        output2 = new Tuple<double, double, double>(1, W, 6.6);
                    }
                    else
                    {
                        if(H > 214 && W < 107)
                        {
                            output1 = new Tuple<double, double, double>(2, H, 6.6);
                            output2 = new Tuple<double, double, double>(0.5, 214, 6.6);
                        }
                        else
                        {
                            output1 = new Tuple<double, double, double>(2, H, 6.6);
                            output2 = new Tuple<double, double, double>(1, W, 6.6);
                        }
                    }
                }

                return new Tuple<Tuple<double, double, double>, Tuple<double, double, double>>(output1, output2);
            }
            public virtual Tuple<Tuple<double, double, double>, Tuple<double, double, double>> mdf16()
            {
                double H = height + 7;
                double W = width + 8;
                Tuple<double, double, double> output1;
                Tuple<double, double, double> output2;
                if (H <= 214 && W <= 107)
                {
                    output1 = new Tuple<double, double, double>(2.5, 214, 7);
                    output2 = new Tuple<double, double, double>(0, 0, 7);
                }
                else
                {
                    if (H < 214 && W > 107)
                    {
                        output1 = new Tuple<double, double, double>(2, 214, 7);
                        output2 = new Tuple<double, double, double>(1, W, 7);
                    }
                    else
                    {
                        if (H > 214 && W < 107)
                        {
                            output1 = new Tuple<double, double, double>(2, H, 7);
                            output2 = new Tuple<double, double, double>(0.5, 214, 7);
                        }
                        else
                        {
                            output1 = new Tuple<double, double, double>(2, H, 7);
                            output2 = new Tuple<double, double, double>(1, W, 7);
                        }
                    }
                }

                return new Tuple<Tuple<double, double, double>, Tuple<double, double, double>>(output1, output2);

            }
            public virtual Tuple<double, double, double> hdf4()
            {
                Tuple<double, double, double> output = new Tuple<double, double, double>(2.5, 207, 4.5);
                return output;
            }
            public virtual Tuple<double, double, double> mdf22()
            {
                Tuple<double, double, double> output = new Tuple<double, double, double>(4, 207, 2.8);
                return output;
            }
        }
        public class Falcovana : Door
        {
            public Falcovana(double height, double width, double depth, bool right, bool glass) : base(height, width, depth, right, glass)
            {
            }
            public override Tuple<double, double, double> Krila()
            {
                Tuple<double, double, double> output = new Tuple<double, double, double>(1, height - 1.7, width - 4);
                return output;
            }
            public override Tuple<Tuple<double, double, double>, Tuple<double, double, double>> mdf28()
            {
                Tuple<double, double, double> output1 = new Tuple<double, double, double>(2, height - 2, depth);
                Tuple<double, double, double> output2 = new Tuple<double, double, double>(1, width - 2.5, depth);
                return new Tuple<Tuple<double, double, double>, Tuple<double, double, double>>(output1, output2);

            }
        }
        public class Brodska : Door
        {
            public Brodska(double height, double width, double depth, bool right, bool glass) : base(height, width, depth, right, glass)
            {
            }
            public override Tuple<double, double, double> Krila()
            {
                Tuple<double, double, double> output = new Tuple<double, double, double>(1, height - 2.7, width - 6.5);
                return output;
            }
            public override Tuple<Tuple<double, double, double>, Tuple<double, double, double>> mdf28()
            {
                Tuple<double, double, double> output1 = new Tuple<double, double, double>(2, height - 2, depth);
                Tuple<double, double, double> output2 = new Tuple<double, double, double>(1, width - 2.5, depth);
                return new Tuple<Tuple<double, double, double>, Tuple<double, double, double>>(output1, output2);
            }
        }
        public class Zaobljena : Door
        {
            public Zaobljena(double height, double width, double depth, bool right, bool glass) : base(height, width, depth, right, glass)
            {
            }
            public override Tuple<double, double, double> Krila()
            {
                Tuple<double, double, double> output = new Tuple<double, double, double>(1, height - 2.3, width - 6.5);
                return output;
            }
            public override Tuple<Tuple<double, double, double>, Tuple<double, double, double>> mdf28()
            {
                Tuple<double, double, double> output1 = new Tuple<double, double, double>(2, height, depth);
                Tuple<double, double, double> output2 = new Tuple<double, double, double>(1, width - 2.5, depth);
                return new Tuple<Tuple<double, double, double>, Tuple<double, double, double>>(output1, output2);
            }
        }
        public class Furnirana : Door
        {
            public Furnirana(double height, double width, double depth, bool right, bool glass) : base(height, width, depth, right, glass)
            {
            }
            public override Tuple<double, double, double> Krila()
            {
                Tuple<double, double, double> output = new Tuple<double, double, double>(1, height - 2.7, width - 6.5);
                return output;
            }
            public override Tuple<Tuple<double, double, double>, Tuple<double, double, double>> mdf28()
            {
                Tuple<double, double, double> output1 = new Tuple<double, double, double>(2, height - 2, depth);
                Tuple<double, double, double> output2 = new Tuple<double, double, double>(1, width - 2.5, depth);
                return new Tuple<Tuple<double, double, double>, Tuple<double, double, double>>(output1, output2);
            }
            public override Tuple<Tuple<double, double, double>, Tuple<double, double, double>> mdf18()
            {
                double H = height + 7;
                double W = width + 8;
                Tuple<double, double, double> output1;
                Tuple<double, double, double> output2;
                if (H <= 214 && W <= 107)
                {
                    output1 = new Tuple<double, double, double>(5, 214, 7);
                    output2 = new Tuple<double, double, double>(0, 0, 7);
                }
                else
                {
                    if (H < 214 && W > 107)
                    {
                        output1 = new Tuple<double, double, double>(4, 214, 7);
                        output2 = new Tuple<double, double, double>(2, W, 7);
                    }
                    else
                    {
                        if (H > 214 && W < 107)
                        {
                            output1 = new Tuple<double, double, double>(4, H, 7);
                            output2 = new Tuple<double, double, double>(1, 214, 7);
                        }
                        else
                        {
                            output1 = new Tuple<double, double, double>(4, H, 7);
                            output2 = new Tuple<double, double, double>(2, W, 7);
                        }
                    }
                }

                return new Tuple<Tuple<double, double, double>, Tuple<double, double, double>>(output1, output2);
            }
            public Tuple<Tuple<double, double>, Tuple<double, double>> trake()
            {
                Tuple<double, double> out1 = new Tuple<double, double>(5, 5);
                Tuple<double, double> out2 = new Tuple<double, double>(10, 2.2);
                return new Tuple<Tuple<double, double>, Tuple<double, double>>(out1, out2);
            }
            public override Tuple<double, double, double> mdf22()
            {
                Tuple<double, double, double> output = new Tuple<double, double, double>(4, 207, 2.2);
                return output;
            }
        }
        
        static PictureBox mainpb = new PictureBox
        {
            Location = new Point(0, 0)
        };
        static FlowLayoutPanel panelpb = new FlowLayoutPanel
        {
            Location = new Point(10,90),
            Size = new Size(900,900),
            AutoScroll = true
        };
        static ComboBox doortype = new ComboBox
        {
            Location = new Point(600, 10),
            Size = new Size(200, 10),
            AutoCompleteMode = AutoCompleteMode.SuggestAppend,
            AutoCompleteSource = AutoCompleteSource.ListItems
        };
        public static int gettype()
        {
            int o = doortype.SelectedIndex;
            return o;
        }
        public static List<Door> allDoors = new List<Door>();

        public Form1()
        {
            InitializeComponent();
        }

        TextBox naslov = new TextBox
        {
            Size = new Size(565, 10),
            Location = new Point(10, 10)
            //BackColor = Color.White
        };
        Button add = new Button
        {
            Text = "Dodaj mere za nova vrata",
            BackColor = Color.White,
            Size = new Size(100, 50),
            Location = new Point(10, 30),
        };
        Button remove = new Button
        {
            Text = "Ukloni poslednja vrata",
            BackColor = Color.White,
            Size = new Size(100, 50),
            Location = new Point(150, 30),
        };
        Button create = new Button
        {
            Text = "Kreiraj fajl za stampanje",
            BackColor = Color.White,
            Size = new Size(100, 50),
            Location = new Point(600, 30),
        };
        static ListBox krila = new ListBox
        {
            Location = new Point(960, 90),
            Size = new Size(400, 250),
            Font = new Font("Arial", 10),
        };
        Label krilalab = new Label
        {
            Location = new Point(960, 70),
            Text = "Vratna krila: ",
            Font = new Font("Arial", 12, FontStyle.Bold)
        };
        TextBox krilatb = new TextBox
        {
            Location = new Point(1060, 70),
            Width = 300
        };
        static ListBox mdf28 = new ListBox
        {
            Location = new Point(1450, 90),
            Size = new Size(400, 250),
            Font = new Font("Arial", 10),
        };
        Label mdf28lab = new Label
        {
            Location = new Point(1450, 70),
            Text = "MDF28mm: ",
            Font = new Font("Arial", 12, FontStyle.Bold)
        };
        TextBox mdf28tb = new TextBox
        {
            Location = new Point(1550, 70),
            Width = 300
        };
        static ListBox mdf18 = new ListBox
        {
            Location = new Point(960, 400),
            Size = new Size(400, 250),
            Font = new Font("Arial", 10)
        };
        Label mdf18lab = new Label
        {
            Location = new Point(960, 380),
            Text = "MDF18mm: ",
            Font = new Font("Arial", 12, FontStyle.Bold)
        };
        TextBox mdf18tb = new TextBox
        {
            Location = new Point(1060, 380),
            Width = 300
        };
        static ListBox mdf16 = new ListBox
        {
            Location = new Point(1450, 400),
            Size = new Size(400, 250),
            Font = new Font("Arial", 10)
        };
        Label mdf16lab = new Label
        {
            Location = new Point(1450, 380),
            Text = "MDF16mm: ",
            Font = new Font("Arial", 12, FontStyle.Bold)
        };
        TextBox mdf16tb = new TextBox
        {
            Location = new Point(1550, 380),
            Width = 300
        };
        static ListBox hdf4 = new ListBox
        {
            Location = new Point(960, 710),
            Size = new Size(400, 250),
            Font = new Font("Arial", 10)
        };
        Label hdf4lab = new Label
        {
            Location = new Point(960, 690),
            Text = "HDF4mm: ",
            Font = new Font("Arial", 12, FontStyle.Bold)
        };
        TextBox hdf4tb = new TextBox
        {
            Location = new Point(1060, 690),
            Width = 300
        };
        static ListBox mdf22 = new ListBox
        {
            Location = new Point(1450, 710),
            Size = new Size(400, 250),
            Font = new Font("Arial", 10)
        };
        Label mdf22lab = new Label
        {
            Location = new Point(1450, 690),
            Text = "MDF22mm: ",
            Font = new Font("Arial", 12, FontStyle.Bold)
        };
        TextBox mdf22tb = new TextBox
        {
            Location = new Point(1550, 690),
            Width = 300
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(595, 842);
            //this.BackColor = Color.White;
            this.Controls.Add(doortype);
            doortype.Items.Add("Falcovana");
            doortype.Items.Add("Brodska sarka");
            doortype.Items.Add("Zaobljeni stok");
            doortype.Items.Add("Furnirana");
            this.Controls.Add(naslov);
            this.Controls.Add(add);
            this.Controls.Add(remove);
            this.Controls.Add(create);
            remove.Click += new EventHandler(remove_Click);
            create.Click += new EventHandler(create_Click);
            add.Click += new EventHandler(add_Click);
            this.Controls.Add(panelpb);
            panelpb.Controls.Add(mainpb);
            //panelpb.BackColor = Color.Black;
            mainpb.Size = new Size(900, 900);
            //mainpb.BackColor = Color.Blue;
            this.Controls.Add(krila);
            this.Controls.Add(krilalab);
            this.Controls.Add(krilatb);
            this.Controls.Add(mdf28);
            this.Controls.Add(mdf28lab);
            this.Controls.Add(mdf28tb);
            this.Controls.Add(mdf18);
            this.Controls.Add(mdf18lab);
            this.Controls.Add(mdf18tb);
            this.Controls.Add(mdf16);
            this.Controls.Add(mdf16lab);
            this.Controls.Add(mdf16tb);
            this.Controls.Add(hdf4);
            this.Controls.Add(hdf4lab);
            this.Controls.Add(hdf4tb);
            this.Controls.Add(mdf22);
            this.Controls.Add(mdf22lab);
            this.Controls.Add(mdf22tb);
            doortype.SelectionChangeCommitted += new EventHandler(doortype_SelectionChangeCommitted);
        }

        public static void drawDoor(Point o, Graphics g, Door d)
        {
            if (!d.glass)
            {
                Pen p = new Pen(Color.Black);
                g.DrawLine(p, o.X + 20, o.Y + 40, o.X + 110, o.Y + 40);
                g.DrawLine(p, o.X + 20, o.Y + 40, o.X + 20, o.Y + 180);
                g.DrawLine(p, o.X + 110, o.Y + 40, o.X + 110, o.Y + 180);
                g.DrawLine(p, o.X + 110, o.Y + 40, o.X + 150, o.Y);
                g.DrawString(d.height.ToString(), new Font("Arial", 12), Brushes.Black, new Point(o.X + 115, o.Y + 110));
                g.DrawString(d.width.ToString(), new Font("Arial", 12), Brushes.Black, new Point(o.X + 55, o.Y + 180));
                g.DrawString(d.depth.ToString(), new Font("Arial", 12), Brushes.Black, new Point(o.X + 100, o.Y + 8));
                if (d.right)
                {
                    g.DrawString("D", new Font("Arial", 12), Brushes.Black, new Point(o.X + 55, o.Y + 100));
                }
                else
                {
                    g.DrawString("L", new Font("Arial", 14), Brushes.Black, new Point(o.X + 55, o.Y + 100));
                }
            }
            else
            {
                Pen p = new Pen(Color.Black);
                g.DrawLine(p, o.X + 20, o.Y + 40, o.X + 110, o.Y + 40);
                g.DrawLine(p, o.X + 20, o.Y + 40, o.X + 20, o.Y + 180);
                g.DrawLine(p, o.X + 110, o.Y + 40, o.X + 110, o.Y + 180);
                g.DrawLine(p, o.X + 110, o.Y + 40, o.X + 150, o.Y);
                g.DrawString(d.height.ToString(), new Font("Arial", 12), Brushes.Black, new Point(o.X + 115, o.Y + 110));
                g.DrawString(d.width.ToString(), new Font("Arial", 12), Brushes.Black, new Point(o.X + 55, o.Y + 180));
                g.DrawString(d.depth.ToString(), new Font("Arial", 12), Brushes.Black, new Point(o.X + 100, o.Y + 8));
                if (d.right)
                {
                    g.DrawString("D", new Font("Arial", 12), Brushes.Black, new Point(o.X + 55, o.Y + 100));
                }
                else
                {
                    g.DrawString("L", new Font("Arial", 14), Brushes.Black, new Point(o.X + 55, o.Y + 100));
                }
                g.DrawLine(p, o.X + 30, o.Y + 50, o.X + 100, o.Y + 50);
                g.DrawLine(p, o.X + 30, o.Y + 50, o.X + 30, o.Y + 170);
                g.DrawLine(p, o.X + 100, o.Y + 50, o.X + 100, o.Y + 170);
                g.DrawLine(p, o.X + 30, o.Y + 170, o.X + 100, o.Y + 170);
            }
            
        }
        public static void drawAll()
        {
            int cnt = -1;
            int starty = -210;
            Bitmap bm;
            if (allDoors.Count() % 5 != 0)
            {
                bm = new Bitmap(900, ((int)(allDoors.Count / 5) + 1) * 210);
            }
            else
            {
                if (allDoors.Count / 5 != 0)
                {
                    MessageBox.Show(allDoors.Count.ToString());
                    bm = new Bitmap(900, ((int)(allDoors.Count / 5)) * 210);
                }
                else
                {
                    bm = new Bitmap(900, 1);
                }
            }
            Graphics g = Graphics.FromImage(bm);

            foreach(Door d in allDoors)
            {
                cnt += 1;
                int tmp = cnt % 5;
                if (tmp == 0)
                    starty += 210;
                drawDoor(new Point(tmp * 150 + 20, starty), g, d);
            }
            mainpb.Size = bm.Size;
            mainpb.Image = bm;
        }
        public static void krilaAll()
        {
            krila.Items.Clear();
            Dictionary<Tuple<double, double, double>, Tuple<int, int>> dic = new Dictionary<Tuple<double, double, double>, Tuple<int, int>>();
            foreach (Door d in allDoors)
            {
                Tuple<int, int> result;
                if (dic.TryGetValue(d.Krila(), out result))
                {
                    dic.Remove(d.Krila());
                    if (d.right)
                    {
                        dic.Add(d.Krila(), Tuple.Create(result.Item1+1, result.Item2+1));
                    }
                    else 
                    {
                        dic.Add(d.Krila(), Tuple.Create(result.Item1 + 1, result.Item2));
                    }
                    
                }
                else
                {
                    if (d.right)
                    {
                        dic.Add(d.Krila(), Tuple.Create(1, 1));
                    }
                    else
                    {
                        dic.Add(d.Krila(), Tuple.Create(1, 0));
                    }

                }
            }
            foreach(KeyValuePair<Tuple<double, double, double>, Tuple<int, int>> item in dic)
            {
                string t = (item.Value.Item1 * item.Key.Item1).ToString() + "kom x " + item.Key.Item2.ToString() + "cm x " + item.Key.Item3.ToString() + "cm. Od toga: " + (item.Value.Item2).ToString() + "x DESNA i " + (item.Value.Item1 - item.Value.Item2).ToString() + "x LEVA!";
                krila.Items.Add(t);
            }
        }
        public static void mdf28All()
        {
            mdf28.Items.Clear();
            Dictionary<Tuple<double, double>, double> dic1 = new Dictionary<Tuple<double, double>, double>();
            Dictionary<Tuple<double, double>, double> dic2 = new Dictionary<Tuple<double, double>, double>();
            foreach (Door d in allDoors)
            {
                double result;
                Tuple<double, double> tmp = new Tuple<double, double>(d.mdf28().Item1.Item2, d.mdf28().Item1.Item3);
                if (dic1.TryGetValue(tmp, out result))
                {
                    dic1.Remove(tmp);
                    dic1.Add(tmp, result + d.mdf28().Item1.Item1);
                }
                else
                {
                    dic1.Add(tmp, d.mdf28().Item1.Item1);
                }
                Tuple<double, double> tmp2 = new Tuple<double, double>(d.mdf28().Item2.Item2, d.mdf28().Item2.Item3);
                if (dic2.TryGetValue(tmp2, out result))
                {
                    dic2.Remove(tmp2);
                    dic2.Add(tmp2, result + d.mdf28().Item2.Item1);
                }
                else
                {
                    dic2.Add(tmp2, d.mdf28().Item2.Item1);
                }
            }
            int l1 = dic1.Count();
            int l2 = dic2.Count();
            int m = Math.Min(l1, l2);
            int i = 0;
            for(; i < m; i++)
            {
                KeyValuePair<Tuple<double, double>, double> prvi = dic1.ElementAt(i);
                KeyValuePair<Tuple<double, double>, double> drugi = dic2.ElementAt(i);
                string t = prvi.Value.ToString() + "kom x " + prvi.Key.Item1.ToString() + "cm x " + prvi.Key.Item2.ToString() + "cm \t \t"
                          + drugi.Value.ToString() + "kom x " + drugi.Key.Item1.ToString() + "cm x " + drugi.Key.Item2.ToString() + "cm";
                mdf28.Items.Add(t);
            }
            while(i < l1)
            {
                KeyValuePair<Tuple<double, double>, double> prvi = dic1.ElementAt(i);
                string t = prvi.Value.ToString() + "kom x " + prvi.Key.Item1.ToString() + "cm x " + prvi.Key.Item2.ToString() + "cm";
                mdf28.Items.Add(t);
                i++;
            }
            while (i < l2)
            {
                KeyValuePair<Tuple<double, double>, double> drugi = dic2.ElementAt(i);
                string t = "\t \t \t \t" + drugi.Value.ToString() + "kom x " + drugi.Key.Item1.ToString() + "cm x " + drugi.Key.Item2.ToString() + "cm";
                mdf28.Items.Add(t);
                i++;
            }
            /*foreach (KeyValuePair<Tuple<Tuple<double, double, double>, Tuple<double, double, double>>, int> item in dic)
            {
                string t = (item.Value * item.Key.Item1.Item1).ToString() + "kom x " + item.Key.Item1.Item2.ToString() + "cm x " + item.Key.Item1.Item3.ToString() + "cm \t \t"
                           + (item.Value * item.Key.Item2.Item1).ToString() + "kom x " + item.Key.Item2.Item2.ToString() + "cm x " + item.Key.Item2.Item3.ToString() + "cm";
                mdf28.Items.Add(t);
            }*/
        }
        public static void mdf18All()
        {
            mdf18.Items.Clear();
            Dictionary<Tuple<double, double>, double> dic1 = new Dictionary<Tuple<double, double>, double>();
            foreach (Door d in allDoors)
            {
                double result;
                Tuple<double, double> tmp = new Tuple<double, double>(d.mdf18().Item1.Item2, d.mdf18().Item1.Item3);
                if (dic1.TryGetValue(tmp, out result))
                {
                    dic1.Remove(tmp);
                    dic1.Add(tmp, result + d.mdf18().Item1.Item1);
                }
                else
                {
                    dic1.Add(tmp, d.mdf18().Item1.Item1);
                }
                Tuple<double, double> tmp2 = new Tuple<double, double>(d.mdf18().Item2.Item2, d.mdf18().Item2.Item3);
                if (dic1.TryGetValue(tmp2, out result))
                {
                    dic1.Remove(tmp2);
                    dic1.Add(tmp2, result + d.mdf18().Item2.Item1);
                }
                else
                {
                    dic1.Add(tmp2, d.mdf18().Item2.Item1);
                }
            }
            foreach (KeyValuePair<Tuple<double, double>, double> item in dic1)
            {
                if (item.Value != 0)
                {
                    string t = item.Value.ToString() + "kom x " + item.Key.Item1.ToString() + "cm x " + item.Key.Item2.ToString() + "cm";
                    mdf18.Items.Add(t);
                }
            }

        }
        public static void mdf16All()
        {
            mdf16.Items.Clear();
            Dictionary<Tuple<double, double>, double> dic1 = new Dictionary<Tuple<double, double>, double>();
            foreach (Door d in allDoors)
            {
                double result;
                Tuple<double, double> tmp = new Tuple<double, double>(d.mdf16().Item1.Item2, d.mdf16().Item1.Item3);
                if (dic1.TryGetValue(tmp, out result))
                {
                    dic1.Remove(tmp);
                    dic1.Add(tmp, result + d.mdf16().Item1.Item1);
                }
                else
                {
                    dic1.Add(tmp, d.mdf16().Item1.Item1);
                }
                Tuple<double, double> tmp2 = new Tuple<double, double>(d.mdf16().Item2.Item2, d.mdf16().Item2.Item3);
                if (dic1.TryGetValue(tmp2, out result))
                {
                    dic1.Remove(tmp2);
                    dic1.Add(tmp2, result + d.mdf16().Item2.Item1);
                }
                else
                {
                    dic1.Add(tmp2, d.mdf16().Item2.Item1);
                }
            }
            foreach (KeyValuePair<Tuple<double, double>, double> item in dic1)
            {
                if (item.Value != 0)
                {
                    string t = item.Value.ToString() + "kom x " + item.Key.Item1.ToString() + "cm x " + item.Key.Item2.ToString() + "cm";
                    mdf16.Items.Add(t);
                }
            }
        }
        public static void hdf4All()
        {
            hdf4.Items.Clear();
            Dictionary<Tuple<double, double, double>, int> dic = new Dictionary<Tuple<double, double, double>, int>();
            foreach (Door d in allDoors)
            {
                int result;
                if (dic.TryGetValue(d.hdf4(), out result))
                {
                    dic.Remove(d.hdf4());
                    dic.Add(d.hdf4(), result + 1);
                }
                else
                {
                    dic.Add(d.hdf4(), 1);
                }
            }
            foreach (KeyValuePair<Tuple<double, double, double>, int> item in dic)
            {
                string t = (item.Value * item.Key.Item1).ToString() + "kom x " + item.Key.Item2.ToString() + "cm x " + item.Key.Item3.ToString() + "cm";
                hdf4.Items.Add(t);
            }
        }
        public static void mdf22All()
        {
            mdf22.Items.Clear();
            Dictionary<Tuple<double, double, double>, int> dic = new Dictionary<Tuple<double, double, double>, int>();
            foreach (Door d in allDoors)
            {
                if (d.glass)
                {
                    int result;
                    if (dic.TryGetValue(d.mdf22(), out result))
                    {
                        dic.Remove(d.mdf22());
                        dic.Add(d.mdf22(), result + 1);
                    }
                    else
                    {
                        dic.Add(d.mdf22(), 1);
                    }
                }
            }
            foreach (KeyValuePair<Tuple<double, double, double>, int> item in dic)
            {
                string t = (item.Value * item.Key.Item1).ToString() + "kom x " + item.Key.Item2.ToString() + "cm x " + item.Key.Item3.ToString() + "cm";
                mdf22.Items.Add(t);
            }
        }
        public static void trakeAll()
        {
            mdf16.Items.Clear();
            Dictionary<double, double> dic1 = new Dictionary<double, double>();
            Dictionary<double, double> dic2 = new Dictionary<double, double>();
            foreach(Furnirana d in allDoors)
            {
                double result;
                double tmp = d.trake().Item1.Item2;
                if (dic1.TryGetValue(tmp, out result))
                {
                    dic1.Remove(tmp);
                    dic1.Add(tmp, result + d.trake().Item1.Item1);
                }
                else
                {
                    dic1.Add(tmp, d.trake().Item1.Item1);
                }
                double tmp2 = d.trake().Item2.Item2;
                if (dic2.TryGetValue(tmp2, out result))
                {
                    dic2.Remove(tmp2);
                    dic2.Add(tmp2, result + d.trake().Item2.Item1);
                }
                else
                {
                    dic2.Add(tmp2, d.trake().Item2.Item1);
                }
            }
            foreach(KeyValuePair<double, double> item in dic1)
            {
                if (item.Value != 0)
                {
                    string t = item.Value.ToString() + "kom x " + item.Key + "cm";
                    mdf16.Items.Add(t);
                }
            }
            foreach (KeyValuePair<double, double> item in dic2)
            {
                if (item.Value != 0)
                {
                    string t = item.Value.ToString() + "kom x " + item.Key + "cm";
                    mdf16.Items.Add(t);
                }
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (doortype.SelectedIndex > -1)
            {
                Adding newdoor = new Adding();
                newdoor.Owner = this;
                newdoor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Izaberite prvo tip vrata!");
            }
        }
        private void remove_Click(object sender, EventArgs e)
        {
            if (allDoors.Count > 0)
            {
                allDoors.RemoveAt(allDoors.Count - 1);
                Form1.drawAll();
                Form1.krilaAll();
                Form1.mdf28All();
                Form1.mdf18All();
                Form1.mdf16All();
                Form1.hdf4All();
                Form1.mdf22All();
            }
        }
        private void create_Click(object sender, EventArgs e)
        {
            createtex();
        }
        private void doortype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(doortype.SelectedIndex == 3)
            {
                mdf16lab.Text = "Hrast. trake";
                mdf22lab.Text = "MDF28Staklo";
            }
        }

        LatexDocument.Document lt;
        Scintilla TextArea;
        private const int BACK_COLOR = 0xB7B7B7;
        private const int FORE_COLOR = 0x2A211C;
        private const int NUMBER_MARGIN = 1;

        private void InitNumberMargin()
        {

            TextArea.Styles[ScintillaNET.Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            TextArea.Styles[ScintillaNET.Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[ScintillaNET.Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[ScintillaNET.Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = TextArea.Margins[NUMBER_MARGIN];
            nums.Width = 10;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;
        }
        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            lt.RecreateDocument(TextArea.Text);
        }
        private void createtex()
        {
            TextArea = new Scintilla();
            TextArea.Dock = DockStyle.Fill;
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;

            InitNumberMargin();
            LatexDocumentMargins margins = new LatexDocumentMargins(0.25, 0.25, 0.75, 0.75);
            //lt = new LatexDocument.Document(@"C:\Program Files\MiKTeX 2.9\miktex\bin\x64\pdflatex.exe", @"C:\Users\stefa\Desktop\Porudzbine\", margins);
            lt = new LatexDocument.Document(@"C:\Program Files\MiKTeX 2.9\miktex\bin\x64\pdflatex.exe", @"C:\Users\user\Desktop\Porudzbine\", margins);


            LatexFont font = new LatexFont();
            font.Size = LatexFont.TEXT_Huge;
            lt.StartCenterAlign();
            StringBuilder title_text = new StringBuilder(naslov.Text.TrimEnd());
            for (int i = 0; i < title_text.Length; i++)
            {
                if (title_text[i] == ' ')
                {
                    title_text[i] = '-';
                }
            }
            LatexTextTitle title = new LatexTextTitle(naslov.Text.TrimEnd(), font);
            lt.Add(title);
            lt.EndAlign();
            font.Size = LatexFont.DEFAULT_FONT;
            lt.Add(new LatexText(doortype.Text, font));
            lt.NewLine();

            Bitmap bm = new Bitmap(mainpb.Image);
            int j = 0;
            int c = bm.Height;
            while(c > 840)
            {
                Bitmap temp = bm.Clone(new Rectangle(0, 0, 900, 840), bm.PixelFormat);
                bm = bm.Clone(new Rectangle(0, 840, bm.Width, bm.Height-840), bm.PixelFormat);
                temp.Save(@"C:\Users\user\Desktop\Porudzbine\image" + j.ToString() + ".png");
                LatexImage itmp = new LatexImage(@"C:\Users\user\Desktop\Porudzbine\image" + j.ToString()+".png", 0.8);
                lt.Add(itmp);
                c = c - 840;
                j++;
                lt.NewPage();
            }
            bm.Save(@"C:\Users\user\Desktop\Porudzbine\image" + (j).ToString() + ".png");
            //bm.Save(@"C:\Users\stefa\Desktop\Porudzbine\image" + (j).ToString()+".png");
            LatexImage img = new LatexImage(@"C:\Users\user\Desktop\Porudzbine\image" + (j).ToString() + ".png", 0.8);
            //LatexImage img = new LatexImage(@"C:\Users\stefa\Desktop\Porudzbine\image" + (j).ToString() + ".png", 0.8);
            lt.Add(img);
            if (allDoors.Count > 5)
                lt.NewPage();
            else
            {
                lt.NewLine();
                lt.NewLine();
                lt.NewLine();
            }
            
            font.Type = LatexFont.TEXT_BOLD;
            lt.Add(new LatexText("Vratno krilo: ", font));
            font.Type = null;
            lt.Add(new LatexText(krilatb.Text, font));
            List<string> tmp = new List<string>();
            foreach(string i in krila.Items)
            {
                tmp.Add(i);
            }
            lt.Add(new LatexList(LatexList.BULLET, tmp));
            tmp.Clear();

            font.Type = LatexFont.TEXT_BOLD;
            lt.Add(new LatexText("MDF28mm: ", font));
            font.Type = null;
            lt.Add(new LatexText(mdf28tb.Text, font));
            foreach (string i in mdf28.Items)
            {
                string o = "";
                if (!char.IsWhiteSpace(i[0]))
                {
                    int p = i.IndexOf('c');
                    string tmp1 = i.Substring(p + 1);
                    p += tmp1.IndexOf('c');
                    o = i.Substring(0, p + 3) + " \\quad \\quad" + i.Substring(p + 3);
                }
                else
                {
                    o = " \\quad \\quad \\quad \\quad \\quad \\quad \\quad \\quad \\quad \\quad \\quad \\quad" + i;
                }
                
                tmp.Add(o);
            }
            lt.Add(new LatexList(LatexList.BULLET, tmp));
            tmp.Clear();

            font.Type = LatexFont.TEXT_BOLD;
            lt.Add(new LatexText("MDF18mm: ", font));
            font.Type = null;
            lt.Add(new LatexText(mdf18tb.Text, font));
            foreach (string i in mdf18.Items)
            {
                tmp.Add(i);
            }
            lt.Add(new LatexList(LatexList.BULLET, tmp));
            tmp.Clear();
            if (doortype.SelectedIndex == 3)
            {
                font.Type = LatexFont.TEXT_BOLD;
                lt.Add(new LatexText("Hrastove trake: ", font));
                font.Type = null;
                lt.Add(new LatexText(mdf16tb.Text, font));
                foreach (string i in mdf16.Items)
                {
                    tmp.Add(i);
                }
                lt.Add(new LatexList(LatexList.BULLET, tmp));
                tmp.Clear();

                if (mdf22.Items.Count != 0)
                {
                    font.Type = LatexFont.TEXT_BOLD;
                    lt.Add(new LatexText("MDF28mmStaklo: ", font));
                    font.Type = null;
                    lt.Add(new LatexText(mdf22tb.Text, font));
                    foreach (string i in mdf22.Items)
                    {
                        tmp.Add(i);
                    }
                    lt.Add(new LatexList(LatexList.BULLET, tmp));
                    tmp.Clear();
                }
            }
            else
            {
                font.Type = LatexFont.TEXT_BOLD;
                lt.Add(new LatexText("MDF16mm: ", font));
                font.Type = null;
                lt.Add(new LatexText(mdf16tb.Text, font));
                foreach (string i in mdf16.Items)
                {
                    tmp.Add(i);
                }
                lt.Add(new LatexList(LatexList.BULLET, tmp));
                tmp.Clear();

                font.Type = LatexFont.TEXT_BOLD;
                lt.Add(new LatexText("HDF4mm: ", font));
                font.Type = null;
                lt.Add(new LatexText(hdf4.Text, font));
                foreach (string i in hdf4.Items)
                {
                    tmp.Add(i);
                }
                lt.Add(new LatexList(LatexList.BULLET, tmp));
                tmp.Clear();

                if (mdf22.Items.Count != 0)
                {
                    font.Type = LatexFont.TEXT_BOLD;
                    lt.Add(new LatexText("MDF22mm: ", font));
                    font.Type = null;
                    lt.Add(new LatexText(mdf22tb.Text, font));
                    foreach (string i in mdf22.Items)
                    {
                        tmp.Add(i);
                    }
                    lt.Add(new LatexList(LatexList.BULLET, tmp));
                    tmp.Clear();
                }
            }
            lt.CreatePdf(title_text.ToString(), true);

            string[] aux = System.IO.Directory.GetFiles(@"C:\Users\user\Desktop\Porudzbine\", "*.aux");
            foreach (string file in aux)
            {
                System.IO.File.Delete(file);
            }
            string[] tex = System.IO.Directory.GetFiles(@"C:\Users\user\Desktop\Porudzbine\", "*.tex");
            foreach (string file in tex)
            {
                System.IO.File.Delete(file);
            }
            string[] log = System.IO.Directory.GetFiles(@"C:\Users\user\Desktop\Porudzbine\", "*.log");
            foreach (string file in log)
            {
                System.IO.File.Delete(file);
            }
            string[] png = System.IO.Directory.GetFiles(@"C:\Users\user\Desktop\Porudzbine\", "*.png");
            foreach (string file in png)
            {
                System.IO.File.Delete(file);
            }
            /*string[] dirs = System.IO.Directory.GetDirectories(@"C:\Users\user\Desktop\Porudzbine\");
            foreach (string dir in dirs)
            {
                System.IO.File.Delete(dir);
            }*/
        }


    }
}

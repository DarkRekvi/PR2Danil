using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2Danil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Monster monstr1 = new Monster(10,10);
            Monster monstr2 = new Monster(20,20);
            Monster monstr3 = new Monster(30,30);
            Monster monstr4 = new Monster(40,40);
            Monster monstr5 = new Monster(50,50);
            Monster monstr6 = new Monster(60,60);
            Monster monstr7 = new Monster(70,70);
            Monster monstr8 = new Monster(80,80);
            Monster monstr9 = new Monster(90,90);
            Monster monstr10 = new Monster(100,100);

            List<String> healthes = new List<String>();

            healthes.Add(monstr1.health.ToString());
            healthes.Add(monstr2.health.ToString());
            healthes.Add(monstr3.health.ToString());
            healthes.Add(monstr4.health.ToString());
            healthes.Add(monstr5.health.ToString());
            healthes.Add(monstr6.health.ToString());
            healthes.Add(monstr7.health.ToString());
            healthes.Add(monstr8.health.ToString());
            healthes.Add(monstr9.health.ToString());
            healthes.Add(monstr10.health.ToString());

            listView1.Items.Add(monstr1.health.ToString());
            listView1.Items.Add(monstr2.health.ToString());
            listView1.Items.Add(monstr3.health.ToString());
            listView1.Items.Add(monstr4.health.ToString());
            listView1.Items.Add(monstr5.health.ToString());
            listView1.Items.Add(monstr6.health.ToString());
            listView1.Items.Add(monstr7.health.ToString());
            listView1.Items.Add(monstr8.health.ToString());
            listView1.Items.Add(monstr9.health.ToString());
            listView1.Items.Add(monstr10.health.ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Items.Add("70");
            listView1.Items.Add("80");
            listView1.Items.Add("90");
            listView1.Items.Add("100");
        }
    }

    class Monster
    {
        private int _health;
        private int _power;
        public int health
        {
            get { return _health; }
            set
            {
                if (value > 100)
                {
                    _health = 100;
                }

                else if (value < 1)
                {
                    _health = 1;
                }

                else
                {
                    _health = value;
                }
            }
        }

        public int power
        {
            get { return _power; }
            set
            {
                if (value > 100)
                {
                    _power = 100;
                }

                else if (value < 1)
                {
                    _power = 1;
                }

                else
                {
                    _power = value;
                }
            }
        }

        public Monster(int hp, int pw)
        {
            health = hp;
            power = pw;
        }

    }
}

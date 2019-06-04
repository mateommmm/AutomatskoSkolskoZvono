using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automatsko_školsko_zvono_MM;

namespace Automatsko_školsko_zvono_MM.Forme
{

   
    public partial class BigScreen : Form
    {
        
        public BigScreen()
        {
            InitializeComponent();
     
        }

        public string Poruka { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSati.Text = DateTime.Now.ToString("HH:mm");
            labelSec.Text = DateTime.Now.ToString("ss");
            labelDatum.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelDan.Text = DateTime.Now.ToString("dddd").ToUpper();
          
        }

        private void labelDan_Click(object sender, EventArgs e)
        {

        }

        private void BigScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelMsg.Text = Poruka;//Preuzimanje poruke

            labelMsg.Location = new Point(labelMsg.Location.X + 5, labelMsg.Location.Y);//Početak poruke

            if (labelMsg.Location.X > this.Width)//ako poruka dođe do kraja ekrana
            {
                labelMsg.Location = new Point(0 - labelMsg.Width, labelMsg.Location.Y);//kreće opet s animacijom
            }
        }
    }
}

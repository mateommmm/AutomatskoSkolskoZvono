﻿using Automatsko_školsko_zvono_MM.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Automatsko_školsko_zvono_MM
{
    public partial class FormUI : Form
    {
        private int satiPocetak, minutePocetak, sekundePocetak;
        int minuta,minuta2;
        int prviSat,drugiSat, treciSat, cetvrtiSat,  petiSat, sestiSat, sedmiSat,kraj;
        BigScreen bigScreen = new BigScreen();
        String url;
     

        //sendmsg and release capture za pomicanje forme
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;



        //kod za zakrivljene rubove forme
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );



        public FormUI()
        {
            InitializeComponent();
            //zakrivljavanje rubova
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.MouseDown += new MouseEventHandler(move_window);//mouse event za pomicanje forme

            labelMsg.MaximumSize = new Size(300, 400);
            labelMsg.AutoSize = true;

        }
        //klasa za pomicanje forme bez rubova
        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Icon TheIcon { get; private set; }


        //minimiziranje forme
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.Visible = true;
        }


        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;


        }

        //timer za sat u formi
        private void timer_Tick(object sender, EventArgs e)
        {
            labelSatiMinute.Text = DateTime.Now.ToString("HH:mm");
            labelSec.Text = DateTime.Now.ToString("ss");
            labelDatum.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelDan.Text = DateTime.Now.ToString("dddd").ToUpper();
        }

      

        private void FormUI_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;


        }

    

        //exit iz minimized appsa
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        //prikazi formu nakon klika na show
        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        void Play()//pokreni muziku
        {
            axPlayer.URL = url;
        }
        void Stop()//zaustavi muziku
        {
            axPlayer.Ctlcontrols.stop();
        }

      
        //timer, periodno izvršavanje koda(za svaki tick)
        private void timerCheck_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
           
         
            if (now >= startaj && (int)now.DayOfWeek <= 4 && now.DayOfWeek >= 0) //ako je sada ili vise od pocetka pocetak i ako je raadni dan
            {
                if (radioButtonUjutro.Checked || radioButtonPoslijepodne.Checked)
                {

                    if (now.Hour == satiPocetak && now.Minute == minutePocetak - 1 && now.Second == sekundePocetak)
                    {
                        Play();
                        lblSat.Text = "Zadnja minuta prije početka nastave";

                    }
                    else if (now.Hour == satiPocetak && now.Minute == minutePocetak && now.Second == sekundePocetak)//prvi
                    {
                        Stop();
                        lblSat.Text = "Prvi sat";
                       
                    }
                    else if (now.Hour == satiPocetak && now.Minute == 45 && now.Second == 0)//kraj prvoga
                    {
                        Play();
                        lblSat.Text = "Prva stanka";
                        
                    }
                    else if (now.Hour == satiPocetak && now.Minute == 50 && now.Second == 0)//pocetak drugoga
                    {
                        Stop();
                        lblSat.Text = "Drugi sat";
                        
                    }
                    else if (now.Hour ==drugiSat  && now.Minute == 35 && now.Second == 0)//kraj drugoga
                    {
                        Play();
                       
                        lblSat.Text = "Druga stanka";
                    }
                    else if (now.Hour == drugiSat && now.Minute == 40 && now.Second == 0)//pocetak trecega
                    {
                        Stop();
                       
                        lblSat.Text = "Treći sat";
                    }
                    else if (now.Hour == treciSat && now.Minute == 25 && now.Second == 0)//kraj trecega
                    {
                        Play();
                      
                        lblSat.Text = "Veliki odmor";
                    }
                    else if (now.Hour == treciSat && now.Minute == 45 && now.Second == 0)//pocetak cetvrtoga
                    {
                        Stop();
                     
                        lblSat.Text = "Četvrti sat";
                    }
                    else if (now.Hour == cetvrtiSat && now.Minute == 30 && now.Second == 0)//kraj cetvrtoga
                    {
                        Play();
                      
                        lblSat.Text = "Četvrta stanka";
                    }
                    else if (now.Hour == cetvrtiSat && now.Minute == 35 && now.Second == 0)//pocetak petoga
                    {
                        Stop();
                       
                        lblSat.Text = "Peti sat";
                    }
                    else if (now.Hour == petiSat && now.Minute == 20 && now.Second == 0)//kraj petoga
                    {
                        Play();
                      
                        lblSat.Text = "Peta stanka";
                    }
                    else if (now.Hour == petiSat && now.Minute == 25 && now.Second ==0)//pocetak sestoga
                    {
                        Stop();
                       
                        lblSat.Text = "Šesti sat";
                    }
                    else if (now.Hour ==sestiSat && now.Minute == 10 && now.Second == 0)//kraj sestoga
                    {
                        Play();
                      
                        lblSat.Text = "Šesta stanka";
                    }
                    else if (now.Hour == sestiSat && now.Minute == 15 && now.Second == 0)//pocetak sedmoga
                    {
                        Stop();
                        lblSat.Text = "Sedmi sat";
                    }
                    else if (now.Hour == kraj && now.Minute == 0 && now.Second == 0)//kraj sedmoga
                    {
                        Play();
                        
                        lblSat.Text = "Kraj nastave";
                    }
                    else if (now.Hour == kraj && now.Minute == 5 && now.Second ==0)//kraj nastave
                    {
                        Stop();
                        lblSat.Text = "Zvono pokrenuto, čekanje početka";
                    }

                }
                else if(radioButtonDemo.Checked)
                {
                    if (minuta2 % 60 == 0)
                    {
                        if (minuta == 0)
                        {
                            Play();
                            minuta = 1;
                            lblSat.Text = "Sada imitiram odmor";
                        }
                        else if (minuta == 1)
                        {
                            Stop();
                            minuta = 0;
                            lblSat.Text = "Sada imitiram Sat";
                        }

                        
                    }
                   
                }
                minuta2++;
                                                                                 
            }
        }

        //varijabla za tekst na oglasnoj ploči
        public string poruka;

        //metoda za pokretanje sekundarnog ekrana
        public Screen GetSecondaryScreen()
        {
            if (Screen.AllScreens.Length == 1)
            {
                return null;
            }

            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Primary == false)
                {
                    return screen;
                }
            }

            return null;
        }

        private void btnPošalji_Click_1(object sender, EventArgs e)//Pošalji poruku na oglasnu ploču
        {
            poruka = textBoxMsg.Text;
            bigScreen.Poruka = poruka;
            labelMsg.Text = "Trenutna poruka za učenike: " + poruka;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikaciju izradio Mateo Mikulić 4.d(2018/2019) za potrebe završnoga rada. " +
                "\nAplikaciju je dozvoljeno koristiti. Aplikaciju nije dozvoljeno umnožavati u profitabilne svrhe." +
                " \nZa sve ostale informacije obratite mi se na mail: mikulic.dev@gmail.com","O programu",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public DateTime startaj;

        private void buttonPokreni_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(dtPickerPocetak.Value.Year, dtPickerPocetak.Value.Month, dtPickerPocetak.Value.Day, satiPocetak, minutePocetak, sekundePocetak);
            //uzimanje trajanja sata sa nuda
        
            DateTime sada = DateTime.Now;
            
            startaj = start;
           
            
            //pogledaj koja smo smjena
            if (radioButtonUjutro.Checked)
            {
                satiPocetak = 08;
                minutePocetak = 00;
                sekundePocetak = 00;

                drugiSat = 9;
                treciSat = 10;
                cetvrtiSat = 11;
                petiSat = 12;
                sestiSat = 13;
                kraj = 14;
               

            }
            else if(radioButtonPoslijepodne.Checked)
            {
                satiPocetak = 14;
                minutePocetak = 00;
                sekundePocetak = 00;

                drugiSat = 15;
                treciSat = 16;
                cetvrtiSat = 17;
                petiSat = 18;
                sestiSat = 19;
                kraj = 20;
            }
           else if(radioButtonDemo.Checked)
            {
                minuta = 0;
                minuta2 = 0;
            }

            //odabir glazbe
            if (glazbaStrana.Checked)
            {
                url = "https://hr-youfm-justmusic.sslcast.addradio.de/hr/youfm/justmusic/mp3/128/stream.mp3";
            }
            else if (glazbaDomaca.Checked)
            {
                url = "http://live.narodni.hr:8175/;";
            }
            else
                url = "https://hr-youfm-justmusic.sslcast.addradio.de/hr/youfm/justmusic/mp3/128/stream.mp3";

          

            timerCheck.Start();//startanje timera


          
            //ako je spojeno više monitora pokreni oglasni screen
              if (Screen.AllScreens.Length > 1)
               {



                   //manualna pozicija forme
                   bigScreen.StartPosition = FormStartPosition.Manual;

                   // Get sekundarni screen
                   Screen screen = GetSecondaryScreen();





                   bigScreen.Show();//pokaži oglasnu ploču

               }

            lblSat.Text = "Zvono pokrenuto, čekanje početka";

            if(radioButtonDemo.Checked)
            {
                MessageBox.Show("Pokrenuli ste školsko zvono u demo verziji, ne preporuča se dugotrajan rad u ovom režimu!", "Zvono pokrenuto u demo verziji", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                poruka = "Pokrenuli ste školsko zvono u demo verziji, ne preporuča se dugotrajan rad u ovom režimu!";
                bigScreen.Poruka = poruka;
            }
            else
                MessageBox.Show("Pokrenuli ste školsko zvono!", "Zvono pokrenuto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


    }
}


using Automatsko_školsko_zvono_MM.Forme;
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
        public int trajanje;
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



        private void Pokreni()
        {

        }

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


        private void labelStartDate_Click(object sender, EventArgs e)
        {

        }

        //minimiziranje forme
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.Visible = true;
        }

        //exit iz notifyicona
        private void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;


        }



        private void labelPoruka_Click(object sender, EventArgs e)
        {

        }

        private void labelSatiMinute_Click(object sender, EventArgs e)
        {

        }

        //timer za sat u formi
        private void timer_Tick(object sender, EventArgs e)
        {
            labelSatiMinute.Text = DateTime.Now.ToString("HH:mm");
            labelSec.Text = DateTime.Now.ToString("ss");
            labelDatum.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelDan.Text = DateTime.Now.ToString("dddd").ToUpper();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

            DateTime prethodniSat = new DateTime();

           
            


            if (now >= startaj && (int)now.DayOfWeek <= 4 && now.DayOfWeek >= 0) //ako je sada ili vise od pocetka pocetak i ako je raadni dan
            {
               

                    if (now.Hour == satiPocetak && now.Minute == minutePocetak - 1 && now.Second == sekundePocetak)
                    {

                    Play();
                    

                     }
                    else if (now.Hour == satiPocetak && now.Minute == minutePocetak && now.Second == sekundePocetak)//prvi
                    {
                    Stop();
                    
                    }
                    else if (now.Hour == satiPocetak && now.Minute == minutePocetak + trajanje && now.Second == sekundePocetak)//kraj prvoga
                    {
                    Play();
                        prethodniSat = now.AddMinutes(5);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//pocetak drugoga
                    {
                        Stop();

                        prethodniSat = now.AddMinutes(trajanje);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//kraj drugoga
                    {
                        Play();
                        prethodniSat = now.AddMinutes(5);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//pocetak trecega
                    {
                        Stop();
                        prethodniSat = now.AddMinutes(trajanje);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//kraj trecega
                    {
                    Play();
                        prethodniSat = now.AddMinutes(20);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//pocetak cetvrtoga
                    {
                        Stop();
                        prethodniSat = now.AddMinutes(trajanje);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//kraj cetvrtoga
                    {
                        Play();
                        prethodniSat = now.AddMinutes(5);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//pocetak petoga
                    {
                        Stop();
                        prethodniSat = now.AddMinutes(trajanje);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//kraj petoga
                    {
                    Play();
                        prethodniSat = now.AddMinutes(5);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//pocetak sestoga
                    {
                        Stop();
                        prethodniSat = now.AddMinutes(trajanje);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//kraj sestoga
                    {
                        Play();
                        prethodniSat = now.AddMinutes(5);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//pocetak sedmoga
                    {
                    Stop();
                        prethodniSat = now.AddMinutes(trajanje - 5);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//kraj sedmoga
                    {
                        Play();
                        prethodniSat = now.AddMinutes(5);
                    }
                    else if (now.Hour == prethodniSat.Hour && now.Minute == prethodniSat.Minute && now.Second == prethodniSat.Second)//kraj nastave
                    {
                        Stop();
                    }




                    
              
                


            }
        }

        private void axPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxSmjena_Enter(object sender, EventArgs e)
        {

            

        }
        //varijabla za tekst na oglasnoj ploči
        public string poruka;

        private void nUDTrajanje_ValueChanged(object sender, EventArgs e)
        {
            nUDTrajanje.Maximum = 45;
            nUDTrajanje.Minimum = 0;
        }

        private void btnPošalji_Click(object sender, EventArgs e)
        {


        }


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikaciju izradio Mateo Mikulić 4.d(2018/2019) za potrebe završnoga rada. " +
                "\nAplikaciju je dozvoljeno koristiti. Aplikaciju nije dozvoljeno umnožavati u profitabilne svrhe." +
                " \nZa sve ostale informacije obratite mi se na mail: mikulic.dev@gmail.com","O programu",MessageBoxButtons.OK);
        }

        public DateTime startaj;

        private void buttonPokreni_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(dtPickerPocetak.Value.Year, dtPickerPocetak.Value.Month, dtPickerPocetak.Value.Day, satiPocetak, minutePocetak, sekundePocetak);
            //uzimanje trajanja sata sa nuda
            trajanje = Decimal.ToInt32(nUDTrajanje.Value);
            
            startaj = start;
            
            //pogledaj koja smo smjena
            if (radioButtonUjutro.Checked)
            {
                satiPocetak = 8;
                minutePocetak = 00;
                sekundePocetak = 00;
            }
            else if(radioButtonPoslijepodne.Checked)
            {
                satiPocetak = 14;
                minutePocetak = 00;
                sekundePocetak = 00;
                
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



                   // Important !
                   bigScreen.StartPosition = FormStartPosition.Manual;

                   // Get the second monitor screen
                   Screen screen = GetSecondaryScreen();





                   bigScreen.Show();//pokaži oglasnu ploču

               }
               


        }


    }
}


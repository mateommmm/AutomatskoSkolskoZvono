namespace Automatsko_školsko_zvono_MM
{
    partial class FormUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.glazbaDomaca = new System.Windows.Forms.RadioButton();
            this.glazbaStrana = new System.Windows.Forms.RadioButton();
            this.btnPošalji = new System.Windows.Forms.Button();
            this.buttonPokreni = new System.Windows.Forms.Button();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.labelPoruka = new System.Windows.Forms.Label();
            this.groupBoxSmjena = new System.Windows.Forms.GroupBox();
            this.radioButtonPoslijepodne = new System.Windows.Forms.RadioButton();
            this.radioButtonUjutro = new System.Windows.Forms.RadioButton();
            this.labelMin = new System.Windows.Forms.Label();
            this.nUDTrajanje = new System.Windows.Forms.NumericUpDown();
            this.labelTrajanjeSata = new System.Windows.Forms.Label();
            this.dtPickerPocetak = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMsg = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelDan = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelSatiMinute = new System.Windows.Forms.Label();
            this.axPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSmjena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTrajanje)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnPošalji);
            this.panel1.Controls.Add(this.buttonPokreni);
            this.panel1.Controls.Add(this.textBoxMsg);
            this.panel1.Controls.Add(this.labelPoruka);
            this.panel1.Controls.Add(this.groupBoxSmjena);
            this.panel1.Controls.Add(this.labelMin);
            this.panel1.Controls.Add(this.nUDTrajanje);
            this.panel1.Controls.Add(this.labelTrajanjeSata);
            this.panel1.Controls.Add(this.dtPickerPocetak);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelStartDate);
            this.panel1.Location = new System.Drawing.Point(-8, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 489);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.glazbaDomaca);
            this.groupBox1.Controls.Add(this.glazbaStrana);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(306, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 128);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir glazbe";
            // 
            // glazbaDomaca
            // 
            this.glazbaDomaca.AutoSize = true;
            this.glazbaDomaca.Location = new System.Drawing.Point(7, 78);
            this.glazbaDomaca.Name = "glazbaDomaca";
            this.glazbaDomaca.Size = new System.Drawing.Size(75, 24);
            this.glazbaDomaca.TabIndex = 1;
            this.glazbaDomaca.Text = "Domaća";
            this.glazbaDomaca.UseVisualStyleBackColor = true;
            // 
            // glazbaStrana
            // 
            this.glazbaStrana.AutoSize = true;
            this.glazbaStrana.Checked = true;
            this.glazbaStrana.Location = new System.Drawing.Point(7, 32);
            this.glazbaStrana.Name = "glazbaStrana";
            this.glazbaStrana.Size = new System.Drawing.Size(63, 24);
            this.glazbaStrana.TabIndex = 0;
            this.glazbaStrana.TabStop = true;
            this.glazbaStrana.Text = "Strana";
            this.glazbaStrana.UseVisualStyleBackColor = true;
            // 
            // btnPošalji
            // 
            this.btnPošalji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPošalji.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPošalji.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPošalji.Location = new System.Drawing.Point(306, 388);
            this.btnPošalji.Name = "btnPošalji";
            this.btnPošalji.Size = new System.Drawing.Size(219, 48);
            this.btnPošalji.TabIndex = 10;
            this.btnPošalji.Text = "Pošalji poruku na oglasnu ploču";
            this.btnPošalji.UseVisualStyleBackColor = false;
            this.btnPošalji.Click += new System.EventHandler(this.btnPošalji_Click_1);
            // 
            // buttonPokreni
            // 
            this.buttonPokreni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonPokreni.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPokreni.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPokreni.Location = new System.Drawing.Point(42, 388);
            this.buttonPokreni.Name = "buttonPokreni";
            this.buttonPokreni.Size = new System.Drawing.Size(234, 48);
            this.buttonPokreni.TabIndex = 9;
            this.buttonPokreni.Text = "Pokreni automatsko školsko zvono";
            this.buttonPokreni.UseVisualStyleBackColor = false;
            this.buttonPokreni.Click += new System.EventHandler(this.buttonPokreni_Click);
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMsg.Location = new System.Drawing.Point(42, 214);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(482, 168);
            this.textBoxMsg.TabIndex = 8;
            // 
            // labelPoruka
            // 
            this.labelPoruka.AutoSize = true;
            this.labelPoruka.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoruka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelPoruka.Location = new System.Drawing.Point(38, 184);
            this.labelPoruka.Name = "labelPoruka";
            this.labelPoruka.Size = new System.Drawing.Size(140, 23);
            this.labelPoruka.TabIndex = 7;
            this.labelPoruka.Text = "Poruka za učenike";
            this.labelPoruka.Click += new System.EventHandler(this.labelPoruka_Click);
            // 
            // groupBoxSmjena
            // 
            this.groupBoxSmjena.Controls.Add(this.radioButtonPoslijepodne);
            this.groupBoxSmjena.Controls.Add(this.radioButtonUjutro);
            this.groupBoxSmjena.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSmjena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxSmjena.Location = new System.Drawing.Point(42, 66);
            this.groupBoxSmjena.Name = "groupBoxSmjena";
            this.groupBoxSmjena.Size = new System.Drawing.Size(255, 61);
            this.groupBoxSmjena.TabIndex = 6;
            this.groupBoxSmjena.TabStop = false;
            this.groupBoxSmjena.Text = "Smjena";
            this.groupBoxSmjena.Enter += new System.EventHandler(this.groupBoxSmjena_Enter);
            // 
            // radioButtonPoslijepodne
            // 
            this.radioButtonPoslijepodne.AutoSize = true;
            this.radioButtonPoslijepodne.Location = new System.Drawing.Point(117, 26);
            this.radioButtonPoslijepodne.Name = "radioButtonPoslijepodne";
            this.radioButtonPoslijepodne.Size = new System.Drawing.Size(107, 24);
            this.radioButtonPoslijepodne.TabIndex = 1;
            this.radioButtonPoslijepodne.Text = "Poslijepodne";
            this.radioButtonPoslijepodne.UseVisualStyleBackColor = true;
            // 
            // radioButtonUjutro
            // 
            this.radioButtonUjutro.AutoSize = true;
            this.radioButtonUjutro.Checked = true;
            this.radioButtonUjutro.Location = new System.Drawing.Point(7, 26);
            this.radioButtonUjutro.Name = "radioButtonUjutro";
            this.radioButtonUjutro.Size = new System.Drawing.Size(61, 24);
            this.radioButtonUjutro.TabIndex = 0;
            this.radioButtonUjutro.TabStop = true;
            this.radioButtonUjutro.Text = "Ujutro";
            this.radioButtonUjutro.UseVisualStyleBackColor = true;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(303, 36);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(35, 15);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "min.";
            // 
            // nUDTrajanje
            // 
            this.nUDTrajanje.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDTrajanje.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDTrajanje.Location = new System.Drawing.Point(249, 30);
            this.nUDTrajanje.Name = "nUDTrajanje";
            this.nUDTrajanje.Size = new System.Drawing.Size(48, 22);
            this.nUDTrajanje.TabIndex = 4;
            this.nUDTrajanje.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nUDTrajanje.ValueChanged += new System.EventHandler(this.nUDTrajanje_ValueChanged);
            // 
            // labelTrajanjeSata
            // 
            this.labelTrajanjeSata.AutoSize = true;
            this.labelTrajanjeSata.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTrajanjeSata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTrajanjeSata.Location = new System.Drawing.Point(245, 4);
            this.labelTrajanjeSata.Name = "labelTrajanjeSata";
            this.labelTrajanjeSata.Size = new System.Drawing.Size(99, 23);
            this.labelTrajanjeSata.TabIndex = 3;
            this.labelTrajanjeSata.Text = "Trajanje sata";
            // 
            // dtPickerPocetak
            // 
            this.dtPickerPocetak.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerPocetak.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtPickerPocetak.Location = new System.Drawing.Point(42, 30);
            this.dtPickerPocetak.Name = "dtPickerPocetak";
            this.dtPickerPocetak.Size = new System.Drawing.Size(170, 22);
            this.dtPickerPocetak.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelMsg);
            this.panel2.Controls.Add(this.labelDatum);
            this.panel2.Controls.Add(this.labelDan);
            this.panel2.Controls.Add(this.labelSec);
            this.panel2.Controls.Add(this.labelSatiMinute);
            this.panel2.Controls.Add(this.axPlayer);
            this.panel2.Location = new System.Drawing.Point(543, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 471);
            this.panel2.TabIndex = 1;
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelMsg.Location = new System.Drawing.Point(5, 210);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(204, 23);
            this.labelMsg.TabIndex = 5;
            this.labelMsg.Text = "Trenuta poruka za učenike: ";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelDatum.Location = new System.Drawing.Point(3, 98);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(153, 32);
            this.labelDatum.TabIndex = 4;
            this.labelDatum.Text = "DD/MM/YY";
            // 
            // labelDan
            // 
            this.labelDan.AutoSize = true;
            this.labelDan.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelDan.Location = new System.Drawing.Point(225, 95);
            this.labelDan.Name = "labelDan";
            this.labelDan.Size = new System.Drawing.Size(154, 32);
            this.labelDan.TabIndex = 3;
            this.labelDan.Text = "Ponedjeljak";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelSec.Location = new System.Drawing.Point(269, 59);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(28, 18);
            this.labelSec.TabIndex = 2;
            this.labelSec.Text = "00";
            // 
            // labelSatiMinute
            // 
            this.labelSatiMinute.AutoSize = true;
            this.labelSatiMinute.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSatiMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelSatiMinute.Location = new System.Drawing.Point(93, 2);
            this.labelSatiMinute.Name = "labelSatiMinute";
            this.labelSatiMinute.Size = new System.Drawing.Size(204, 75);
            this.labelSatiMinute.TabIndex = 1;
            this.labelSatiMinute.Text = "00:00";
            this.labelSatiMinute.Click += new System.EventHandler(this.labelSatiMinute_Click);
            // 
            // axPlayer
            // 
            this.axPlayer.Enabled = true;
            this.axPlayer.Location = new System.Drawing.Point(36, 147);
            this.axPlayer.Name = "axPlayer";
            this.axPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer.OcxState")));
            this.axPlayer.Size = new System.Drawing.Size(317, 47);
            this.axPlayer.TabIndex = 0;
            this.axPlayer.Enter += new System.EventHandler(this.axPlayer_Enter);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelStartDate.Location = new System.Drawing.Point(38, 4);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(114, 23);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "Datum početka";
            this.labelStartDate.Click += new System.EventHandler(this.labelStartDate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Automatsko_školsko_zvono_MM.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(881, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Automatsko_školsko_zvono_MM.Properties.Resources.bell;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Dvokliknite za vraćanje aplikacije u uvećani način";
            this.notifyIcon.BalloonTipTitle = "Minimizirali ste aplikaciju";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Automatsko školsko zvono";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemShow.Text = "Show";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // FormUI
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(919, 507);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatsko školsko zvono";
            this.Load += new System.EventHandler(this.FormUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSmjena.ResumeLayout(false);
            this.groupBoxSmjena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTrajanje)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dtPickerPocetak;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Label labelPoruka;
        private System.Windows.Forms.GroupBox groupBoxSmjena;
        private System.Windows.Forms.RadioButton radioButtonPoslijepodne;
        private System.Windows.Forms.RadioButton radioButtonUjutro;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.NumericUpDown nUDTrajanje;
        private System.Windows.Forms.Label labelTrajanjeSata;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonPokreni;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelDan;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelSatiMinute;
        private AxWMPLib.AxWindowsMediaPlayer axPlayer;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Button btnPošalji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton glazbaDomaca;
        private System.Windows.Forms.RadioButton glazbaStrana;
        private System.Windows.Forms.Label labelMsg;
    }
}


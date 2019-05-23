namespace Automatsko_školsko_zvono_MM.Forme
{
    partial class BigScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigScreen));
            this.labelSati = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelDan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMsg = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelSati
            // 
            this.labelSati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSati.AutoSize = true;
            this.labelSati.Font = new System.Drawing.Font("Century Gothic", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSati.ForeColor = System.Drawing.Color.White;
            this.labelSati.Location = new System.Drawing.Point(536, 209);
            this.labelSati.Name = "labelSati";
            this.labelSati.Size = new System.Drawing.Size(513, 206);
            this.labelSati.TabIndex = 0;
            this.labelSati.Text = "00:00";
            // 
            // labelSec
            // 
            this.labelSec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSec.ForeColor = System.Drawing.Color.White;
            this.labelSec.Location = new System.Drawing.Point(981, 359);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(103, 78);
            this.labelSec.TabIndex = 1;
            this.labelSec.Text = "00";
            // 
            // labelDatum
            // 
            this.labelDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatum.ForeColor = System.Drawing.Color.White;
            this.labelDatum.Location = new System.Drawing.Point(111, 458);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(565, 115);
            this.labelDatum.TabIndex = 2;
            this.labelDatum.Text = "DD/MM/YY";
            // 
            // labelDan
            // 
            this.labelDan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDan.AutoSize = true;
            this.labelDan.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDan.ForeColor = System.Drawing.Color.White;
            this.labelDan.Location = new System.Drawing.Point(974, 458);
            this.labelDan.Name = "labelDan";
            this.labelDan.Size = new System.Drawing.Size(696, 115);
            this.labelDan.TabIndex = 3;
            this.labelDan.Text = "PONEDJELJAK";
            this.labelDan.Click += new System.EventHandler(this.labelDan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMsg.ForeColor = System.Drawing.Color.White;
            this.labelMsg.Location = new System.Drawing.Point(13, 13);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(0, 32);
            this.labelMsg.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BigScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1692, 770);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.labelDan);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelSati);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BigScreen";
            this.Text = "BigScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BigScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSati;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelDan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Timer timer2;
    }
}
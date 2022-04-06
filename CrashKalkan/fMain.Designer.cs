﻿namespace CrashKalkan
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tmrResume = new System.Windows.Forms.Timer(this.components);
            this.lblSessionStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrintScreen = new System.Windows.Forms.Button();
            this.btnScrollLock = new System.Windows.Forms.Button();
            this.btnPauseBreak = new System.Windows.Forms.Button();
            this.lblLockSessionInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrNetwork = new System.Windows.Forms.Timer(this.components);
            this.lblAfkStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrResume
            // 
            this.tmrResume.Interval = 10000;
            this.tmrResume.Tick += new System.EventHandler(this.tmrResume_Tick);
            // 
            // lblSessionStatus
            // 
            this.lblSessionStatus.BackColor = System.Drawing.Color.Green;
            this.lblSessionStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSessionStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionStatus.ForeColor = System.Drawing.Color.White;
            this.lblSessionStatus.Location = new System.Drawing.Point(0, 393);
            this.lblSessionStatus.Name = "lblSessionStatus";
            this.lblSessionStatus.Size = new System.Drawing.Size(666, 31);
            this.lblSessionStatus.TabIndex = 2;
            this.lblSessionStatus.Text = "Sunucu kilitli değil!";
            this.lblSessionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnPrintScreen);
            this.groupBox1.Controls.Add(this.btnScrollLock);
            this.groupBox1.Controls.Add(this.btnPauseBreak);
            this.groupBox1.Controls.Add(this.lblLockSessionInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(175, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuşlar";
            // 
            // btnEnd
            // 
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnd.Image = global::CrashKalkan.Properties.Resources.end;
            this.btnEnd.Location = new System.Drawing.Point(6, 224);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(40, 38);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.TabStop = false;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(52, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "AFK sebebinden atılmamanızın için fareyi otomatik olarak haraket ettirir.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(52, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bağlantınızı 5 saniye boyunca keser.\r\n";
            // 
            // btnPrintScreen
            // 
            this.btnPrintScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrintScreen.Image = global::CrashKalkan.Properties.Resources.printscreen;
            this.btnPrintScreen.Location = new System.Drawing.Point(6, 180);
            this.btnPrintScreen.Name = "btnPrintScreen";
            this.btnPrintScreen.Size = new System.Drawing.Size(40, 38);
            this.btnPrintScreen.TabIndex = 6;
            this.btnPrintScreen.TabStop = false;
            this.btnPrintScreen.UseVisualStyleBackColor = true;
            this.btnPrintScreen.Click += new System.EventHandler(this.btnPrintScreen_Click);
            // 
            // btnScrollLock
            // 
            this.btnScrollLock.Image = global::CrashKalkan.Properties.Resources.scrolllock;
            this.btnScrollLock.Location = new System.Drawing.Point(6, 70);
            this.btnScrollLock.Name = "btnScrollLock";
            this.btnScrollLock.Size = new System.Drawing.Size(40, 38);
            this.btnScrollLock.TabIndex = 5;
            this.btnScrollLock.TabStop = false;
            this.btnScrollLock.UseVisualStyleBackColor = true;
            this.btnScrollLock.Click += new System.EventHandler(this.btnScrollLock_Click);
            // 
            // btnPauseBreak
            // 
            this.btnPauseBreak.Image = global::CrashKalkan.Properties.Resources.pausebreak;
            this.btnPauseBreak.Location = new System.Drawing.Point(6, 24);
            this.btnPauseBreak.Name = "btnPauseBreak";
            this.btnPauseBreak.Size = new System.Drawing.Size(40, 38);
            this.btnPauseBreak.TabIndex = 4;
            this.btnPauseBreak.TabStop = false;
            this.btnPauseBreak.UseVisualStyleBackColor = true;
            this.btnPauseBreak.Click += new System.EventHandler(this.btnPauseBreak_Click);
            // 
            // lblLockSessionInfo
            // 
            this.lblLockSessionInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockSessionInfo.Location = new System.Drawing.Point(52, 70);
            this.lblLockSessionInfo.Name = "lblLockSessionInfo";
            this.lblLockSessionInfo.Size = new System.Drawing.Size(248, 112);
            this.lblLockSessionInfo.TabIndex = 3;
            this.lblLockSessionInfo.Text = resources.GetString("lblLockSessionInfo.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sunucuda ki bağlantını keserek tek kalmanı sağlar.";
            // 
            // tmrNetwork
            // 
            this.tmrNetwork.Interval = 5000;
            this.tmrNetwork.Tick += new System.EventHandler(this.tmrNetwork_Tick);
            // 
            // lblAfkStatus
            // 
            this.lblAfkStatus.BackColor = System.Drawing.Color.Green;
            this.lblAfkStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAfkStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfkStatus.ForeColor = System.Drawing.Color.White;
            this.lblAfkStatus.Location = new System.Drawing.Point(0, 362);
            this.lblAfkStatus.Name = "lblAfkStatus";
            this.lblAfkStatus.Size = new System.Drawing.Size(666, 31);
            this.lblAfkStatus.TabIndex = 4;
            this.lblAfkStatus.Text = "Otomaik fare haraketi kapalı!";
            this.lblAfkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CrashKalkan.Properties.Resources.webicon;
            this.pictureBox1.Location = new System.Drawing.Point(616, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CrashKalkan.Properties.Resources.afisfinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAfkStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSessionStatus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crash Kalkan";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrResume;
        private System.Windows.Forms.Label lblSessionStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLockSessionInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScrollLock;
        private System.Windows.Forms.Button btnPauseBreak;
        private System.Windows.Forms.Button btnPrintScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrNetwork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblAfkStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


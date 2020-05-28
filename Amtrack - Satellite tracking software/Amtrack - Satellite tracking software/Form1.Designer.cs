﻿namespace Amtrack___Satellite_tracking_software
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Title = new System.Windows.Forms.Label();
            this.TLE_Files = new System.Windows.Forms.ListBox();
            this.TLE_Path = new System.Windows.Forms.Label();
            this.GetTLEPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Sats = new System.Windows.Forms.ListBox();
            this.UpdateTLE = new System.Windows.Forms.Label();
            this.TLE_Update = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sat_Name = new System.Windows.Forms.Label();
            this.Launch_Year = new System.Windows.Forms.Label();
            this.Catalog_Number = new System.Windows.Forms.Label();
            this.Track = new System.Windows.Forms.Button();
            this.Active_sats = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomSatUpdate = new System.Windows.Forms.Button();
            this.ObjectName = new System.Windows.Forms.TextBox();
            this.Line1 = new System.Windows.Forms.TextBox();
            this.Line2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(584, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "Amtrack";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TLE_Files
            // 
            this.TLE_Files.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLE_Files.FormattingEnabled = true;
            this.TLE_Files.ItemHeight = 15;
            this.TLE_Files.Location = new System.Drawing.Point(15, 143);
            this.TLE_Files.Name = "TLE_Files";
            this.TLE_Files.Size = new System.Drawing.Size(125, 169);
            this.TLE_Files.TabIndex = 1;
            this.TLE_Files.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TLE_Files_MouseDoubleClick);
            // 
            // TLE_Path
            // 
            this.TLE_Path.AutoSize = true;
            this.TLE_Path.BackColor = System.Drawing.SystemColors.Control;
            this.TLE_Path.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLE_Path.ForeColor = System.Drawing.Color.Black;
            this.TLE_Path.Location = new System.Drawing.Point(12, 50);
            this.TLE_Path.Name = "TLE_Path";
            this.TLE_Path.Size = new System.Drawing.Size(63, 15);
            this.TLE_Path.TabIndex = 2;
            this.TLE_Path.Text = "TLE-Path:";
            // 
            // GetTLEPath
            // 
            this.GetTLEPath.BackColor = System.Drawing.Color.Red;
            this.GetTLEPath.Location = new System.Drawing.Point(15, 83);
            this.GetTLEPath.Name = "GetTLEPath";
            this.GetTLEPath.Size = new System.Drawing.Size(180, 25);
            this.GetTLEPath.TabIndex = 3;
            this.GetTLEPath.Text = "Click to set TLE file location";
            this.GetTLEPath.UseVisualStyleBackColor = false;
            this.GetTLEPath.Click += new System.EventHandler(this.GetTLEPath_Click);
            // 
            // Sats
            // 
            this.Sats.FormattingEnabled = true;
            this.Sats.ItemHeight = 15;
            this.Sats.Location = new System.Drawing.Point(337, 143);
            this.Sats.Name = "Sats";
            this.Sats.Size = new System.Drawing.Size(235, 169);
            this.Sats.TabIndex = 4;
            this.Sats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Sats_MouseDoubleClick);
            // 
            // UpdateTLE
            // 
            this.UpdateTLE.AutoSize = true;
            this.UpdateTLE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTLE.Location = new System.Drawing.Point(173, 125);
            this.UpdateTLE.Name = "UpdateTLE";
            this.UpdateTLE.Size = new System.Drawing.Size(129, 15);
            this.UpdateTLE.TabIndex = 5;
            this.UpdateTLE.Text = "Update/Downlaod TLE:";
            // 
            // TLE_Update
            // 
            this.TLE_Update.FormattingEnabled = true;
            this.TLE_Update.ItemHeight = 15;
            this.TLE_Update.Location = new System.Drawing.Point(176, 143);
            this.TLE_Update.Name = "TLE_Update";
            this.TLE_Update.Size = new System.Drawing.Size(125, 169);
            this.TLE_Update.TabIndex = 6;
            this.TLE_Update.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TLE_Update_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "TLE-files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Available satellites in:";
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(82, 50);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(30, 15);
            this.Path.TabIndex = 9;
            this.Path.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Satellite name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Year of launch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Catalog number:";
            // 
            // Sat_Name
            // 
            this.Sat_Name.AutoSize = true;
            this.Sat_Name.BackColor = System.Drawing.Color.Red;
            this.Sat_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sat_Name.Location = new System.Drawing.Point(109, 468);
            this.Sat_Name.Name = "Sat_Name";
            this.Sat_Name.Size = new System.Drawing.Size(32, 17);
            this.Sat_Name.TabIndex = 14;
            this.Sat_Name.Text = "N/A";
            // 
            // Launch_Year
            // 
            this.Launch_Year.AutoSize = true;
            this.Launch_Year.BackColor = System.Drawing.Color.Red;
            this.Launch_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Launch_Year.Location = new System.Drawing.Point(259, 468);
            this.Launch_Year.Name = "Launch_Year";
            this.Launch_Year.Size = new System.Drawing.Size(32, 17);
            this.Launch_Year.TabIndex = 15;
            this.Launch_Year.Text = "N/A";
            // 
            // Catalog_Number
            // 
            this.Catalog_Number.AutoSize = true;
            this.Catalog_Number.BackColor = System.Drawing.Color.Red;
            this.Catalog_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Catalog_Number.Location = new System.Drawing.Point(404, 468);
            this.Catalog_Number.Name = "Catalog_Number";
            this.Catalog_Number.Size = new System.Drawing.Size(32, 17);
            this.Catalog_Number.TabIndex = 16;
            this.Catalog_Number.Text = "N/A";
            // 
            // Track
            // 
            this.Track.Location = new System.Drawing.Point(135, 505);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(130, 30);
            this.Track.TabIndex = 17;
            this.Track.Text = "Track satellite";
            this.Track.UseVisualStyleBackColor = true;
            this.Track.Click += new System.EventHandler(this.Track_Click);
            // 
            // Active_sats
            // 
            this.Active_sats.Location = new System.Drawing.Point(335, 505);
            this.Active_sats.Name = "Active_sats";
            this.Active_sats.Size = new System.Drawing.Size(130, 30);
            this.Active_sats.TabIndex = 18;
            this.Active_sats.Text = "Visible sats in TLE";
            this.Active_sats.UseVisualStyleBackColor = true;
            this.Active_sats.Click += new System.EventHandler(this.Active_sats_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "1st line:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "2nd line:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Custom TLE:";
            // 
            // CustomSatUpdate
            // 
            this.CustomSatUpdate.Location = new System.Drawing.Point(487, 361);
            this.CustomSatUpdate.Name = "CustomSatUpdate";
            this.CustomSatUpdate.Size = new System.Drawing.Size(75, 50);
            this.CustomSatUpdate.TabIndex = 23;
            this.CustomSatUpdate.Text = "Update satellite";
            this.CustomSatUpdate.UseVisualStyleBackColor = true;
            this.CustomSatUpdate.Click += new System.EventHandler(this.CustomSatUpdate_Click);
            // 
            // ObjectName
            // 
            this.ObjectName.Location = new System.Drawing.Point(101, 348);
            this.ObjectName.Name = "ObjectName";
            this.ObjectName.Size = new System.Drawing.Size(380, 22);
            this.ObjectName.TabIndex = 24;
            // 
            // Line1
            // 
            this.Line1.Location = new System.Drawing.Point(101, 376);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(380, 22);
            this.Line1.TabIndex = 25;
            // 
            // Line2
            // 
            this.Line2.Location = new System.Drawing.Point(101, 404);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(380, 22);
            this.Line2.TabIndex = 26;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.ObjectName);
            this.Controls.Add(this.CustomSatUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Active_sats);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.Catalog_Number);
            this.Controls.Add(this.Launch_Year);
            this.Controls.Add(this.Sat_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TLE_Update);
            this.Controls.Add(this.UpdateTLE);
            this.Controls.Add(this.Sats);
            this.Controls.Add(this.GetTLEPath);
            this.Controls.Add(this.TLE_Path);
            this.Controls.Add(this.TLE_Files);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form";
            this.Text = "Amtrack - By Victor Boesen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox TLE_Files;
        private System.Windows.Forms.Label TLE_Path;
        private System.Windows.Forms.Button GetTLEPath;
        private System.Windows.Forms.ListBox Sats;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label UpdateTLE;
        private System.Windows.Forms.ListBox TLE_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Sat_Name;
        private System.Windows.Forms.Label Launch_Year;
        private System.Windows.Forms.Label Catalog_Number;
        private System.Windows.Forms.Button Track;
        private System.Windows.Forms.Button Active_sats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CustomSatUpdate;
        private System.Windows.Forms.TextBox ObjectName;
        private System.Windows.Forms.TextBox Line1;
        private System.Windows.Forms.TextBox Line2;
    }
}


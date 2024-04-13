// This is DrawCard.Designer.cs
// This file declares all of the properties for the Card selection page, which includes the pictures for the cards,
// the pictures for all four suites for each card, the drop-down for selecting the value of the cards, and the buttons
// Before that happens, any resources that need to be disposed to set up the design will be disposed if needed.
using System.Drawing;
using System.Windows.Forms;

namespace CS4500HW1
{
    partial class DrawCard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        // List the design properties
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawCard));
            this.DealBtn = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.pictureBoxC1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxD1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxS1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxS2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxC2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxD2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxS3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxC3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxD3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxS4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxC4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxD4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH4 = new System.Windows.Forms.PictureBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.card1Confirm = new System.Windows.Forms.Button();
            this.card2Confirm = new System.Windows.Forms.Button();
            this.card3Confirm = new System.Windows.Forms.Button();
            this.card4Confirm = new System.Windows.Forms.Button();
            this.NextRoundBtn = new System.Windows.Forms.Button();
            this.NextPattern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH4)).BeginInit();
            this.SuspendLayout();
            // 
            // DealBtn
            // 
            this.DealBtn.AccessibleDescription = "Button to Draw Cards";
            this.DealBtn.AccessibleName = "DealBtn";
            this.DealBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.DealBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DealBtn.FlatAppearance.BorderSize = 2;
            this.DealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DealBtn.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DealBtn.ForeColor = System.Drawing.Color.White;
            this.DealBtn.Location = new System.Drawing.Point(324, 582);
            this.DealBtn.Name = "DealBtn";
            this.DealBtn.Size = new System.Drawing.Size(200, 40);
            this.DealBtn.TabIndex = 0;
            this.DealBtn.Text = "Deal";
            this.DealBtn.UseVisualStyleBackColor = false;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Quit.FlatAppearance.BorderSize = 2;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quit.ForeColor = System.Drawing.Color.White;
            this.Quit.Location = new System.Drawing.Point(578, 581);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(200, 40);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(60, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 255);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(323, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 255);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(576, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 255);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(843, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(193, 255);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(232, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 97);
            this.label1.TabIndex = 6;
            this.label1.Text = "ART DEALER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Khaki;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Please select value"});
            this.comboBox1.Location = new System.Drawing.Point(60, 456);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Khaki;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Please select value"});
            this.comboBox2.Location = new System.Drawing.Point(322, 456);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Khaki;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Please select value"});
            this.comboBox3.Location = new System.Drawing.Point(578, 456);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 23);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.Khaki;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Please select value"});
            this.comboBox4.Location = new System.Drawing.Point(843, 456);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(193, 23);
            this.comboBox4.TabIndex = 10;
            // 
            // pictureBoxC1
            // 
            this.pictureBoxC1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxC1.Image")));
            this.pictureBoxC1.Location = new System.Drawing.Point(160, 397);
            this.pictureBoxC1.Name = "pictureBoxC1";
            this.pictureBoxC1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxC1.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxC1.TabIndex = 25;
            this.pictureBoxC1.TabStop = false;
            // 
            // pictureBoxD1
            // 
            this.pictureBoxD1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxD1.Image")));
            this.pictureBoxD1.Location = new System.Drawing.Point(109, 397);
            this.pictureBoxD1.Name = "pictureBoxD1";
            this.pictureBoxD1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxD1.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxD1.TabIndex = 24;
            this.pictureBoxD1.TabStop = false;
            // 
            // pictureBoxH1
            // 
            this.pictureBoxH1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxH1.Image")));
            this.pictureBoxH1.Location = new System.Drawing.Point(59, 397);
            this.pictureBoxH1.Name = "pictureBoxH1";
            this.pictureBoxH1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxH1.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxH1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxH1.TabIndex = 23;
            this.pictureBoxH1.TabStop = false;
            // 
            // pictureBoxS1
            // 
            this.pictureBoxS1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxS1.Image")));
            this.pictureBoxS1.Location = new System.Drawing.Point(211, 397);
            this.pictureBoxS1.Name = "pictureBoxS1";
            this.pictureBoxS1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxS1.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxS1.TabIndex = 26;
            this.pictureBoxS1.TabStop = false;
            // 
            // pictureBoxS2
            // 
            this.pictureBoxS2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxS2.Image")));
            this.pictureBoxS2.Location = new System.Drawing.Point(474, 397);
            this.pictureBoxS2.Name = "pictureBoxS2";
            this.pictureBoxS2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxS2.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxS2.TabIndex = 30;
            this.pictureBoxS2.TabStop = false;
            // 
            // pictureBoxC2
            // 
            this.pictureBoxC2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxC2.Image")));
            this.pictureBoxC2.Location = new System.Drawing.Point(423, 397);
            this.pictureBoxC2.Name = "pictureBoxC2";
            this.pictureBoxC2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxC2.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxC2.TabIndex = 29;
            this.pictureBoxC2.TabStop = false;
            // 
            // pictureBoxD2
            // 
            this.pictureBoxD2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxD2.Image")));
            this.pictureBoxD2.Location = new System.Drawing.Point(372, 397);
            this.pictureBoxD2.Name = "pictureBoxD2";
            this.pictureBoxD2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxD2.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxD2.TabIndex = 28;
            this.pictureBoxD2.TabStop = false;
            // 
            // pictureBoxH2
            // 
            this.pictureBoxH2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxH2.Image")));
            this.pictureBoxH2.Location = new System.Drawing.Point(322, 397);
            this.pictureBoxH2.Name = "pictureBoxH2";
            this.pictureBoxH2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxH2.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxH2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxH2.TabIndex = 27;
            this.pictureBoxH2.TabStop = false;
            // 
            // pictureBoxS3
            // 
            this.pictureBoxS3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxS3.Image")));
            this.pictureBoxS3.Location = new System.Drawing.Point(726, 397);
            this.pictureBoxS3.Name = "pictureBoxS3";
            this.pictureBoxS3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxS3.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxS3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxS3.TabIndex = 34;
            this.pictureBoxS3.TabStop = false;
            // 
            // pictureBoxC3
            // 
            this.pictureBoxC3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxC3.Image")));
            this.pictureBoxC3.Location = new System.Drawing.Point(675, 397);
            this.pictureBoxC3.Name = "pictureBoxC3";
            this.pictureBoxC3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxC3.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxC3.TabIndex = 33;
            this.pictureBoxC3.TabStop = false;
            // 
            // pictureBoxD3
            // 
            this.pictureBoxD3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxD3.Image")));
            this.pictureBoxD3.Location = new System.Drawing.Point(624, 397);
            this.pictureBoxD3.Name = "pictureBoxD3";
            this.pictureBoxD3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxD3.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxD3.TabIndex = 32;
            this.pictureBoxD3.TabStop = false;
            // 
            // pictureBoxH3
            // 
            this.pictureBoxH3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxH3.Image")));
            this.pictureBoxH3.Location = new System.Drawing.Point(574, 397);
            this.pictureBoxH3.Name = "pictureBoxH3";
            this.pictureBoxH3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxH3.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxH3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxH3.TabIndex = 31;
            this.pictureBoxH3.TabStop = false;
            // 
            // pictureBoxS4
            // 
            this.pictureBoxS4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxS4.Image")));
            this.pictureBoxS4.Location = new System.Drawing.Point(993, 397);
            this.pictureBoxS4.Name = "pictureBoxS4";
            this.pictureBoxS4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxS4.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxS4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxS4.TabIndex = 38;
            this.pictureBoxS4.TabStop = false;
            // 
            // pictureBoxC4
            // 
            this.pictureBoxC4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxC4.Image")));
            this.pictureBoxC4.Location = new System.Drawing.Point(942, 397);
            this.pictureBoxC4.Name = "pictureBoxC4";
            this.pictureBoxC4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxC4.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxC4.TabIndex = 37;
            this.pictureBoxC4.TabStop = false;
            // 
            // pictureBoxD4
            // 
            this.pictureBoxD4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxD4.Image")));
            this.pictureBoxD4.Location = new System.Drawing.Point(891, 397);
            this.pictureBoxD4.Name = "pictureBoxD4";
            this.pictureBoxD4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxD4.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxD4.TabIndex = 36;
            this.pictureBoxD4.TabStop = false;
            // 
            // pictureBoxH4
            // 
            this.pictureBoxH4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxH4.Image")));
            this.pictureBoxH4.Location = new System.Drawing.Point(841, 397);
            this.pictureBoxH4.Name = "pictureBoxH4";
            this.pictureBoxH4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxH4.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxH4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxH4.TabIndex = 35;
            this.pictureBoxH4.TabStop = false;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(891, 5);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(196, 107);
            this.textBoxLog.TabIndex = 39;
            // 
            // card1Confirm
            // 
            this.card1Confirm.BackColor = System.Drawing.Color.ForestGreen;
            this.card1Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.card1Confirm.ForeColor = System.Drawing.Color.Gold;
            this.card1Confirm.Location = new System.Drawing.Point(59, 502);
            this.card1Confirm.Name = "card1Confirm";
            this.card1Confirm.Size = new System.Drawing.Size(194, 39);
            this.card1Confirm.TabIndex = 40;
            this.card1Confirm.Text = "Confirm Card";
            this.card1Confirm.UseVisualStyleBackColor = false;
            // 
            // card2Confirm
            // 
            this.card2Confirm.BackColor = System.Drawing.Color.ForestGreen;
            this.card2Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.card2Confirm.ForeColor = System.Drawing.Color.Gold;
            this.card2Confirm.Location = new System.Drawing.Point(322, 502);
            this.card2Confirm.Name = "card2Confirm";
            this.card2Confirm.Size = new System.Drawing.Size(194, 39);
            this.card2Confirm.TabIndex = 41;
            this.card2Confirm.Text = "Confirm Card";
            this.card2Confirm.UseVisualStyleBackColor = false;
            // 
            // card3Confirm
            // 
            this.card3Confirm.BackColor = System.Drawing.Color.ForestGreen;
            this.card3Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.card3Confirm.ForeColor = System.Drawing.Color.Gold;
            this.card3Confirm.Location = new System.Drawing.Point(578, 502);
            this.card3Confirm.Name = "card3Confirm";
            this.card3Confirm.Size = new System.Drawing.Size(194, 39);
            this.card3Confirm.TabIndex = 42;
            this.card3Confirm.Text = "Confirm Card";
            this.card3Confirm.UseVisualStyleBackColor = false;
            // 
            // card4Confirm
            // 
            this.card4Confirm.BackColor = System.Drawing.Color.ForestGreen;
            this.card4Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.card4Confirm.ForeColor = System.Drawing.Color.Gold;
            this.card4Confirm.Location = new System.Drawing.Point(841, 502);
            this.card4Confirm.Name = "card4Confirm";
            this.card4Confirm.Size = new System.Drawing.Size(194, 39);
            this.card4Confirm.TabIndex = 43;
            this.card4Confirm.Text = "Confirm Card";
            this.card4Confirm.UseVisualStyleBackColor = false;
            // 
            // NextRoundBtn
            // 
            this.NextRoundBtn.AccessibleDescription = "Button to Draw Cards";
            this.NextRoundBtn.AccessibleName = "Draw";
            this.NextRoundBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.NextRoundBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NextRoundBtn.FlatAppearance.BorderSize = 2;
            this.NextRoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextRoundBtn.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextRoundBtn.ForeColor = System.Drawing.Color.White;
            this.NextRoundBtn.Location = new System.Drawing.Point(60, 581);
            this.NextRoundBtn.Name = "NextRoundBtn";
            this.NextRoundBtn.Size = new System.Drawing.Size(200, 40);
            this.NextRoundBtn.TabIndex = 44;
            this.NextRoundBtn.Text = "Next Round";
            this.NextRoundBtn.UseVisualStyleBackColor = false;
            // 
            // NextPattern
            // 
            this.NextPattern.AccessibleDescription = "Button to Move Patterns";
            this.NextPattern.AccessibleName = "NextPattern";
            this.NextPattern.BackColor = System.Drawing.Color.DarkGreen;
            this.NextPattern.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NextPattern.FlatAppearance.BorderSize = 2;
            this.NextPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPattern.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextPattern.ForeColor = System.Drawing.Color.White;
            this.NextPattern.Location = new System.Drawing.Point(843, 582);
            this.NextPattern.Name = "NextPattern";
            this.NextPattern.Size = new System.Drawing.Size(200, 40);
            this.NextPattern.TabIndex = 45;
            this.NextPattern.Text = "Next Pattern";
            this.NextPattern.UseVisualStyleBackColor = false;
            // 
            // DrawCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 657);
            this.Controls.Add(this.NextPattern);
            this.Controls.Add(this.NextRoundBtn);
            this.Controls.Add(this.card4Confirm);
            this.Controls.Add(this.card3Confirm);
            this.Controls.Add(this.card2Confirm);
            this.Controls.Add(this.card1Confirm);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.pictureBoxS4);
            this.Controls.Add(this.pictureBoxC4);
            this.Controls.Add(this.pictureBoxD4);
            this.Controls.Add(this.pictureBoxH4);
            this.Controls.Add(this.pictureBoxS3);
            this.Controls.Add(this.pictureBoxC3);
            this.Controls.Add(this.pictureBoxD3);
            this.Controls.Add(this.pictureBoxH3);
            this.Controls.Add(this.pictureBoxS2);
            this.Controls.Add(this.pictureBoxC2);
            this.Controls.Add(this.pictureBoxD2);
            this.Controls.Add(this.pictureBoxH2);
            this.Controls.Add(this.pictureBoxS1);
            this.Controls.Add(this.pictureBoxC1);
            this.Controls.Add(this.pictureBoxD1);
            this.Controls.Add(this.pictureBoxH1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.DealBtn);
            this.Name = "DrawCard";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARD GAME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DealBtn;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private PictureBox pictureBoxC1;
        private PictureBox pictureBoxD1;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBoxH1;
        private PictureBox pictureBoxS1;
        private PictureBox pictureBoxS2;
        private PictureBox pictureBoxC2;
        private PictureBox pictureBoxD2;
        private PictureBox pictureBoxH2;
        private PictureBox pictureBoxS3;
        private PictureBox pictureBoxC3;
        private PictureBox pictureBoxD3;
        private PictureBox pictureBoxH3;
        private PictureBox pictureBoxS4;
        private PictureBox pictureBoxC4;
        private PictureBox pictureBoxD4;
        private PictureBox pictureBoxH4;
        private TextBox textBoxLog;
        private Button card1Confirm;
        private Button card2Confirm;
        private Button card3Confirm;
        private Button card4Confirm;
        private Button NextRoundBtn;
        private Button NextPattern;
    }
}
// End of file
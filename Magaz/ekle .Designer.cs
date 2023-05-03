
namespace Magaz
{
    partial class ekle
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuekle2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.butek1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuclose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuclose);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 0;
            // 
            // bunifuclose
            // 
            this.bunifuclose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuclose, BunifuAnimatorNS.DecorationType.None);
            this.bunifuclose.Image = ((System.Drawing.Image)(resources.GetObject("bunifuclose.Image")));
            this.bunifuclose.ImageActive = null;
            this.bunifuclose.Location = new System.Drawing.Point(12, 12);
            this.bunifuclose.Name = "bunifuclose";
            this.bunifuclose.Size = new System.Drawing.Size(42, 46);
            this.bunifuclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuclose.TabIndex = 1;
            this.bunifuclose.TabStop = false;
            this.bunifuclose.Zoom = 10;
            this.bunifuclose.Click += new System.EventHandler(this.bunifuclose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.bunifuekle2);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 90);
            this.panel2.TabIndex = 1;
            // 
            // bunifuekle2
            // 
            this.bunifuekle2.ActiveBorderThickness = 1;
            this.bunifuekle2.ActiveCornerRadius = 20;
            this.bunifuekle2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle2.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuekle2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuekle2.BackColor = System.Drawing.Color.Silver;
            this.bunifuekle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuekle2.BackgroundImage")));
            this.bunifuekle2.ButtonText = "Ekleme";
            this.bunifuekle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuekle2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuekle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuekle2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle2.IdleBorderThickness = 1;
            this.bunifuekle2.IdleCornerRadius = 20;
            this.bunifuekle2.IdleFillColor = System.Drawing.Color.White;
            this.bunifuekle2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuekle2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle2.Location = new System.Drawing.Point(286, 20);
            this.bunifuekle2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuekle2.Name = "bunifuekle2";
            this.bunifuekle2.Size = new System.Drawing.Size(229, 59);
            this.bunifuekle2.TabIndex = 1;
            this.bunifuekle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuGroupBox2);
            this.panel3.Controls.Add(this.bunifuGroupBox1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 525);
            this.panel3.TabIndex = 2;
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.linkLabel1);
            this.bunifuGroupBox2.Controls.Add(this.pictureBox1);
            this.bunifuGroupBox2.Controls.Add(this.bunifuRating1);
            this.bunifuGroupBox2.Controls.Add(this.bunifuDatepicker1);
            this.bunifuGroupBox2.Controls.Add(this.lab7);
            this.bunifuGroupBox2.Controls.Add(this.lab6);
            this.bunifuGroupBox2.Controls.Add(this.lab5);
            this.bunifuTransition1.SetDecoration(this.bunifuGroupBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(450, 6);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(338, 508);
            this.bunifuGroupBox2.TabIndex = 1;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "ikincil bilgiler";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel1, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(20, 411);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 21);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = " fotoğraf yükleme";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuRating1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRating1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(14, 194);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(324, 57);
            this.bunifuRating1.TabIndex = 5;
            this.bunifuRating1.Value = 0;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuDatepicker1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(14, 105);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(293, 36);
            this.bunifuDatepicker1.TabIndex = 4;
            this.bunifuDatepicker1.Value = new System.DateTime(2023, 4, 23, 18, 13, 42, 917);
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lab7, BunifuAnimatorNS.DecorationType.None);
            this.lab7.Location = new System.Drawing.Point(10, 268);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(73, 21);
            this.lab7.TabIndex = 3;
            this.lab7.Text = "fotoğraf";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lab6, BunifuAnimatorNS.DecorationType.None);
            this.lab6.Location = new System.Drawing.Point(10, 144);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(47, 21);
            this.lab6.TabIndex = 2;
            this.lab6.Text = "Oran";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lab5, BunifuAnimatorNS.DecorationType.None);
            this.lab5.Location = new System.Drawing.Point(10, 78);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(48, 21);
            this.lab5.TabIndex = 1;
            this.lab5.Text = "Tarih";
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.butek1);
            this.bunifuGroupBox1.Controls.Add(this.comboBox1);
            this.bunifuGroupBox1.Controls.Add(this.bunifuMaterialTextbox3);
            this.bunifuGroupBox1.Controls.Add(this.bunifuMaterialTextbox2);
            this.bunifuGroupBox1.Controls.Add(this.bunifuMaterialTextbox1);
            this.bunifuGroupBox1.Controls.Add(this.lab4);
            this.bunifuGroupBox1.Controls.Add(this.lab3);
            this.bunifuGroupBox1.Controls.Add(this.lab2);
            this.bunifuGroupBox1.Controls.Add(this.lab1);
            this.bunifuTransition1.SetDecoration(this.bunifuGroupBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(12, 6);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(277, 508);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "genel bilgiler";
            // 
            // butek1
            // 
            this.butek1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butek1.BackgroundImage")));
            this.butek1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.butek1, BunifuAnimatorNS.DecorationType.None);
            this.butek1.Location = new System.Drawing.Point(183, 348);
            this.butek1.Name = "butek1";
            this.butek1.Size = new System.Drawing.Size(80, 65);
            this.butek1.TabIndex = 8;
            this.butek1.Text = " ";
            this.butek1.UseVisualStyleBackColor = true;
            this.butek1.Click += new System.EventHandler(this.butek1_Click);
            // 
            // comboBox1
            // 
            this.bunifuTransition1.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 367);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 29);
            this.comboBox1.TabIndex = 7;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(9, 180);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(268, 44);
            this.bunifuMaterialTextbox3.TabIndex = 6;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(9, 274);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(268, 44);
            this.bunifuMaterialTextbox2.TabIndex = 5;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(9, 78);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(268, 44);
            this.bunifuMaterialTextbox1.TabIndex = 4;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lab4, BunifuAnimatorNS.DecorationType.None);
            this.lab4.Location = new System.Drawing.Point(10, 322);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(65, 21);
            this.lab4.TabIndex = 3;
            this.lab4.Text = "çeşitler";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lab3, BunifuAnimatorNS.DecorationType.None);
            this.lab3.Location = new System.Drawing.Point(10, 249);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(45, 21);
            this.lab3.TabIndex = 2;
            this.lab3.Text = "fiyat";
            this.lab3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lab2, BunifuAnimatorNS.DecorationType.None);
            this.lab2.Location = new System.Drawing.Point(10, 144);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(57, 21);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "yapan";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lab1, BunifuAnimatorNS.DecorationType.None);
            this.lab1.Location = new System.Drawing.Point(10, 53);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(55, 21);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "başlık";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 7;
            // 
            // ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuclose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuclose;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuekle2;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button butek1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}
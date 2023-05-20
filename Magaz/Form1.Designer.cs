namespace Magaz
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelbaslik = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifumini = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuBilgi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuselme = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuduzen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuekle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifumini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuclose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.labelbaslik);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifumini);
            this.panel1.Controls.Add(this.bunifuclose);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 84);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // labelbaslik
            // 
            this.labelbaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelbaslik.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelbaslik, BunifuAnimatorNS.DecorationType.None);
            this.labelbaslik.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelbaslik.Location = new System.Drawing.Point(433, 29);
            this.labelbaslik.Name = "labelbaslik";
            this.labelbaslik.Size = new System.Drawing.Size(328, 29);
            this.labelbaslik.TabIndex = 3;
            this.labelbaslik.Text = "Mağaza Yönetim Programı";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(159, 16);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // bunifumini
            // 
            this.bunifumini.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifumini, BunifuAnimatorNS.DecorationType.None);
            this.bunifumini.Image = ((System.Drawing.Image)(resources.GetObject("bunifumini.Image")));
            this.bunifumini.ImageActive = null;
            this.bunifumini.Location = new System.Drawing.Point(86, 16);
            this.bunifumini.Name = "bunifumini";
            this.bunifumini.Size = new System.Drawing.Size(38, 42);
            this.bunifumini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifumini.TabIndex = 1;
            this.bunifumini.TabStop = false;
            this.bunifumini.Zoom = 10;
            this.bunifumini.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuclose
            // 
            this.bunifuclose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuclose, BunifuAnimatorNS.DecorationType.None);
            this.bunifuclose.Image = ((System.Drawing.Image)(resources.GetObject("bunifuclose.Image")));
            this.bunifuclose.ImageActive = null;
            this.bunifuclose.Location = new System.Drawing.Point(21, 16);
            this.bunifuclose.Name = "bunifuclose";
            this.bunifuclose.Size = new System.Drawing.Size(42, 46);
            this.bunifuclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuclose.TabIndex = 0;
            this.bunifuclose.TabStop = false;
            this.bunifuclose.Zoom = 10;
            this.bunifuclose.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.bunifuBilgi);
            this.panel2.Controls.Add(this.bunifuselme);
            this.panel2.Controls.Add(this.bunifuduzen);
            this.panel2.Controls.Add(this.bunifuekle);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 656);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 94);
            this.panel2.TabIndex = 1;
            // 
            // bunifuBilgi
            // 
            this.bunifuBilgi.ActiveBorderThickness = 1;
            this.bunifuBilgi.ActiveCornerRadius = 20;
            this.bunifuBilgi.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuBilgi.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuBilgi.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuBilgi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuBilgi.BackColor = System.Drawing.Color.Silver;
            this.bunifuBilgi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuBilgi.BackgroundImage")));
            this.bunifuBilgi.ButtonText = "Ürün Bilgileri";
            this.bunifuBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuBilgi, BunifuAnimatorNS.DecorationType.None);
            this.bunifuBilgi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuBilgi.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuBilgi.IdleBorderThickness = 1;
            this.bunifuBilgi.IdleCornerRadius = 20;
            this.bunifuBilgi.IdleFillColor = System.Drawing.Color.White;
            this.bunifuBilgi.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuBilgi.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuBilgi.Location = new System.Drawing.Point(51, 16);
            this.bunifuBilgi.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuBilgi.Name = "bunifuBilgi";
            this.bunifuBilgi.Size = new System.Drawing.Size(229, 62);
            this.bunifuBilgi.TabIndex = 3;
            this.bunifuBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuBilgi.Click += new System.EventHandler(this.bunifuBilgi_Click);
            // 
            // bunifuselme
            // 
            this.bunifuselme.ActiveBorderThickness = 1;
            this.bunifuselme.ActiveCornerRadius = 20;
            this.bunifuselme.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuselme.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuselme.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuselme.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuselme.BackColor = System.Drawing.Color.Silver;
            this.bunifuselme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuselme.BackgroundImage")));
            this.bunifuselme.ButtonText = "Ürünü Silme";
            this.bunifuselme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuselme, BunifuAnimatorNS.DecorationType.None);
            this.bunifuselme.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuselme.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuselme.IdleBorderThickness = 1;
            this.bunifuselme.IdleCornerRadius = 20;
            this.bunifuselme.IdleFillColor = System.Drawing.Color.White;
            this.bunifuselme.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuselme.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuselme.Location = new System.Drawing.Point(341, 16);
            this.bunifuselme.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuselme.Name = "bunifuselme";
            this.bunifuselme.Size = new System.Drawing.Size(229, 62);
            this.bunifuselme.TabIndex = 2;
            this.bunifuselme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuduzen
            // 
            this.bunifuduzen.ActiveBorderThickness = 1;
            this.bunifuduzen.ActiveCornerRadius = 20;
            this.bunifuduzen.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuduzen.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuduzen.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuduzen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuduzen.BackColor = System.Drawing.Color.Silver;
            this.bunifuduzen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuduzen.BackgroundImage")));
            this.bunifuduzen.ButtonText = "Ürünü Düzenleme";
            this.bunifuduzen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuduzen, BunifuAnimatorNS.DecorationType.None);
            this.bunifuduzen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuduzen.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuduzen.IdleBorderThickness = 1;
            this.bunifuduzen.IdleCornerRadius = 20;
            this.bunifuduzen.IdleFillColor = System.Drawing.Color.White;
            this.bunifuduzen.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuduzen.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuduzen.Location = new System.Drawing.Point(631, 16);
            this.bunifuduzen.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuduzen.Name = "bunifuduzen";
            this.bunifuduzen.Size = new System.Drawing.Size(229, 62);
            this.bunifuduzen.TabIndex = 1;
            this.bunifuduzen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuekle
            // 
            this.bunifuekle.ActiveBorderThickness = 1;
            this.bunifuekle.ActiveCornerRadius = 20;
            this.bunifuekle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuekle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuekle.BackColor = System.Drawing.Color.Silver;
            this.bunifuekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuekle.BackgroundImage")));
            this.bunifuekle.ButtonText = "Yeni Ürün Ekleme";
            this.bunifuekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuekle, BunifuAnimatorNS.DecorationType.None);
            this.bunifuekle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuekle.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.IdleBorderThickness = 1;
            this.bunifuekle.IdleCornerRadius = 20;
            this.bunifuekle.IdleFillColor = System.Drawing.Color.White;
            this.bunifuekle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.Location = new System.Drawing.Point(921, 15);
            this.bunifuekle.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuekle.Name = "bunifuekle";
            this.bunifuekle.Size = new System.Drawing.Size(229, 59);
            this.bunifuekle.TabIndex = 0;
            this.bunifuekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuekle.Click += new System.EventHandler(this.bunifuekle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 572);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 572);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeadersDefaultCellStyleChanged += new System.EventHandler(this.Form1_Load);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifumini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuclose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifumini;
        private Bunifu.Framework.UI.BunifuImageButton bunifuclose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelbaslik;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuBilgi;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuselme;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuduzen;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}


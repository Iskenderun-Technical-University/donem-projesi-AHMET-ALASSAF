
namespace Magaz
{
    partial class cesitler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cesitler));
            this.TEXTER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labcesit = new System.Windows.Forms.Label();
            this.bunifuekle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuclose1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuclose1)).BeginInit();
            this.SuspendLayout();
            // 
            // TEXTER
            // 
            this.TEXTER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXTER.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.TEXTER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TEXTER.HintForeColor = System.Drawing.Color.Empty;
            this.TEXTER.HintText = "";
            this.TEXTER.isPassword = false;
            this.TEXTER.LineFocusedColor = System.Drawing.Color.Blue;
            this.TEXTER.LineIdleColor = System.Drawing.Color.Gray;
            this.TEXTER.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TEXTER.LineThickness = 8;
            this.TEXTER.Location = new System.Drawing.Point(64, 217);
            this.TEXTER.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.TEXTER.Name = "TEXTER";
            this.TEXTER.Size = new System.Drawing.Size(553, 108);
            this.TEXTER.TabIndex = 6;
            this.TEXTER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labcesit
            // 
            this.labcesit.AutoSize = true;
            this.labcesit.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcesit.Location = new System.Drawing.Point(227, 143);
            this.labcesit.Name = "labcesit";
            this.labcesit.Size = new System.Drawing.Size(218, 48);
            this.labcesit.TabIndex = 5;
            this.labcesit.Text = "ÇEŞİTLER";
            // 
            // bunifuekle
            // 
            this.bunifuekle.ActiveBorderThickness = 1;
            this.bunifuekle.ActiveCornerRadius = 20;
            this.bunifuekle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuekle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuekle.BackColor = System.Drawing.Color.White;
            this.bunifuekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuekle.BackgroundImage")));
            this.bunifuekle.ButtonText = "Ekle";
            this.bunifuekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuekle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuekle.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.IdleBorderThickness = 1;
            this.bunifuekle.IdleCornerRadius = 20;
            this.bunifuekle.IdleFillColor = System.Drawing.Color.White;
            this.bunifuekle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuekle.Location = new System.Drawing.Point(15, 417);
            this.bunifuekle.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuekle.Name = "bunifuekle";
            this.bunifuekle.Size = new System.Drawing.Size(657, 50);
            this.bunifuekle.TabIndex = 7;
            this.bunifuekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuekle.Click += new System.EventHandler(this.bunifuekle_Click);
            // 
            // bunifuclose1
            // 
            this.bunifuclose1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuclose1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuclose1.Image")));
            this.bunifuclose1.ImageActive = null;
            this.bunifuclose1.Location = new System.Drawing.Point(12, 12);
            this.bunifuclose1.Name = "bunifuclose1";
            this.bunifuclose1.Size = new System.Drawing.Size(34, 42);
            this.bunifuclose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuclose1.TabIndex = 8;
            this.bunifuclose1.TabStop = false;
            this.bunifuclose1.Zoom = 10;
            this.bunifuclose1.Click += new System.EventHandler(this.bunifuclose1_Click);
            // 
            // cesitler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 482);
            this.Controls.Add(this.bunifuclose1);
            this.Controls.Add(this.bunifuekle);
            this.Controls.Add(this.TEXTER);
            this.Controls.Add(this.labcesit);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "cesitler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cesitler";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuclose1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TEXTER;
        private System.Windows.Forms.Label labcesit;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuekle;
        private Bunifu.Framework.UI.BunifuImageButton bunifuclose1;
    }
}
namespace SahibindenBot
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WhatsappAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkAdd = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeSettings = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DurdurButton = new MaterialSkin.Controls.MaterialButton();
            this.DevamButton = new MaterialSkin.Controls.MaterialButton();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WhatsappAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Run)).BeginInit();
            this.SuspendLayout();
            // 
            // WhatsappAdd
            // 
            this.WhatsappAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WhatsappAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhatsappAdd.Image = ((System.Drawing.Image)(resources.GetObject("WhatsappAdd.Image")));
            this.WhatsappAdd.Location = new System.Drawing.Point(94, 104);
            this.WhatsappAdd.Name = "WhatsappAdd";
            this.WhatsappAdd.Size = new System.Drawing.Size(259, 198);
            this.WhatsappAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WhatsappAdd.TabIndex = 1;
            this.WhatsappAdd.TabStop = false;
            this.WhatsappAdd.Click += new System.EventHandler(this.WhatsappAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "WhatsApp Ekle";
            // 
            // LinkAdd
            // 
            this.LinkAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinkAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkAdd.Image = ((System.Drawing.Image)(resources.GetObject("LinkAdd.Image")));
            this.LinkAdd.Location = new System.Drawing.Point(359, 104);
            this.LinkAdd.Name = "LinkAdd";
            this.LinkAdd.Size = new System.Drawing.Size(259, 198);
            this.LinkAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LinkAdd.TabIndex = 3;
            this.LinkAdd.TabStop = false;
            this.LinkAdd.Click += new System.EventHandler(this.LinkAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Link Ekle";
            // 
            // TimeSettings
            // 
            this.TimeSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeSettings.Image = ((System.Drawing.Image)(resources.GetObject("TimeSettings.Image")));
            this.TimeSettings.Location = new System.Drawing.Point(624, 104);
            this.TimeSettings.Name = "TimeSettings";
            this.TimeSettings.Size = new System.Drawing.Size(259, 198);
            this.TimeSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TimeSettings.TabIndex = 5;
            this.TimeSettings.TabStop = false;
            this.TimeSettings.Click += new System.EventHandler(this.TimeSettings_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Süre Ayarları";
            // 
            // Run
            // 
            this.Run.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Run.Image = ((System.Drawing.Image)(resources.GetObject("Run.Image")));
            this.Run.Location = new System.Drawing.Point(387, 373);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(231, 175);
            this.Run.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Run.TabIndex = 7;
            this.Run.TabStop = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Çalıştır";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox2.Location = new System.Drawing.Point(94, 424);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(276, 124);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bildirim Gelecek Numaralar";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox1.Location = new System.Drawing.Point(647, 373);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(316, 131);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // DurdurButton
            // 
            this.DurdurButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DurdurButton.AutoSize = false;
            this.DurdurButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DurdurButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DurdurButton.Depth = 0;
            this.DurdurButton.HighEmphasis = true;
            this.DurdurButton.Icon = null;
            this.DurdurButton.Location = new System.Drawing.Point(647, 512);
            this.DurdurButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DurdurButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DurdurButton.Name = "DurdurButton";
            this.DurdurButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DurdurButton.Size = new System.Drawing.Size(158, 36);
            this.DurdurButton.TabIndex = 12;
            this.DurdurButton.Text = "Durdur";
            this.DurdurButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DurdurButton.UseAccentColor = false;
            this.DurdurButton.UseVisualStyleBackColor = true;
            this.DurdurButton.Click += new System.EventHandler(this.durdurbutton_Click);
            // 
            // DevamButton
            // 
            this.DevamButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DevamButton.AutoSize = false;
            this.DevamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DevamButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DevamButton.Depth = 0;
            this.DevamButton.HighEmphasis = true;
            this.DevamButton.Icon = null;
            this.DevamButton.Location = new System.Drawing.Point(813, 513);
            this.DevamButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DevamButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DevamButton.Name = "DevamButton";
            this.DevamButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DevamButton.Size = new System.Drawing.Size(150, 35);
            this.DevamButton.TabIndex = 13;
            this.DevamButton.Text = "Devam Ettir";
            this.DevamButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DevamButton.UseAccentColor = false;
            this.DevamButton.UseVisualStyleBackColor = true;
            this.DevamButton.Click += new System.EventHandler(this.DevamButton_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox3.Location = new System.Drawing.Point(647, 373);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(316, 130);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox4.Location = new System.Drawing.Point(647, 373);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(100, 96);
            this.richTextBox4.TabIndex = 15;
            this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 590);
            this.Controls.Add(this.DevamButton);
            this.Controls.Add(this.DurdurButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WhatsappAdd);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sahibinden İlan Kontrol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WhatsappAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Run)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WhatsappAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LinkAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox TimeSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Run;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialButton DurdurButton;
        private MaterialSkin.Controls.MaterialButton DevamButton;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
    }
}


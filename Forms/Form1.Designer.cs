
namespace kutuphaneSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKutuphane = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrenciEkle.Image")));
            this.btnOgrenciEkle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(22, 72);
            this.btnOgrenciEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(232, 234);
            this.btnOgrenciEkle.TabIndex = 0;
            this.btnOgrenciEkle.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\nÖğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapEkle.ImageKey = "depositphotos_59584049-stock-illustration-books-icon-set.jpg";
            this.btnKitapEkle.ImageList = this.ımageList1;
            this.btnKitapEkle.Location = new System.Drawing.Point(22, 317);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(232, 234);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\nKitap Ekle / Listele";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir (1333).png");
            this.ımageList1.Images.SetKeyName(1, "depositphotos_59584049-stock-illustration-books-icon-set.jpg");
            this.ımageList1.Images.SetKeyName(2, "indir.png");
            this.ımageList1.Images.SetKeyName(3, "istockphoto-950814916-1024x1024.jpg");
            this.ımageList1.Images.SetKeyName(4, "images.png");
            this.ımageList1.Images.SetKeyName(5, "جزوات-مکالمه-زبان-انگلیسی.jpg");
            this.ımageList1.Images.SetKeyName(6, "library-icon-1-1.png");
            // 
            // btnKutuphane
            // 
            this.btnKutuphane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKutuphane.ImageKey = "library-icon-1-1.png";
            this.btnKutuphane.ImageList = this.ımageList1;
            this.btnKutuphane.Location = new System.Drawing.Point(267, 167);
            this.btnKutuphane.Margin = new System.Windows.Forms.Padding(2);
            this.btnKutuphane.Name = "btnKutuphane";
            this.btnKutuphane.Size = new System.Drawing.Size(232, 247);
            this.btnKutuphane.TabIndex = 2;
            this.btnKutuphane.Text = "\r\n\r\n\r\n\r\n\r\nKutuphane";
            this.btnKutuphane.UseVisualStyleBackColor = true;
            this.btnKutuphane.Click += new System.EventHandler(this.btnKutuphane_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.ImageKey = "istockphoto-950814916-1024x1024.jpg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(514, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 234);
            this.button1.TabIndex = 3;
            this.button1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\nOgrenci Kitapları";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(513, 319);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 232);
            this.button2.TabIndex = 4;
            this.button2.Text = "\r\n\r\n\r\n\r\n\r\n\r\nGrafik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKutuphane);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "KÜTÜPHANE OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKutuphane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}


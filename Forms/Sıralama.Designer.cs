namespace kutuphaneSistemi
{
    partial class Sıralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sıralama));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.lblToplamKitap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmanetKitap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKalanKitap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(76, 147);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(655, 401);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zedGraphControl1_PointValueEvent);
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            this.zedGraphControl1.DoubleClick += new System.EventHandler(this.zedGraphControl1_DoubleClick);
            // 
            // lblToplamKitap
            // 
            this.lblToplamKitap.AutoSize = true;
            this.lblToplamKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKitap.Location = new System.Drawing.Point(523, 18);
            this.lblToplamKitap.Name = "lblToplamKitap";
            this.lblToplamKitap.Size = new System.Drawing.Size(24, 20);
            this.lblToplamKitap.TabIndex = 3;
            this.lblToplamKitap.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(289, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "TOPLAM KİTAP SAYISI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(289, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMANETTE KİTAP SAYISI:";
            // 
            // lblEmanetKitap
            // 
            this.lblEmanetKitap.AutoSize = true;
            this.lblEmanetKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmanetKitap.Location = new System.Drawing.Point(523, 97);
            this.lblEmanetKitap.Name = "lblEmanetKitap";
            this.lblEmanetKitap.Size = new System.Drawing.Size(24, 20);
            this.lblEmanetKitap.TabIndex = 5;
            this.lblEmanetKitap.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(289, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "KALAN KİTAP SAYISI:";
            // 
            // lblKalanKitap
            // 
            this.lblKalanKitap.AutoSize = true;
            this.lblKalanKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanKitap.Location = new System.Drawing.Point(523, 58);
            this.lblKalanKitap.Name = "lblKalanKitap";
            this.lblKalanKitap.Size = new System.Drawing.Size(24, 20);
            this.lblKalanKitap.TabIndex = 7;
            this.lblKalanKitap.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(259, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(259, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(259, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "3";
            // 
            // Sıralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 625);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKalanKitap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmanetKitap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToplamKitap);
            this.Controls.Add(this.zedGraphControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sıralama";
            this.Text = "Sıralama";
            this.Load += new System.EventHandler(this.Sıralama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label lblToplamKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmanetKitap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKalanKitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}
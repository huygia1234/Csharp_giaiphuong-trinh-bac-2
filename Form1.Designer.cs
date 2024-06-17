namespace Csharp_giaiphuong_trinh_bac_2
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
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(99, 55);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(42, 13);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "Nhập a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(99, 130);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(42, 13);
            this.lblb.TabIndex = 1;
            this.lblb.Text = "Nhập b";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Location = new System.Drawing.Point(99, 209);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(42, 13);
            this.labelc.TabIndex = 2;
            this.labelc.Text = "Nhập c";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(216, 48);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(124, 20);
            this.txta.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(424, 23);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(309, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(216, 123);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(124, 20);
            this.txtb.TabIndex = 5;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(216, 202);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(124, 20);
            this.txtc.TabIndex = 6;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(424, 98);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(309, 45);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(424, 177);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(309, 45);
            this.trackBar3.TabIndex = 8;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(64, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(530, 173);
            this.listBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(363, 220);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(75, 34);
            this.btnKQ.TabIndex = 11;
            this.btnKQ.Text = "button1";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKQ;
    }
}


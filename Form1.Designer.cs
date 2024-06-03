namespace CSharp_gptb1
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btngpt = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblso2 = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(67, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(71, 23);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Nhập a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(187, 23);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 30);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            // 
            // btngpt
            // 
            this.btngpt.Location = new System.Drawing.Point(176, 259);
            this.btngpt.Name = "btngpt";
            this.btngpt.Size = new System.Drawing.Size(216, 31);
            this.btngpt.TabIndex = 2;
            this.btngpt.Text = "GIẢI PHƯƠNG TRÌNH";
            this.btngpt.UseVisualStyleBackColor = true;
            this.btngpt.Click += new System.EventHandler(this.btngpt_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(187, 81);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 30);
            this.txtB.TabIndex = 4;
            // 
            // lblso2
            // 
            this.lblso2.AutoSize = true;
            this.lblso2.Location = new System.Drawing.Point(67, 88);
            this.lblso2.Name = "lblso2";
            this.lblso2.Size = new System.Drawing.Size(72, 23);
            this.lblso2.TabIndex = 3;
            this.lblso2.Text = "Nhập b";
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(67, 153);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(75, 23);
            this.lblketqua.TabIndex = 6;
            this.lblketqua.Text = "Kết quả";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(303, 23);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(437, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(773, 385);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblso2);
            this.Controls.Add(this.btngpt);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "GIẢI PHƯƠNG TRÌNH BẬC 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btngpt;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblso2;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}


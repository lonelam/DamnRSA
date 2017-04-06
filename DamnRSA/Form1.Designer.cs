namespace DamnRSA
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
            this.PubK = new System.Windows.Forms.Label();
            this.PrivK = new System.Windows.Forms.Label();
            this.pub_box = new System.Windows.Forms.TextBox();
            this.pv_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PubK
            // 
            this.PubK.AutoSize = true;
            this.PubK.Location = new System.Drawing.Point(12, 9);
            this.PubK.Name = "PubK";
            this.PubK.Size = new System.Drawing.Size(79, 15);
            this.PubK.TabIndex = 0;
            this.PubK.Text = "PublicKey";
            // 
            // PrivK
            // 
            this.PrivK.AutoSize = true;
            this.PrivK.Location = new System.Drawing.Point(417, 9);
            this.PrivK.Name = "PrivK";
            this.PrivK.Size = new System.Drawing.Size(87, 15);
            this.PrivK.TabIndex = 1;
            this.PrivK.Text = "PriviteKey";
            // 
            // pub_box
            // 
            this.pub_box.Location = new System.Drawing.Point(12, 27);
            this.pub_box.Multiline = true;
            this.pub_box.Name = "pub_box";
            this.pub_box.Size = new System.Drawing.Size(402, 226);
            this.pub_box.TabIndex = 2;
            // 
            // pv_box
            // 
            this.pv_box.Location = new System.Drawing.Point(420, 27);
            this.pv_box.Multiline = true;
            this.pv_box.Name = "pv_box";
            this.pv_box.Size = new System.Drawing.Size(376, 637);
            this.pv_box.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "GenerateKeyPair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 325);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 28);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Digest(Sha1)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 385);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(399, 28);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 444);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(399, 85);
            this.textBox3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Signature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Resolved Signature";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 550);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(399, 85);
            this.textBox4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 676);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pv_box);
            this.Controls.Add(this.pub_box);
            this.Controls.Add(this.PrivK);
            this.Controls.Add(this.PubK);
            this.Name = "Form1";
            this.Text = "DamnRSA——计算机科学进展研讨";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PubK;
        private System.Windows.Forms.Label PrivK;
        private System.Windows.Forms.TextBox pub_box;
        private System.Windows.Forms.TextBox pv_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}


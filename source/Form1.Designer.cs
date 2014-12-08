namespace WindowsFormsApplication1
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
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.lx1 = new System.Windows.Forms.Label();
            this.lx2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(53, 48);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 0;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(208, 48);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 1;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(374, 48);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "C=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Számol!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(88, 143);
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 4;
            this.x1.Visible = false;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(401, 143);
            this.x2.Name = "x2";
            this.x2.ReadOnly = true;
            this.x2.Size = new System.Drawing.Size(100, 20);
            this.x2.TabIndex = 5;
            this.x2.Visible = false;
            // 
            // lx1
            // 
            this.lx1.AutoSize = true;
            this.lx1.Location = new System.Drawing.Point(62, 150);
            this.lx1.Name = "lx1";
            this.lx1.Size = new System.Drawing.Size(24, 13);
            this.lx1.TabIndex = 1;
            this.lx1.Text = "x1=";
            this.lx1.Visible = false;
            // 
            // lx2
            // 
            this.lx2.AutoSize = true;
            this.lx2.Location = new System.Drawing.Point(371, 150);
            this.lx2.Name = "lx2";
            this.lx2.Size = new System.Drawing.Size(24, 13);
            this.lx2.TabIndex = 1;
            this.lx2.Text = "x2=";
            this.lx2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(436, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eredmények és az adatok törlése";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(23, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "eredmeny";
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 251);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lx2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Másodfokú egyenlet megoldóképlet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Label lx1;
        private System.Windows.Forms.Label lx2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}


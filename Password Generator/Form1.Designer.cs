
namespace Password_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.chkSpecical = new System.Windows.Forms.CheckBox();
            this.chkNumeric = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.Location = new System.Drawing.Point(20, 33);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(82, 17);
            this.chkLowerCase.TabIndex = 0;
            this.chkLowerCase.Text = "Lower Case";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.Location = new System.Drawing.Point(20, 56);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(82, 17);
            this.chkUpperCase.TabIndex = 1;
            this.chkUpperCase.Text = "Upper Case";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // chkSpecical
            // 
            this.chkSpecical.AutoSize = true;
            this.chkSpecical.Location = new System.Drawing.Point(20, 102);
            this.chkSpecical.Name = "chkSpecical";
            this.chkSpecical.Size = new System.Drawing.Size(110, 17);
            this.chkSpecical.TabIndex = 2;
            this.chkSpecical.Text = "Special Character";
            this.chkSpecical.UseVisualStyleBackColor = true;
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Location = new System.Drawing.Point(20, 79);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(65, 17);
            this.chkNumeric.TabIndex = 3;
            this.chkNumeric.Text = "Numeric";
            this.chkNumeric.UseVisualStyleBackColor = true;
            this.chkNumeric.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(124, 181);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(36, 20);
            this.txtPasswordLength.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(78, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNumeric);
            this.groupBox1.Controls.Add(this.chkLowerCase);
            this.groupBox1.Controls.Add(this.chkUpperCase);
            this.groupBox1.Controls.Add(this.chkSpecical);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerate.Location = new System.Drawing.Point(78, 229);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(138, 23);
            this.BtnGenerate.TabIndex = 9;
            this.BtnGenerate.Text = "Generate Password";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 24);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mousedown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mousemove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouseup);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password Generator";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mdown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mmove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mup);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.SystemColors.Desktop;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Transparent;
            this.Minimize.Location = new System.Drawing.Point(247, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 24);
            this.Minimize.TabIndex = 1;
            this.Minimize.Text = "━";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(270, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 24);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 5);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(288, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 235);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 235);
            this.panel4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(293, 264);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPasswordLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(309, 280);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.CheckBox chkSpecical;
        private System.Windows.Forms.CheckBox chkNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}


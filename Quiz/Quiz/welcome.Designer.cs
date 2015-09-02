namespace Quiz
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.TakeQuiz = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Instructions = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TakeQuiz
            // 
            this.TakeQuiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TakeQuiz.AutoSize = true;
            this.TakeQuiz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TakeQuiz.BackColor = System.Drawing.Color.DodgerBlue;
            this.TakeQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TakeQuiz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeQuiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TakeQuiz.Location = new System.Drawing.Point(146, 252);
            this.TakeQuiz.Name = "TakeQuiz";
            this.TakeQuiz.Size = new System.Drawing.Size(104, 34);
            this.TakeQuiz.TabIndex = 1;
            this.TakeQuiz.Text = "TakeQuiz";
            this.TakeQuiz.UseVisualStyleBackColor = false;
            this.TakeQuiz.Click += new System.EventHandler(this.TakeQuiz_Click);
            // 
            // Logout
            // 
            this.Logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logout.AutoSize = true;
            this.Logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout.BackColor = System.Drawing.Color.DodgerBlue;
            this.Logout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Logout.Location = new System.Drawing.Point(523, 252);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(85, 34);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Instructions
            // 
            this.Instructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Instructions.BackColor = System.Drawing.Color.DodgerBlue;
            this.Instructions.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Instructions.Location = new System.Drawing.Point(324, 252);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(122, 34);
            this.Instructions.TabIndex = 4;
            this.Instructions.Text = "Instructions";
            this.Instructions.UseVisualStyleBackColor = false;
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 407);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.TakeQuiz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TakeQuiz;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Instructions;
        private System.Windows.Forms.Timer timer1;
    }
}
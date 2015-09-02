namespace Quiz
{
    partial class select
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
            this.Aptitude = new System.Windows.Forms.Button();
            this.Technical = new System.Windows.Forms.Button();
            this.Gk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Aptitude
            // 
            this.Aptitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aptitude.BackColor = System.Drawing.Color.DodgerBlue;
            this.Aptitude.FlatAppearance.BorderSize = 3;
            this.Aptitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aptitude.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aptitude.ForeColor = System.Drawing.Color.White;
            this.Aptitude.Location = new System.Drawing.Point(314, 38);
            this.Aptitude.Name = "Aptitude";
            this.Aptitude.Size = new System.Drawing.Size(117, 34);
            this.Aptitude.TabIndex = 1;
            this.Aptitude.Text = "Aptitude";
            this.Aptitude.UseVisualStyleBackColor = false;
            this.Aptitude.Click += new System.EventHandler(this.Aptitude_Click);
            // 
            // Technical
            // 
            this.Technical.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Technical.BackColor = System.Drawing.Color.DodgerBlue;
            this.Technical.FlatAppearance.BorderSize = 3;
            this.Technical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Technical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technical.ForeColor = System.Drawing.Color.White;
            this.Technical.Location = new System.Drawing.Point(314, 150);
            this.Technical.Name = "Technical";
            this.Technical.Size = new System.Drawing.Size(117, 34);
            this.Technical.TabIndex = 2;
            this.Technical.Text = "Technical";
            this.Technical.UseVisualStyleBackColor = false;
            this.Technical.Click += new System.EventHandler(this.Technical_Click);
            // 
            // Gk
            // 
            this.Gk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gk.BackColor = System.Drawing.Color.DodgerBlue;
            this.Gk.FlatAppearance.BorderSize = 3;
            this.Gk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gk.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gk.ForeColor = System.Drawing.Color.White;
            this.Gk.Location = new System.Drawing.Point(297, 255);
            this.Gk.Name = "Gk";
            this.Gk.Size = new System.Drawing.Size(159, 35);
            this.Gk.TabIndex = 3;
            this.Gk.Text = "General Knowledge";
            this.Gk.UseVisualStyleBackColor = false;
            this.Gk.Click += new System.EventHandler(this.Gk_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          //  this.BackgroundImage = global::Quiz.Properties.Resources.quiz_bg3;
            this.ClientSize = new System.Drawing.Size(724, 331);
            this.Controls.Add(this.Gk);
            this.Controls.Add(this.Technical);
            this.Controls.Add(this.Aptitude);
            this.Name = "select";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aptitude;
        private System.Windows.Forms.Button Technical;
        private System.Windows.Forms.Button Gk;
        private System.Windows.Forms.Timer timer1;

    }
}
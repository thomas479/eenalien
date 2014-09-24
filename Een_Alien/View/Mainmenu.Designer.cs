namespace Een_Alien.View
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_level1 = new System.Windows.Forms.Button();
            this.btn_level2 = new System.Windows.Forms.Button();
            this.btn_highscores = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(36, 64);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("http://www.henk.nl", System.UriKind.Absolute);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(921, 660);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 0;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_level1
            // 
            this.btn_level1.Location = new System.Drawing.Point(93, 276);
            this.btn_level1.Name = "btn_level1";
            this.btn_level1.Size = new System.Drawing.Size(75, 23);
            this.btn_level1.TabIndex = 1;
            this.btn_level1.Text = "Level 1";
            this.btn_level1.UseVisualStyleBackColor = true;
            this.btn_level1.Click += new System.EventHandler(this.btn_level1_Click);
            // 
            // btn_level2
            // 
            this.btn_level2.Location = new System.Drawing.Point(174, 276);
            this.btn_level2.Name = "btn_level2";
            this.btn_level2.Size = new System.Drawing.Size(75, 23);
            this.btn_level2.TabIndex = 2;
            this.btn_level2.Text = "Level 2";
            this.btn_level2.UseVisualStyleBackColor = true;
            this.btn_level2.Click += new System.EventHandler(this.btn_level2_Click);
            // 
            // btn_highscores
            // 
            this.btn_highscores.Location = new System.Drawing.Point(93, 362);
            this.btn_highscores.Name = "btn_highscores";
            this.btn_highscores.Size = new System.Drawing.Size(75, 23);
            this.btn_highscores.TabIndex = 3;
            this.btn_highscores.Text = "Highscores";
            this.btn_highscores.UseVisualStyleBackColor = true;
            this.btn_highscores.Click += new System.EventHandler(this.btn_highscores_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageKey = "(none)";
            this.btn_exit.Location = new System.Drawing.Point(921, 694);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_highscores);
            this.Controls.Add(this.btn_level2);
            this.Controls.Add(this.btn_level1);
            this.Controls.Add(this.btn_help);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Een Alien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_level1;
        private System.Windows.Forms.Button btn_level2;
        private System.Windows.Forms.Button btn_highscores;
        private System.Windows.Forms.Button btn_exit;
    }
}



namespace ShopApp
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
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.pcMinimize = new System.Windows.Forms.PictureBox();
            this.pcWelcome = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // pcClose
            // 
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(829, 12);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(64, 55);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcClose.TabIndex = 0;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // pcMinimize
            // 
            this.pcMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pcMinimize.Image")));
            this.pcMinimize.Location = new System.Drawing.Point(750, 12);
            this.pcMinimize.Name = "pcMinimize";
            this.pcMinimize.Size = new System.Drawing.Size(64, 55);
            this.pcMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcMinimize.TabIndex = 1;
            this.pcMinimize.TabStop = false;
            this.pcMinimize.Click += new System.EventHandler(this.pcMinimize_Click);
            // 
            // pcWelcome
            // 
            this.pcWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pcWelcome.Image")));
            this.pcWelcome.Location = new System.Drawing.Point(222, 119);
            this.pcWelcome.Name = "pcWelcome";
            this.pcWelcome.Size = new System.Drawing.Size(455, 358);
            this.pcWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcWelcome.TabIndex = 2;
            this.pcWelcome.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(12, 531);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(174, 52);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Registration";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Violet;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(719, 531);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(174, 52);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 595);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pcWelcome);
            this.Controls.Add(this.pcMinimize);
            this.Controls.Add(this.pcClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.PictureBox pcMinimize;
        private System.Windows.Forms.PictureBox pcWelcome;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
    }
}


namespace Login2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblinc = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.prgbar1 = new System.Windows.Forms.ProgressBar();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblinc
            // 
            this.lblinc.AutoSize = true;
            this.lblinc.BackColor = System.Drawing.Color.Transparent;
            this.lblinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinc.Location = new System.Drawing.Point(592, 398);
            this.lblinc.Name = "lblinc";
            this.lblinc.Size = new System.Drawing.Size(196, 31);
            this.lblinc.TabIndex = 0;
            this.lblinc.Text = "أوليفر جوميز inc.";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Yu Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltitulo.Location = new System.Drawing.Point(206, 30);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(347, 35);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Arabic Hacker University";
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(277, 353);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(194, 33);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login or Leave";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // prgbar1
            // 
            this.prgbar1.Location = new System.Drawing.Point(265, 406);
            this.prgbar1.Name = "prgbar1";
            this.prgbar1.Size = new System.Drawing.Size(225, 23);
            this.prgbar1.TabIndex = 3;
            this.prgbar1.Visible = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(232, 95);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(53, 25);
            this.lbluser.TabIndex = 4;
            this.lbluser.Text = "User";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(232, 181);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(99, 25);
            this.lblpass.TabIndex = 5;
            this.lblpass.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Black;
            this.txtuser.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(237, 133);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(152, 25);
            this.txtuser.TabIndex = 6;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Black;
            this.txtpass.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(237, 227);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(152, 25);
            this.txtpass.TabIndex = 7;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BackgroundImage = global::Login2.Properties.Resources.puerta_cerrada_icon;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrar.Location = new System.Drawing.Point(12, 376);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(39, 53);
            this.btncerrar.TabIndex = 8;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login2.Properties.Resources._796947;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.prgbar1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblinc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Login Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinc;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ProgressBar prgbar1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace rrt
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.edPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.edLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.edRememberMe = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(199, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(345, 182);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.materialLabel2.Size = new System.Drawing.Size(106, 41);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "LOG IN";
            this.materialLabel2.UseAccent = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(358, 405);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(73, 36);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "SIGN IN";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(520, 424);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(255, 36);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "Don\'t have account? Register";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // edPassword
            // 
            this.edPassword.AnimateReadOnly = false;
            this.edPassword.AutoWordSelection = true;
            this.edPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edPassword.Depth = 0;
            this.edPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edPassword.Hint = "Password";
            this.edPassword.LeadingIcon = null;
            this.edPassword.Location = new System.Drawing.Point(233, 309);
            this.edPassword.MaxLength = 50;
            this.edPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.edPassword.Multiline = false;
            this.edPassword.Name = "edPassword";
            this.edPassword.Password = true;
            this.edPassword.Size = new System.Drawing.Size(356, 50);
            this.edPassword.TabIndex = 16;
            this.edPassword.Text = "";
            this.edPassword.TrailingIcon = null;
            // 
            // edLogin
            // 
            this.edLogin.AnimateReadOnly = false;
            this.edLogin.AutoWordSelection = true;
            this.edLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLogin.Depth = 0;
            this.edLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edLogin.Hint = "Login";
            this.edLogin.LeadingIcon = null;
            this.edLogin.Location = new System.Drawing.Point(233, 239);
            this.edLogin.MaxLength = 50;
            this.edLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.edLogin.Multiline = false;
            this.edLogin.Name = "edLogin";
            this.edLogin.Size = new System.Drawing.Size(356, 50);
            this.edLogin.TabIndex = 17;
            this.edLogin.Text = "";
            this.edLogin.TrailingIcon = null;
            // 
            // edRememberMe
            // 
            this.edRememberMe.AutoSize = true;
            this.edRememberMe.Depth = 0;
            this.edRememberMe.Location = new System.Drawing.Point(199, 362);
            this.edRememberMe.Margin = new System.Windows.Forms.Padding(0);
            this.edRememberMe.MouseLocation = new System.Drawing.Point(-1, -1);
            this.edRememberMe.MouseState = MaterialSkin.MouseState.HOVER;
            this.edRememberMe.Name = "edRememberMe";
            this.edRememberMe.ReadOnly = false;
            this.edRememberMe.Ripple = true;
            this.edRememberMe.Size = new System.Drawing.Size(137, 37);
            this.edRememberMe.TabIndex = 18;
            this.edRememberMe.Text = "Remember me";
            this.edRememberMe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.edRememberMe);
            this.Controls.Add(this.edLogin);
            this.Controls.Add(this.edPassword);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox edPassword;
        private MaterialSkin.Controls.MaterialTextBox edLogin;
        private MaterialSkin.Controls.MaterialCheckbox edRememberMe;
    }
}


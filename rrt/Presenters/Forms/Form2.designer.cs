namespace rrt
{
    partial class Form2
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
            this.edEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.edPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.edName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.edPasswordConfirm = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // edEmail
            // 
            this.edEmail.AnimateReadOnly = false;
            this.edEmail.AutoWordSelection = true;
            this.edEmail.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edEmail.Depth = 0;
            this.edEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edEmail.Hint = "Email";
            this.edEmail.LeadingIcon = null;
            this.edEmail.Location = new System.Drawing.Point(245, 201);
            this.edEmail.MaxLength = 50;
            this.edEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.edEmail.Multiline = false;
            this.edEmail.Name = "edEmail";
            this.edEmail.Size = new System.Drawing.Size(356, 50);
            this.edEmail.TabIndex = 25;
            this.edEmail.Text = "";
            this.edEmail.TrailingIcon = null;
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
            this.edPassword.Location = new System.Drawing.Point(245, 268);
            this.edPassword.MaxLength = 50;
            this.edPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.edPassword.Multiline = false;
            this.edPassword.Name = "edPassword";
            this.edPassword.Password = true;
            this.edPassword.Size = new System.Drawing.Size(356, 50);
            this.edPassword.TabIndex = 24;
            this.edPassword.Text = "";
            this.edPassword.TrailingIcon = null;
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
            this.materialButton2.Location = new System.Drawing.Point(7, 70);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(64, 36);
            this.materialButton2.TabIndex = 23;
            this.materialButton2.Text = "BACK";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(346, 85);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.materialLabel2.Size = new System.Drawing.Size(153, 41);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "REGISTER";
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
            this.materialButton1.Location = new System.Drawing.Point(384, 388);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 21;
            this.materialButton1.Text = "SIGN UP";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // edName
            // 
            this.edName.AnimateReadOnly = false;
            this.edName.AutoWordSelection = true;
            this.edName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edName.Depth = 0;
            this.edName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edName.Hint = "Name";
            this.edName.LeadingIcon = null;
            this.edName.Location = new System.Drawing.Point(245, 139);
            this.edName.MaxLength = 50;
            this.edName.MouseState = MaterialSkin.MouseState.OUT;
            this.edName.Multiline = false;
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(356, 50);
            this.edName.TabIndex = 26;
            this.edName.Text = "";
            this.edName.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(192, 155);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Name:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(194, 216);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 19);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Email:";
            // 
            // edPasswordConfirm
            // 
            this.edPasswordConfirm.AnimateReadOnly = false;
            this.edPasswordConfirm.AutoWordSelection = true;
            this.edPasswordConfirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edPasswordConfirm.Depth = 0;
            this.edPasswordConfirm.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edPasswordConfirm.Hint = "Confirm password";
            this.edPasswordConfirm.LeadingIcon = null;
            this.edPasswordConfirm.Location = new System.Drawing.Point(245, 329);
            this.edPasswordConfirm.MaxLength = 50;
            this.edPasswordConfirm.MouseState = MaterialSkin.MouseState.OUT;
            this.edPasswordConfirm.Multiline = false;
            this.edPasswordConfirm.Name = "edPasswordConfirm";
            this.edPasswordConfirm.Password = true;
            this.edPasswordConfirm.Size = new System.Drawing.Size(356, 50);
            this.edPasswordConfirm.TabIndex = 29;
            this.edPasswordConfirm.Text = "";
            this.edPasswordConfirm.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(164, 284);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 30;
            this.materialLabel4.Text = "Password:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(104, 343);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(135, 19);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "Confirm password:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.edPasswordConfirm);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.edEmail);
            this.Controls.Add(this.edPassword);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton1);
            this.Name = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox edEmail;
        private MaterialSkin.Controls.MaterialTextBox edPassword;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox edName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox edPasswordConfirm;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}
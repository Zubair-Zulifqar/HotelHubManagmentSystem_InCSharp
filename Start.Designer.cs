namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{
    partial class Start
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(10, 10);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(250, 44);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.signupButton.Location = new System.Drawing.Point(10, 78);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(250, 49);
            this.signupButton.TabIndex = 1;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // Start
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signupButton);
            this.Name = "Start";
 
            this.ResumeLayout(false);

        }
    }
}

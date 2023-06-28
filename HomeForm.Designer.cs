namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button addReservationButton;
        private System.Windows.Forms.Button addRoomButton;

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
            this.addClientButton = new System.Windows.Forms.Button();
            this.addReservationButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClientButton
            // 
            this.addClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.Location = new System.Drawing.Point(10, 10);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(262, 30);
            this.addClientButton.TabIndex = 0;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // addReservationButton
            // 
            this.addReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.addReservationButton.Location = new System.Drawing.Point(10, 59);
            this.addReservationButton.Name = "addReservationButton";
            this.addReservationButton.Size = new System.Drawing.Size(262, 30);
            this.addReservationButton.TabIndex = 1;
            this.addReservationButton.Text = "Add Reservation";
            this.addReservationButton.UseVisualStyleBackColor = true;
            this.addReservationButton.Click += new System.EventHandler(this.addReservationButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.addRoomButton.Location = new System.Drawing.Point(10, 118);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(262, 30);
            this.addRoomButton.TabIndex = 2;
            this.addRoomButton.Text = "Add Room";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(10, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.Location = new System.Drawing.Point(10, 169);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(262, 30);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // HomeForm
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.addReservationButton);
            this.Controls.Add(this.addRoomButton);
            this.Name = "HomeForm";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowAll;
    }
}

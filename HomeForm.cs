using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{
    public partial class HomeForm : Form
    {
      
        public HomeForm()
        {
            InitializeComponent();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
           AddClient add = new AddClient();
            add.ShowDialog();

            this.Hide();
        }

        private void addReservationButton_Click(object sender, EventArgs e)
        {
            AddReservation reserve = new AddReservation();
            reserve.ShowDialog();

            this.Hide();

        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            AddRoom  add = new AddRoom();
            add.ShowDialog();

            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
           ShowAll show=new ShowAll();
            show.ShowDialog();

            this.Hide();
        }
    }
}

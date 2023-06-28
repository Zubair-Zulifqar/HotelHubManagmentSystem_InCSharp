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
    public partial class ShowAll : Form
    {
        Reservation reservation = new Reservation();
        public ShowAll()
        {
            InitializeComponent();
        }

        private void ShowAll_Load(object sender, EventArgs e)
        {
            gridShowAll.DataSource = reservation.ShowAllReservations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.ShowDialog();

            this.Hide();
        }
    }
}

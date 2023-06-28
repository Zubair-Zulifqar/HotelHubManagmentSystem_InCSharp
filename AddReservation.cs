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
    public partial class AddReservation : Form
    {
        Reservation reservation = new Reservation();
        Room room = new Room();
        public AddReservation()
        {
            InitializeComponent();
        }

        private void AddReservations_Load(object sender, EventArgs e)
        {
           

            gridReservations.DataSource = reservation.GetAllReservations();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int guestID = Convert.ToInt32(tbGuestID.Text);
                int roomID = Convert.ToInt32(tbRoomID.Text);
                string payment = tbPayment.Text;
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date must be Greater Or Equal than Current Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The DateOut must be Greater Or Equal than DateIn", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.MakeReservation(guestID,roomID, dateIn, dateOut,payment))
                    {
                        room.SetRoomFree(roomID, "NO");
                        gridReservations.DataSource = reservation.GetAllReservations();
                        MessageBox.Show("Reservation made successfully!", "Make Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClearFields.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Reservation not added!", "Make Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Make Reservation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int reservationID = Convert.ToInt32(tbReservID.Text);
                int guestID = Convert.ToInt32(tbGuestID.Text);
                int roomID = Convert.ToInt32(tbRoomID.Text);
                string payment = tbPayment.Text;
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date must be Greater Or Equal than Current Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The DateOut must be Greater Or Equal than DateIn", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.EditReservation(reservationID,guestID, roomID, dateIn, dateOut, payment))
                    {
                        room.SetRoomFree(roomID, "NO");
                        gridReservations.DataSource = reservation.GetAllReservations();
                        MessageBox.Show("Reservation made successfully!", "Make Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClearFields.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Reservation not added!", "Make Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Make Reservation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationID = Convert.ToInt32(tbReservID.Text);
                int roomNumber = Convert.ToInt32(tbRoomID.Text);

                if (reservation.RemoveReservation(reservationID))
                {
                    room.SetRoomFree(roomNumber, "YES");
                    gridReservations.DataSource = reservation.GetAllReservations();
                    MessageBox.Show("Reservation deleted successfully!", "Reservation Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClearFields.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Reservation not deleted!", "Reservation Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete reservation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbReservID.Text = "";
            tbGuestID.Text = "";
            tbRoomID.Text = "";
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;
        }
        //private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    tbReservID.Text = gridReservations.CurrentRow.Cells[0].Value.ToString();
        //    tbGuestID.Text = gridReservations.CurrentRow.Cells[1].Value.ToString();
        //    tbRoomID.Text = gridReservations.CurrentRow.Cells[2].Value.ToString();
        //    dateTimePickerIN.Value = Convert.ToDateTime(gridReservations.CurrentRow.Cells[3].Value.ToString());
        //    dateTimePickerOUT.Value = Convert.ToDateTime(gridReservations.CurrentRow.Cells[4].Value.ToString());
        //    tbPayment.Text= gridReservations.CurrentRow.Cells[5].Value.ToString();

        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.ShowDialog();

            this.Hide();
        }

        private void gridReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbReservID.Text = gridReservations.CurrentRow.Cells[0].Value.ToString();
            tbGuestID.Text = gridReservations.CurrentRow.Cells[1].Value.ToString();
            tbRoomID.Text = gridReservations.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerIN.Value = Convert.ToDateTime(gridReservations.CurrentRow.Cells[3].Value.ToString());
            dateTimePickerOUT.Value = Convert.ToDateTime(gridReservations.CurrentRow.Cells[4].Value.ToString());
            tbPayment.Text = gridReservations.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

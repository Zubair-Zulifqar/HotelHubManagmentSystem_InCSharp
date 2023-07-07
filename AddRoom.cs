using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{
    public partial class AddRoom : Form
    {
        Room room = new Room();
        public AddRoom()
        {
            InitializeComponent();
        }
        private void AddRooms_Load(object sender, EventArgs e)
        {

            gridRooms.DataSource = room.GetAllRooms();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = 0;
            number=Convert.ToInt32(tbNumber.Text);
            String type=tbType.Text;
            String capacity=tbCapacity.Text;
            String price = tbPrice.Text;
            String occupied=tbOccupied.Text;
            if (type.Trim().Equals("") || capacity.Trim().Equals("") || price.Trim().Equals("") || occupied.Trim().Equals("") || number == 0)
            {
                MessageBox.Show("Feilds Missing", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {


                    if (room.InsertRoom(number, type, capacity, price, occupied))
                    {
                        gridRooms.DataSource = room.GetAllRooms();
                        MessageBox.Show("inserted successfully!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClearFields.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("not inserted!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Room number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    
        private void gridRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNumber.Text = gridRooms.CurrentRow.Cells[0].Value.ToString();
            tbType.Text = gridRooms.CurrentRow.Cells[1].Value.ToString();
            tbCapacity.Text = gridRooms.CurrentRow.Cells[2].Value.ToString();
            tbPrice.Text = gridRooms.CurrentRow.Cells[3].Value.ToString();
            tbOccupied.Text = gridRooms.CurrentRow.Cells[4].Value.ToString();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.ShowDialog();

            this.Hide();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            int number = 0;
            number=Convert.ToInt32(tbNumber.Text);
            String type = tbType.Text;
            String capacity = tbCapacity.Text;
            String price = tbPrice.Text;
            String occupied = tbOccupied.Text;
            if (type.Trim().Equals("") || capacity.Trim().Equals("") || price.Trim().Equals("") || occupied.Trim().Equals("") || number == 0)
            {
                MessageBox.Show("Feilds Missing", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {


                    if (room.EditRoom(number, type, capacity, price, occupied))
                    {
                        gridRooms.DataSource = room.GetAllRooms();
                        MessageBox.Show("inserted successfully!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClearFields.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("not inserted!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Room number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {

            int number = 0;
            number = Convert.ToInt32(tbNumber.Text);
            if (number == 0)
            {
                MessageBox.Show("Feilds Missing", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (room.RemoveRoom(number))
                    {
                        gridRooms.DataSource = room.GetAllRooms();
                        MessageBox.Show("deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClearFields.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(" Room not deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Room number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
       

        private void btnClearFields_Click_1(object sender, EventArgs e)
        {
            tbNumber.Text = "";
            tbType.Text = "";
            tbCapacity.Text = "";
            tbPrice.Text = "";
            tbOccupied.Text = "";
        }

        private void gridRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             tbNumber.Text = gridRooms.CurrentRow.Cells[0].Value.ToString();
            tbType.Text = gridRooms.CurrentRow.Cells[1].Value.ToString();
            tbCapacity.Text = gridRooms.CurrentRow.Cells[2].Value.ToString();
            tbPrice.Text = gridRooms.CurrentRow.Cells[3].Value.ToString();
            tbOccupied.Text = gridRooms.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

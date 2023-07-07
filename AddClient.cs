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
    
    public partial class AddClient : Form
    {
        Client client = new Client();
        public AddClient()
        {
            InitializeComponent();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = gridClients.CurrentRow.Cells[0].Value.ToString();
            tbFirstName.Text = gridClients.CurrentRow.Cells[1].Value.ToString();
            tbLastName.Text = gridClients.CurrentRow.Cells[2].Value.ToString();
            tbPhone.Text = gridClients.CurrentRow.Cells[3].Value.ToString();
            tbAddress.Text = gridClients.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String fname = tbFirstName.Text;
            String lname = tbLastName.Text;
            String phone = tbPhone.Text;
            String country = tbAddress.Text;

            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("Feilds Missing", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean IsInserted = client.InsertClient(fname, lname, phone, country);

                if (IsInserted)
                {
                    gridClients.DataSource = client.GetAllClients();
                    MessageBox.Show("inserted successfully!", "Client Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClearFields.PerformClick();
                }
                else
                {
                    MessageBox.Show("Client not inserted!", "Client Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void AddClients_Load(object sender, EventArgs e)
        {
            gridClients.DataSource = client.GetAllClients();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;
            String fname = tbFirstName.Text;
            String lname = tbLastName.Text;
            String phone = tbPhone.Text;
            String address = tbAddress.Text;

            try
            {
                id = Convert.ToInt32(tbID.Text);

                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("Required fields - Firstname/Lastname/Phone", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean IsUpdatedClient = client.EditClient(id, fname, lname, phone, address);

                    if (IsUpdatedClient)
                    {
                        gridClients.DataSource = client.GetAllClients();
                        MessageBox.Show("Client updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("not updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            int id = 0;
            id = Convert.ToInt32(tbID.Text);
            if (id == 0)
            {
                MessageBox.Show("Feilds Missing", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (client.RemoveClient(id))
                    {
                        gridClients.DataSource = client.GetAllClients();
                        MessageBox.Show("Client deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClearFields.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("not deleted!", " Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.ShowDialog();

            this.Hide();
        }
    }
}

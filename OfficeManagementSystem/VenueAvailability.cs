using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeManagementSystem
{
    public partial class VenueAvailability : Form
    {
        public VenueAvailability()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the CheckBox is currently checked
            if (checkBox1.Checked)
            {
                // If it's checked, uncheck it
                checkBox1.Checked = false;
            }
            else
            {
                // If it's not checked, check it
                checkBox1.Checked = true;
            }
        }

        private void VenueAvailability_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                // If the user is an admin, make the button visible
                adminButton.Visible = true;
            }
            else
            {
                // If the user is not an admin, hide the button
                adminButton.Visible = false;
            }
        }
    }

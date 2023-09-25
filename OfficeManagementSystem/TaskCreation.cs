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
    public partial class TaskCreation : Form
    {
        public TaskCreation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusLabel1.Text = "Completed";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.Forms
{
    public partial class formClientList : Form
    {
        public formClientList()
        {
            InitializeComponent();
        }

        private void formClientList_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconAddClient_Click(object sender, EventArgs e)
        {
            using var addClientForm = new formAddingClient();
            addClientForm.ShowDialog(this);
        }
    }
}

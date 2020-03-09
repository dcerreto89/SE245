using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_win
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            // create an instance of form1 and make it visible
            Form1 temp = new Form1();
            temp.Show();
        }

        private void btnSearchPeople_Click(object sender, EventArgs e)
        {
            // create an instance of the search form and make it visible
            Search temp = new Search();
            temp.Show();
        }
    }
}

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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get Data
            PersonV2 temp = new PersonV2();
            //Perform the search we created in EBook class and store the returned dataset
            DataSet ds = temp.SearchPersons(txtSearchFName.Text, txtSearchLName.Text);

            //Display data (dataset)
            dgvResults.DataSource = ds;                                  //point datagrid to dataset
            dgvResults.DataMember = ds.Tables["Person_Temp"].ToString();     // What table in the dataset?
        }

        private void dgvResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gather the information (Gathers the row clicked, then chooses the first cell's data
            string strPersonID = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Display data in Pop-up
            MessageBox.Show(strPersonID);

            //Convert the string over to an integer
            int intPersonID = Convert.ToInt32(strPersonID);

            
            Form1 Editor = new Form1(intPersonID);
            Editor.ShowDialog();
        }
    }
}

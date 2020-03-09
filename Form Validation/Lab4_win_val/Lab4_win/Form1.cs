using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_4;

namespace Lab4_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //create a person object
            PersonV2 temp = new PersonV2();

            //fill the person from the form
            temp.FName = txtFName.Text;
            temp.MName = txtMName.Text;
            temp.LName = txtLName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.Zip = txtZip.Text;
            temp.Phone = txtPhone.Text;
            temp.Email = txtEmail.Text;
            temp.Cellphone = txtCellphone.Text;
            temp.Facebook = txtFacebook.Text;

            

            //Look for Errors listed in Feedback...If none found, display data
            if (!temp.Feedback.Contains("ERROR:"))
            {
                //output the results from the person object
                lblResult.Text = temp.FName + "\n" + temp.MName + "\n" + temp.LName + "\n" + temp.Street1 + "\n" + temp.Street2 + "\n" + temp.City + "\n" + temp.State + "\n" + temp.Zip + "\n" + temp.Phone + "\n" + temp.Email + "\n" + temp.Cellphone + "\n" + temp.Facebook;
            }
            else
            {
                //Else...Display Error Messages
                lblResult.Text = temp.Feedback;
            }

        }
    }
}

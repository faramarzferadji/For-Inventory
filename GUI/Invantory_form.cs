using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invantory.ASP.Business;
using Invantory.ASP.DataAccesses;


namespace Invantory.ASP.GUI
{
    public partial class Invantory_form : Form
    {
        List<Invantor> listc = new List<Invantor>();
        public Invantory_form()
        {
            InitializeComponent();
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            Invantor invantor2 = new Invantor();
            invantor2.ID_Articl = Convert.ToInt32(textBoxID.Text);
            invantor2.Name_Articl = textBoxName.Text;
            invantor2.Quntity_IN = Convert.ToInt32(textBoxQuntityIn.Text);
            invantor2.Quntity_Out = Convert.ToInt32(textBoxQuntityOut.Text);
            invantor2.Price = Convert.ToInt32(textBoxPrice.Text);
           
            listc.Add(invantor2);


            // InvantorIO.Total();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Invantor invantor = new Invantor();
            invantor.ID_Articl = Convert.ToInt32(textBoxID.Text);
            invantor.Name_Articl = textBoxName.Text;
            invantor.Quntity_IN = Convert.ToInt32(textBoxQuntityIn.Text);
            invantor.Quntity_Out = Convert.ToInt32(textBoxQuntityOut.Text);
            invantor.Price = Convert.ToInt32(textBoxPrice.Text);
            InvantoryIO.SaveRecord(invantor);
         

        }

        private void buttonShowInList_Click(object sender, EventArgs e)
        {
            listViewInvanter.Items.Clear();

            InvantoryIO.ListInvanter(listViewInvanter);


        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choise = comboBoxSearch.SelectedIndex;
            switch (choise)
            {

                case 0:
                    labelSearch.Text = "please enter the ID";
                    break;
                case 1:
                    labelSearch.Text = "please enter the name";
                    break;
                default:
                    break;


            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choise = comboBoxSearch.SelectedIndex;
            switch (choise)
            {
                case -1:
                    MessageBox.Show("please enter one option");
                    break;
                case 0:

                    Invantor invantor =   InvantoryIO.Search(Convert.ToInt32(textBoxInPutInfo.Text));
                    
                   
                 
                        if (invantor != null)
                        {
                            textBoxID.Text = (invantor.ID_Articl).ToString();
                            textBoxName.Text = invantor.Name_Articl;                                                       
                            textBoxQuntityIn.Text = (invantor.Quntity_IN).ToString();
                            textBoxQuntityOut.Text = (invantor.Quntity_Out).ToString();
                            textBoxPrice.Text = (invantor.Price).ToString();

                    }
                        else
                        {
                            MessageBox.Show("Articl not found!");
                            textBoxInPutInfo.Clear();
                            textBoxInPutInfo.Focus();
                        }
                    
                        break;
                   
                case 1:
                    Invantor invantor1 =InvantoryIO.Search(textBoxInPutInfo.Text);
                        
                        
                    if (invantor1 != null)
                    {
                        textBoxID.Text = (invantor1.ID_Articl).ToString();
                        textBoxName.Text = invantor1.Name_Articl;
                        textBoxQuntityIn.Text = (invantor1.Quntity_IN).ToString();
                        textBoxQuntityOut.Text = (invantor1.Quntity_Out).ToString();
                        textBoxPrice.Text = (invantor1.Price).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Articl not found!");
                        textBoxInPutInfo.Clear();
                        textBoxInPutInfo.Focus();
                    }
                    break;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxQuntityIn.Clear();
            textBoxQuntityOut.Clear();
            textBoxPrice.Clear();
            textBoxInPutInfo.Clear();
            textBoxID.Focus();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            InvantoryIO.Delete(Convert.ToInt32(textBoxID.Text));
            MessageBox.Show("The Datas that been choised have been Deleted successfully! ");
        }

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            Invantor invantor1 = new Invantor();
            invantor1.ID_Articl = Convert.ToInt32(textBoxID.Text);
            invantor1.Name_Articl = textBoxName.Text;
            invantor1.Quntity_IN = Convert.ToInt32(textBoxQuntityIn.Text);
            invantor1.Quntity_Out = Convert.ToInt32(textBoxQuntityOut.Text);
            invantor1.Price = Convert.ToInt32(textBoxPrice.Text);
            DialogResult anaswer = MessageBox.Show("are you sure to update?", "Confermation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (anaswer == DialogResult.Yes)
            {
               InvantoryIO.UpDate(invantor1);
                MessageBox.Show("Data has been updated");
            }


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult anaswer = MessageBox.Show("are you sure to exit?", "Confermation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (anaswer == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void textBoxShowTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Invantory_form_Load(object sender, EventArgs e)
        {

        }
    }
}

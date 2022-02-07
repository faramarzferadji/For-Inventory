using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invantory.ASP.Business;
using System.IO;

namespace Invantory.ASP.DataAccesses
{
   public static class InvantoryIO

    {

        private static string FilePath = Application.StartupPath + @"\Invantor.dat";
        private static string Filetemp = Application.StartupPath + @"\Tamp.dat";
        public static void SaveRecord(Invantor invo)
        {
            StreamWriter streamWriter = new StreamWriter(FilePath);
            streamWriter.WriteLine(invo.ID_Articl + "," + invo.Name_Articl + "," + invo.Quntity_IN + "," +
                invo.Quntity_Out + "," + invo.Quntity_Exist + "," + invo.Price + "," + invo.Total_Worth);
                    
            streamWriter.Close();
                MessageBox.Show("Invantory information has been saved");
           
        }

        public static void ListInvanter(ListView listviewInvanter)
        {
            StreamReader streamReader1 = new StreamReader(FilePath);
            listviewInvanter.Items.Clear();
            string line = streamReader1.ReadLine();
           
            while(line != null)
            {
                string[] fildes = line.Split(',');
                ListViewItem item = new ListViewItem(fildes[0]);
                item.SubItems.Add(fildes[1]);
                item.SubItems.Add(fildes[2]);
                item.SubItems.Add(fildes[3]);
                item.SubItems.Add(fildes[4]);
                item.SubItems.Add(fildes[5]);
                item.SubItems.Add(fildes[6]);
                listviewInvanter.Items.Add(item);
                line = streamReader1.ReadLine();

            }
            streamReader1.Close();

        }
        
        public static List<Invantor> ListInvantor()
        {

           
            List<Invantor> listc = new List<Invantor>();
            StreamReader streamReader = new StreamReader(FilePath);
            //int total = 0;
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                 Invantor inv = new Invantor();
                inv.ID_Articl = Convert.ToInt32(fields[0]);
                inv.Name_Articl = fields[1];
                inv.Quntity_IN = Convert.ToInt32(fields[2]);
                inv.Quntity_Out = Convert.ToInt32(fields[3]);
                inv.Quntity_Exist = Convert.ToInt32(fields[4]);
                inv.Price = Convert.ToInt32(fields[5]);
                inv.Total_Worth = Convert.ToInt32(fields[6]);

                listc.Add(inv);
                line = streamReader.ReadLine();
                //total = listc.Sum(item => item.Total_Worth);
                /// MessageBox.Show(total.ToString());

            }

            streamReader.Close();

            return listc;
        }



        public static Invantor Search(int articlID)
        {
            Invantor invantor = new Invantor();
            StreamReader streamReader = new StreamReader(FilePath);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (articlID == Convert.ToInt32(fields[0]))
                {
                    invantor.ID_Articl = Convert.ToInt32(fields[0]);
                    invantor.Name_Articl = fields[1];
                    invantor.Price = Convert.ToInt32(fields[5]);
                    invantor.Quntity_IN = Convert.ToInt32(fields[2]);
                    invantor.Quntity_Out = Convert.ToInt32(fields[3]);



                    return invantor;

                }
                line = streamReader.ReadLine();

            }
            streamReader.Close();

            return null;
        }
        public static Invantor Search(string nameInv)
        {
            Invantor invantor = new Invantor();
            StreamReader streamReader = new StreamReader(FilePath);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (nameInv == fields[1])
                {
                    invantor.ID_Articl = Convert.ToInt32(fields[0]);
                    invantor.Name_Articl = fields[1];
                    invantor.Quntity_IN = Convert.ToInt32(fields[2]);
                    invantor.Quntity_Out = Convert.ToInt32(fields[3]);
                    invantor.Price = Convert.ToInt32(fields[5]);

                    return invantor;

                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            return null;
        }
        public static void Delete(int articlID)
        {
            StreamReader streamReader = new StreamReader(FilePath);
            StreamWriter streamWriter = new StreamWriter(Filetemp, true);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (articlID != Convert.ToInt32(fields[0]))
                {
                    streamWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," +
                        fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);

                }
                line = streamReader.ReadLine();

            }


            streamReader.Close();
            streamWriter.Close();
            File.Delete(FilePath);
            File.Move(Filetemp, FilePath);

        }
        public static void UpDate(Invantor inv)
        {
            StreamReader streamReader = new StreamReader(FilePath);
            StreamWriter streamWriter = new StreamWriter(Filetemp, true);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (Convert.ToInt32(fields[0]) != inv.ID_Articl)
                {
                    streamWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," +
                        fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);

                }
                line = streamReader.ReadLine();

            }
            streamWriter.WriteLine(inv.ID_Articl + "," + inv.Name_Articl + "," + inv.Quntity_IN +
                "," + inv.Quntity_Out + "," + inv.Quntity_Exist + "," + inv.Price + "," + inv.Total_Worth);


            streamReader.Close();
            streamWriter.Close();
            File.Delete(FilePath);
            File.Move(Filetemp, FilePath);

        }
    }
}

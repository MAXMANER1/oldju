using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
//Data[P_Name,P_Phone,P_Address,R_Name,R_Phone,R_Address,amount]
namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            
            InitializeComponent();
            Purchaser_Load();           
        }
        #region btn_Event

        private void btn_Purchaser_Click(object sender, EventArgs e)
        {
            
            var Purchaser = new List<String> { };
            
            Purchaser_Write(Purchaser);
            
            //StreamWriter sw = new StreamWriter(@"D:\Purchaser1.csv", append: true);
            
            try
            {
                
                 File.AppendAllText(@"D:\Purchaser1.csv",
                       $"{string.Join(",", Purchaser)}\r\n",
                       Encoding.UTF8
                       );  
                       
                //sw.WriteLine($"{string.Join(",", Purchaser)}");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Purchaser_Clear();
            //sw.Close();
        }
        private void btn_test_Click(object sender, EventArgs e)
        {
            //Purchaser_Name.Text = Purchaser_Data[1, 1].Value.ToString();
            //Load_Purchaser();
            //Purchaser_Save();
            //Data_Select();
            Data_Delete();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int.TryParse(Price_Single.Text, out var n);
            Price_Total.Text = (n * Purchaser_Load()).ToString();
        }

        #endregion

        #region function
        //get user input data
        private void Purchaser_Write(List<String> Purchaser)
        {
            Purchaser.Add(Purchaser_Name.Text);
            Purchaser.Add(Puchaser_Phone.Text);
            Purchaser.Add(Purchaser_Address.Text);
        //if receiver data is empty get purchaser data
            if (Receiver_Name.Text== String.Empty)
            {
                Purchaser.Add(Purchaser_Name.Text);
                Purchaser.Add(Puchaser_Phone.Text);
                Purchaser.Add(Purchaser_Address.Text);
                Purchaser.Add(Receiver_Amount.Text);
            }
            else
            {
                Purchaser.Add(Receiver_Name.Text);
                Purchaser.Add(Receiver_Phone.Text);
                Purchaser.Add(Receiver_Address.Text);
                Purchaser.Add(Receiver_Amount.Text);
            }
            
        }

        //clear all user input data
        private void Purchaser_Clear()
        {
            
            Purchaser_Name.Text = null;
            Puchaser_Phone.Text = null;
            Purchaser_Address.Text = null;
            Receiver_Name.Text = null;
            Receiver_Phone.Text = null;
            Receiver_Address.Text = null;
            Receiver_Amount.Text = null;

        }
        //load all data in datagrid and return total amount
        private int Purchaser_Load() {
            
            DataGridViewRowCollection rows = Purchaser_Data.Rows;
            rows.Clear();
            //xml.Load(@"D:\Purchaser.csv");
            StreamReader sr = new StreamReader(@"D:\Purchaser1.csv", Encoding.Default);
            int Total=0;
            int number;
            while (!sr.EndOfStream)
            {

                string AllData = sr.ReadLine();
                string[] All_array = AllData.Split(",".ToCharArray());
                rows.Add(new Object[] { All_array[0], All_array[1], All_array[2], All_array[6] });
                int.TryParse(All_array[6],out number);
                Total = Total + number;
            }
            sr.Close();
            Total_Nuber .Text= Total.ToString();
            return Total;
            
            //Purchaser_Name.Text=AllData;
            /*
            while (!sr.EndOfStream)
            {
                string AllData = sr.ReadLine();
                string[] rows = AllData.Split(",".ToCharArray());
                for (int j = 0; j < 7; j++)
                { this.Purchaser_Data).Columns[j].HeaderText = rows[j]; }
        */

        }

        //NOT COMPLETE BELOW
        private void Data_Delete()
        {
            
            //if (Purchaser_Data.CurrentCell != null)
            //Purchaser_Data.
            foreach (DataGridViewRow r in Purchaser_Data.SelectedRows)
            {
                //Purchaser_Name.Text = Purchaser_Data[1, 1].Value.ToString();
                Purchaser_Data.Rows.Remove(r);
                    
            }
        }
        private void Data_Select()
        {

            //if (Purchaser_Data.CurrentCell != null)
            foreach (DataGridViewRow r in Purchaser_Data.SelectedRows)
            {
                // Purchaser_Name.Text = Purchaser_Data[1,1].Value.ToString();                            
                Purchaser_Data.Rows.Remove(r);


            }
        }
        
        
        private void Purchaser_Save()
        {
            string strData = String.Empty;
            string strResult = String.Empty;
            for (int i = 0; i <= 4; i++)
            {
                strData = String.Empty;
                for (int j = 0; j <= 4; j++)
                {
                    strData=Purchaser_Data[i, j].Value.ToString() + ",";
                }
                strData = strData.Trim(',');
                strResult += strData + Environment.NewLine;

            }
            using (StreamWriter sw = new StreamWriter(@"D:\Purchaser1.csv", false, Encoding.Default))
            {
                sw.Write(strResult);
            }
        }



        #endregion

        private void Data_Refresh_Click(object sender, EventArgs e)
        {
            Purchaser_Load();
        }
    }



}

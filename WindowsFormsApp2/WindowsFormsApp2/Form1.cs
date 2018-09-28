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
            Data_List.SetItemChecked(0, true);
            Data_List.SetItemChecked(1, true);
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
            Purchaser_Save();
            //Data_Delete();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int.TryParse(Price_Single.Text, out var n);
            Price_Total.Text = (n * Purchaser_Load()).ToString();
        }
        private void Data_Refresh_Click(object sender, EventArgs e)
        {
            Purchaser_Load();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool[] checklist = new bool[] { List_check(0), List_check(1) };
            this.Purchaser_Data.Columns["PurchaserD_Name"].Visible = checklist[0];
            this.Purchaser_Data.Columns["PurchaserD_Phone"].Visible = checklist[0];
            this.Purchaser_Data.Columns["PurchaserD_Address"].Visible = checklist[0];
            this.Purchaser_Data.Columns["ReceiverD_Name"].Visible = checklist[1];
            this.Purchaser_Data.Columns["ReceiverD_Phone"].Visible = checklist[1];
            this.Purchaser_Data.Columns["ReceiverD_Address"].Visible = checklist[1];
        }
        #endregion

        #region function
        //get user input data
        private void Purchaser_Write(List<String> Purchaser)
        {
            Purchaser.Add(Purchaser_Name.Text);
            Purchaser.Add(Purchaser_Phone.Text);
            Purchaser.Add(Purchaser_Address.Text);
        //if receiver data is empty get purchaser data
            if (Receiver_Name.Text== String.Empty)
            {
                Purchaser.Add(Purchaser_Name.Text);
                Purchaser.Add(Purchaser_Phone.Text);
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
            Purchaser_Phone.Text = null;
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
                rows.Add(new Object[] { All_array[0], All_array[1], All_array[2], All_array[3], All_array[4], All_array[5], All_array[6] });
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

        private void Data_Delete()
        {
            
            //if (Purchaser_Data.CurrentCell != null)
            foreach (DataGridViewRow r in Purchaser_Data.SelectedRows)
            {
                Purchaser_Data.Rows.Remove(r);                   
            }
        }       
        
        private void Purchaser_Save()
        {
            string strData = String.Empty;
            string strResult = String.Empty;          
            for (int i = 0; i < Purchaser_Data.RowCount-1; i++)
            {
                strData = String.Empty;
                for (int j = 0; j < Purchaser_Data.ColumnCount-1; j++)
                {
                    strData+=Purchaser_Data[j,i].Value.ToString() + ",";
                }               
               strData = strData.Trim(',');
                strResult += strData + Environment.NewLine;
            }       
            using (StreamWriter sw = new StreamWriter(@"D:\Purchaser3.csv", false, Encoding.Default))
            {
                sw.Write(strResult);
            }
        }
        private Boolean List_check(int index)
        {

            if (Data_List.GetItemChecked(index))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Revise_Click(object sender, EventArgs e)
        {
            //myButton.BackColor = default(Color);
            this.Invoke(new Action(() => { btn_Revise.BackColor = Color.LightGreen; }));            
            //DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)Purchaser_Data.CurrentRow.Cells[0];
            Purchaser_Name.Text=Purchaser_Data.CurrentRow.Cells[0].Value.ToString();
            Purchaser_Phone.Text = Purchaser_Data.CurrentRow.Cells[1].Value.ToString();
            Purchaser_Address.Text = Purchaser_Data.CurrentRow.Cells[2].Value.ToString();
            Receiver_Name.Text = Purchaser_Data.CurrentRow.Cells[3].Value.ToString();
            Receiver_Phone.Text = Purchaser_Data.CurrentRow.Cells[4].Value.ToString();
            Receiver_Address.Text= Purchaser_Data.CurrentRow.Cells[5].Value.ToString();
            Receiver_Amount.Text= Purchaser_Data.CurrentRow.Cells[6].Value.ToString();
            //var a=Purchaser_Data.SelectedRows[0].Index;
            //return Purchaser_Data.CurrentCell.RowIndex;
        }
    }





    #endregion





}

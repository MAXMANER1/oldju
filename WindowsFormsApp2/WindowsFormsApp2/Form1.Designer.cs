namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Receiver_Amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Purchaser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Receiver_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Receiver_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Receiver_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Purchaser_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Purchaser_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Purchaser_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Calculate = new System.Windows.Forms.Button();
            this.Price_Total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Price_Single = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Total_Nuber = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Purchaser_Data = new System.Windows.Forms.DataGridView();
            this.PurchaserD_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaserD_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaserD_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverD_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverD_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverD_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaserD_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Refresh = new System.Windows.Forms.Button();
            this.Data_List = new System.Windows.Forms.CheckedListBox();
            this.btn_Revise = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.schedule = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Purchaser_Data)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Receiver_Amount);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btn_Purchaser);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Receiver_Address);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Receiver_Phone);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Receiver_Name);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Purchaser_Address);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Purchaser_Phone);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Purchaser_Name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新增訂單";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Receiver_Amount
            // 
            this.Receiver_Amount.Location = new System.Drawing.Point(123, 289);
            this.Receiver_Amount.Name = "Receiver_Amount";
            this.Receiver_Amount.Size = new System.Drawing.Size(57, 25);
            this.Receiver_Amount.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "數量:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(25, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "收貨人資料";
            // 
            // btn_Purchaser
            // 
            this.btn_Purchaser.Location = new System.Drawing.Point(355, 289);
            this.btn_Purchaser.Name = "btn_Purchaser";
            this.btn_Purchaser.Size = new System.Drawing.Size(75, 29);
            this.btn_Purchaser.TabIndex = 13;
            this.btn_Purchaser.Text = "新增";
            this.btn_Purchaser.UseVisualStyleBackColor = true;
            this.btn_Purchaser.Click += new System.EventHandler(this.btn_Purchaser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(25, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "購買人資料";
            // 
            // Receiver_Address
            // 
            this.Receiver_Address.Location = new System.Drawing.Point(123, 236);
            this.Receiver_Address.Name = "Receiver_Address";
            this.Receiver_Address.Size = new System.Drawing.Size(307, 25);
            this.Receiver_Address.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "收件人地址: ";
            // 
            // Receiver_Phone
            // 
            this.Receiver_Phone.Location = new System.Drawing.Point(330, 185);
            this.Receiver_Phone.Name = "Receiver_Phone";
            this.Receiver_Phone.Size = new System.Drawing.Size(100, 25);
            this.Receiver_Phone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "收件人電話: ";
            // 
            // Receiver_Name
            // 
            this.Receiver_Name.Location = new System.Drawing.Point(123, 185);
            this.Receiver_Name.Name = "Receiver_Name";
            this.Receiver_Name.Size = new System.Drawing.Size(100, 25);
            this.Receiver_Name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "收件人姓名: ";
            // 
            // Purchaser_Address
            // 
            this.Purchaser_Address.Location = new System.Drawing.Point(123, 107);
            this.Purchaser_Address.Name = "Purchaser_Address";
            this.Purchaser_Address.Size = new System.Drawing.Size(307, 25);
            this.Purchaser_Address.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "購買人地址: ";
            // 
            // Purchaser_Phone
            // 
            this.Purchaser_Phone.Location = new System.Drawing.Point(330, 56);
            this.Purchaser_Phone.Name = "Purchaser_Phone";
            this.Purchaser_Phone.Size = new System.Drawing.Size(100, 25);
            this.Purchaser_Phone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "購買人電話: ";
            // 
            // Purchaser_Name
            // 
            this.Purchaser_Name.Location = new System.Drawing.Point(123, 56);
            this.Purchaser_Name.Name = "Purchaser_Name";
            this.Purchaser_Name.Size = new System.Drawing.Size(100, 25);
            this.Purchaser_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "購買人姓名: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Calculate);
            this.tabPage2.Controls.Add(this.Price_Total);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.Price_Single);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.Total_Nuber);
            this.tabPage2.Controls.Add(this.label_total);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "統計";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(321, 161);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "計算";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Price_Total
            // 
            this.Price_Total.Location = new System.Drawing.Point(385, 225);
            this.Price_Total.Name = "Price_Total";
            this.Price_Total.Size = new System.Drawing.Size(100, 25);
            this.Price_Total.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "總收入:";
            // 
            // Price_Single
            // 
            this.Price_Single.Location = new System.Drawing.Point(85, 80);
            this.Price_Single.Name = "Price_Single";
            this.Price_Single.Size = new System.Drawing.Size(100, 25);
            this.Price_Single.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "單價:";
            // 
            // Total_Nuber
            // 
            this.Total_Nuber.Location = new System.Drawing.Point(85, 35);
            this.Total_Nuber.Name = "Total_Nuber";
            this.Total_Nuber.Size = new System.Drawing.Size(100, 25);
            this.Total_Nuber.TabIndex = 1;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(32, 35);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(41, 15);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "數量:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1255, 433);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // Purchaser_Data
            // 
            this.Purchaser_Data.AllowUserToOrderColumns = true;
            this.Purchaser_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Purchaser_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaserD_Name,
            this.PurchaserD_Phone,
            this.PurchaserD_Address,
            this.ReceiverD_Name,
            this.ReceiverD_Phone,
            this.ReceiverD_Address,
            this.PurchaserD_amount});
            this.Purchaser_Data.Location = new System.Drawing.Point(576, 46);
            this.Purchaser_Data.Name = "Purchaser_Data";
            this.Purchaser_Data.RowTemplate.Height = 27;
            this.Purchaser_Data.Size = new System.Drawing.Size(777, 375);
            this.Purchaser_Data.TabIndex = 1;
            // 
            // PurchaserD_Name
            // 
            this.PurchaserD_Name.HeaderText = "購買人姓名";
            this.PurchaserD_Name.Name = "PurchaserD_Name";
            // 
            // PurchaserD_Phone
            // 
            this.PurchaserD_Phone.HeaderText = "購買人電話";
            this.PurchaserD_Phone.Name = "PurchaserD_Phone";
            this.PurchaserD_Phone.Width = 150;
            // 
            // PurchaserD_Address
            // 
            this.PurchaserD_Address.HeaderText = "購買人地址";
            this.PurchaserD_Address.Name = "PurchaserD_Address";
            this.PurchaserD_Address.Width = 200;
            // 
            // ReceiverD_Name
            // 
            this.ReceiverD_Name.HeaderText = "收貨人姓名";
            this.ReceiverD_Name.Name = "ReceiverD_Name";
            // 
            // ReceiverD_Phone
            // 
            this.ReceiverD_Phone.HeaderText = "收貨人電話";
            this.ReceiverD_Phone.Name = "ReceiverD_Phone";
            // 
            // ReceiverD_Address
            // 
            this.ReceiverD_Address.HeaderText = "收貨人地址";
            this.ReceiverD_Address.Name = "ReceiverD_Address";
            // 
            // PurchaserD_amount
            // 
            this.PurchaserD_amount.HeaderText = "數量";
            this.PurchaserD_amount.Name = "PurchaserD_amount";
            this.PurchaserD_amount.Width = 50;
            // 
            // Data_Refresh
            // 
            this.Data_Refresh.Location = new System.Drawing.Point(818, 433);
            this.Data_Refresh.Name = "Data_Refresh";
            this.Data_Refresh.Size = new System.Drawing.Size(75, 23);
            this.Data_Refresh.TabIndex = 2;
            this.Data_Refresh.Text = "刷新";
            this.Data_Refresh.UseVisualStyleBackColor = true;
            this.Data_Refresh.Click += new System.EventHandler(this.Data_Refresh_Click);
            // 
            // Data_List
            // 
            this.Data_List.CheckOnClick = true;
            this.Data_List.FormattingEnabled = true;
            this.Data_List.Items.AddRange(new object[] {
            "購買人",
            "收貨人"});
            this.Data_List.Location = new System.Drawing.Point(576, 433);
            this.Data_List.Name = "Data_List";
            this.Data_List.Size = new System.Drawing.Size(120, 84);
            this.Data_List.TabIndex = 16;
            this.Data_List.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btn_Revise
            // 
            this.btn_Revise.Location = new System.Drawing.Point(716, 433);
            this.btn_Revise.Name = "btn_Revise";
            this.btn_Revise.Size = new System.Drawing.Size(75, 23);
            this.btn_Revise.TabIndex = 17;
            this.btn_Revise.Text = "修改";
            this.btn_Revise.UseVisualStyleBackColor = true;
            this.btn_Revise.Click += new System.EventHandler(this.btn_Revise_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.schedule);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(554, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(35, 34);
            this.schedule.Multiline = true;
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(229, 289);
            this.schedule.TabIndex = 0;
            this.schedule.TextChanged += new System.EventHandler(this.schedule_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 674);
            this.Controls.Add(this.btn_Revise);
            this.Controls.Add(this.Data_List);
            this.Controls.Add(this.Data_Refresh);
            this.Controls.Add(this.Purchaser_Data);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Purchaser_Data)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Receiver_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Receiver_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Receiver_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Purchaser_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Purchaser_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Purchaser_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Purchaser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Purchaser_Data;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox Receiver_Amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox Total_Nuber;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Price_Total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Price_Single;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Data_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaserD_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaserD_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaserD_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverD_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverD_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverD_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaserD_amount;
        private System.Windows.Forms.CheckedListBox Data_List;
        private System.Windows.Forms.Button btn_Revise;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox schedule;
    }
}


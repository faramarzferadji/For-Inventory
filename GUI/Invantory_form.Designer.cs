
namespace Invantory.ASP.GUI
{
    partial class Invantory_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.buttonShowInList = new System.Windows.Forms.Button();
            this.buttonUpDate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelprice = new System.Windows.Forms.Label();
            this.textBoxQuntityIn = new System.Windows.Forms.TextBox();
            this.labelquntityin = new System.Windows.Forms.Label();
            this.textBoxQuntityOut = new System.Windows.Forms.TextBox();
            this.labelQuntityOut = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxInPutInfo = new System.Windows.Forms.TextBox();
            this.labelinputInfo = new System.Windows.Forms.Label();
            this.listViewInvanter = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(713, 35);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(713, 84);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(75, 23);
            this.buttonAddList.TabIndex = 1;
            this.buttonAddList.Text = "AddToList";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // buttonShowInList
            // 
            this.buttonShowInList.Location = new System.Drawing.Point(713, 134);
            this.buttonShowInList.Name = "buttonShowInList";
            this.buttonShowInList.Size = new System.Drawing.Size(75, 23);
            this.buttonShowInList.TabIndex = 2;
            this.buttonShowInList.Text = "ShowInList";
            this.buttonShowInList.UseVisualStyleBackColor = true;
            this.buttonShowInList.Click += new System.EventHandler(this.buttonShowInList_Click);
            // 
            // buttonUpDate
            // 
            this.buttonUpDate.Location = new System.Drawing.Point(713, 188);
            this.buttonUpDate.Name = "buttonUpDate";
            this.buttonUpDate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpDate.TabIndex = 3;
            this.buttonUpDate.Text = "UpDate";
            this.buttonUpDate.UseVisualStyleBackColor = true;
            this.buttonUpDate.Click += new System.EventHandler(this.buttonUpDate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(713, 248);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(713, 299);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(579, 134);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 84);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name of Articl";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(12, 85);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 9;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(43, 62);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(224, 83);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 11;
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Location = new System.Drawing.Point(272, 61);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(40, 17);
            this.labelprice.TabIndex = 12;
            this.labelprice.Text = "Price";
            // 
            // textBoxQuntityIn
            // 
            this.textBoxQuntityIn.Location = new System.Drawing.Point(340, 84);
            this.textBoxQuntityIn.Name = "textBoxQuntityIn";
            this.textBoxQuntityIn.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuntityIn.TabIndex = 13;
            // 
            // labelquntityin
            // 
            this.labelquntityin.AutoSize = true;
            this.labelquntityin.Location = new System.Drawing.Point(351, 62);
            this.labelquntityin.Name = "labelquntityin";
            this.labelquntityin.Size = new System.Drawing.Size(72, 17);
            this.labelquntityin.TabIndex = 14;
            this.labelquntityin.Text = "Quntity_In";
            // 
            // textBoxQuntityOut
            // 
            this.textBoxQuntityOut.Location = new System.Drawing.Point(465, 83);
            this.textBoxQuntityOut.Name = "textBoxQuntityOut";
            this.textBoxQuntityOut.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuntityOut.TabIndex = 15;
            // 
            // labelQuntityOut
            // 
            this.labelQuntityOut.AutoSize = true;
            this.labelQuntityOut.Location = new System.Drawing.Point(481, 55);
            this.labelQuntityOut.Name = "labelQuntityOut";
            this.labelQuntityOut.Size = new System.Drawing.Size(84, 17);
            this.labelQuntityOut.TabIndex = 16;
            this.labelQuntityOut.Text = "Quntity_Out";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Search By ID",
            "Search By Name"});
            this.comboBoxSearch.Location = new System.Drawing.Point(12, 151);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSearch.TabIndex = 17;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(32, 128);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(73, 17);
            this.labelSearch.TabIndex = 18;
            this.labelSearch.Text = "Search By";
            // 
            // textBoxInPutInfo
            // 
            this.textBoxInPutInfo.Location = new System.Drawing.Point(180, 152);
            this.textBoxInPutInfo.Name = "textBoxInPutInfo";
            this.textBoxInPutInfo.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutInfo.TabIndex = 19;
            // 
            // labelinputInfo
            // 
            this.labelinputInfo.AutoSize = true;
            this.labelinputInfo.Location = new System.Drawing.Point(206, 128);
            this.labelinputInfo.Name = "labelinputInfo";
            this.labelinputInfo.Size = new System.Drawing.Size(66, 17);
            this.labelinputInfo.TabIndex = 20;
            this.labelinputInfo.Text = "Input Info";
            // 
            // listViewInvanter
            // 
            this.listViewInvanter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewInvanter.HideSelection = false;
            this.listViewInvanter.Location = new System.Drawing.Point(12, 188);
            this.listViewInvanter.Name = "listViewInvanter";
            this.listViewInvanter.Size = new System.Drawing.Size(677, 236);
            this.listViewInvanter.TabIndex = 21;
            this.listViewInvanter.UseCompatibleStateImageBehavior = false;
            this.listViewInvanter.View = System.Windows.Forms.View.Details;
            this.listViewInvanter.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IN_Q";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OUT_Q";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EX_Q";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Totl_Worth";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(484, 133);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Invantory_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listViewInvanter);
            this.Controls.Add(this.labelinputInfo);
            this.Controls.Add(this.textBoxInPutInfo);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.labelQuntityOut);
            this.Controls.Add(this.textBoxQuntityOut);
            this.Controls.Add(this.labelquntityin);
            this.Controls.Add(this.textBoxQuntityIn);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpDate);
            this.Controls.Add(this.buttonShowInList);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.buttonSave);
            this.Name = "Invantory_form";
            this.Text = "Invantory_form";
            this.Load += new System.EventHandler(this.Invantory_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Button buttonShowInList;
        private System.Windows.Forms.Button buttonUpDate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.TextBox textBoxQuntityIn;
        private System.Windows.Forms.Label labelquntityin;
        private System.Windows.Forms.TextBox textBoxQuntityOut;
        private System.Windows.Forms.Label labelQuntityOut;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxInPutInfo;
        private System.Windows.Forms.Label labelinputInfo;
        private System.Windows.Forms.ListView listViewInvanter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonClear;
    }
}

namespace AddressApp
{
  partial class AddressForm
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
      this.components = new System.ComponentModel.Container();
      this.FirstName = new System.Windows.Forms.Label();
      this.FirstNameTxt = new System.Windows.Forms.TextBox();
      this.LastNameTxt = new System.Windows.Forms.TextBox();
      this.LastName = new System.Windows.Forms.Label();
      this.StreetNameTxt = new System.Windows.Forms.TextBox();
      this.StreetName = new System.Windows.Forms.Label();
      this.HouseNumberTxt = new System.Windows.Forms.TextBox();
      this.HouseNumber = new System.Windows.Forms.Label();
      this.ApartmentNumberTxt = new System.Windows.Forms.TextBox();
      this.ApartmentNumber = new System.Windows.Forms.Label();
      this.PostalCodeTxt = new System.Windows.Forms.TextBox();
      this.PostalCode = new System.Windows.Forms.Label();
      this.TownTxt = new System.Windows.Forms.TextBox();
      this.Town = new System.Windows.Forms.Label();
      this.PhoneNumberTxt = new System.Windows.Forms.TextBox();
      this.PhoneNumber = new System.Windows.Forms.Label();
      this.DateOfBirth = new System.Windows.Forms.Label();
      this.DateOfBirthPkr = new System.Windows.Forms.DateTimePicker();
      this.SaveBtn = new System.Windows.Forms.Button();
      this.AddressGrid = new System.Windows.Forms.DataGridView();
      this.deleteBtn = new System.Windows.Forms.Button();
      this.CLEAR = new System.Windows.Forms.Button();
      this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
      this.SuspendLayout();
      // 
      // FirstName
      // 
      this.FirstName.AutoSize = true;
      this.FirstName.Location = new System.Drawing.Point(12, 38);
      this.FirstName.Name = "FirstName";
      this.FirstName.Size = new System.Drawing.Size(67, 15);
      this.FirstName.TabIndex = 0;
      this.FirstName.Text = "FirstName :";
      // 
      // FirstNameTxt
      // 
      this.FirstNameTxt.Location = new System.Drawing.Point(132, 35);
      this.FirstNameTxt.Name = "FirstNameTxt";
      this.FirstNameTxt.Size = new System.Drawing.Size(129, 23);
      this.FirstNameTxt.TabIndex = 1;
      this.FirstNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameTxt_Validating);
      // 
      // LastNameTxt
      // 
      this.LastNameTxt.Location = new System.Drawing.Point(132, 71);
      this.LastNameTxt.Name = "LastNameTxt";
      this.LastNameTxt.Size = new System.Drawing.Size(129, 23);
      this.LastNameTxt.TabIndex = 13;
      this.LastNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameTxt_Validating);
      // 
      // LastName
      // 
      this.LastName.AutoSize = true;
      this.LastName.Location = new System.Drawing.Point(12, 74);
      this.LastName.Name = "LastName";
      this.LastName.Size = new System.Drawing.Size(66, 15);
      this.LastName.TabIndex = 12;
      this.LastName.Text = "LastName :";
      // 
      // StreetNameTxt
      // 
      this.StreetNameTxt.Location = new System.Drawing.Point(132, 113);
      this.StreetNameTxt.Name = "StreetNameTxt";
      this.StreetNameTxt.Size = new System.Drawing.Size(129, 23);
      this.StreetNameTxt.TabIndex = 15;
      this.StreetNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.StreetNameTxt_Validating);
      // 
      // StreetName
      // 
      this.StreetName.AutoSize = true;
      this.StreetName.Location = new System.Drawing.Point(12, 113);
      this.StreetName.Name = "StreetName";
      this.StreetName.Size = new System.Drawing.Size(75, 15);
      this.StreetName.TabIndex = 14;
      this.StreetName.Text = "StreetName :";
      // 
      // HouseNumberTxt
      // 
      this.HouseNumberTxt.Location = new System.Drawing.Point(132, 155);
      this.HouseNumberTxt.Name = "HouseNumberTxt";
      this.HouseNumberTxt.Size = new System.Drawing.Size(129, 23);
      this.HouseNumberTxt.TabIndex = 17;
      this.HouseNumberTxt.Validating += new System.ComponentModel.CancelEventHandler(this.HouseNumberTxt_Validating);
      // 
      // HouseNumber
      // 
      this.HouseNumber.AutoSize = true;
      this.HouseNumber.Location = new System.Drawing.Point(12, 158);
      this.HouseNumber.Name = "HouseNumber";
      this.HouseNumber.Size = new System.Drawing.Size(91, 15);
      this.HouseNumber.TabIndex = 16;
      this.HouseNumber.Text = "HouseNumber :";
      // 
      // ApartmentNumberTxt
      // 
      this.ApartmentNumberTxt.Location = new System.Drawing.Point(132, 207);
      this.ApartmentNumberTxt.Name = "ApartmentNumberTxt";
      this.ApartmentNumberTxt.Size = new System.Drawing.Size(129, 23);
      this.ApartmentNumberTxt.TabIndex = 19;
      // 
      // ApartmentNumber
      // 
      this.ApartmentNumber.AutoSize = true;
      this.ApartmentNumber.Location = new System.Drawing.Point(12, 210);
      this.ApartmentNumber.Name = "ApartmentNumber";
      this.ApartmentNumber.Size = new System.Drawing.Size(114, 15);
      this.ApartmentNumber.TabIndex = 18;
      this.ApartmentNumber.Text = "ApartmentNumber :";
      // 
      // PostalCodeTxt
      // 
      this.PostalCodeTxt.Location = new System.Drawing.Point(463, 40);
      this.PostalCodeTxt.Name = "PostalCodeTxt";
      this.PostalCodeTxt.Size = new System.Drawing.Size(129, 23);
      this.PostalCodeTxt.TabIndex = 21;
      this.PostalCodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.PostalCodeTxt_Validating);
      // 
      // PostalCode
      // 
      this.PostalCode.AutoSize = true;
      this.PostalCode.Location = new System.Drawing.Point(343, 43);
      this.PostalCode.Name = "PostalCode";
      this.PostalCode.Size = new System.Drawing.Size(73, 15);
      this.PostalCode.TabIndex = 20;
      this.PostalCode.Text = "PostalCode :";
      // 
      // TownTxt
      // 
      this.TownTxt.Location = new System.Drawing.Point(463, 83);
      this.TownTxt.Name = "TownTxt";
      this.TownTxt.Size = new System.Drawing.Size(129, 23);
      this.TownTxt.TabIndex = 23;
      this.TownTxt.Validating += new System.ComponentModel.CancelEventHandler(this.TownTxt_Validating);
      // 
      // Town
      // 
      this.Town.AutoSize = true;
      this.Town.Location = new System.Drawing.Point(343, 83);
      this.Town.Name = "Town";
      this.Town.Size = new System.Drawing.Size(41, 15);
      this.Town.TabIndex = 22;
      this.Town.Text = "Town :";
      // 
      // PhoneNumberTxt
      // 
      this.PhoneNumberTxt.Location = new System.Drawing.Point(463, 119);
      this.PhoneNumberTxt.Name = "PhoneNumberTxt";
      this.PhoneNumberTxt.Size = new System.Drawing.Size(129, 23);
      this.PhoneNumberTxt.TabIndex = 25;
      this.PhoneNumberTxt.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneNumberTxt_Validating);
      // 
      // PhoneNumber
      // 
      this.PhoneNumber.AutoSize = true;
      this.PhoneNumber.Location = new System.Drawing.Point(343, 122);
      this.PhoneNumber.Name = "PhoneNumber";
      this.PhoneNumber.Size = new System.Drawing.Size(91, 15);
      this.PhoneNumber.TabIndex = 24;
      this.PhoneNumber.Text = "PhoneNumber :";
      // 
      // DateOfBirth
      // 
      this.DateOfBirth.AutoSize = true;
      this.DateOfBirth.Location = new System.Drawing.Point(343, 166);
      this.DateOfBirth.Name = "DateOfBirth";
      this.DateOfBirth.Size = new System.Drawing.Size(75, 15);
      this.DateOfBirth.TabIndex = 26;
      this.DateOfBirth.Text = "DateOfBirth :";
      // 
      // DateOfBirthPkr
      // 
      this.DateOfBirthPkr.Location = new System.Drawing.Point(463, 160);
      this.DateOfBirthPkr.Name = "DateOfBirthPkr";
      this.DateOfBirthPkr.Size = new System.Drawing.Size(185, 23);
      this.DateOfBirthPkr.TabIndex = 28;
      // 
      // SaveBtn
      // 
      this.SaveBtn.Location = new System.Drawing.Point(423, 210);
      this.SaveBtn.Name = "SaveBtn";
      this.SaveBtn.Size = new System.Drawing.Size(75, 23);
      this.SaveBtn.TabIndex = 29;
      this.SaveBtn.Text = "SAVE";
      this.SaveBtn.UseVisualStyleBackColor = true;
      this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
      // 
      // AddressGrid
      // 
      this.AddressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.AddressGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
      this.AddressGrid.Location = new System.Drawing.Point(12, 266);
      this.AddressGrid.Name = "AddressGrid";
      this.AddressGrid.RowTemplate.Height = 25;
      this.AddressGrid.Size = new System.Drawing.Size(776, 208);
      this.AddressGrid.TabIndex = 30;
      this.AddressGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressGrid_CellValueChanged);
      // 
      // deleteBtn
      // 
      this.deleteBtn.Location = new System.Drawing.Point(526, 210);
      this.deleteBtn.Name = "deleteBtn";
      this.deleteBtn.Size = new System.Drawing.Size(75, 23);
      this.deleteBtn.TabIndex = 31;
      this.deleteBtn.Text = "DELETE";
      this.deleteBtn.UseVisualStyleBackColor = true;
      this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
      // 
      // CLEAR
      // 
      this.CLEAR.Location = new System.Drawing.Point(643, 210);
      this.CLEAR.Name = "CLEAR";
      this.CLEAR.Size = new System.Drawing.Size(75, 23);
      this.CLEAR.TabIndex = 32;
      this.CLEAR.Text = "CLEAR";
      this.CLEAR.UseVisualStyleBackColor = true;
      this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
      // 
      // errorProviderApp
      // 
      this.errorProviderApp.ContainerControl = this;
      // 
      // AddressForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.NavajoWhite;
      this.ClientSize = new System.Drawing.Size(800, 486);
      this.Controls.Add(this.CLEAR);
      this.Controls.Add(this.deleteBtn);
      this.Controls.Add(this.AddressGrid);
      this.Controls.Add(this.SaveBtn);
      this.Controls.Add(this.DateOfBirthPkr);
      this.Controls.Add(this.DateOfBirth);
      this.Controls.Add(this.PhoneNumberTxt);
      this.Controls.Add(this.PhoneNumber);
      this.Controls.Add(this.TownTxt);
      this.Controls.Add(this.Town);
      this.Controls.Add(this.PostalCodeTxt);
      this.Controls.Add(this.PostalCode);
      this.Controls.Add(this.ApartmentNumberTxt);
      this.Controls.Add(this.ApartmentNumber);
      this.Controls.Add(this.HouseNumberTxt);
      this.Controls.Add(this.HouseNumber);
      this.Controls.Add(this.StreetNameTxt);
      this.Controls.Add(this.StreetName);
      this.Controls.Add(this.LastNameTxt);
      this.Controls.Add(this.LastName);
      this.Controls.Add(this.FirstNameTxt);
      this.Controls.Add(this.FirstName);
      this.ForeColor = System.Drawing.Color.Black;
      this.Name = "AddressForm";
      this.Text = "AddressForm";
      ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label FirstName;
    private System.Windows.Forms.TextBox FirstNameTxt;
    private System.Windows.Forms.TextBox LastNameTxt;
    private System.Windows.Forms.Label LastName;
    private System.Windows.Forms.TextBox StreetNameTxt;
    private System.Windows.Forms.Label StreetName;
    private System.Windows.Forms.TextBox HouseNumberTxt;
    private System.Windows.Forms.Label HouseNumber;
    private System.Windows.Forms.TextBox ApartmentNumberTxt;
    private System.Windows.Forms.Label ApartmentNumber;
    private System.Windows.Forms.TextBox PostalCodeTxt;
    private System.Windows.Forms.Label PostalCode;
    private System.Windows.Forms.TextBox TownTxt;
    private System.Windows.Forms.Label Town;
    private System.Windows.Forms.TextBox PhoneNumberTxt;
    private System.Windows.Forms.Label PhoneNumber;
    private System.Windows.Forms.Label DateOfBirth;
    private System.Windows.Forms.DateTimePicker DateOfBirthPkr;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.DataGridView AddressGrid;
    private System.Windows.Forms.Button SaveBtn;
    private System.Windows.Forms.Button deleteBtn;
    private System.Windows.Forms.Button CLEAR;
    private System.Windows.Forms.ErrorProvider errorProviderApp;
  }
}
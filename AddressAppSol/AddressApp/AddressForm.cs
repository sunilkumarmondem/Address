using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AddressApp
{
  public partial class AddressForm : Form
  {
    XmlSerializer xs;
    List<Address> addressList;
    int counter = 1;
    string path = @"C:\Users\Aneta\Desktop\AddressAppSol\Address.xml";


    public AddressForm()
    {
      InitializeComponent();
      addressList = new List<Address>();
      xs = new XmlSerializer(typeof(List<Address>));
    }

    private void ReadData()
    {
      FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);
      addressList = (List<Address>)xs.Deserialize(fsRead);
      AddressGrid.DataSource = addressList;
      fsRead.Close();
    }                                                                                                 

    private void SaveBtn_Click(object sender, EventArgs e)
    {
      FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
      Address ad = new Address();
      ad.Id = counter++;
      ad.FirstName = FirstNameTxt.Text;
      ad.LastName = LastNameTxt.Text;
      ad.StreetName = StreetNameTxt.Text;
      ad.HouseNumber = int.Parse(HouseNumberTxt.Text);
      ad.ApartmentNumber = int.Parse(ApartmentNumberTxt.Text);
      ad.PostalCode = PostalCodeTxt.Text;
      ad.Town = TownTxt.Text;
      ad.PhoneNumber = PhoneNumberTxt.Text;
      ad.DateOfBirth = DateOfBirthPkr.Value;
      int myAge =DateTime.Today.Year - DateOfBirthPkr.Value.Year;
      ad.Age = myAge;
      addressList.Add(ad);
      xs.Serialize(fs, addressList);
      clearData();
    
      fs.Close();
      ReadData();

    }

    private void clearData()
    {
      FirstNameTxt.Text = null;
      LastNameTxt.Text = null;
      StreetNameTxt.Text = null;
      HouseNumberTxt.Text = null;
      ApartmentNumberTxt.Text = null;
      PostalCodeTxt.Text = null;
      TownTxt.Text = null;
      PhoneNumberTxt.Text = null;
      DateOfBirthPkr.Value = DateTime.Now;
    }

  
    private void AddressGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);
      addressList = (List<Address>)xs.Deserialize(fsRead);
      int id = Convert.ToInt32(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[0].Value);
      List<Address> editAddress = new List<Address>();
      foreach(Address ad in addressList)
      {
        if (ad.Id == id)
        {
          ad.Id = Convert.ToInt32(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[0].Value);
          ad.FirstName = Convert.ToString(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[1].Value);
          ad.LastName = Convert.ToString(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[2].Value);
          ad.StreetName = Convert.ToString(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[3].Value);
          ad.HouseNumber = Convert.ToInt32(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[4].Value);
          ad.ApartmentNumber = Convert.ToInt32(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[5].Value);
          ad.PostalCode = Convert.ToString(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[6].Value);
          ad.Town = Convert.ToString(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[7].Value);
          ad.PhoneNumber = Convert.ToString(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[8].Value);
          ad.DateOfBirth = Convert.ToDateTime(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[9].Value);
          editAddress.Add(ad);
        }
        else
        {
          editAddress.Add(ad);
        }
      }
      fsRead.Close();
      FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
      xs.Serialize(fs, editAddress);
      fs.Close();
      ReadData();
    }

    private void deleteBtn_Click(object sender, EventArgs e)
    {
      FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);
      addressList = (List<Address>)xs.Deserialize(fsRead);
      int id = Convert.ToInt32(AddressGrid.Rows[AddressGrid.CurrentRow.Index].Cells[0].Value);
      List<Address> deleteAddress = new List<Address>();
      foreach (Address ad in addressList)
      {
        if (ad.Id == id)
        {                   
        }
        else
        {
          deleteAddress.Add(ad);
        }
        fsRead.Close();
        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
        xs.Serialize(fs, deleteAddress);
        fs.Close();
        ReadData();
      }
    }

    private void CLEAR_Click(object sender, EventArgs e)
    {
      clearData();
      ReadData();
    }

    private void FirstNameTxt_Validating(object sender, CancelEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(FirstNameTxt.Text))
      {
        e.Cancel = true;
        FirstNameTxt.Focus();
        errorProviderApp.SetError(FirstNameTxt, "FirstName should not be left blank!");
      }
      else
      {
        e.Cancel = false;
        errorProviderApp.SetError(FirstNameTxt, "");
      }
    }

    private void StreetNameTxt_Validating(object sender, CancelEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(StreetNameTxt.Text))
      {
        e.Cancel = true;
        StreetNameTxt.Focus();
        errorProviderApp.SetError(StreetNameTxt, "StreetName should not be left blank!");
      }
      else
      {
        e.Cancel = false;
        errorProviderApp.SetError(StreetNameTxt, "");
      }
    }

    private void HouseNumberTxt_Validating(object sender, CancelEventArgs e)
    {
      if (System.Text.RegularExpressions.Regex.IsMatch(HouseNumberTxt.Text, "[^0-9]"))
      {
        e.Cancel = true;
        HouseNumberTxt.Focus();
        errorProviderApp.SetError(HouseNumberTxt, "HouseNumber format is wrong!");
      }
      else
      {
        e.Cancel = false;
        errorProviderApp.SetError(HouseNumberTxt, "");
      }
    }

    private void PostalCodeTxt_Validating(object sender, CancelEventArgs e)
    {
      Regex postalCodePattern = new Regex(@"^\d{5}-\d{4}|\d{5}|[A-Z]\d[A-Z] \d[A-Z]\d$");
      if (postalCodePattern.IsMatch(PostalCodeTxt.Text)||string.IsNullOrWhiteSpace(PostalCodeTxt.Text))
      {
        e.Cancel = true;
        PostalCodeTxt.Focus();
        errorProviderApp.SetError(PostalCodeTxt, "Postal code format is wrong!");
      }
      else
      {
        e.Cancel = false;
        errorProviderApp.SetError(PostalCodeTxt, "");
      }
    }

    private void TownTxt_Validating(object sender, CancelEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(TownTxt.Text))
      {
        e.Cancel = true;
        TownTxt.Focus();
        errorProviderApp.SetError(TownTxt, "Town should not be left blank!");
      }
      else
      {
        e.Cancel = false;
        errorProviderApp.SetError(TownTxt, "");
      }
    }

    private void PhoneNumberTxt_Validating(object sender, CancelEventArgs e)
    {
      Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{5}\s+[0-9]{3}");
      if (phoneNumpattern.IsMatch(PhoneNumberTxt.Text) || (PhoneNumberTxt.Text.Length < 9) && (PhoneNumberTxt.Text.Length > 0))
      {
        e.Cancel = true;
        PhoneNumberTxt.Focus();
        errorProviderApp.SetError(PhoneNumberTxt, "Phone number format is wrong");
      }
      else
      {
        e.Cancel = false;
        errorProviderApp.SetError(PhoneNumberTxt, "");
      }
    }

    private void LastNameTxt_Validating(object sender, CancelEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(LastNameTxt.Text))
      {
        e.Cancel = true;
        LastNameTxt.Focus();
        errorProviderApp.SetError(LastNameTxt, "LastName should not be left blank!");
      }
      else
      {
        e.Cancel = false;
        errorProviderApp.SetError(LastNameTxt, "");
      }
    }
  }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project13InsuranceManagement.DataLayer;

namespace Project13InsuranceManagement.Views
{
    public partial class ClientView : UserControl, IForm
    {
        public ClientView()
        {
            InitializeComponent();
        }

        public void Set(object o)
        {
            if (o == null)
            {
                return;
            }
            Client c = o as Client;
            firstNameTextBox.Text = c.FirstName;
            lastNameTextBox.Text = c.LastName;
            peselTextBox.Text = c.Pesel.ToString();
            discountTextBox.Text = c.Discount.ToString();
        }

        public void Reset()
        {
            firstNameTextBox.Reset();
            lastNameTextBox.Reset();
            peselTextBox.Reset();
            discountTextBox.Reset();
        }

        public List<string> ValidateForm()
        {
            List<string> validationErrors = new List<string>();
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || firstNameTextBox.IsUnchanged())
            {
                validationErrors.Add("First name is empty or a placeholder");
            }
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text) || lastNameTextBox.IsUnchanged())
            {
                validationErrors.Add("Last name is empty or a placeholder");
            }
            double val;
            if (Double.TryParse(peselTextBox.Text, out val))
            {
                if (peselTextBox.Text.Length == 11)
                {
                    int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                    int controlSum = CalculateControlSum(peselTextBox.Text, weights);
                    int controlNum = controlSum % 10;
                    controlNum = 10 - controlNum;
                    if (controlNum == 10)
                    {
                        controlNum = 0;
                    }
                    int lastDigit = int.Parse(peselTextBox.Text[10].ToString());
                    if (controlNum != lastDigit)
                    {
                        validationErrors.Add("Wrong PESEL, check numbers");
                    }
                }
                else if (peselTextBox.Text.Length < 11)
                {
                    validationErrors.Add("PESEL is too short");
                }
                else if (peselTextBox.Text.Length > 11)
                {
                    validationErrors.Add("PESEL is too long");
                }
            }
            else
            {
                validationErrors.Add("PESEL must contains digits only");
            }
            double val2;
            if (Double.TryParse(discountTextBox.Text, out val2))
            {
                if (val2 > 100 || val2 < 0)
                {
                    validationErrors.Add("discount should be between 0 and 100");
                }
            }
            else
            {
                validationErrors.Add("Wrong format of discount");
            }
            return validationErrors;
        }

        public bool ValidateAndCreateObject()
        {
            List<string> validationErrors = ValidateForm();
            if (validationErrors.Count == 0)
            {
                Client newCar = new Client(firstNameTextBox.Text, lastNameTextBox.Text, Double.Parse(discountTextBox.Text), Double.Parse(peselTextBox.Text));
                return true;
            }
            MessageBox.Show(string.Join(Environment.NewLine, validationErrors));
            return false;
        }

        public bool ValidateAndUpdateObject(Object o)
        {
            List<string> validationErrors = ValidateForm();
            if (validationErrors.Count == 0)
            {
                Client cl = o as Client;
                cl.Discount = Double.Parse(discountTextBox.Text);
                cl.FirstName = firstNameTextBox.Text;
                cl.LastName = lastNameTextBox.Text;
                cl.Pesel = Double.Parse(peselTextBox.Text);
                return true;
            }
            MessageBox.Show(string.Join(Environment.NewLine, validationErrors));
            return false;
        }

        public int CalculateControlSum(string pesel, int[] weights)
        {
            int controlSum = 0;
            for (int i = 0; i < pesel.Length - 1; i++)
            {
                controlSum += weights[i] * int.Parse(pesel[i].ToString());
            }
            return controlSum;
        }
    }
}
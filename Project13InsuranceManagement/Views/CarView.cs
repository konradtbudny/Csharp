using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project13InsuranceManagement.DataLayer;

namespace Project13InsuranceManagement.Views
{
    public partial class CarView : UserControl, IForm
    {
        public CarView()
        {
            InitializeComponent();
        }

        public void Set(Object o)
        {
            if (o == null)
            {
                return;
            }
            Car t = o as Car;
            makeTextBox.Text = t.Brand;
            modelTextBox.Text = t.Model;
            priceTextBox.Text = t.Price.ToString();
        }

        public void Reset()
        {
            priceTextBox.Reset();
            makeTextBox.Reset();
            modelTextBox.Reset();
        }

        public List<string> ValidateForm()
        {
            List<string> validationErrors = new List<string>();
            if (string.IsNullOrWhiteSpace(makeTextBox.Text) || makeTextBox.IsUnchanged())
            {
                validationErrors.Add("Make is empty or a placeholder");
            }
            if (string.IsNullOrWhiteSpace(modelTextBox.Text) || modelTextBox.IsUnchanged())
            {
                validationErrors.Add("Model is empty or a placeholder");
            }
            if (string.IsNullOrWhiteSpace(priceTextBox.Text) || priceTextBox.IsUnchanged())
            {
                validationErrors.Add("Price is empty or a placeholder");
            }
            double val;
            if (Double.TryParse(priceTextBox.Text, out val))
            {
                if (val < 0)
                    validationErrors.Add("Price is negative");
            }
            else
            {
                validationErrors.Add("Wrong format of price");
            }
            return validationErrors;
        }

        public bool ValidateAndCreateObject()
        {
            List<string> validationErrors = ValidateForm();
            if (validationErrors.Count == 0)
            {
                Car newCar = new Car(makeTextBox.Text, modelTextBox.Text, double.Parse(priceTextBox.Text));
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
                Car car = o as Car;
                car.Brand = makeTextBox.Text;
                car.Model = modelTextBox.Text;
                car.Price = Double.Parse(priceTextBox.Text);
                return true;
            }
            MessageBox.Show(string.Join(Environment.NewLine, validationErrors));
            return false;
        }
    }
}
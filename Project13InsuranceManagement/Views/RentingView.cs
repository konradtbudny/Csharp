using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Project13InsuranceManagement.DataLayer;

namespace Project13InsuranceManagement.Views
{
    public partial class RentingView : NavigableUserControl
    {
        private double ocPercentage = 0.1;
        private double acPercentage = 0.15;
        private double nnwPercentage = 0.12;

        public RentingView()
        {
            InitializeComponent();
            listOfClientsBox.DataSource = DataLayer.ObjectPlus.Objects[typeof(DataLayer.Client)];
            listOfAvailableCarsBox.DataSource = DataLayer.ObjectPlus.Objects[typeof(DataLayer.Car)];
            toDateTimePicker.Value = DateTime.Today.AddDays(1);
            fromDateTimePicker.Value = toDateTimePicker.Value.AddDays(-1);
            if (listOfAvailableCarsBox.SelectedIndex >= 0 && listOfClientsBox.SelectedIndex >= 0)
            {
                var car = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
                var client = (DataLayer.Client)listOfClientsBox.SelectedItem;
                int numOfDays = (int)(toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays;
                double totalPrice = numOfDays * car.Price * (1 - client.Discount / 100);
                priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
            }
        }

        private void listOfClientsBox_Format(object sender, ListControlConvertEventArgs e)
        {
            DataLayer.Client currentClient = (DataLayer.Client)e.Value;
            e.Value = currentClient.FirstName + " " + currentClient.LastName;
        }

        private void listOfAvailableCarsBox_Format(object sender, ListControlConvertEventArgs e)
        {
            DataLayer.Car currentCar = (DataLayer.Car)e.Value;
            e.Value = currentCar.Brand + " " + currentCar.Model;
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (fromDateTimePicker.Value > toDateTimePicker.Value)
            {
                MessageBox.Show("wrong date. too late");
            }
            else
            {
                var car = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
                if (car != null)
                {
                    var client = (DataLayer.Client)listOfClientsBox.SelectedItem;
                    int numOfDays = (int)((toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays);
                    double totalPrice = numOfDays * car.Price * (1 - client.Discount / 100);
                    priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
                }
            }
            UpdateAvailableCars();
        }

        public void UpdateAvailableCars()
        {
            listOfAvailableCarsBox.DataSource = Car.GetAvailableCars(fromDateTimePicker.Value, toDateTimePicker.Value);
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (toDateTimePicker.Value < fromDateTimePicker.Value)
            {
                MessageBox.Show("wrong date. too late");
            }
            else
            {
                var car = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
                if (car != null)
                {
                    var client = (DataLayer.Client)listOfClientsBox.SelectedItem;
                    int numOfDays = (int)(toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays;
                    double totalPrice = numOfDays * car.Price * (1 - client.Discount / 100);
                    priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
                }
            }
            UpdateAvailableCars();
        }

        private void listOfAvailableCarsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var car = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
            var client = (DataLayer.Client)listOfClientsBox.SelectedItem;
            int numOfDays = (int)(toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays;
            double totalPrice = numOfDays * car.Price * (1 - client.Discount / 100);
            priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            GeneratePDF(sender, e);
            var car = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
            var client = (DataLayer.Client)listOfClientsBox.SelectedItem;
            DataLayer.Rental rental = new DataLayer.Rental(client, car, fromDateTimePicker.Value, toDateTimePicker.Value);
        }

        protected void GeneratePDF(object sender, System.EventArgs e)
        {
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                Document document = new Document(PageSize.A4, 10, 10, 10, 10);
                PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
                document.Open();
                Paragraph titleParagraph = new Paragraph();
                titleParagraph.SpacingBefore = 10;
                titleParagraph.SpacingAfter = 10;
                titleParagraph.Alignment = Element.ALIGN_CENTER;
                titleParagraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.BLACK);
                titleParagraph.Add("Umowa wypożyczenia");
                document.Add(titleParagraph);
                var selectedUser = (DataLayer.Client)listOfClientsBox.SelectedItem;
                var selectedCar = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
                Paragraph textParagraph = new Paragraph();
                textParagraph.SpacingBefore = 10;
                textParagraph.SpacingAfter = 10;
                textParagraph.Alignment = Element.ALIGN_JUSTIFIED;
                textParagraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.BLACK);
                string agreementText = "Ja, " + selectedUser.FirstName + " " + selectedUser.LastName + ", pesel: " + selectedUser.Pesel + " wypozyczam " + selectedCar.Brand + " " + selectedCar.Model + " pomiedzy " + fromDateTimePicker.Value.Date.ToString() + " a " + toDateTimePicker.Value.ToString() + " z wybranymi opcjami: ";
                if (ocCheckBox.Checked == true)
                {
                    agreementText += "\n -OC: tak";
                }
                else { agreementText += "\n -OC: brak"; }
                if (acCheckBox.Checked == true)
                {
                    agreementText += "\n -AC: tak";
                }
                else
                {
                    agreementText += "\n -AC: brak";
                }
                if (nnwCheckBox.Checked == true)
                {
                    agreementText += "\n -NNW: tak";
                }
                else
                {
                    agreementText += "\n -NNW: brak";
                }
                agreementText += "\nPrzy tych warunkach cena wypozyczenia wynosi: " + priceLabel.Text;
                agreementText += "\n\n\n\nData, podpis";
                textParagraph.Add(agreementText);
                document.Add(textParagraph);
                document.Close();
                byte[] bytes = memoryStream.ToArray();
                string savePath = $"umowa{selectedUser.FirstName}{selectedUser.LastName} {DateTime.Now}.pdf".Replace(":", "-").Replace("/", "-");
                using (FileStream file = new FileStream(savePath, FileMode.Create, System.IO.FileAccess.Write))
                {
                    file.Write(bytes, 0, bytes.Length);
                }
                System.Diagnostics.Process.Start(savePath);
                memoryStream.Close();
            }
        }

        private void ocCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var car = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
            var client = (DataLayer.Client)listOfClientsBox.SelectedItem;
            int numOfDays = (int)(toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays;
            double totalPrice = numOfDays * car.Price * (1 - client.Discount / 100);
            if (ocCheckBox.Checked == true)
            {
                totalPrice += totalPrice * ocPercentage;
                if (acCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * acPercentage;
                }
                if (nnwCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * nnwPercentage;
                }
                priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
            }
            else
            {
                if (acCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * acPercentage;
                }
                if (nnwCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * nnwPercentage;
                }
                priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
            }
        }

        private void acCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var car = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
            var client = (DataLayer.Client)listOfClientsBox.SelectedItem;
            int numOfDays = (int)(toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays;
            double totalPrice = numOfDays * car.Price * (1 - client.Discount / 100);
            if (acCheckBox.Checked == true)
            {
                totalPrice += totalPrice * acPercentage;
                if (ocCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * ocPercentage;
                }
                if (nnwCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * nnwPercentage;
                }
                priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
            }
            else
            {
                if (ocCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * ocPercentage;
                }
                if (nnwCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * nnwPercentage;
                }
                priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
            }
        }

        private void nnwCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var car = (DataLayer.Car)listOfAvailableCarsBox.SelectedItem;
            var client = (DataLayer.Client)listOfClientsBox.SelectedItem;
            int numOfDays = (int)(toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays;
            double totalPrice = numOfDays * car.Price * (1 - client.Discount / 100);
            if (nnwCheckBox.Checked == true)
            {
                totalPrice += totalPrice * nnwPercentage;
                if (acCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * acPercentage;
                }
                if (ocCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * ocPercentage;
                }
                priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
            }
            else
            {
                if (acCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * acPercentage;
                }
                if (ocCheckBox.Checked == true)
                {
                    totalPrice += totalPrice * ocPercentage;
                }
                priceLabel.Text = "$ " + Math.Round((Decimal)totalPrice, 2).ToString();
            }
        }
    }
}
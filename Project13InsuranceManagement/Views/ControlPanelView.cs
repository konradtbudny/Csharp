using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Project13InsuranceManagement.DataLayer;

namespace Project13InsuranceManagement.Views
{
    public partial class ControlPanelView : NavigableUserControl
    {
        //wlasciwosc na ktorej zapamietujesz swoj iformularz np. currentForm
        public IForm Form { get; set; }
        public Type currentType { get; set; }

        public ControlPanelView()
        {
            InitializeComponent();
            objectTypeCombobox.DataSource = new List<Type>(ObjectPlus.Objects.Keys.Where(x => !x.Equals(typeof(Rental))));
            objectTypeCombobox.DisplayMember = "name";
            objectTypeCombobox.ValueMember = null;
        }

        private void objectTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (objectTypeCombobox.SelectedValue != null)
            {
                currentType = (Type)objectTypeCombobox.SelectedValue;
                if (currentType.Equals(typeof(Car)))
                {
                    Form = new CarView();
                }
                else if (currentType.Equals(typeof(IdentityManagement.User)))
                {
                    Form = new UserView();
                }
                else if (currentType.Equals(typeof(Client)))
                {
                    Form = new ClientView();
                }
                infoTablePanel.Controls.Clear();
                infoTablePanel.Controls.Add((UserControl)Form);
                objectListBox.DataSource = ObjectPlus.Objects[currentType];
            }
            //pobieramy wybrana wartosc z comboboxa to bedzie wartosc typu Type
            //dzieki tej wartosci z ObjectPlus.Objects[selectedType] mozemy pobrac wszystkie obiekty tego typu i wypelnic naszy listview(a jak nie zadziala to listbox)
        }

        private void ObjectListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Form?.Set(objectListBox.SelectedItem as ObjectPlus);
            objectListBox.Refresh();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            objectListBox.SelectedItem = null;
            Form.Reset();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            bool isSuccess;
            if (objectListBox.SelectedItem != null)
            {
                isSuccess = Form.ValidateAndUpdateObject(objectListBox.SelectedItem);
            }
            else
            {
                isSuccess = Form.ValidateAndCreateObject();
            }
            if (isSuccess)
            {
                objectListBox.DataSource = null;
                objectListBox.DataSource = objectListBox.DataSource = ObjectPlus.Objects[currentType];
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (objectListBox.SelectedItem != null)
            {
                Object selectedObject = objectListBox.SelectedItem;
                ObjectPlus.Objects[selectedObject.GetType()].Remove(selectedObject);
            }
        }
    }
}
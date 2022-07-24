using System;
using System.Windows.Forms;

namespace Project13InsuranceManagement
{
    public class PlaceHolderTextBox : TextBox
    {
        public string PlaceHolderText { get; set; }

        public PlaceHolderTextBox()
        {
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (Text.Equals(PlaceHolderText))
            {
                Text = String.Empty;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (String.IsNullOrWhiteSpace(Text) || this.Text.Equals(""))
            {
                this.Text = PlaceHolderText;
            }
        }
        public bool IsUnchanged() => Text == PlaceHolderText;
        public void Reset() => Text = PlaceHolderText;
    }
}
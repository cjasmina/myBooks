using System.Windows.Forms;
using System.ComponentModel;

namespace myBooks.Desktop.Helpers
{
    public static class Validacija
    {

        public static void ValidirajPictureBox(CancelEventArgs e, ErrorProvider errorProvider, PictureBox pictureBox, string message)
        {
            if (pictureBox.Image == null)
            {
                e.Cancel = true;
                pictureBox.Focus();
                errorProvider.SetError(pictureBox, message);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(pictureBox, null);
            }
        }

        public static void ValidirajTextBox(CancelEventArgs e, ErrorProvider errorProvider, TextBox textBox, string message)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider.SetError(textBox, message);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        public static void ValidirajCheckedListBox(CancelEventArgs e, ErrorProvider errorProvider, CheckedListBox checkedListBox, string message)
        {
            if (checkedListBox.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                checkedListBox.Focus();
                errorProvider.SetError(checkedListBox, message);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(checkedListBox, null);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManage
{
    internal class NumberOnlyTextBox
    {

        public void acceptOnlyNumbers(KeyPressEventArgs e)
        {
            char pressed_character = e.KeyChar;
            //KeyChar property stores the character pressed from the keyboard
            if (char.IsNumber(pressed_character))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        public void functionBackspace(KeyEventArgs e, TextBox txtbx)
        {

            if (e.KeyCode == Keys.Back && txtbx.Text.Length > 0)
            {
                if (txtbx.SelectionLength == 0) // check if no text is selected
                {
                    int cursorPosition = txtbx.SelectionStart; // get the current cursor position
                    string IDText = txtbx.Text;
                    txtbx.Text = IDText.Substring(0, cursorPosition - 1) + IDText.Substring(cursorPosition);
                    txtbx.SelectionStart = cursorPosition - 1; // set the cursor position after removing the character
                    txtbx.SelectionLength = 0;

                }
                else // if text is selected, remove the selected text
                {
                    int selectionStart = txtbx.SelectionStart;
                    int selectionLength = txtbx.SelectionLength;
                    string IDText = txtbx.Text;
                    txtbx.Text = IDText.Substring(0, selectionStart) + IDText.Substring(selectionStart + selectionLength);
                    txtbx.SelectionStart = selectionStart;
                    txtbx.SelectionLength = 0;
                }
            }
        }


    }
}

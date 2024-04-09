using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class MatKhauTextBox : TextBox
    {
        private ErrorProvider errorProvider;

        public MatKhauTextBox()
        {
            errorProvider = new ErrorProvider();
            this.Validating += PassTextBox_Validating;
        }

        private void PassTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string input = this.Text;

            // Kiểm tra chỉ chứa số và có ít nhất 3 số
            if (!input.All(char.IsDigit) || input.Count(char.IsDigit) < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(this, "Mật khẩu chỉ chứa số và tối thiểu có 3 số.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(this, ""); // Xóa thông báo lỗi
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class TaiKhoanTextBox : TextBox
    {
        private ErrorProvider errorProvider;

        public TaiKhoanTextBox()
        {
            errorProvider = new ErrorProvider();
            this.Validating += UserTextBox_Validating;
        }

        private void UserTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string input = this.Text;

            // Kiểm tra nếu có ký tự đặc biệt
            if (input.Any(c => !char.IsLetterOrDigit(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(this, "Không được chứa ký tự đặc biệt.");
            }
            else
            {
                e.Cancel = false; // Cho phép thoát khỏi control
                errorProvider.SetError(this, ""); // Xóa thông báo lỗi
            }
        }
    }
}

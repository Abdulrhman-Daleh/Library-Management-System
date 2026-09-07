using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Font = new Font("Microsoft Tai Le", 22, FontStyle.Regular, GraphicsUnit.Pixel);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BazaDanychPojazdow
{
    public static class TextBoxExtensions
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetPlaceholder(this TextBox textBox, string placeholderText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, placeholderText);
        }
    }
}

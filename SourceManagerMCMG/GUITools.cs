using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SourceManagerMCMG
{
    public static class GUITools
    {

        public static string ShrinkToDotDotDot(TextBox tb, string s)
        {
            string result = "";

            int charSize = PtToPx(tb.Font.Size);
            int tbWidth = tb.Size.Width;

            result = s.Substring(0, (tbWidth / charSize) - 5) + "...";



            return result;
        }

        public static int PtToPx(float pt)
        {
            return (int)(0.727272727f * (float)pt) - 1;
        }

    }
}

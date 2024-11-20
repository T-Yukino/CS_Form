using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace CS_Form
{
    internal class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x, int y, int width, int height)
        {
            //ラベル内に文字を表示
            Text = str.ToString();

            //ラベルの位置
            Location = new Point(x, y);

            //ラベルのサイズ
            Size = new Size(width, height);          
            

        }

        public string TextReplacement(string str)
        {
            string temp = Text;

            Text = str;

            return temp;
        }

        /// <summary>
        /// ラベルの文字更新関数
        /// </summary>
        /// <param name="str"></param>
 
    }

}

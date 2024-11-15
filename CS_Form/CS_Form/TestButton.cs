using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_Form
{
    class TestButton : Button
    {
        Form1 _form1;

        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>
        public TestButton(Form1 form1,int id,int x, int y, int width, int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録
            Click += onclick;

            //ボタン内に文字を表示
            Text =id.ToString();
            if (id == 1)
            {
                Text = "あ";
            }
            if (id == 2)
            {
                Text = "い";
            }
            if (id == 3)
            {
                Text = "う";
            }
            if (id == 4)
            {
                Text = "え";
            }
            if (id == 5)
            {
                Text = "お";
            }
            if (id == 6)
            {
                Text = "か";
            }
            if (id == 7)
            {
                Text = "き";
            }
            if (id == 8)
            {
                Text = "く";
            }
            if (id == 9)
            {
                Text = "け";
            }
            if (id == 0)
            {
                Text = "こ";
            }

            //ボタンの位置
            Location = new Point(x,y);

            //ボタンのサイズ
            Size = new Size(width,height);

        }

        public void onclick(object sender,EventArgs s)
        {
            _form1.LabelTextUpdate(Text);
        }

    }
}

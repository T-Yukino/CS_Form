using System;
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
        private ColorDialog colorDialog1;

        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>
        public TestButton(int x, int y)
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録
            Click += onclick;

            //ボタン内に文字を表示
            Text = "ボタン";

            Location = new Point(x,y);

        }

        public void onclick(object sender,EventArgs s)
        {
            MessageBox.Show("( *´艸｀)");
        }

    }
}

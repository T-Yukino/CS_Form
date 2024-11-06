﻿using System;
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

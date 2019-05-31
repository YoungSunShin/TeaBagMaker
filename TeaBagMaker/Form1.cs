using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        // 초기 콤보박스 데이터 설정
        string[] SList = new string[]{"홍차", "녹차", };
        string orgStr = ""; // 선택 결과 저장

        public Form1()
        {
            InitializeComponent();
        }
    }
}

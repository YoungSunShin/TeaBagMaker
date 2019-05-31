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
        string[] teaList = new string[]{"홍차", "녹차", "루이보이스차", "국화차"};
        string orgStr = ""; // 선택 결과 저장

        int CountOrgNum = 120;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < teaList.Length; i++)
            {
                this.teaComboBox.Items.Add(teaList[i]);
            }

            if (teaComboBox.Items.Count > 0)
            {
                this.teaComboBox.SelectedIndex = 1;
            }

        }

        private void TeaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.teaComboBox.Text != "")
            {
                this.orgStr = selectTea.Text;
                this.selectTea.Text = orgStr + this.teaComboBox.Text;
            }

        }

        private void Soaking_Click(object sender, EventArgs e)
        {
            if (orgStr == "홍차") { CountOrgNum = 120; }
            else if (orgStr == "녹차") { CountOrgNum = 180; }
            else if (orgStr == "루이보이스차") { CountOrgNum = 300; }
            else if (orgStr == "국화차") { CountOrgNum = 120; }
            this.timer1.Enabled = true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {


            if (CountOrgNum < 1)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("티백을 건지세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.teaComboBox.Focus();
            }
            else
            {
                this.CountOrgNum--;
                this.countTime.Text = Convert.ToString(this.CountOrgNum);
            }

        }
    }
}

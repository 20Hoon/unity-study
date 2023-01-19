using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            int number2 = 2;
            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString(); //문자열에 인트를 직접적으로 넣을 수 없으므로 .Tostring() 사용
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Sum1.Text);// Convert.Toint32 == int형으로 바꿈
            int number2 = Convert.ToInt32(Sum2.Text);
            int sum = number1 + number2;
            SumResult.Text = Convert.ToString(sum); // SumResult.Text = sum.ToString;
        }
    }
}

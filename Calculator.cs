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

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;

            if (String.IsNullOrWhiteSpace(Sum1.Text)) // 입력값이 없거나 공백 문자이면 true
            {
                MessageBox.Show("숫자를 입력해주세요");
                Sum1.Focus();// 입력된 문자를 선택처리 해줌
                return;
            }

            if(int.TryParse(Sum1.Text, out number1) == false) //Sum1.Text를 숫자로 변경해서 성공하면 number1에 저장하게 되는데 숫자로 변경이 안되면 false == false 이므로 if문 실행
            {
                MessageBox.Show("숫자만 입력해주세요");
                Sum1.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("숫자를 입력해주세요");
                Sum2.Focus();
                return;
            }

            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("숫자만 입력해주세요");
                Sum2.Focus();
                return;
            }

            int sum = Add(number1, number2);
            SumResult.Text = sum.ToString(); // SumResult.Text = Convert.ToString(sum)
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }
        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
        
    }
}

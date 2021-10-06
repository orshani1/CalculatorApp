using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
        class CalcMath
        {
            public static double result = 0;
            public static string operat = string.Empty;
            public static bool isTurnOn { get; set; } = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            this.oneBtn.BackColor = System.Drawing.Color.FromArgb(250,250,250);
            firstDisplayTxtBox.Text += oneBtn.Text;


        }
        #region MouseEnterMouseLeaveEvents

        private void oneBtn_MouseEnter(object sender, EventArgs e)
        {
            this.oneBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void oneBtn_MouseLeave(object sender, EventArgs e)
        {
            this.oneBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void twoBtn_MouseEnter(object sender, EventArgs e)
        {
            this.twoBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void twoBtn_MouseLeave(object sender, EventArgs e)
        {
            this.twoBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void threeBtn_MouseEnter(object sender, EventArgs e)
        {
            this.threeBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void threeBtn_MouseLeave(object sender, EventArgs e)
        {
            this.threeBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void fourBtn_MouseEnter(object sender, EventArgs e)
        {
            this.fourBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void fourBtn_MouseLeave(object sender, EventArgs e)
        {
            this.fourBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void fiveBtn_MouseEnter(object sender, EventArgs e)
        {
            this.fiveBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void fiveBtn_MouseLeave(object sender, EventArgs e)
        {
            this.fiveBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void sixBtn_MouseEnter(object sender, EventArgs e)
        {
            this.sixBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void sixBtn_MouseLeave(object sender, EventArgs e)
        {
            this.sixBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }


        private void sevenBtn_MouseEnter(object sender, EventArgs e)
        {
            this.sevenBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void sevenBtn_MouseLeave(object sender, EventArgs e)
        {
            this.sevenBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void eightBtn_MouseEnter(object sender, EventArgs e)
        {
            this.eightBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void eightBtn_MouseLeave(object sender, EventArgs e)
        {
            this.eightBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void nineBtn_MouseEnter(object sender, EventArgs e)
        {
            this.nineBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void nineBtn_MouseLeave(object sender, EventArgs e)
        {
            this.nineBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void minusBtn_MouseEnter(object sender, EventArgs e)
        {
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void minusBtn_MouseLeave(object sender, EventArgs e)
        {
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void divBtn_MouseEnter(object sender, EventArgs e)
        {
            this.divBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void divBtn_MouseLeave(object sender, EventArgs e)
        {
            this.divBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void plusButton_MouseEnter(object sender, EventArgs e)
        {
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void plusButton_MouseLeave(object sender, EventArgs e)
        {
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        private void kefelBtn_MouseEnter(object sender, EventArgs e)
        {
            this.kefelBtn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void kefelBtn_MouseLeave(object sender, EventArgs e)
        {
            this.kefelBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

    

        private void deleteBtn_MouseEnter(object sender, EventArgs e)
        {
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(180, 0, 30);
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(202, 0, 42);
        }

        private void equalBtn_MouseEnter(object sender, EventArgs e)
        {
            this.equalBtn.BackColor = System.Drawing.Color.FromArgb(138, 200, 250);
        }

        private void equalBtn_MouseLeave(object sender, EventArgs e)
        {
            this.equalBtn.BackColor = System.Drawing.Color.FromArgb(138, 186, 224);
        }
        #endregion

        private void plusButton_Click(object sender, EventArgs e)
        {
            plusButton.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            CalcMath.result += Convert.ToInt32(firstDisplayTxtBox.Text);
            this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + plusButton.Text;
            CalcMath.operat = "+";
            this.firstDisplayTxtBox.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void Form1_Activated(object sender, EventArgs e)
        {




        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            this.equalBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            switch (CalcMath.operat)
            {
                case "+":
                    
                    CalcMath.result += Convert.ToDouble(firstDisplayTxtBox.Text);
                    this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + equalBtn.Text;
                    this.firstDisplayTxtBox.Clear();
                    this.firstDisplayTxtBox.Text = CalcMath.result.ToString();
                    break;
                case "-":
                    CalcMath.result -= Convert.ToDouble(firstDisplayTxtBox.Text);
                    this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + equalBtn.Text;
                    this.firstDisplayTxtBox.Clear();
                    this.firstDisplayTxtBox.Text = CalcMath.result.ToString();
                    break;
                case "*":
                    CalcMath.result *= Convert.ToDouble(firstDisplayTxtBox.Text);
                    this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + equalBtn.Text;
                    this.firstDisplayTxtBox.Clear();
                    this.firstDisplayTxtBox.Text = CalcMath.result.ToString();
                    break;
                case "/":
                    CalcMath.result /= Convert.ToDouble(firstDisplayTxtBox.Text);
                    this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + equalBtn.Text;
                    this.firstDisplayTxtBox.Clear();
                    this.firstDisplayTxtBox.Text = CalcMath.result.ToString();
                    break;

            }



        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            this.twoBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += twoBtn.Text;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            this.threeBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += threeBtn.Text;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            this.fourBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += fourBtn.Text;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            this.fiveBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += fiveBtn.Text;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            this.sixBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += sixBtn.Text;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            this.sevenBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += sevenBtn.Text;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            this.eightBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += eightBtn.Text;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            this.nineBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += nineBtn.Text;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Clear();
            secondDisplayRichTextbox.Clear();
            CalcMath.result = 0;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

        }

        private void kefelBtn_Click(object sender, EventArgs e)
        {
            
            if (CalcMath.result == 0)
            {
                this.kefelBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
                CalcMath.result = Convert.ToDouble(firstDisplayTxtBox.Text);
                this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + kefelBtn.Text;
                CalcMath.operat = "*";

                this.firstDisplayTxtBox.Clear();
            }
            else
            {
                this.kefelBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
                CalcMath.operat = "*";
                CalcMath.result = Convert.ToDouble(firstDisplayTxtBox.Text);
                this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + kefelBtn.Text;
                this.firstDisplayTxtBox.Clear();
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            CalcMath.result = Convert.ToDouble(firstDisplayTxtBox.Text);
            this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + minusBtn.Text;
            CalcMath.operat = "-";
            this.firstDisplayTxtBox.Clear();
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            this.divBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            CalcMath.result = Convert.ToDouble(firstDisplayTxtBox.Text);
            this.secondDisplayRichTextbox.Text += firstDisplayTxtBox.Text + divBtn.Text;
            CalcMath.operat = "/";
            this.firstDisplayTxtBox.Clear();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            this.zeroBtn.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            firstDisplayTxtBox.Text += zeroBtn.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.BackColor = System.Drawing.Color.FromArgb(120,0,0);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.BackColor = System.Drawing.Color.FromArgb(30,30,30);
        }

        private void firstDisplayTxtBox_TextChanged(object sender, EventArgs e)
        {
            plusButton.Enabled = firstDisplayTxtBox.Text.Length > 0;
            minusBtn.Enabled = firstDisplayTxtBox.Text.Length > 0;
            divBtn.Enabled = firstDisplayTxtBox.Text.Length > 0;
            kefelBtn.Enabled = firstDisplayTxtBox.Text.Length > 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string caption = "Exit Menu";
            string text = "Are you sure you want to Exit ?";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icn = MessageBoxIcon.Warning;


            if (MessageBox.Show(text, caption, btn, icn) == DialogResult.Yes)
                Application.Exit();
            

           
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
  public partial class Form1 : Form
  {

    Double resultValue = 0;
    string operationPerformed = "";

    public Form1()
    {
      InitializeComponent();
    }

    private void btn_One_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Zero_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Two_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Three_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Four_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Five_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Six_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Seven_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Eight_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Nine_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void btn_Decimal_Click(object sender, EventArgs e)
    {
      if (rtb_Result.Text == "0")
      {
        rtb_Result.Clear();
      }
      Button button = (Button)sender;
      rtb_Result.Text = rtb_Result.Text + button.Text;
    }

    private void operator_Click(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      operationPerformed = button.Text;
      resultValue = Double.Parse(rtb_Result.Text);
    }

    private void btn_ClearAll_Click(object sender, EventArgs e)
    {
      rtb_Result.Text = "0";
    }

    private void btn_Clear_Click(object sender, EventArgs e)
    {
      rtb_Result.Text = "0";
      resultValue = 0;
    }

    private void btn_Equals_Click(object sender, EventArgs e)
    {
      switch (operationPerformed)
      {
        case "+":
          rtb_Result.Text = 
      }
    }
  }
}

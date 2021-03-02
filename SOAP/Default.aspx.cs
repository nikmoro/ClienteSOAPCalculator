using System;

namespace SOAP
{
    public partial class Default : System.Web.UI.Page
    {
        // Objeto que hace uso del Web service
        CalculatorWebService.CalculatorSoapClient oCalculator = new CalculatorWebService.CalculatorSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = oCalculator.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = oCalculator.Subtract(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = oCalculator.Multiply(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = oCalculator.Divide(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
    }
}
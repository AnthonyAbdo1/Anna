using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anna
{

    public partial class TempConverter : Form
    {
        public TempConverter()
        {
            InitializeComponent();
        }

        private void FahrenheitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CelsiusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FtoCbtn_Click(object sender, EventArgs e)
        {
            var convert = new FtoC_Converter();
            CelsiusBox.Text = convert.FtoC_Con(FahrenheitBox.Text);

        }
    }


    public class FtoC_Converter
    {
        public string FtoC_Con(string temp)
        {
            double celsius;
            double temperature = Convert.ToDouble(temp);
            celsius = (temperature - 32) * 5 / 9;
            return (celsius).ToString();
        }
    }



}

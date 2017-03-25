using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Result : Form
    {
        int totalErrors;
        int total;
        public Result(int totalErrors, int total)
        {
            InitializeComponent();
            this.totalErrors = totalErrors;
            this.total = total;
            errorsLabel.Text += totalErrors.ToString() + " из " + total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();

        }
    }
}

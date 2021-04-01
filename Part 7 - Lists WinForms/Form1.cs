using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7___Lists_WinForms
{
    public partial class frmThing : Form
    {
        public frmThing()
        {
            InitializeComponent();
        }


        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();

        Random generator = new Random();

        private void frmThing_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;

            heroes.Add("BATMAN");
            heroes.Add("SUPERMAN");
            lstNumbers.DataSource = numbers;
            lstHeroes.DataSource = heroes;

        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: Numbers Sorted";
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: Heroes Sorted";
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = $"Status: New Numbers List";

        }

        private void btnNewHeros_Click(object sender, EventArgs e)
        {
            heroes.Clear();

            heroes.Add("SUPERMAN");
            heroes.Add("BATMAN");
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = $"Status: New Heroes List";

        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedIndex > -1)
            {
                numbers.RemoveAt(lstNumbers.SelectedIndex);
            }
            
        
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = $"Status: Selected Number Removed";

        }

        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
            while (numbers.Remove((int)lstNumbers.SelectedItem)) ;
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = $"Status: All Numbers Removed";
        }
    }
}

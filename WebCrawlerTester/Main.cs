using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScraperClient;

namespace WebCrawlerTester
{
    public partial class Main : Form
    {

        public List<Item> oItems;

        public Main()
        {
            InitializeComponent();
        }

        private void cmdGet_Click(object sender, EventArgs e)
        {
            oItems = PageScraper.GetItems();
            if (oItems != null && oItems.Count > 0)
                dgvResults.DataSource = oItems;
            else
                MessageBox.Show("No data to display");
        }

        private void gmdGetMore_Click(object sender, EventArgs e)
        {
            if (oItems != null && oItems.Count > 0)
            {
                var xItems = from x in oItems
                             where x.Words > 5
                             orderby x.Comments ascending
                             select x;
                dgvResults.DataSource = xItems.ToList();
            }
            else
                MessageBox.Show("No data to display");
        }

        private void cmdGetLess_Click(object sender, EventArgs e)
        {
            if (oItems != null && oItems.Count > 0)
            {
                var xItems = from x in oItems
                             where x.Words <= 5
                             orderby x.Points ascending
                             select x;
                dgvResults.DataSource = xItems.ToList();
            }
            else
                MessageBox.Show("No data to display");
        }

        private void cmdGetAll_Click(object sender, EventArgs e)
        {
            if (oItems != null && oItems.Count > 0)
                dgvResults.DataSource = oItems;
            else
                MessageBox.Show("No data to display");
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (oItems != null && oItems.Count > 0)
            {
                var xItems = from x in oItems
                             where x.Title.ToLower().Contains(txtSearch.Text.ToLower())
                             orderby x.Id ascending
                             select x;
                dgvResults.DataSource = xItems.ToList();
            }
            else
                MessageBox.Show("No data to display");
        }
    }
}

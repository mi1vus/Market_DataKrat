using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketView
{
    public partial class MarketMainForm : Form
    {
        public MarketMainForm()
        {
            InitializeComponent();
        }

        public void UpdateFormseVisibility() {
            if (CheckBS.DataSource == null)
            {
                CancelCheck.Enabled = false;
                SaveCheck.Enabled = false;
                CreateBuyCheck.Enabled = true;
                CreateReturnCheck.Enabled = true;
            }
            else {
                CancelCheck.Enabled = true;
                SaveCheck.Enabled = true;
                CreateBuyCheck.Enabled = false;
                CreateReturnCheck.Enabled = false;
            }
        }

        private void MarketMainForm_Load(object sender, EventArgs e)
        {
            UpdateFormseVisibility();
        }

    }
}

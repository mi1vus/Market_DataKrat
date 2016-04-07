using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarketView
{
    /// <summary>
    /// Форма для поиска товаров по их штрих кодам
    /// </summary>
    public partial class AddCheckItem : Form
    {
        public MarketModels.Good Good { get; set; }

        public AddCheckItem()
        {
            InitializeComponent();
        }

        private void Init()
        {
            GoodNameValueLbl.Text = "нет";
            GoodPriceValueLbl.Text = "нет";
            AddBtn.Enabled = (Good != null);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Good = null;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void BarCodeTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (string.IsNullOrWhiteSpace(BarCodeTB.Text.Trim())) {
                    GoodBS.DataSource = null;
                    Init();
                    return;
                }

                Good = MarketController.MarketController.GetGod(BarCodeTB.Text.Trim());
                if (Good == null)
                {
                    Init();
                    return;
                }
                GoodNameValueLbl.Text = Good.Name;
                GoodPriceValueLbl.Text = Good.PriceText;
                AddBtn.Enabled = (Good != null);
            }
        }
    }
}

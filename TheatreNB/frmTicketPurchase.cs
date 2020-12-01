using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreNB
{
    public partial class frmTicketPurchase : Form
    {
        public frmTicketPurchase()
        {
            InitializeComponent();
        }

        #region Methods
        void Setup()
        {
            rdoBalcony.Checked = true;
            foreach (CheckBox c in grpPlays.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }

            txtCreditCard.Text = string.Empty;
            lblDisplay.Text = String.Empty;
        }

        private bool IsValidCreditCard(string card)
        {
            if (!long.TryParse(card, out long result))
            {
                return false;

            }
            if (card.Length != 16)
            {
                return false;
            }
            if (card[0] != char.Parse("4") && card[1] != char.Parse("5"))
            {
                return false;
            }
            return true;
        }

        void Calculate()
        {
            double cost = 0;
            int countChecked = grpPlays.Controls.OfType<CheckBox>().Count(d => d.Checked);

            if (rdoBalcony.Checked)
            {
                cost = 50;
            }
            else if(rdoOrchestra.Checked)
            {
                cost = 85;
            }
            else if(rdoBox.Checked)
            {
                cost = 110;
                if (countChecked >= 2)
                {
                    cost = cost * 0.85;
                }
            }

            if (cost > 0 )
            {
                lblDisplay.Text = $"{cost} has been charged to your credit card ending in {txtCreditCard.Text.Substring(txtCreditCard.Text.Length-4)}";
            }
        }

        #endregion

        bool IsChoosedPlay()
        {
           return grpPlays.Controls.OfType<CheckBox>().Any(d => d.Checked);
        }

        private void Changed_conditionClick(object sender, EventArgs e)
        {
            btnPlaceOrder_Click(sender, e);
        }



        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!IsChoosedPlay())//1
            {
                MessageBox.Show("Choose play!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidCreditCard(txtCreditCard.Text.Trim()))//2
            {
                MessageBox.Show("Entered credit card is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCreditCard.Focus();
                txtCreditCard.SelectAll();
                return;
            }
           
            Calculate();
        }

       
        private void frmTicketPurchase_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Setup();
        }
    }
}

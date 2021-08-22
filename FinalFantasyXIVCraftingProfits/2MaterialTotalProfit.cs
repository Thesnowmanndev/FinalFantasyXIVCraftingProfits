using System;
using System.Windows.Forms;

namespace FinalFantasyXIVCraftingProfits
{
    public partial class FrmTwoMaterialCost : Form
    {
        private int _materialOneCost;
        private int _materialOneAmountNeeded;
        private int _materialTwoCost;
        private int _materialTwoAmountNeeded;
        private int _shardOneCost;
        private int _shardOneAmountNeeded;
        private int _shardTwoCost;
        private int _shardTwoAmountNeeded;
        private int _materialTotalCost;
        private int _itemSellsFor;
        private int _totalProfit;

        private string _matTotalCostFormatted;
        private string _totalProfitFormatted;

        public FrmTwoMaterialCost()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _materialOneCost = Convert.ToInt32(txtMat1Cost.Text);
            _materialOneAmountNeeded = Convert.ToInt32(txtMat1Amount.Text);
            _materialTwoCost = Convert.ToInt32(txtMat2Cost.Text);
            _materialTwoAmountNeeded = Convert.ToInt32(txtMat2Amount.Text);

            _shardOneCost = Convert.ToInt32(txtShard1Cost.Text);
            _shardOneAmountNeeded = Convert.ToInt32(txtShard1Amount.Text);
            _shardTwoCost = Convert.ToInt32(txtShard2Cost.Text);
            _shardTwoAmountNeeded = Convert.ToInt32(txtShard2Amount.Text);

            _materialTotalCost = (_materialOneCost * _materialOneAmountNeeded) +
                                (_materialTwoCost * _materialTwoAmountNeeded) +
                                (_shardOneCost * _shardOneAmountNeeded) +
                                (_shardTwoCost * _shardTwoAmountNeeded);

            _itemSellsFor = Convert.ToInt32(txtISellsFor.Text);

            _matTotalCostFormatted = string.Format("{0:#,0}", _materialTotalCost);
            txtMaterialCost.Text = _matTotalCostFormatted;

            _totalProfit = _itemSellsFor - _materialTotalCost;

            _totalProfitFormatted = string.Format("{0:#,0}", _totalProfit);
            txtTotalProfit.Text = _totalProfitFormatted;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMat1Cost.Text = string.Empty;
            txtMat1Amount.Text = string.Empty;
            txtMat2Cost.Text = string.Empty;
            txtMat2Amount.Text = string.Empty;
            txtShard1Cost.Text = string.Empty;
            txtShard1Amount.Text = string.Empty;
            txtShard2Cost.Text = string.Empty;
            txtShard2Amount.Text = string.Empty;
            txtISellsFor.Text = string.Empty;
            txtMaterialCost.Text = string.Empty;
            txtTotalProfit.Text = string.Empty;
        }

        private void lblCreditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Thesnowmanndev/FinalFantasyXIVCraftingProfits");
        }
    }
}

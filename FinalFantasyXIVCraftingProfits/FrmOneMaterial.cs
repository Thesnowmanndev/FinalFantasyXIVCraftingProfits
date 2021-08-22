using System;
using System.Linq;
using System.Windows.Forms;

namespace FinalFantasyXIVCraftingProfits
{
    public partial class FrmOneMaterial : Form
    {
        private int _materialOneCost;
        private int _materialOneAmountNeeded;
        private int _shardOneCost;
        private int _shardOneAmountNeeded;
        private int _shardTwoCost;
        private int _shardTwoAmountNeeded;
        private int _materialTotalCost;
        private int _itemSellsFor;
        private int _totalProfit;

        private string _matTotalCostFormatted;
        private string _totalProfitFormatted;

        public FrmOneMaterial()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMat1Cost.Text = string.Empty;
            txtMat1Amount.Text = string.Empty;
            txtShard1Cost.Text = string.Empty;
            txtShard1Amount.Text = string.Empty;
            txtShard2Cost.Text = string.Empty;
            txtShard2Amount.Text = string.Empty;
            txtISellsFor.Text = string.Empty;
            txtMaterialCost.Text = string.Empty;
            txtTotalProfit.Text = string.Empty;
        }

        private void CatchFormErrors()
        {
            const string zero = "0";
            var matOneCostDigitsOnly = txtMat1Cost.Text.All(char.IsDigit);
            var matOneAmountDigitsOnly = txtMat1Amount.Text.All(char.IsDigit);
            var shardOneCostDigitsOnly = txtShard1Cost.Text.All(char.IsDigit);
            var shardOneAmountDigitsOnly = txtShard1Amount.Text.All(char.IsDigit);
            var shardTwoCostDigitsOnly = txtShard2Cost.Text.All(char.IsDigit);
            var shardTwoAmountDigitsOnly = txtShard2Amount.Text.All(char.IsDigit);
            var iSellsForDigitsOnly = txtISellsFor.Text.All(char.IsDigit);

            if (!matOneCostDigitsOnly)
            {
                txtMat1Cost.Text = zero;
            }

            if (!matOneAmountDigitsOnly)
            {
                txtMat1Amount.Text = zero;
            }

            if (!shardOneCostDigitsOnly)
            {
                txtShard1Cost.Text = zero;
            }

            if (!shardOneAmountDigitsOnly)
            {
                txtShard1Amount.Text = zero;
            }

            if (!shardTwoCostDigitsOnly)
            {
                txtShard2Cost.Text = zero;
            }

            if (!shardTwoAmountDigitsOnly)
            {
                txtShard2Amount.Text = zero;
            }

            if (!iSellsForDigitsOnly)
            {
                txtISellsFor.Text = zero;
            }

            if (txtMat1Cost.Text != null && txtMat1Cost.Text == "")
            {
                txtMat1Cost.Text = zero;
            }

            if (txtMat1Amount.Text != null && txtMat1Amount.Text == "")
            {
                txtMat1Amount.Text = zero;
            }

            if (txtShard1Cost.Text != null && txtShard1Cost.Text == "")
            {
                txtShard1Cost.Text = zero;
            }

            if (txtShard1Amount.Text != null && txtShard1Amount.Text == "")
            {
                txtShard1Amount.Text = zero;
            }

            if (txtShard2Cost.Text != null && txtShard2Cost.Text == "")
            {
                txtShard2Cost.Text = zero;
            }

            if (txtShard2Amount.Text != null && txtShard2Amount.Text == "")
            {
                txtShard2Amount.Text = zero;
            }

            if (txtISellsFor.Text != null && txtISellsFor.Text == "")
            {
                txtISellsFor.Text = zero;
            }

            if (txtMat1Cost.Text == null)
            {
                txtMat1Cost.Text = zero;
            }

            if (txtMat1Amount.Text == null)
            {
                txtMat1Amount.Text = zero;
            }

            if (txtShard1Cost.Text == null)
            {
                txtShard1Cost.Text = zero;
            }

            if (txtShard1Amount.Text == null)
            {
                txtShard1Amount.Text = zero;
            }

            if (txtShard2Cost.Text == null)
            {
                txtShard2Cost.Text = zero;
            }

            if (txtShard2Amount.Text == null)
            {
                txtShard2Amount.Text = zero;
            }

            if (txtISellsFor.Text == null)
            {
                txtISellsFor.Text = zero;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CatchFormErrors();

            _materialOneCost = Convert.ToInt32(txtMat1Cost.Text);
            _materialOneAmountNeeded = Convert.ToInt32(txtMat1Amount.Text);

            _shardOneCost = Convert.ToInt32(txtShard1Cost.Text);
            _shardOneAmountNeeded = Convert.ToInt32(txtShard1Amount.Text);
            _shardTwoCost = Convert.ToInt32(txtShard2Cost.Text);
            _shardTwoAmountNeeded = Convert.ToInt32(txtShard2Amount.Text);

            _materialTotalCost = (_materialOneCost * _materialOneAmountNeeded) + 
                                  (_shardOneCost * _shardOneAmountNeeded) +
                                  (_shardTwoCost * _shardTwoAmountNeeded);


            _matTotalCostFormatted = $"{_materialTotalCost:#,0}";
            txtMaterialCost.Text = _matTotalCostFormatted;

            _itemSellsFor = Convert.ToInt32(txtISellsFor.Text);
            _totalProfit = _itemSellsFor - _materialTotalCost;

            _totalProfitFormatted = $"{_totalProfit:#,0}";
            txtTotalProfit.Text = _totalProfitFormatted;
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

namespace FinalFantasyXIVCraftingProfits
{
    public partial class FrmFiveMaterial : Form
    {
        private int _materialOneCost;
        private int _materialOneAmount;
        private int _materialTwoCost;
        private int _materialTwoAmount;
        private int _materialThreeCost;
        private int _materialThreeAmount;
        private int _materialFourCost;
        private int _materialFourAmount;
        private int _materialFiveCost;
        private int _materialFiveAmount;
        private int _shardOneCost;
        private int _shardOneAmount;
        private int _shardTwoCost;
        private int _shardTwoAmount;
        private int _materialTotalCost;
        private int _itemSellsFor;
        private int _totalProfit;

        private string _matTotalCostFormatted;
        private string _totalProfitFormatted;

        public FrmFiveMaterial()
        {
            InitializeComponent();
        }

        private void CatchFormErrors()
        {
            const string zero = "0";

            var matOneCostDigitsOnly = TxtMat1Cost.Text.All(char.IsDigit);
            var matOneAmountDigitsOnly = TxtMat1Amount.Text.All(char.IsDigit);
            var matTwoCostDigitsOnly = TxtMat2Cost.Text.All(char.IsDigit);
            var matTwoAmountDigitsOnly = TxtMat2Amount.Text.All(char.IsDigit);
            var matThreeCostDigitsOnly = TxtMat3Cost.Text.All(char.IsDigit);
            var matThreeAmountDigitsOnly = TxtMat3Amount.Text.All(char.IsDigit);
            var matFourCostDigitsOnly = TxtMat4Cost.Text.All(char.IsDigit);
            var matFourAmountDigitsOnly = TxtMat4Amount.Text.All(char.IsDigit);
            var matFiveCostDigitsOnly = TxtMat5Cost.Text.All(char.IsDigit);
            var matFiveAmountDigitsOnly = TxtMat5Amount.Text.All(char.IsDigit);

            var shardOneCostDigitsOnly = TxtShard1Cost.Text.All(char.IsDigit);
            var shardOneAmountDigitsOnly = TxtShard1Amount.Text.All(char.IsDigit);
            var shardTwoCostDigitsOnly = TxtShard2Cost.Text.All(char.IsDigit);
            var shardTwoAmountDigitsOnly = TxtShard2Amount.Text.All(char.IsDigit);

            var itemSellsForDigitsOnly = TxtItemSellsFor.Text.All(char.IsDigit);

            if (!matOneCostDigitsOnly)
            {
                TxtMat1Cost.Text = zero;
            }

            if (!matOneAmountDigitsOnly)
            {
                TxtMat1Amount.Text = zero;
            }

            if (!matTwoCostDigitsOnly)
            {
                TxtMat2Cost.Text = zero;
            }

            if (!matTwoAmountDigitsOnly)
            {
                TxtMat2Amount.Text = zero;
            }

            if (!matThreeCostDigitsOnly)
            {
                TxtMat3Cost.Text = zero;
            }

            if (!matThreeAmountDigitsOnly)
            {
                TxtMat3Amount.Text = zero;
            }

            if (!matFourCostDigitsOnly)
            {
                TxtMat4Cost.Text = zero;
            }

            if (!matFourAmountDigitsOnly)
            {
                TxtMat4Amount.Text = zero;
            }

            if (!matFiveCostDigitsOnly)
            {
                TxtMat5Cost.Text = zero;
            }

            if (!matFiveAmountDigitsOnly)
            {
                TxtMat5Amount.Text = zero;
            }

            if (!shardOneCostDigitsOnly)
            {
                TxtShard1Cost.Text = zero;
            }

            if (!shardOneAmountDigitsOnly)
            {
                TxtShard1Amount.Text = zero;
            }

            if (!shardTwoCostDigitsOnly)
            {
                TxtShard2Cost.Text = zero;
            }

            if (!shardTwoAmountDigitsOnly)
            {
                TxtShard2Amount.Text = zero;
            }

            if (!itemSellsForDigitsOnly)
            {
                TxtItemSellsFor.Text = zero;
            }

            if (TxtMat1Cost.Text != null && TxtMat1Cost.Text == "")
            {
                TxtMat1Cost.Text = zero;
            }

            if (TxtMat1Amount.Text != null && TxtMat1Amount.Text == "")
            {
                TxtMat1Amount.Text = zero;
            }

            if (TxtMat2Cost.Text != null && TxtMat2Cost.Text == "")
            {
                TxtMat2Cost.Text = zero;
            }

            if (TxtMat2Amount.Text != null && TxtMat2Amount.Text == "")
            {
                TxtMat2Amount.Text = zero;
            }

            if (TxtMat3Cost.Text != null && TxtMat3Cost.Text == "")
            {
                TxtMat3Cost.Text = zero;
            }

            if (TxtMat3Amount.Text != null && TxtMat3Amount.Text == "")
            {
                TxtMat3Amount.Text = zero;
            }

            if (TxtMat4Cost.Text != null && TxtMat4Cost.Text == "")
            {
                TxtMat4Cost.Text = zero;
            }

            if (TxtMat4Amount.Text != null && TxtMat4Amount.Text == "")
            {
                TxtMat4Amount.Text = zero;
            }

            if (TxtMat5Cost.Text != null && TxtMat5Cost.Text == "")
            {
                TxtMat5Cost.Text = zero;
            }

            if (TxtMat5Amount.Text != null && TxtMat5Amount.Text == "")
            {
                TxtMat5Amount.Text = zero;
            }

            if (TxtShard1Cost.Text != null && TxtShard1Cost.Text == "")
            {
                TxtShard1Cost.Text = zero;
            }

            if (TxtShard1Amount.Text != null && TxtShard1Amount.Text == "")
            {
                TxtShard1Amount.Text = zero;
            }

            if (TxtShard2Cost.Text != null && TxtShard2Cost.Text == "")
            {
                TxtShard2Cost.Text = zero;
            }

            if (TxtShard2Amount.Text != null && TxtShard2Amount.Text == "")
            {
                TxtShard2Amount.Text = zero;
            }

            if (TxtItemSellsFor.Text != null && TxtItemSellsFor.Text == "")
            {
                TxtItemSellsFor.Text = zero;
            }

            if (TxtMat1Cost.Text == null)
            {
                TxtMat1Cost.Text = zero;
            }

            if (TxtMat1Amount.Text == null)
            {
                TxtMat1Amount.Text = zero;
            }

            if (TxtMat2Cost.Text == null)
            {
                TxtMat2Cost.Text = zero;
            }

            if (TxtMat2Amount.Text == null)
            {
                TxtMat2Amount.Text = zero;
            }

            if (TxtMat3Cost.Text == null)
            {
                TxtMat3Cost.Text = zero;
            }

            if (TxtMat3Amount.Text == null)
            {
                TxtMat3Amount.Text = zero;
            }

            if (TxtMat4Cost.Text == null)
            {
                TxtMat4Cost.Text = zero;
            }

            if (TxtMat4Amount.Text == null)
            {
                TxtMat4Amount.Text = zero;
            }

            if (TxtMat5Cost.Text == null)
            {
                TxtMat5Cost.Text = zero;
            }

            if (TxtMat5Amount.Text == null)
            {
                TxtMat5Amount.Text = zero;
            }

            if (TxtShard1Cost.Text == null)
            {
                TxtShard1Cost.Text = zero;
            }

            if (TxtShard1Amount.Text == null)
            {
                TxtShard1Amount.Text = zero;
            }

            if (TxtShard2Cost.Text == null)
            {
                TxtShard2Cost.Text = zero;
            }

            if (TxtShard2Amount.Text == null)
            {
                TxtShard2Amount.Text = zero;
            }

            if (TxtItemSellsFor.Text == null)
            {
                TxtItemSellsFor.Text = zero;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CatchFormErrors();

            _materialOneCost = Convert.ToInt32(TxtMat1Cost.Text);
            _materialOneAmount = Convert.ToInt32(TxtMat1Amount.Text);
            _materialTwoCost = Convert.ToInt32(TxtMat2Cost.Text);
            _materialTwoAmount = Convert.ToInt32(TxtMat2Amount.Text);
            _materialThreeCost = Convert.ToInt32(TxtMat3Cost.Text);
            _materialThreeAmount = Convert.ToInt32(TxtMat3Amount.Text);
            _materialFourCost = Convert.ToInt32(TxtMat4Cost.Text);
            _materialFourAmount = Convert.ToInt32(TxtMat4Amount.Text);
            _materialFiveCost = Convert.ToInt32(TxtMat5Cost.Text);
            _materialFiveAmount = Convert.ToInt32(TxtMat5Amount.Text);
            _shardOneCost = Convert.ToInt32(TxtShard1Cost.Text);
            _shardOneAmount = Convert.ToInt32(TxtShard1Amount.Text);
            _shardTwoCost = Convert.ToInt32(TxtShard2Cost.Text);
            _shardTwoAmount = Convert.ToInt32(TxtShard2Amount.Text);
            _itemSellsFor = Convert.ToInt32(TxtItemSellsFor.Text);

            _materialTotalCost = (_materialOneCost * _materialOneAmount) +
                                 (_materialTwoCost * _materialTwoAmount) +
                                 (_materialThreeCost * _materialThreeAmount) +
                                 (_materialFourCost * _materialFourAmount) +
                                 (_materialFiveCost * _materialFiveAmount) +
                                 (_shardOneCost * _shardOneAmount) +
                                 (_shardTwoCost * _shardTwoAmount);

            _totalProfit = _itemSellsFor - _materialTotalCost;

            _matTotalCostFormatted = $"{_materialTotalCost:#,0}";
            _totalProfitFormatted = $"{_totalProfit:#,0}";

            TxtMaterialCost.Text = _matTotalCostFormatted;
            TxtTotalProfit.Text = _totalProfitFormatted;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtMat1Cost.Text = string.Empty;
            TxtMat1Amount.Text = string.Empty;
            TxtMat2Cost.Text = string.Empty;
            TxtMat2Amount.Text = string.Empty;
            TxtMat3Cost.Text = string.Empty;
            TxtMat3Amount.Text = string.Empty;
            TxtMat4Cost.Text = string.Empty;
            TxtMat4Amount.Text = string.Empty;
            TxtMat5Cost.Text = string.Empty;
            TxtMat5Amount.Text = string.Empty;

            TxtShard1Cost.Text = string.Empty;
            TxtShard1Amount.Text = string.Empty;
            TxtShard2Cost.Text = string.Empty;
            TxtShard2Amount.Text = string.Empty;

            TxtItemSellsFor.Text = string.Empty;
            TxtMaterialCost.Text = string.Empty;
            TxtTotalProfit.Text = string.Empty;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LblCreditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Thesnowmanndev/FinalFantasyXIVCraftingProfits");
        }
    }
}

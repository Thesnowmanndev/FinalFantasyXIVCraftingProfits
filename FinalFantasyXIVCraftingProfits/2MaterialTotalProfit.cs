using System;
using System.Windows.Forms;

namespace FinalFantasyXIVCraftingProfits
{
    public partial class frmTwoMaterialCost : Form
    {
        private int materialOneCost;
        private int materialOneAmountNeeded;
        private int materialTwoCost;
        private int materialTwoAmountNeeded;
        private int shardOneCost;
        private int shardOneAmountNeeded;
        private int shardTwoCost;
        private int shardTwoAmountNeeded;
        private int materialTotalCost;
        private int itemSellsFor;
        private int totalProfit;

        private string matTotalCostFormatted;
        private string totalProfitFormatted;

        public frmTwoMaterialCost()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            materialOneCost = Convert.ToInt32(txtMat1Cost.Text);
            materialOneAmountNeeded = Convert.ToInt32(txtMat1Amount.Text);
            materialTwoCost = Convert.ToInt32(txtMat2Cost.Text);
            materialTwoAmountNeeded = Convert.ToInt32(txtMat2Amount.Text);

            shardOneCost = Convert.ToInt32(txtShard1Cost.Text);
            shardOneAmountNeeded = Convert.ToInt32(txtShard1Amount.Text);
            shardTwoCost = Convert.ToInt32(txtShard2Cost.Text);
            shardTwoAmountNeeded = Convert.ToInt32(txtShard2Amount.Text);

            materialTotalCost = (materialOneCost * materialOneAmountNeeded) +
                                (materialTwoCost * materialTwoAmountNeeded) +
                                (shardOneCost * shardOneAmountNeeded) +
                                (shardTwoCost * shardTwoAmountNeeded);

            itemSellsFor = Convert.ToInt32(txtISellsFor.Text);

            matTotalCostFormatted = string.Format("{0:#,0}", materialTotalCost);
            txtMaterialCost.Text = matTotalCostFormatted;

            totalProfit = itemSellsFor - materialTotalCost;

            totalProfitFormatted = string.Format("{0:#,0}", totalProfit);
            txtTotalProfit.Text = totalProfitFormatted;
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
    }
}

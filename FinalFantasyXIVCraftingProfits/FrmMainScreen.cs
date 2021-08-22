using System;
using System.Windows.Forms;

namespace FinalFantasyXIVCraftingProfits
{
    public partial class FrmMainScreen : Form
    {
        public FrmMainScreen()
        {
            InitializeComponent();
        }

        private void lblCreditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Thesnowmanndev/FinalFantasyXIVCraftingProfits");
        }

        private void btn2MaterialCost_Click(object sender, EventArgs e)
        {
            Form frmTwoMaterialCost = new FrmTwoMaterialCost();
            frmTwoMaterialCost.Show();
        }

        private void lblSuggestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:thesnowmanndev@gmail.com?subject=FFXIV_Calculator_Feature_Request");
        }

        private void lblReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Thesnowmanndev/FinalFantasyXIVCraftingProfits/issues/");
        }
    }
}

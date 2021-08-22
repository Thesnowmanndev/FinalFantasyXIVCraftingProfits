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

        private void LblCreditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Thesnowmanndev/FinalFantasyXIVCraftingProfits");
        }

        private void LblSuggestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:thesnowmanndev@gmail.com?subject=FFXIV_Calculator_Feature_Request");
        }

        private void LblReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Thesnowmanndev/FinalFantasyXIVCraftingProfits/issues/");
        }

        private void BtnOneMaterialCalculator_Click(object sender, EventArgs e)
        {
            Form frmOneMaterialCost = new FrmOneMaterial();
            frmOneMaterialCost.Show();
        }

        private void Btn2MaterialCost_Click(object sender, EventArgs e)
        {
            Form frmTwoMaterialCost = new FrmTwoMaterials();
            frmTwoMaterialCost.Show();
        }
    }
}

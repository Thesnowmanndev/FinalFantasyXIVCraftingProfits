
using System;
using System.Windows.Forms;

namespace FinalFantasyXIVCraftingProfits
{
    partial class FrmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainScreen));
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCreditLink = new System.Windows.Forms.LinkLabel();
            this.gpCraftingProfits = new System.Windows.Forms.GroupBox();
            this.gpFiveMaterials = new System.Windows.Forms.GroupBox();
            this.gpFourMaterials = new System.Windows.Forms.GroupBox();
            this.gpThreeMaterials = new System.Windows.Forms.GroupBox();
            this.gpTwoMaterials = new System.Windows.Forms.GroupBox();
            this.TwoMaterialDescription = new System.Windows.Forms.Label();
            this.Btn2MaterialCost = new System.Windows.Forms.Button();
            this.gpOneMaterial = new System.Windows.Forms.GroupBox();
            this.OneMaterialDescription = new System.Windows.Forms.Label();
            this.BtnOneMaterialCalculator = new System.Windows.Forms.Button();
            this.gpQuestsMisc = new System.Windows.Forms.GroupBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.lblReportLink = new System.Windows.Forms.LinkLabel();
            this.lblSuggestLink = new System.Windows.Forms.LinkLabel();
            this.Btn5MaterialCost = new System.Windows.Forms.Button();
            this.FiveMaterialDescription = new System.Windows.Forms.Label();
            this.gpCraftingProfits.SuspendLayout();
            this.gpFiveMaterials.SuspendLayout();
            this.gpTwoMaterials.SuspendLayout();
            this.gpOneMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(528, 642);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(249, 13);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Created by Kyle | Sin Swordborne @ Famfrit [Primal]";
            // 
            // lblCreditLink
            // 
            this.lblCreditLink.AutoSize = true;
            this.lblCreditLink.Location = new System.Drawing.Point(481, 660);
            this.lblCreditLink.Name = "lblCreditLink";
            this.lblCreditLink.Size = new System.Drawing.Size(334, 13);
            this.lblCreditLink.TabIndex = 1;
            this.lblCreditLink.TabStop = true;
            this.lblCreditLink.Text = "https://github.com/Thesnowmanndev/FinalFantasyXIVCraftingProfits";
            this.lblCreditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCreditLink_LinkClicked);
            // 
            // gpCraftingProfits
            // 
            this.gpCraftingProfits.Controls.Add(this.gpFiveMaterials);
            this.gpCraftingProfits.Controls.Add(this.gpFourMaterials);
            this.gpCraftingProfits.Controls.Add(this.gpThreeMaterials);
            this.gpCraftingProfits.Controls.Add(this.gpTwoMaterials);
            this.gpCraftingProfits.Controls.Add(this.gpOneMaterial);
            this.gpCraftingProfits.Location = new System.Drawing.Point(26, 83);
            this.gpCraftingProfits.Name = "gpCraftingProfits";
            this.gpCraftingProfits.Size = new System.Drawing.Size(585, 553);
            this.gpCraftingProfits.TabIndex = 2;
            this.gpCraftingProfits.TabStop = false;
            this.gpCraftingProfits.Text = "Crafting Profits";
            // 
            // gpFiveMaterials
            // 
            this.gpFiveMaterials.Controls.Add(this.FiveMaterialDescription);
            this.gpFiveMaterials.Controls.Add(this.Btn5MaterialCost);
            this.gpFiveMaterials.Location = new System.Drawing.Point(22, 448);
            this.gpFiveMaterials.Name = "gpFiveMaterials";
            this.gpFiveMaterials.Size = new System.Drawing.Size(541, 100);
            this.gpFiveMaterials.TabIndex = 7;
            this.gpFiveMaterials.TabStop = false;
            this.gpFiveMaterials.Text = "Five Materials Required";
            // 
            // gpFourMaterials
            // 
            this.gpFourMaterials.Location = new System.Drawing.Point(22, 341);
            this.gpFourMaterials.Name = "gpFourMaterials";
            this.gpFourMaterials.Size = new System.Drawing.Size(541, 100);
            this.gpFourMaterials.TabIndex = 6;
            this.gpFourMaterials.TabStop = false;
            this.gpFourMaterials.Text = "Four Materials Required";
            // 
            // gpThreeMaterials
            // 
            this.gpThreeMaterials.Location = new System.Drawing.Point(22, 234);
            this.gpThreeMaterials.Name = "gpThreeMaterials";
            this.gpThreeMaterials.Size = new System.Drawing.Size(541, 100);
            this.gpThreeMaterials.TabIndex = 5;
            this.gpThreeMaterials.TabStop = false;
            this.gpThreeMaterials.Text = "Three Materials Required";
            // 
            // gpTwoMaterials
            // 
            this.gpTwoMaterials.Controls.Add(this.TwoMaterialDescription);
            this.gpTwoMaterials.Controls.Add(this.Btn2MaterialCost);
            this.gpTwoMaterials.Location = new System.Drawing.Point(22, 127);
            this.gpTwoMaterials.Name = "gpTwoMaterials";
            this.gpTwoMaterials.Size = new System.Drawing.Size(541, 100);
            this.gpTwoMaterials.TabIndex = 4;
            this.gpTwoMaterials.TabStop = false;
            this.gpTwoMaterials.Text = "Two Materials Required";
            // 
            // TwoMaterialDescription
            // 
            this.TwoMaterialDescription.AutoSize = true;
            this.TwoMaterialDescription.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoMaterialDescription.Location = new System.Drawing.Point(24, 77);
            this.TwoMaterialDescription.Name = "TwoMaterialDescription";
            this.TwoMaterialDescription.Size = new System.Drawing.Size(493, 16);
            this.TwoMaterialDescription.TabIndex = 1;
            this.TwoMaterialDescription.Text = "Allows for the user to input material costs and amounts for a max of two material" +
    "s and a max of two shard slots.";
            // 
            // Btn2MaterialCost
            // 
            this.Btn2MaterialCost.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2MaterialCost.Location = new System.Drawing.Point(186, 19);
            this.Btn2MaterialCost.Name = "Btn2MaterialCost";
            this.Btn2MaterialCost.Size = new System.Drawing.Size(159, 52);
            this.Btn2MaterialCost.TabIndex = 2;
            this.Btn2MaterialCost.Text = "Open Calculator";
            this.Btn2MaterialCost.UseVisualStyleBackColor = true;
            this.Btn2MaterialCost.Click += new System.EventHandler(this.Btn2MaterialCost_Click);
            // 
            // gpOneMaterial
            // 
            this.gpOneMaterial.Controls.Add(this.OneMaterialDescription);
            this.gpOneMaterial.Controls.Add(this.BtnOneMaterialCalculator);
            this.gpOneMaterial.Location = new System.Drawing.Point(22, 20);
            this.gpOneMaterial.Name = "gpOneMaterial";
            this.gpOneMaterial.Size = new System.Drawing.Size(541, 100);
            this.gpOneMaterial.TabIndex = 3;
            this.gpOneMaterial.TabStop = false;
            this.gpOneMaterial.Text = "One Material Required ";
            // 
            // OneMaterialDescription
            // 
            this.OneMaterialDescription.AutoSize = true;
            this.OneMaterialDescription.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneMaterialDescription.Location = new System.Drawing.Point(24, 71);
            this.OneMaterialDescription.Name = "OneMaterialDescription";
            this.OneMaterialDescription.Size = new System.Drawing.Size(488, 16);
            this.OneMaterialDescription.TabIndex = 3;
            this.OneMaterialDescription.Text = "Allows for the user to input material costs and amounts for a max of one material" +
    " and a max of two shard slots.";
            // 
            // BtnOneMaterialCalculator
            // 
            this.BtnOneMaterialCalculator.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOneMaterialCalculator.Location = new System.Drawing.Point(186, 13);
            this.BtnOneMaterialCalculator.Name = "BtnOneMaterialCalculator";
            this.BtnOneMaterialCalculator.Size = new System.Drawing.Size(159, 52);
            this.BtnOneMaterialCalculator.TabIndex = 1;
            this.BtnOneMaterialCalculator.Text = "Open Calculator";
            this.BtnOneMaterialCalculator.UseVisualStyleBackColor = true;
            this.BtnOneMaterialCalculator.Click += new System.EventHandler(this.BtnOneMaterialCalculator_Click);
            // 
            // gpQuestsMisc
            // 
            this.gpQuestsMisc.Location = new System.Drawing.Point(656, 83);
            this.gpQuestsMisc.Name = "gpQuestsMisc";
            this.gpQuestsMisc.Size = new System.Drawing.Size(585, 553);
            this.gpQuestsMisc.TabIndex = 3;
            this.gpQuestsMisc.TabStop = false;
            this.gpQuestsMisc.Text = "Quests and Misc";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(366, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(525, 39);
            this.lblGreeting.TabIndex = 4;
            this.lblGreeting.Text = "Welcome to the FFXIV  Crafting Profits Calculator";
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(544, 48);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(166, 33);
            this.lblOption.TabIndex = 5;
            this.lblOption.Text = "Choose an Option";
            // 
            // lblReportLink
            // 
            this.lblReportLink.AutoSize = true;
            this.lblReportLink.Location = new System.Drawing.Point(1139, 651);
            this.lblReportLink.Name = "lblReportLink";
            this.lblReportLink.Size = new System.Drawing.Size(83, 13);
            this.lblReportLink.TabIndex = 6;
            this.lblReportLink.TabStop = true;
            this.lblReportLink.Text = "Report An Issue";
            this.lblReportLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblReportLink_LinkClicked);
            // 
            // lblSuggestLink
            // 
            this.lblSuggestLink.AutoSize = true;
            this.lblSuggestLink.Location = new System.Drawing.Point(45, 651);
            this.lblSuggestLink.Name = "lblSuggestLink";
            this.lblSuggestLink.Size = new System.Drawing.Size(94, 13);
            this.lblSuggestLink.TabIndex = 7;
            this.lblSuggestLink.TabStop = true;
            this.lblSuggestLink.Text = "Suggest a Feature";
            this.lblSuggestLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblSuggestLink_LinkClicked);
            // 
            // Btn5MaterialCost
            // 
            this.Btn5MaterialCost.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5MaterialCost.Location = new System.Drawing.Point(191, 24);
            this.Btn5MaterialCost.Name = "Btn5MaterialCost";
            this.Btn5MaterialCost.Size = new System.Drawing.Size(159, 52);
            this.Btn5MaterialCost.TabIndex = 3;
            this.Btn5MaterialCost.Text = "Open Calculator";
            this.Btn5MaterialCost.UseVisualStyleBackColor = true;
            this.Btn5MaterialCost.Click += new System.EventHandler(this.Btn5MaterialCost_Click);
            // 
            // FiveMaterialDescription
            // 
            this.FiveMaterialDescription.AutoSize = true;
            this.FiveMaterialDescription.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveMaterialDescription.Location = new System.Drawing.Point(24, 79);
            this.FiveMaterialDescription.Name = "FiveMaterialDescription";
            this.FiveMaterialDescription.Size = new System.Drawing.Size(493, 16);
            this.FiveMaterialDescription.TabIndex = 4;
            this.FiveMaterialDescription.Text = "Allows for the user to input material costs and amounts for a max of two material" +
    "s and a max of two shard slots.";
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gpCraftingProfits);
            this.Controls.Add(this.gpQuestsMisc);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblCreditLink);
            this.Controls.Add(this.lblReportLink);
            this.Controls.Add(this.lblSuggestLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Fantasy XIV - Crafting Profits";
            this.gpCraftingProfits.ResumeLayout(false);
            this.gpFiveMaterials.ResumeLayout(false);
            this.gpFiveMaterials.PerformLayout();
            this.gpTwoMaterials.ResumeLayout(false);
            this.gpTwoMaterials.PerformLayout();
            this.gpOneMaterial.ResumeLayout(false);
            this.gpOneMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.LinkLabel lblCreditLink;
        private System.Windows.Forms.GroupBox gpCraftingProfits;
        private System.Windows.Forms.GroupBox gpQuestsMisc;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Button Btn2MaterialCost;
        private System.Windows.Forms.LinkLabel lblReportLink;
        private System.Windows.Forms.LinkLabel lblSuggestLink;
        private System.Windows.Forms.GroupBox gpThreeMaterials;
        private System.Windows.Forms.GroupBox gpTwoMaterials;
        private System.Windows.Forms.GroupBox gpOneMaterial;
        private System.Windows.Forms.GroupBox gpFiveMaterials;
        private System.Windows.Forms.GroupBox gpFourMaterials;
        private System.Windows.Forms.Label TwoMaterialDescription;
        private System.Windows.Forms.Label OneMaterialDescription;
        private System.Windows.Forms.Button BtnOneMaterialCalculator;
        private Label FiveMaterialDescription;
        private Button Btn5MaterialCost;
    }
}
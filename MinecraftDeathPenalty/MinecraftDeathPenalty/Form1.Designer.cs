namespace MinecraftDeathPenalty
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDeathCount = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.pbMinecraftLogo = new System.Windows.Forms.PictureBox();
            this.pbDeathCounter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinecraftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeathCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeathCount
            // 
            this.txtDeathCount.Location = new System.Drawing.Point(147, 160);
            this.txtDeathCount.Name = "txtDeathCount";
            this.txtDeathCount.Size = new System.Drawing.Size(100, 23);
            this.txtDeathCount.TabIndex = 0;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(113, 262);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(154, 15);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Pay the resurrection cost of:";
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Location = new System.Drawing.Point(156, 294);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(78, 15);
            this.lblItemAmount.TabIndex = 2;
            this.lblItemAmount.Text = "Item Amount";
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(144, 189);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(103, 23);
            this.btnCalculateCost.TabIndex = 3;
            this.btnCalculateCost.Text = "Pay the Toll Troll";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // lblDeaths
            // 
            this.lblDeaths.AutoSize = true;
            this.lblDeaths.Location = new System.Drawing.Point(160, 142);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(74, 15);
            this.lblDeaths.TabIndex = 4;
            this.lblDeaths.Text = "Death Count";
            // 
            // pbItem
            // 
            this.pbItem.Location = new System.Drawing.Point(147, 330);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(100, 50);
            this.pbItem.TabIndex = 5;
            this.pbItem.TabStop = false;
            // 
            // pbMinecraftLogo
            // 
            this.pbMinecraftLogo.ImageLocation = "E:\\GitHub Projects\\Minecraft-Death-Penalty\\MinecraftDeathPenalty\\MinecraftDeathPe" +
    "nalty\\Resources\\Minecraft.png";
            this.pbMinecraftLogo.Location = new System.Drawing.Point(3, 12);
            this.pbMinecraftLogo.Name = "pbMinecraftLogo";
            this.pbMinecraftLogo.Size = new System.Drawing.Size(400, 66);
            this.pbMinecraftLogo.TabIndex = 6;
            this.pbMinecraftLogo.TabStop = false;
            // 
            // pbDeathCounter
            // 
            this.pbDeathCounter.ImageLocation = "E:\\GitHub Projects\\Minecraft-Death-Penalty\\MinecraftDeathPenalty\\MinecraftDeathPe" +
    "nalty\\Resources\\DeathCounter.png";
            this.pbDeathCounter.Location = new System.Drawing.Point(38, 84);
            this.pbDeathCounter.Name = "pbDeathCounter";
            this.pbDeathCounter.Size = new System.Drawing.Size(327, 43);
            this.pbDeathCounter.TabIndex = 7;
            this.pbDeathCounter.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(407, 457);
            this.Controls.Add(this.pbDeathCounter);
            this.Controls.Add(this.pbMinecraftLogo);
            this.Controls.Add(this.pbItem);
            this.Controls.Add(this.lblDeaths);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.lblItemAmount);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtDeathCount);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinecraftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeathCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeathCount;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.PictureBox pbMinecraftLogo;
        private System.Windows.Forms.PictureBox pbDeathCounter;
    }
}


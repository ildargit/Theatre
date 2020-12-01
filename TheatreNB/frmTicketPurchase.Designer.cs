namespace TheatreNB
{
    partial class frmTicketPurchase
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
            this.grpPlays = new System.Windows.Forms.GroupBox();
            this.chkBoysGirls = new System.Windows.Forms.CheckBox();
            this.chkAnnie = new System.Windows.Forms.CheckBox();
            this.chkWonderfulLife = new System.Windows.Forms.CheckBox();
            this.chk1979 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.grpSeating = new System.Windows.Forms.GroupBox();
            this.rdoBox = new System.Windows.Forms.RadioButton();
            this.rdoOrchestra = new System.Windows.Forms.RadioButton();
            this.rdoBalcony = new System.Windows.Forms.RadioButton();
            this.grpPlays.SuspendLayout();
            this.grpSeating.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlays
            // 
            this.grpPlays.Controls.Add(this.chkBoysGirls);
            this.grpPlays.Controls.Add(this.chkAnnie);
            this.grpPlays.Controls.Add(this.chkWonderfulLife);
            this.grpPlays.Controls.Add(this.chk1979);
            this.grpPlays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlays.Location = new System.Drawing.Point(42, 35);
            this.grpPlays.Name = "grpPlays";
            this.grpPlays.Size = new System.Drawing.Size(487, 105);
            this.grpPlays.TabIndex = 0;
            this.grpPlays.TabStop = false;
            this.grpPlays.Text = "Choose your Plays";
            // 
            // chkBoysGirls
            // 
            this.chkBoysGirls.AutoSize = true;
            this.chkBoysGirls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoysGirls.Location = new System.Drawing.Point(227, 64);
            this.chkBoysGirls.Name = "chkBoysGirls";
            this.chkBoysGirls.Size = new System.Drawing.Size(235, 17);
            this.chkBoysGirls.TabIndex = 4;
            this.chkBoysGirls.Text = "Boys, Girls and Other Mythological Creatures";
            this.chkBoysGirls.UseVisualStyleBackColor = true;
            this.chkBoysGirls.Click += new System.EventHandler(this.Changed_conditionClick);
            // 
            // chkAnnie
            // 
            this.chkAnnie.AutoSize = true;
            this.chkAnnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnnie.Location = new System.Drawing.Point(227, 41);
            this.chkAnnie.Name = "chkAnnie";
            this.chkAnnie.Size = new System.Drawing.Size(53, 17);
            this.chkAnnie.TabIndex = 3;
            this.chkAnnie.Text = "Annie";
            this.chkAnnie.UseVisualStyleBackColor = true;
            this.chkAnnie.Click += new System.EventHandler(this.Changed_conditionClick);
            // 
            // chkWonderfulLife
            // 
            this.chkWonderfulLife.AutoSize = true;
            this.chkWonderfulLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWonderfulLife.Location = new System.Drawing.Point(52, 64);
            this.chkWonderfulLife.Name = "chkWonderfulLife";
            this.chkWonderfulLife.Size = new System.Drawing.Size(120, 17);
            this.chkWonderfulLife.TabIndex = 1;
            this.chkWonderfulLife.Text = "It\'s a Wonderful Life";
            this.chkWonderfulLife.UseVisualStyleBackColor = true;
            this.chkWonderfulLife.Click += new System.EventHandler(this.Changed_conditionClick);
            // 
            // chk1979
            // 
            this.chk1979.AutoSize = true;
            this.chk1979.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1979.Location = new System.Drawing.Point(52, 41);
            this.chk1979.Name = "chk1979";
            this.chk1979.Size = new System.Drawing.Size(50, 17);
            this.chk1979.TabIndex = 0;
            this.chk1979.Text = "1979";
            this.chk1979.UseVisualStyleBackColor = true;
            this.chk1979.Click += new System.EventHandler(this.Changed_conditionClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your credit card number";
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(39, 266);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(223, 20);
            this.txtCreditCard.TabIndex = 4;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(290, 236);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(239, 60);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(248, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 43);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(39, 308);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(490, 29);
            this.lblDisplay.TabIndex = 7;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSeating
            // 
            this.grpSeating.Controls.Add(this.rdoBox);
            this.grpSeating.Controls.Add(this.rdoOrchestra);
            this.grpSeating.Controls.Add(this.rdoBalcony);
            this.grpSeating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSeating.Location = new System.Drawing.Point(42, 146);
            this.grpSeating.Name = "grpSeating";
            this.grpSeating.Size = new System.Drawing.Size(487, 84);
            this.grpSeating.TabIndex = 5;
            this.grpSeating.TabStop = false;
            this.grpSeating.Text = "Choose your Seating";
            // 
            // rdoBox
            // 
            this.rdoBox.AutoSize = true;
            this.rdoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBox.Location = new System.Drawing.Point(323, 40);
            this.rdoBox.Name = "rdoBox";
            this.rdoBox.Size = new System.Drawing.Size(43, 17);
            this.rdoBox.TabIndex = 2;
            this.rdoBox.Text = "Box";
            this.rdoBox.UseVisualStyleBackColor = true;
            this.rdoBox.Click += new System.EventHandler(this.Changed_conditionClick);
            // 
            // rdoOrchestra
            // 
            this.rdoOrchestra.AutoSize = true;
            this.rdoOrchestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOrchestra.Location = new System.Drawing.Point(206, 40);
            this.rdoOrchestra.Name = "rdoOrchestra";
            this.rdoOrchestra.Size = new System.Drawing.Size(71, 17);
            this.rdoOrchestra.TabIndex = 1;
            this.rdoOrchestra.Text = "Orchestra";
            this.rdoOrchestra.UseVisualStyleBackColor = true;
            this.rdoOrchestra.Click += new System.EventHandler(this.Changed_conditionClick);
            // 
            // rdoBalcony
            // 
            this.rdoBalcony.AutoSize = true;
            this.rdoBalcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBalcony.Location = new System.Drawing.Point(90, 40);
            this.rdoBalcony.Name = "rdoBalcony";
            this.rdoBalcony.Size = new System.Drawing.Size(63, 17);
            this.rdoBalcony.TabIndex = 0;
            this.rdoBalcony.Text = "Balcony";
            this.rdoBalcony.UseVisualStyleBackColor = true;
            this.rdoBalcony.Click += new System.EventHandler(this.Changed_conditionClick);
            // 
            // frmTicketPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 442);
            this.Controls.Add(this.grpSeating);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpPlays);
            this.Name = "frmTicketPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theatre New Brunswick Season Tickets";
            this.Load += new System.EventHandler(this.frmTicketPurchase_Load);
            this.grpPlays.ResumeLayout(false);
            this.grpPlays.PerformLayout();
            this.grpSeating.ResumeLayout(false);
            this.grpSeating.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlays;
        private System.Windows.Forms.CheckBox chkBoysGirls;
        private System.Windows.Forms.CheckBox chkAnnie;
        private System.Windows.Forms.CheckBox chkWonderfulLife;
        private System.Windows.Forms.CheckBox chk1979;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.GroupBox grpSeating;
        private System.Windows.Forms.RadioButton rdoBox;
        private System.Windows.Forms.RadioButton rdoOrchestra;
        private System.Windows.Forms.RadioButton rdoBalcony;
    }
}


namespace MoneeRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.burgerCitylabel = new System.Windows.Forms.Label();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.friesLabel = new System.Windows.Forms.Label();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOut = new System.Windows.Forms.Label();
            this.taxOut = new System.Windows.Forms.Label();
            this.totalOut = new System.Windows.Forms.Label();
            this.blackBar = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeCalculatebutton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOut = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptBox = new System.Windows.Forms.RichTextBox();
            this.newOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerCitylabel
            // 
            this.burgerCitylabel.BackColor = System.Drawing.Color.SkyBlue;
            this.burgerCitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerCitylabel.Location = new System.Drawing.Point(-4, -3);
            this.burgerCitylabel.Name = "burgerCitylabel";
            this.burgerCitylabel.Size = new System.Drawing.Size(558, 32);
            this.burgerCitylabel.TabIndex = 0;
            this.burgerCitylabel.Text = "Burger City";
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(9, 73);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(157, 20);
            this.burgerLabel.TabIndex = 2;
            this.burgerLabel.Text = "Number of Burgers:";
            this.burgerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(194, 73);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(100, 22);
            this.burgerInput.TabIndex = 3;
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(9, 115);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(135, 20);
            this.friesLabel.TabIndex = 4;
            this.friesLabel.Text = "Number of Fries:";
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(194, 115);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(100, 22);
            this.friesInput.TabIndex = 5;
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(9, 159);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(146, 20);
            this.drinkLabel.TabIndex = 6;
            this.drinkLabel.Text = "Number of Drinks:";
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(194, 157);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(100, 22);
            this.drinkInput.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 191);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(282, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(9, 237);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(75, 20);
            this.subLabel.TabIndex = 9;
            this.subLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(9, 280);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(41, 20);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(9, 322);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 20);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalOut
            // 
            this.subtotalOut.AutoSize = true;
            this.subtotalOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOut.Location = new System.Drawing.Point(168, 237);
            this.subtotalOut.Name = "subtotalOut";
            this.subtotalOut.Size = new System.Drawing.Size(0, 20);
            this.subtotalOut.TabIndex = 12;
            // 
            // taxOut
            // 
            this.taxOut.AutoSize = true;
            this.taxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOut.Location = new System.Drawing.Point(168, 280);
            this.taxOut.Name = "taxOut";
            this.taxOut.Size = new System.Drawing.Size(0, 20);
            this.taxOut.TabIndex = 13;
            // 
            // totalOut
            // 
            this.totalOut.AutoSize = true;
            this.totalOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOut.Location = new System.Drawing.Point(168, 322);
            this.totalOut.Name = "totalOut";
            this.totalOut.Size = new System.Drawing.Size(0, 20);
            this.totalOut.TabIndex = 14;
            // 
            // blackBar
            // 
            this.blackBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackBar.Location = new System.Drawing.Point(10, 342);
            this.blackBar.Name = "blackBar";
            this.blackBar.Size = new System.Drawing.Size(284, 11);
            this.blackBar.TabIndex = 15;
            this.blackBar.Text = "label1";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(9, 376);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(84, 20);
            this.tenderedLabel.TabIndex = 16;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(194, 376);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 22);
            this.tenderedInput.TabIndex = 17;
            this.tenderedInput.TextChanged += new System.EventHandler(this.tenderedInput_TextChanged);
            // 
            // changeCalculatebutton
            // 
            this.changeCalculatebutton.Location = new System.Drawing.Point(13, 404);
            this.changeCalculatebutton.Name = "changeCalculatebutton";
            this.changeCalculatebutton.Size = new System.Drawing.Size(281, 23);
            this.changeCalculatebutton.TabIndex = 18;
            this.changeCalculatebutton.Text = "Calculate Change";
            this.changeCalculatebutton.UseVisualStyleBackColor = true;
            this.changeCalculatebutton.Click += new System.EventHandler(this.changeCalculatebutton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(9, 449);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(71, 20);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change:";
            this.changeLabel.Click += new System.EventHandler(this.changeLabel_Click);
            // 
            // changeOut
            // 
            this.changeOut.AutoSize = true;
            this.changeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOut.Location = new System.Drawing.Point(168, 449);
            this.changeOut.Name = "changeOut";
            this.changeOut.Size = new System.Drawing.Size(0, 20);
            this.changeOut.TabIndex = 20;
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(13, 485);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(281, 23);
            this.receiptButton.TabIndex = 21;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptBox
            // 
            this.receiptBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBox.Location = new System.Drawing.Point(300, 39);
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.ReadOnly = true;
            this.receiptBox.Size = new System.Drawing.Size(242, 444);
            this.receiptBox.TabIndex = 23;
            this.receiptBox.Text = "";
            this.receiptBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(300, 485);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(242, 23);
            this.newOrder.TabIndex = 24;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 521);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.receiptBox);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOut);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeCalculatebutton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.blackBar);
            this.Controls.Add(this.totalOut);
            this.Controls.Add(this.taxOut);
            this.Controls.Add(this.subtotalOut);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.burgerCitylabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerCitylabel;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOut;
        private System.Windows.Forms.Label taxOut;
        private System.Windows.Forms.Label totalOut;
        private System.Windows.Forms.Label blackBar;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeCalculatebutton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOut;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.RichTextBox receiptBox;
        private System.Windows.Forms.Button newOrder;
    }
}


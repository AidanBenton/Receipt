
namespace Reciet
{
    partial class backgroundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backgroundForm));
            this.stringsLabel = new System.Windows.Forms.Label();
            this.overGripLabel = new System.Windows.Forms.Label();
            this.tennisBallsLabel = new System.Windows.Forms.Label();
            this.stringsTextBox = new System.Windows.Forms.TextBox();
            this.overGripTextBox = new System.Windows.Forms.TextBox();
            this.tennisBallsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.realTotalLabel = new System.Windows.Forms.Label();
            this.costTypeLabel = new System.Windows.Forms.Label();
            this.blackBarLabel = new System.Windows.Forms.Label();
            this.tenderedTextBox = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeTypeLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.centerReceiptTextLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.leftReceiptTextLabel = new System.Windows.Forms.Label();
            this.rightReceiptTextLabel = new System.Windows.Forms.Label();
            this.catchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringsLabel
            // 
            this.stringsLabel.Location = new System.Drawing.Point(12, 9);
            this.stringsLabel.Name = "stringsLabel";
            this.stringsLabel.Size = new System.Drawing.Size(84, 16);
            this.stringsLabel.TabIndex = 0;
            this.stringsLabel.Text = "Strings";
            // 
            // overGripLabel
            // 
            this.overGripLabel.Location = new System.Drawing.Point(12, 25);
            this.overGripLabel.Name = "overGripLabel";
            this.overGripLabel.Size = new System.Drawing.Size(84, 16);
            this.overGripLabel.TabIndex = 1;
            this.overGripLabel.Text = "Over Grip";
            // 
            // tennisBallsLabel
            // 
            this.tennisBallsLabel.Location = new System.Drawing.Point(12, 44);
            this.tennisBallsLabel.Name = "tennisBallsLabel";
            this.tennisBallsLabel.Size = new System.Drawing.Size(84, 16);
            this.tennisBallsLabel.TabIndex = 2;
            this.tennisBallsLabel.Text = "Tennis balls";
            // 
            // stringsTextBox
            // 
            this.stringsTextBox.Location = new System.Drawing.Point(103, 5);
            this.stringsTextBox.Name = "stringsTextBox";
            this.stringsTextBox.Size = new System.Drawing.Size(61, 20);
            this.stringsTextBox.TabIndex = 3;
            this.stringsTextBox.Text = "0";
            this.stringsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.stringsTextBox.Enter += new System.EventHandler(this.stringsTextBox_Enter);
            this.stringsTextBox.Leave += new System.EventHandler(this.stringsTextBox_Leave);
            // 
            // overGripTextBox
            // 
            this.overGripTextBox.Location = new System.Drawing.Point(103, 22);
            this.overGripTextBox.Name = "overGripTextBox";
            this.overGripTextBox.Size = new System.Drawing.Size(61, 20);
            this.overGripTextBox.TabIndex = 4;
            this.overGripTextBox.Text = "0";
            this.overGripTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.overGripTextBox.Enter += new System.EventHandler(this.overGripTextBox_Enter);
            this.overGripTextBox.Leave += new System.EventHandler(this.overGripTextBox_Leave);
            // 
            // tennisBallsTextBox
            // 
            this.tennisBallsTextBox.Location = new System.Drawing.Point(103, 41);
            this.tennisBallsTextBox.Name = "tennisBallsTextBox";
            this.tennisBallsTextBox.Size = new System.Drawing.Size(61, 20);
            this.tennisBallsTextBox.TabIndex = 5;
            this.tennisBallsTextBox.Text = "0";
            this.tennisBallsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tennisBallsTextBox.Enter += new System.EventHandler(this.tennisBallsTextBox_Enter);
            this.tennisBallsTextBox.Leave += new System.EventHandler(this.tennisBallsTextBox_Leave);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 67);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(152, 34);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // realTotalLabel
            // 
            this.realTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.realTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realTotalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.realTotalLabel.Location = new System.Drawing.Point(99, 112);
            this.realTotalLabel.Name = "realTotalLabel";
            this.realTotalLabel.Size = new System.Drawing.Size(64, 75);
            this.realTotalLabel.TabIndex = 10;
            this.realTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // costTypeLabel
            // 
            this.costTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.costTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTypeLabel.Location = new System.Drawing.Point(12, 112);
            this.costTypeLabel.Name = "costTypeLabel";
            this.costTypeLabel.Size = new System.Drawing.Size(84, 75);
            this.costTypeLabel.TabIndex = 11;
            // 
            // blackBarLabel
            // 
            this.blackBarLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackBarLabel.Location = new System.Drawing.Point(12, 195);
            this.blackBarLabel.Name = "blackBarLabel";
            this.blackBarLabel.Size = new System.Drawing.Size(152, 11);
            this.blackBarLabel.TabIndex = 12;
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Location = new System.Drawing.Point(104, 209);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(60, 20);
            this.tenderedTextBox.TabIndex = 13;
            this.tenderedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tenderedTextBox.Enter += new System.EventHandler(this.tenderedTextBox_Enter);
            this.tenderedTextBox.Leave += new System.EventHandler(this.tenderedTextBox_Leave);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(12, 212);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(56, 13);
            this.tenderedLabel.TabIndex = 14;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Location = new System.Drawing.Point(12, 235);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(152, 34);
            this.calculateChangeButton.TabIndex = 15;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeTypeLabel
            // 
            this.changeTypeLabel.AutoSize = true;
            this.changeTypeLabel.Location = new System.Drawing.Point(12, 272);
            this.changeTypeLabel.Name = "changeTypeLabel";
            this.changeTypeLabel.Size = new System.Drawing.Size(47, 13);
            this.changeTypeLabel.TabIndex = 16;
            this.changeTypeLabel.Text = "Change:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(120, 272);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 13);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Location = new System.Drawing.Point(11, 288);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(152, 34);
            this.printReceiptButton.TabIndex = 18;
            this.printReceiptButton.Text = "Print receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptLabel.Location = new System.Drawing.Point(175, 8);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(193, 277);
            this.receiptLabel.TabIndex = 19;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // centerReceiptTextLabel
            // 
            this.centerReceiptTextLabel.BackColor = System.Drawing.Color.White;
            this.centerReceiptTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerReceiptTextLabel.Location = new System.Drawing.Point(178, 8);
            this.centerReceiptTextLabel.Name = "centerReceiptTextLabel";
            this.centerReceiptTextLabel.Size = new System.Drawing.Size(186, 93);
            this.centerReceiptTextLabel.TabIndex = 20;
            this.centerReceiptTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(196, 288);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(152, 34);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "New order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // leftReceiptTextLabel
            // 
            this.leftReceiptTextLabel.BackColor = System.Drawing.Color.White;
            this.leftReceiptTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftReceiptTextLabel.Location = new System.Drawing.Point(193, 101);
            this.leftReceiptTextLabel.Name = "leftReceiptTextLabel";
            this.leftReceiptTextLabel.Size = new System.Drawing.Size(113, 184);
            this.leftReceiptTextLabel.TabIndex = 22;
            // 
            // rightReceiptTextLabel
            // 
            this.rightReceiptTextLabel.BackColor = System.Drawing.Color.White;
            this.rightReceiptTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightReceiptTextLabel.Location = new System.Drawing.Point(282, 101);
            this.rightReceiptTextLabel.Name = "rightReceiptTextLabel";
            this.rightReceiptTextLabel.Size = new System.Drawing.Size(71, 184);
            this.rightReceiptTextLabel.TabIndex = 23;
            this.rightReceiptTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // catchLabel
            // 
            this.catchLabel.AutoSize = true;
            this.catchLabel.BackColor = System.Drawing.Color.Transparent;
            this.catchLabel.Location = new System.Drawing.Point(12, 112);
            this.catchLabel.Name = "catchLabel";
            this.catchLabel.Size = new System.Drawing.Size(0, 13);
            this.catchLabel.TabIndex = 24;
            // 
            // backgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.catchLabel);
            this.Controls.Add(this.rightReceiptTextLabel);
            this.Controls.Add(this.leftReceiptTextLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.centerReceiptTextLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeTypeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.tenderedTextBox);
            this.Controls.Add(this.blackBarLabel);
            this.Controls.Add(this.costTypeLabel);
            this.Controls.Add(this.realTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.tennisBallsTextBox);
            this.Controls.Add(this.overGripTextBox);
            this.Controls.Add(this.stringsTextBox);
            this.Controls.Add(this.tennisBallsLabel);
            this.Controls.Add(this.overGripLabel);
            this.Controls.Add(this.stringsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "backgroundForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringsLabel;
        private System.Windows.Forms.Label overGripLabel;
        private System.Windows.Forms.Label tennisBallsLabel;
        private System.Windows.Forms.TextBox stringsTextBox;
        private System.Windows.Forms.TextBox overGripTextBox;
        private System.Windows.Forms.TextBox tennisBallsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label realTotalLabel;
        private System.Windows.Forms.Label costTypeLabel;
        private System.Windows.Forms.Label blackBarLabel;
        private System.Windows.Forms.TextBox tenderedTextBox;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeTypeLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label centerReceiptTextLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label leftReceiptTextLabel;
        private System.Windows.Forms.Label rightReceiptTextLabel;
        private System.Windows.Forms.Label catchLabel;
    }
}


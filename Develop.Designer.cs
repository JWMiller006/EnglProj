namespace EnglProj
{
    partial class Develop
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Answers");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Questions");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Statements");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Develop));
            this.tabs = new System.Windows.Forms.TabControl();
            this.NewQuote = new System.Windows.Forms.TabPage();
            this.instuctions = new System.Windows.Forms.RichTextBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.TypeInput = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.displayNum = new System.Windows.Forms.Label();
            this.sentimentInput = new System.Windows.Forms.TrackBar();
            this.quoteBox = new System.Windows.Forms.RichTextBox();
            this.EnteredQuotes = new System.Windows.Forms.TabPage();
            this.quotesOut = new System.Windows.Forms.TreeView();
            this.tabs.SuspendLayout();
            this.NewQuote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentimentInput)).BeginInit();
            this.EnteredQuotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.NewQuote);
            this.tabs.Controls.Add(this.EnteredQuotes);
            this.tabs.Location = new System.Drawing.Point(9, 10);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(738, 516);
            this.tabs.TabIndex = 0;
            // 
            // NewQuote
            // 
            this.NewQuote.BackColor = System.Drawing.Color.Black;
            this.NewQuote.Controls.Add(this.instuctions);
            this.NewQuote.Controls.Add(this.typeLbl);
            this.NewQuote.Controls.Add(this.TypeInput);
            this.NewQuote.Controls.Add(this.addButton);
            this.NewQuote.Controls.Add(this.displayNum);
            this.NewQuote.Controls.Add(this.sentimentInput);
            this.NewQuote.Controls.Add(this.quoteBox);
            this.NewQuote.ForeColor = System.Drawing.SystemColors.Control;
            this.NewQuote.Location = new System.Drawing.Point(4, 22);
            this.NewQuote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewQuote.Name = "NewQuote";
            this.NewQuote.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewQuote.Size = new System.Drawing.Size(730, 490);
            this.NewQuote.TabIndex = 0;
            this.NewQuote.Text = "New Quote";
            // 
            // instuctions
            // 
            this.instuctions.BackColor = System.Drawing.Color.Black;
            this.instuctions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instuctions.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instuctions.ForeColor = System.Drawing.Color.Gainsboro;
            this.instuctions.Location = new System.Drawing.Point(118, 24);
            this.instuctions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instuctions.Name = "instuctions";
            this.instuctions.Size = new System.Drawing.Size(499, 106);
            this.instuctions.TabIndex = 12;
            this.instuctions.Text = "To add a quote, enter the quote and choose the sentiment. After that choose the t" +
    "ype of quote. The type of quote is as follows,\n1: Statement\n2: Question\n3: Answe" +
    "r";
            // 
            // typeLbl
            // 
            this.typeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLbl.AutoSize = true;
            this.typeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typeLbl.Location = new System.Drawing.Point(638, 452);
            this.typeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(82, 15);
            this.typeLbl.TabIndex = 11;
            this.typeLbl.Text = "Type of Quote";
            // 
            // TypeInput
            // 
            this.TypeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeInput.BackColor = System.Drawing.Color.DimGray;
            this.TypeInput.Location = new System.Drawing.Point(638, 470);
            this.TypeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeInput.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.TypeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TypeInput.Name = "TypeInput";
            this.TypeInput.Size = new System.Drawing.Size(90, 20);
            this.TypeInput.TabIndex = 10;
            this.TypeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(652, 5);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 36);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add Quote";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // displayNum
            // 
            this.displayNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.displayNum.AutoSize = true;
            this.displayNum.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNum.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.displayNum.Location = new System.Drawing.Point(320, 132);
            this.displayNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayNum.Name = "displayNum";
            this.displayNum.Size = new System.Drawing.Size(129, 20);
            this.displayNum.TabIndex = 8;
            this.displayNum.Text = "Sentiment: 0";
            // 
            // sentimentInput
            // 
            this.sentimentInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sentimentInput.Location = new System.Drawing.Point(233, 151);
            this.sentimentInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sentimentInput.Name = "sentimentInput";
            this.sentimentInput.Size = new System.Drawing.Size(262, 56);
            this.sentimentInput.TabIndex = 7;
            this.sentimentInput.Scroll += new System.EventHandler(this.sentimentInput_Scroll_1);
            // 
            // quoteBox
            // 
            this.quoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quoteBox.BackColor = System.Drawing.Color.DimGray;
            this.quoteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quoteBox.Location = new System.Drawing.Point(154, 202);
            this.quoteBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.Size = new System.Drawing.Size(426, 251);
            this.quoteBox.TabIndex = 6;
            this.quoteBox.Text = "";
            // 
            // EnteredQuotes
            // 
            this.EnteredQuotes.BackColor = System.Drawing.Color.Black;
            this.EnteredQuotes.Controls.Add(this.quotesOut);
            this.EnteredQuotes.Location = new System.Drawing.Point(4, 22);
            this.EnteredQuotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnteredQuotes.Name = "EnteredQuotes";
            this.EnteredQuotes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnteredQuotes.Size = new System.Drawing.Size(730, 490);
            this.EnteredQuotes.TabIndex = 1;
            this.EnteredQuotes.Text = "Entered Quotes";
            // 
            // quotesOut
            // 
            this.quotesOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quotesOut.BackColor = System.Drawing.Color.Black;
            this.quotesOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quotesOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotesOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.quotesOut.Location = new System.Drawing.Point(2, 48);
            this.quotesOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quotesOut.Name = "quotesOut";
            treeNode1.Name = "Answers";
            treeNode1.Text = "Answers";
            treeNode2.Name = "Questions";
            treeNode2.Text = "Questions";
            treeNode3.Name = "Statements";
            treeNode3.Text = "Statements";
            this.quotesOut.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.quotesOut.Size = new System.Drawing.Size(723, 440);
            this.quotesOut.TabIndex = 0;
            // 
            // Develop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(756, 535);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Develop";
            this.Text = "Develop";
            this.tabs.ResumeLayout(false);
            this.NewQuote.ResumeLayout(false);
            this.NewQuote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentimentInput)).EndInit();
            this.EnteredQuotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage NewQuote;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.NumericUpDown TypeInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label displayNum;
        private System.Windows.Forms.TrackBar sentimentInput;
        private System.Windows.Forms.RichTextBox quoteBox;
        private System.Windows.Forms.TabPage EnteredQuotes;
        private System.Windows.Forms.RichTextBox instuctions;
        private System.Windows.Forms.TreeView quotesOut;
    }
}
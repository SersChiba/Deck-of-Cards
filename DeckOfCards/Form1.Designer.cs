namespace DeckOfCards
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
            this.deck1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deck2 = new System.Windows.Forms.ListBox();
            this.resetDeck1 = new System.Windows.Forms.Button();
            this.resetDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deck1
            // 
            this.deck1.FormattingEnabled = true;
            this.deck1.Location = new System.Drawing.Point(13, 31);
            this.deck1.Name = "deck1";
            this.deck1.Size = new System.Drawing.Size(138, 290);
            this.deck1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deck #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deck #2";
            // 
            // deck2
            // 
            this.deck2.FormattingEnabled = true;
            this.deck2.Location = new System.Drawing.Point(209, 31);
            this.deck2.Name = "deck2";
            this.deck2.Size = new System.Drawing.Size(143, 290);
            this.deck2.TabIndex = 3;
            // 
            // resetDeck1
            // 
            this.resetDeck1.Location = new System.Drawing.Point(12, 337);
            this.resetDeck1.Name = "resetDeck1";
            this.resetDeck1.Size = new System.Drawing.Size(139, 23);
            this.resetDeck1.TabIndex = 4;
            this.resetDeck1.Text = "Reset Deck #1";
            this.resetDeck1.UseVisualStyleBackColor = true;
            this.resetDeck1.Click += new System.EventHandler(this.resetDeck1_Click);
            // 
            // resetDeck2
            // 
            this.resetDeck2.Location = new System.Drawing.Point(209, 337);
            this.resetDeck2.Name = "resetDeck2";
            this.resetDeck2.Size = new System.Drawing.Size(143, 23);
            this.resetDeck2.TabIndex = 5;
            this.resetDeck2.Text = "Reset Deck #2";
            this.resetDeck2.UseVisualStyleBackColor = true;
            this.resetDeck2.Click += new System.EventHandler(this.resetDeck2_Click);
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Location = new System.Drawing.Point(12, 366);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(139, 23);
            this.shuffleDeck1.TabIndex = 6;
            this.shuffleDeck1.Text = "Shuffle Deck #1";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            this.shuffleDeck1.Click += new System.EventHandler(this.shuffleDeck1_Click);
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Location = new System.Drawing.Point(209, 366);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(143, 23);
            this.shuffleDeck2.TabIndex = 7;
            this.shuffleDeck2.Text = "Shuffle Deck #2";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            this.shuffleDeck2.Click += new System.EventHandler(this.shuffleDeck2_Click);
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(158, 128);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(45, 23);
            this.moveToDeck2.TabIndex = 8;
            this.moveToDeck2.Text = "> >";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(158, 172);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(45, 23);
            this.moveToDeck1.TabIndex = 9;
            this.moveToDeck1.Text = "< <";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 401);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.resetDeck2);
            this.Controls.Add(this.resetDeck1);
            this.Controls.Add(this.deck2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deck1);
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deck1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox deck2;
        private System.Windows.Forms.Button resetDeck1;
        private System.Windows.Forms.Button resetDeck2;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.Button shuffleDeck2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
    }
}


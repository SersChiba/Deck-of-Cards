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
            this.reset1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.shuffle2 = new System.Windows.Forms.Button();
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
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(12, 337);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(139, 23);
            this.reset1.TabIndex = 4;
            this.reset1.Text = "Reset Deck #1";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(209, 337);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(143, 23);
            this.reset2.TabIndex = 5;
            this.reset2.Text = "Reset Deck #2";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // shuffle1
            // 
            this.shuffle1.Location = new System.Drawing.Point(12, 366);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(139, 23);
            this.shuffle1.TabIndex = 6;
            this.shuffle1.Text = "Shuffle Deck #1";
            this.shuffle1.UseVisualStyleBackColor = true;
            this.shuffle1.Click += new System.EventHandler(this.shuffle1_Click);
            // 
            // shuffle2
            // 
            this.shuffle2.Location = new System.Drawing.Point(209, 366);
            this.shuffle2.Name = "shuffle2";
            this.shuffle2.Size = new System.Drawing.Size(143, 23);
            this.shuffle2.TabIndex = 7;
            this.shuffle2.Text = "Shuffle Deck #2";
            this.shuffle2.UseVisualStyleBackColor = true;
            this.shuffle2.Click += new System.EventHandler(this.shuffle2_Click);
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
            this.Controls.Add(this.shuffle2);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.reset1);
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
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button shuffle2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
    }
}


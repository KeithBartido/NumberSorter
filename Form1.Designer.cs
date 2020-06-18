namespace SorterMidterms
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
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.binaryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.enterValueButton = new System.Windows.Forms.Button();
            this.binaryButton = new System.Windows.Forms.Button();
            this.bubbleButton = new System.Windows.Forms.Button();
            this.bubbleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueTextBox
            // 
            this.valueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.valueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.valueTextBox.Location = new System.Drawing.Point(32, 36);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(1223, 28);
            this.valueTextBox.TabIndex = 0;
            this.valueTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            this.valueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valueTextBox_KeyDown);
            this.valueTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.valueTextBox_KeyUp);
            // 
            // binaryRichTextBox
            // 
            this.binaryRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.binaryRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.binaryRichTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryRichTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.binaryRichTextBox.Location = new System.Drawing.Point(32, 167);
            this.binaryRichTextBox.Name = "binaryRichTextBox";
            this.binaryRichTextBox.ReadOnly = true;
            this.binaryRichTextBox.Size = new System.Drawing.Size(582, 450);
            this.binaryRichTextBox.TabIndex = 1;
            this.binaryRichTextBox.Text = "";
            // 
            // enterValueButton
            // 
            this.enterValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enterValueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterValueButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterValueButton.ForeColor = System.Drawing.Color.Aqua;
            this.enterValueButton.Location = new System.Drawing.Point(496, 82);
            this.enterValueButton.Name = "enterValueButton";
            this.enterValueButton.Size = new System.Drawing.Size(311, 34);
            this.enterValueButton.TabIndex = 2;
            this.enterValueButton.Text = "Enter values";
            this.enterValueButton.UseVisualStyleBackColor = false;
            this.enterValueButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // binaryButton
            // 
            this.binaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.binaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.binaryButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryButton.ForeColor = System.Drawing.Color.Aqua;
            this.binaryButton.Location = new System.Drawing.Point(228, 127);
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(187, 34);
            this.binaryButton.TabIndex = 3;
            this.binaryButton.Text = "Binary Insertion";
            this.binaryButton.UseVisualStyleBackColor = false;
            this.binaryButton.Click += new System.EventHandler(this.BinaryButton_Click);
            // 
            // bubbleButton
            // 
            this.bubbleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bubbleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bubbleButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleButton.ForeColor = System.Drawing.Color.Aqua;
            this.bubbleButton.Location = new System.Drawing.Point(876, 119);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(187, 34);
            this.bubbleButton.TabIndex = 4;
            this.bubbleButton.Text = "Bubbly Sort";
            this.bubbleButton.UseVisualStyleBackColor = false;
            this.bubbleButton.Click += new System.EventHandler(this.BubbleButton_Click);
            // 
            // bubbleRichTextBox
            // 
            this.bubbleRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bubbleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bubbleRichTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleRichTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.bubbleRichTextBox.Location = new System.Drawing.Point(680, 167);
            this.bubbleRichTextBox.Name = "bubbleRichTextBox";
            this.bubbleRichTextBox.ReadOnly = true;
            this.bubbleRichTextBox.Size = new System.Drawing.Size(575, 450);
            this.bubbleRichTextBox.TabIndex = 5;
            this.bubbleRichTextBox.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Aqua;
            this.exitButton.Location = new System.Drawing.Point(552, 635);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 34);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1283, 692);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bubbleRichTextBox);
            this.Controls.Add(this.bubbleButton);
            this.Controls.Add(this.binaryButton);
            this.Controls.Add(this.enterValueButton);
            this.Controls.Add(this.binaryRichTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.RichTextBox binaryRichTextBox;
        private System.Windows.Forms.Button enterValueButton;
        private System.Windows.Forms.Button binaryButton;
        private System.Windows.Forms.Button bubbleButton;
        private System.Windows.Forms.RichTextBox bubbleRichTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}


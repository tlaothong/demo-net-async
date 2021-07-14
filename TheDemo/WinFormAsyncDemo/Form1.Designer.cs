
namespace WinFormAsyncDemo
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
            this.CountNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.SyncDemoButton = new System.Windows.Forms.Button();
            this.AsyncDemoButton = new System.Windows.Forms.Button();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CountNumberUpDown
            // 
            this.CountNumberUpDown.Location = new System.Drawing.Point(12, 12);
            this.CountNumberUpDown.Name = "CountNumberUpDown";
            this.CountNumberUpDown.Size = new System.Drawing.Size(180, 31);
            this.CountNumberUpDown.TabIndex = 0;
            this.CountNumberUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SyncDemoButton
            // 
            this.SyncDemoButton.Location = new System.Drawing.Point(12, 49);
            this.SyncDemoButton.Name = "SyncDemoButton";
            this.SyncDemoButton.Size = new System.Drawing.Size(180, 34);
            this.SyncDemoButton.TabIndex = 1;
            this.SyncDemoButton.Text = "Sync Demo";
            this.SyncDemoButton.UseVisualStyleBackColor = true;
            this.SyncDemoButton.Click += new System.EventHandler(this.SyncDemoButton_Click);
            // 
            // AsyncDemoButton
            // 
            this.AsyncDemoButton.Location = new System.Drawing.Point(12, 89);
            this.AsyncDemoButton.Name = "AsyncDemoButton";
            this.AsyncDemoButton.Size = new System.Drawing.Size(180, 34);
            this.AsyncDemoButton.TabIndex = 2;
            this.AsyncDemoButton.Text = "Async Demo";
            this.AsyncDemoButton.UseVisualStyleBackColor = true;
            this.AsyncDemoButton.Click += new System.EventHandler(this.AsyncDemoButton_Click);
            // 
            // OutputListBox
            // 
            this.OutputListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 25;
            this.OutputListBox.Location = new System.Drawing.Point(222, 12);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(566, 429);
            this.OutputListBox.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(51, 404);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 34);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.AsyncDemoButton);
            this.Controls.Add(this.SyncDemoButton);
            this.Controls.Add(this.CountNumberUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CountNumberUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CountNumberUpDown;
        private System.Windows.Forms.Button SyncDemoButton;
        private System.Windows.Forms.Button AsyncDemoButton;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Button ClearButton;
    }
}


﻿namespace Q3
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.calcButton = new System.Windows.Forms.Button();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// calcButton
			// 
			this.calcButton.Location = new System.Drawing.Point(480, 102);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(75, 23);
			this.calcButton.TabIndex = 0;
			this.calcButton.Text = "判斷";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(246, 102);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(187, 22);
			this.inputTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(111, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "請輸入生日";
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(351, 184);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(33, 12);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 282);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.calcButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label resultLabel;
	}
}


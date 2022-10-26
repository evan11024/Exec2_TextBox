namespace Q1
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
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.answerLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.enterButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(64, 62);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(108, 22);
			this.inputTextBox.TabIndex = 0;
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.answerLabel.Location = new System.Drawing.Point(304, 139);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(56, 24);
			this.answerLabel.TabIndex = 1;
			this.answerLabel.Text = "是/否";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(220, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "是否介於1,99之間";
			// 
			// enterButton
			// 
			this.enterButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.enterButton.Location = new System.Drawing.Point(407, 60);
			this.enterButton.Name = "enterButton";
			this.enterButton.Size = new System.Drawing.Size(75, 23);
			this.enterButton.TabIndex = 3;
			this.enterButton.Text = "輸入";
			this.enterButton.UseVisualStyleBackColor = true;
			this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 344);
			this.Controls.Add(this.enterButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.inputTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button enterButton;
	}
}


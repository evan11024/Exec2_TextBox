namespace Q4
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.peopleTextBox = new System.Windows.Forms.TextBox();
			this.carTextBox = new System.Windows.Forms.TextBox();
			this.caluButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(62, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(263, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "車輛數";
			// 
			// peopleTextBox
			// 
			this.peopleTextBox.Location = new System.Drawing.Point(122, 61);
			this.peopleTextBox.Name = "peopleTextBox";
			this.peopleTextBox.Size = new System.Drawing.Size(100, 22);
			this.peopleTextBox.TabIndex = 2;
			// 
			// carTextBox
			// 
			this.carTextBox.Location = new System.Drawing.Point(353, 61);
			this.carTextBox.Name = "carTextBox";
			this.carTextBox.Size = new System.Drawing.Size(100, 22);
			this.carTextBox.TabIndex = 3;
			// 
			// caluButton
			// 
			this.caluButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.caluButton.Location = new System.Drawing.Point(366, 124);
			this.caluButton.Name = "caluButton";
			this.caluButton.Size = new System.Drawing.Size(87, 32);
			this.caluButton.TabIndex = 4;
			this.caluButton.Text = "計算";
			this.caluButton.UseVisualStyleBackColor = true;
			this.caluButton.Click += new System.EventHandler(this.caluButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(88, 197);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(350, 231);
			this.resultLabel.TabIndex = 5;
			this.resultLabel.Text = "label3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 471);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.caluButton);
			this.Controls.Add(this.carTextBox);
			this.Controls.Add(this.peopleTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = " ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox peopleTextBox;
		private System.Windows.Forms.TextBox carTextBox;
		private System.Windows.Forms.Button caluButton;
		private System.Windows.Forms.Label resultLabel;
	}
}


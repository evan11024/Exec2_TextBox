namespace Q2
{
	partial class Form2
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
			this.inputTextbox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputTextbox
			// 
			this.inputTextbox.Location = new System.Drawing.Point(116, 85);
			this.inputTextbox.Name = "inputTextbox";
			this.inputTextbox.Size = new System.Drawing.Size(175, 22);
			this.inputTextbox.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(364, 83);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "判斷";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(272, 165);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(54, 20);
			this.resultLabel.TabIndex = 2;
			this.resultLabel.Text = "label1";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 261);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.inputTextbox);
			this.Name = "Form2";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputTextbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label resultLabel;
	}
}


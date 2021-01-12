namespace Prime
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnIsPrime = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnPrimes = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNum.Location = new System.Drawing.Point(12, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 27);
            this.txtNum.TabIndex = 0;
            this.txtNum.Text = "0";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIsPrime
            // 
            this.btnIsPrime.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnIsPrime.Location = new System.Drawing.Point(118, 14);
            this.btnIsPrime.Name = "btnIsPrime";
            this.btnIsPrime.Size = new System.Drawing.Size(75, 23);
            this.btnIsPrime.TabIndex = 1;
            this.btnIsPrime.Text = "素数？";
            this.btnIsPrime.UseVisualStyleBackColor = true;
            this.btnIsPrime.Click += new System.EventHandler(this.btnIsPrime_Click);
            // 
            // txtOut
            // 
            this.txtOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOut.Location = new System.Drawing.Point(12, 45);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(460, 273);
            this.txtOut.TabIndex = 3;
            // 
            // btnPrimes
            // 
            this.btnPrimes.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrimes.Location = new System.Drawing.Point(199, 14);
            this.btnPrimes.Name = "btnPrimes";
            this.btnPrimes.Size = new System.Drawing.Size(96, 23);
            this.btnPrimes.TabIndex = 2;
            this.btnPrimes.Text = "すべての素数";
            this.btnPrimes.UseVisualStyleBackColor = true;
            this.btnPrimes.Click += new System.EventHandler(this.btnPrimes_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(301, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 19);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 333);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnPrimes);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnIsPrime);
            this.Controls.Add(this.txtNum);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnIsPrime;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnPrimes;
        private System.Windows.Forms.Label lblTime;
    }
}


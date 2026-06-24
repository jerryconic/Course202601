namespace Ap11
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
            this.grpGuess = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGuess
            // 
            this.grpGuess.Controls.Add(this.txtGuess);
            this.grpGuess.Controls.Add(this.label1);
            this.grpGuess.Location = new System.Drawing.Point(41, 29);
            this.grpGuess.Name = "grpGuess";
            this.grpGuess.Size = new System.Drawing.Size(234, 83);
            this.grpGuess.TabIndex = 0;
            this.grpGuess.TabStop = false;
            this.grpGuess.Text = " 猜數字";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1-99";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(87, 28);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(95, 25);
            this.txtGuess.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(41, 130);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(128, 130);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(64, 31);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "猜";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(211, 130);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(64, 31);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "結束";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 190);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpGuess);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGuess.ResumeLayout(false);
            this.grpGuess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnQuit;
    }
}


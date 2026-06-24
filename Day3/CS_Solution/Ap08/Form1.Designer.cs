namespace Ap08
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
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Location = new System.Drawing.Point(26, 31);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(133, 125);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 0;
            this.pct1.TabStop = false;
            // 
            // pct2
            // 
            this.pct2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct2.Location = new System.Drawing.Point(165, 31);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(133, 125);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct2.TabIndex = 1;
            this.pct2.TabStop = false;
            // 
            // pct3
            // 
            this.pct3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct3.Location = new System.Drawing.Point(304, 31);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(133, 125);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct3.TabIndex = 2;
            this.pct3.TabStop = false;
            // 
            // pct4
            // 
            this.pct4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct4.Location = new System.Drawing.Point(443, 31);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(133, 125);
            this.pct4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct4.TabIndex = 3;
            this.pct4.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(449, 178);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(126, 41);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(596, 288);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pct4);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.PictureBox pct4;
        private System.Windows.Forms.Button btnRoll;
    }
}


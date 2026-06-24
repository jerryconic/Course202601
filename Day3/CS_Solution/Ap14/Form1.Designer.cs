namespace Ap14
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.BackColor = System.Drawing.Color.White;
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Location = new System.Drawing.Point(17, 18);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(497, 356);
            this.pct1.TabIndex = 0;
            this.pct1.TabStop = false;
            this.pct1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseDown);
            this.pct1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseMove);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(17, 380);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(497, 25);
            this.txtData.TabIndex = 1;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(530, 23);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(139, 32);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rectangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(530, 99);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(139, 32);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 509);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.pct1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEllipse;
    }
}


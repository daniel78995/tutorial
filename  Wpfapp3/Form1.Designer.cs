namespace Picture
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.btnS = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnN = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(468, 423);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(64, 23);
            this.btnS.TabIndex = 14;
            this.btnS.Text = "縮小";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(263, 427);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(33, 12);
            this.lblNo.TabIndex = 13;
            this.lblNo.Text = "label1";
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(302, 422);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(64, 23);
            this.btnN.TabIndex = 12;
            this.btnN.Text = "下一張";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(193, 423);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(64, 23);
            this.btnP.TabIndex = 11;
            this.btnP.Text = "上一張";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // picShow
            // 
            this.picShow.Location = new System.Drawing.Point(16, 13);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(642, 404);
            this.picShow.TabIndex = 10;
            this.picShow.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 423);
            this.button1.Name = "btnB";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "放大";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.picShow);
            this.Name = "Form1";
            this.Text = "電子書";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Button button1;
    }
}


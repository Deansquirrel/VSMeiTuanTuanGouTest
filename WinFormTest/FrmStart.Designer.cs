namespace WinFormTest
{
    partial class FrmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labToken = new System.Windows.Forms.Label();
            this.labCharset = new System.Windows.Forms.Label();
            this.textBoxCharSet = new System.Windows.Forms.TextBox();
            this.textBoxTimestamp = new System.Windows.Forms.TextBox();
            this.labTimestamp = new System.Windows.Forms.Label();
            this.btnRefreshTimestamp = new System.Windows.Forms.Button();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.labVersion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCouponCode = new System.Windows.Forms.Label();
            this.textBoxCouponCode = new System.Windows.Forms.TextBox();
            this.btnCheckPre = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBusinessId = new System.Windows.Forms.TextBox();
            this.textBoxEPoiId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.textBoxDeveloperId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEPoiName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(142, 34);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(189, 21);
            this.textBoxToken.TabIndex = 0;
            // 
            // labToken
            // 
            this.labToken.AutoSize = true;
            this.labToken.Location = new System.Drawing.Point(58, 37);
            this.labToken.Name = "labToken";
            this.labToken.Size = new System.Drawing.Size(77, 12);
            this.labToken.TabIndex = 1;
            this.labToken.Text = "appAuthToken";
            // 
            // labCharset
            // 
            this.labCharset.AutoSize = true;
            this.labCharset.Location = new System.Drawing.Point(337, 37);
            this.labCharset.Name = "labCharset";
            this.labCharset.Size = new System.Drawing.Size(47, 12);
            this.labCharset.TabIndex = 2;
            this.labCharset.Text = "charset";
            // 
            // textBoxCharSet
            // 
            this.textBoxCharSet.Location = new System.Drawing.Point(398, 34);
            this.textBoxCharSet.Name = "textBoxCharSet";
            this.textBoxCharSet.Size = new System.Drawing.Size(62, 21);
            this.textBoxCharSet.TabIndex = 3;
            // 
            // textBoxTimestamp
            // 
            this.textBoxTimestamp.Location = new System.Drawing.Point(553, 33);
            this.textBoxTimestamp.Name = "textBoxTimestamp";
            this.textBoxTimestamp.Size = new System.Drawing.Size(100, 21);
            this.textBoxTimestamp.TabIndex = 5;
            // 
            // labTimestamp
            // 
            this.labTimestamp.AutoSize = true;
            this.labTimestamp.Location = new System.Drawing.Point(484, 37);
            this.labTimestamp.Name = "labTimestamp";
            this.labTimestamp.Size = new System.Drawing.Size(59, 12);
            this.labTimestamp.TabIndex = 4;
            this.labTimestamp.Text = "timestamp";
            // 
            // btnRefreshTimestamp
            // 
            this.btnRefreshTimestamp.Location = new System.Drawing.Point(666, 32);
            this.btnRefreshTimestamp.Name = "btnRefreshTimestamp";
            this.btnRefreshTimestamp.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTimestamp.TabIndex = 6;
            this.btnRefreshTimestamp.Text = "Refresh";
            this.btnRefreshTimestamp.UseVisualStyleBackColor = true;
            this.btnRefreshTimestamp.Click += new System.EventHandler(this.BtnRefreshTimestamp_Click);
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(835, 32);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(35, 21);
            this.textBoxVersion.TabIndex = 8;
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.Location = new System.Drawing.Point(775, 36);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(47, 12);
            this.labVersion.TabIndex = 7;
            this.labVersion.Text = "Version";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(16, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(950, 2);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // labelCouponCode
            // 
            this.labelCouponCode.AutoSize = true;
            this.labelCouponCode.Location = new System.Drawing.Point(60, 156);
            this.labelCouponCode.Name = "labelCouponCode";
            this.labelCouponCode.Size = new System.Drawing.Size(65, 12);
            this.labelCouponCode.TabIndex = 12;
            this.labelCouponCode.Text = "couponCode";
            // 
            // textBoxCouponCode
            // 
            this.textBoxCouponCode.Location = new System.Drawing.Point(132, 152);
            this.textBoxCouponCode.Name = "textBoxCouponCode";
            this.textBoxCouponCode.Size = new System.Drawing.Size(141, 21);
            this.textBoxCouponCode.TabIndex = 13;
            // 
            // btnCheckPre
            // 
            this.btnCheckPre.Location = new System.Drawing.Point(279, 151);
            this.btnCheckPre.Name = "btnCheckPre";
            this.btnCheckPre.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPre.TabIndex = 14;
            this.btnCheckPre.Text = "CheckPre";
            this.btnCheckPre.UseVisualStyleBackColor = true;
            this.btnCheckPre.Click += new System.EventHandler(this.BtnCheckPre_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(368, 150);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(633, 150);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(89, 23);
            this.btnTest.TabIndex = 16;
            this.btnTest.Text = "门店授权映射";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(603, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 395);
            this.label1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "businessId";
            // 
            // textBoxBusinessId
            // 
            this.textBoxBusinessId.Location = new System.Drawing.Point(705, 243);
            this.textBoxBusinessId.Name = "textBoxBusinessId";
            this.textBoxBusinessId.Size = new System.Drawing.Size(261, 21);
            this.textBoxBusinessId.TabIndex = 19;
            // 
            // textBoxEPoiId
            // 
            this.textBoxEPoiId.Location = new System.Drawing.Point(705, 287);
            this.textBoxEPoiId.Name = "textBoxEPoiId";
            this.textBoxEPoiId.Size = new System.Drawing.Size(261, 21);
            this.textBoxEPoiId.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "ePoiId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "link";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(705, 408);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(261, 21);
            this.textBoxLink.TabIndex = 23;
            // 
            // textBoxDeveloperId
            // 
            this.textBoxDeveloperId.Location = new System.Drawing.Point(705, 201);
            this.textBoxDeveloperId.Name = "textBoxDeveloperId";
            this.textBoxDeveloperId.Size = new System.Drawing.Size(261, 21);
            this.textBoxDeveloperId.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "developerId";
            // 
            // textBoxEPoiName
            // 
            this.textBoxEPoiName.Location = new System.Drawing.Point(705, 332);
            this.textBoxEPoiName.Name = "textBoxEPoiName";
            this.textBoxEPoiName.Size = new System.Drawing.Size(261, 21);
            this.textBoxEPoiName.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "ePoiName";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // labResult
            // 
            this.labResult.Location = new System.Drawing.Point(55, 195);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(500, 323);
            this.labResult.TabIndex = 29;
            this.labResult.Text = "labResult";
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxEPoiName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDeveloperId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEPoiId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBusinessId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCheckPre);
            this.Controls.Add(this.textBoxCouponCode);
            this.Controls.Add(this.labelCouponCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.labVersion);
            this.Controls.Add(this.btnRefreshTimestamp);
            this.Controls.Add(this.textBoxTimestamp);
            this.Controls.Add(this.labTimestamp);
            this.Controls.Add(this.textBoxCharSet);
            this.Controls.Add(this.labCharset);
            this.Controls.Add(this.labToken);
            this.Controls.Add(this.textBoxToken);
            this.Name = "FrmStart";
            this.Text = "FrmStart";
            this.Activated += new System.EventHandler(this.FrmStart_Activated);
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label labToken;
        private System.Windows.Forms.Label labCharset;
        private System.Windows.Forms.TextBox textBoxCharSet;
        private System.Windows.Forms.TextBox textBoxTimestamp;
        private System.Windows.Forms.Label labTimestamp;
        private System.Windows.Forms.Button btnRefreshTimestamp;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label labVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCouponCode;
        private System.Windows.Forms.TextBox textBoxCouponCode;
        private System.Windows.Forms.Button btnCheckPre;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBusinessId;
        private System.Windows.Forms.TextBox textBoxEPoiId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.TextBox textBoxDeveloperId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEPoiName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labResult;
    }
}
namespace TwitterAwayZwei
{
    partial class AboutForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.versionNumberLabel = new System.Windows.Forms.Label();
            this.applicationNameLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // copyrightLabel
            // 
            resources.ApplyResources(this.copyrightLabel, "copyrightLabel");
            this.copyrightLabel.Name = "copyrightLabel";
            // 
            // versionNumberLabel
            // 
            resources.ApplyResources(this.versionNumberLabel, "versionNumberLabel");
            this.versionNumberLabel.Name = "versionNumberLabel";
            // 
            // applicationNameLabel
            // 
            resources.ApplyResources(this.applicationNameLabel, "applicationNameLabel");
            this.applicationNameLabel.Name = "applicationNameLabel";
            // 
            // iconPictureBox
            // 
            resources.ApplyResources(this.iconPictureBox, "iconPictureBox");
            this.iconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox.Name = "iconPictureBox";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.versionNumberLabel);
            this.Controls.Add(this.applicationNameLabel);
            this.Name = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label versionNumberLabel;
        private System.Windows.Forms.Label applicationNameLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
    }
}
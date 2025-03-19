namespace VisualBinaryEditor.Update
{
    partial class UpdateCheckedResultDialog
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
            resultLabel = new System.Windows.Forms.Label();
            currentVersionLabel = new System.Windows.Forms.Label();
            officialVersionLabel = new System.Windows.Forms.Label();
            preReleaseVersionLabel = new System.Windows.Forms.Label();
            downloadLabel = new System.Windows.Forms.Label();
            downloadPreReleaseVersionButton = new System.Windows.Forms.Button();
            downloadOfficalVersionButton = new System.Windows.Forms.Button();
            preReleaseWarningLabel = new System.Windows.Forms.Label();
            closeButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(16, 16);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(201, 23);
            resultLabel.TabIndex = 0;
            resultLabel.Text = "アップデートが見つかりました。";
            // 
            // currentVersionLabel
            // 
            currentVersionLabel.AutoSize = true;
            currentVersionLabel.Location = new System.Drawing.Point(48, 60);
            currentVersionLabel.Name = "currentVersionLabel";
            currentVersionLabel.Size = new System.Drawing.Size(129, 23);
            currentVersionLabel.TabIndex = 1;
            currentVersionLabel.Text = "現在のバージョン: ";
            // 
            // officialVersionLabel
            // 
            officialVersionLabel.AutoSize = true;
            officialVersionLabel.Location = new System.Drawing.Point(48, 100);
            officialVersionLabel.Name = "officialVersionLabel";
            officialVersionLabel.Size = new System.Drawing.Size(225, 23);
            officialVersionLabel.TabIndex = 2;
            officialVersionLabel.Text = "最新の正式リリースのバージョン: ";
            // 
            // preReleaseVersionLabel
            // 
            preReleaseVersionLabel.AutoSize = true;
            preReleaseVersionLabel.Location = new System.Drawing.Point(48, 130);
            preReleaseVersionLabel.Name = "preReleaseVersionLabel";
            preReleaseVersionLabel.Size = new System.Drawing.Size(215, 23);
            preReleaseVersionLabel.TabIndex = 3;
            preReleaseVersionLabel.Text = "最新のプレリリースのバージョン: ";
            // 
            // downloadLabel
            // 
            downloadLabel.AutoSize = true;
            downloadLabel.Location = new System.Drawing.Point(16, 180);
            downloadLabel.Name = "downloadLabel";
            downloadLabel.Size = new System.Drawing.Size(252, 23);
            downloadLabel.TabIndex = 4;
            downloadLabel.Text = "アップデートのダウンロードページを開く:";
            // 
            // downloadPreReleaseVersionButton
            // 
            downloadPreReleaseVersionButton.Enabled = false;
            downloadPreReleaseVersionButton.Location = new System.Drawing.Point(137, 210);
            downloadPreReleaseVersionButton.Name = "downloadPreReleaseVersionButton";
            downloadPreReleaseVersionButton.Size = new System.Drawing.Size(100, 30);
            downloadPreReleaseVersionButton.TabIndex = 5;
            downloadPreReleaseVersionButton.Text = "プレリリース";
            downloadPreReleaseVersionButton.UseVisualStyleBackColor = true;
            downloadPreReleaseVersionButton.Click += downloadPreReleaseVersionButton_Click;
            // 
            // downloadOfficalVersionButton
            // 
            downloadOfficalVersionButton.Enabled = false;
            downloadOfficalVersionButton.Location = new System.Drawing.Point(337, 210);
            downloadOfficalVersionButton.Name = "downloadOfficalVersionButton";
            downloadOfficalVersionButton.Size = new System.Drawing.Size(100, 30);
            downloadOfficalVersionButton.TabIndex = 6;
            downloadOfficalVersionButton.Text = "正式リリース";
            downloadOfficalVersionButton.UseVisualStyleBackColor = true;
            downloadOfficalVersionButton.Click += downloadOfficalVersionButton_Click;
            // 
            // preReleaseWarningLabel
            // 
            preReleaseWarningLabel.AutoSize = true;
            preReleaseWarningLabel.ForeColor = System.Drawing.Color.Red;
            preReleaseWarningLabel.Location = new System.Drawing.Point(16, 250);
            preReleaseWarningLabel.Name = "preReleaseWarningLabel";
            preReleaseWarningLabel.Size = new System.Drawing.Size(536, 23);
            preReleaseWarningLabel.TabIndex = 7;
            preReleaseWarningLabel.Text = "※ プレリリース版は開発中のものであり、安定版ではないことに注意して下さい。";
            // 
            // closeButton
            // 
            closeButton.Location = new System.Drawing.Point(244, 300);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(87, 30);
            closeButton.TabIndex = 8;
            closeButton.Text = "閉じる";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.GrayText;
            label1.Location = new System.Drawing.Point(274, 180);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(197, 23);
            label1.TabIndex = 9;
            label1.Text = "(GitHubのページを開きます)";
            // 
            // UpdateCheckedResultDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new System.Drawing.Size(574, 353);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(preReleaseWarningLabel);
            Controls.Add(downloadOfficalVersionButton);
            Controls.Add(downloadPreReleaseVersionButton);
            Controls.Add(downloadLabel);
            Controls.Add(preReleaseVersionLabel);
            Controls.Add(officialVersionLabel);
            Controls.Add(currentVersionLabel);
            Controls.Add(resultLabel);
            Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateCheckedResultDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "アップデートを確認";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label currentVersionLabel;
        private System.Windows.Forms.Label officialVersionLabel;
        private System.Windows.Forms.Label preReleaseVersionLabel;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.Button downloadPreReleaseVersionButton;
        private System.Windows.Forms.Button downloadOfficalVersionButton;
        private System.Windows.Forms.Label preReleaseWarningLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
    }
}
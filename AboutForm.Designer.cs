namespace VisualBinaryEditor
{
    partial class AboutForm
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
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            gitHubLabel = new System.Windows.Forms.Label();
            gitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            closeButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
            titleLabel.Location = new System.Drawing.Point(138, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(187, 28);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Visual Binary Editor";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 85);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(446, 46);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "System.IO.BinaryWriterによるバイナリファイルの作成を視覚的に\r\n行うことを目的としたソフトウェアです。";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(180, 43);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(102, 23);
            versionLabel.TabIndex = 2;
            versionLabel.Text = "v0.1.0-alpha";
            // 
            // gitHubLabel
            // 
            gitHubLabel.AutoSize = true;
            gitHubLabel.Location = new System.Drawing.Point(20, 140);
            gitHubLabel.Name = "gitHubLabel";
            gitHubLabel.Size = new System.Drawing.Size(68, 23);
            gitHubLabel.TabIndex = 3;
            gitHubLabel.Text = "GitHub:";
            // 
            // gitHubLinkLabel
            // 
            gitHubLinkLabel.AutoSize = true;
            gitHubLinkLabel.Location = new System.Drawing.Point(89, 140);
            gitHubLinkLabel.Name = "gitHubLinkLabel";
            gitHubLinkLabel.Size = new System.Drawing.Size(353, 23);
            gitHubLinkLabel.TabIndex = 4;
            gitHubLinkLabel.TabStop = true;
            gitHubLinkLabel.Text = "https://github.com/Nil256/VisualBinaryEditor";
            gitHubLinkLabel.LinkClicked += gitHubLinkLabel_LinkClicked;
            // 
            // closeButton
            // 
            closeButton.Location = new System.Drawing.Point(187, 181);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(88, 30);
            closeButton.TabIndex = 5;
            closeButton.Text = "閉じる";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(462, 223);
            Controls.Add(closeButton);
            Controls.Add(gitHubLinkLabel);
            Controls.Add(gitHubLabel);
            Controls.Add(versionLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Visual Binary Editorについて";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label gitHubLabel;
        private System.Windows.Forms.LinkLabel gitHubLinkLabel;
        private System.Windows.Forms.Button closeButton;
    }
}
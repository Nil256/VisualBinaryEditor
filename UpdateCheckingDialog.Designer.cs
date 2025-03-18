namespace VisualBinaryEditor
{
    partial class UpdateCheckingDialog
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
            progressBar = new System.Windows.Forms.ProgressBar();
            label = new System.Windows.Forms.Label();
            button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(12, 42);
            progressBar.MarqueeAnimationSpeed = 10;
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(358, 32);
            progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBar.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(12, 16);
            label.Name = "label";
            label.Size = new System.Drawing.Size(158, 23);
            label.TabIndex = 1;
            label.Text = "アップデートを確認中...";
            // 
            // button
            // 
            button.Location = new System.Drawing.Point(142, 88);
            button.Name = "button";
            button.Size = new System.Drawing.Size(98, 28);
            button.TabIndex = 2;
            button.Text = "キャンセル";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // UpdateCheckingDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = button;
            ClientSize = new System.Drawing.Size(382, 128);
            Controls.Add(button);
            Controls.Add(label);
            Controls.Add(progressBar);
            Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateCheckingDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "アップデートを確認";
            Load += UpdateCheckingDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button;
    }
}
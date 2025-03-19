namespace VisualBinaryEditor.Update.Result
{
    partial class NoUpdateDialog
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
            label = new System.Windows.Forms.Label();
            button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(27, 16);
            label.Name = "label";
            label.Size = new System.Drawing.Size(169, 23);
            label.TabIndex = 0;
            label.Text = "ソフトウェアは最新です。";
            // 
            // button
            // 
            button.Location = new System.Drawing.Point(72, 46);
            button.Name = "button";
            button.Size = new System.Drawing.Size(78, 30);
            button.TabIndex = 1;
            button.Text = "閉じる";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // NoUpdateDialog
            // 
            AcceptButton = button;
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = button;
            ClientSize = new System.Drawing.Size(222, 88);
            Controls.Add(button);
            Controls.Add(label);
            Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NoUpdateDialog";
            Text = "アップデートを確認";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button;
    }
}
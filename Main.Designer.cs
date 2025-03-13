using System.Drawing;
using System.Windows.Forms;

namespace VisualBinaryEditor
{
    partial class Main
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
            boolButton = new Button();
            binaryOrderPanel = new Panel();
            menuStrip = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            バイナリオーダーToolStripMenuItem = new ToolStripMenuItem();
            ヘルプToolStripMenuItem = new ToolStripMenuItem();
            addLabel = new Label();
            byteButton = new Button();
            sbyteButton = new Button();
            shortButton = new Button();
            ushortButton = new Button();
            intButton = new Button();
            uintButton = new Button();
            longButton = new Button();
            ulongButton = new Button();
            floatButton = new Button();
            doubleButton = new Button();
            decimalButton = new Button();
            moveLabel = new Label();
            upButton = new Button();
            downButton = new Button();
            deleteLabel = new Label();
            deleteButton = new Button();
            stringButton = new Button();
            charButton = new Button();
            statusStrip1 = new StatusStrip();
            debugLabel = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // boolButton
            // 
            boolButton.Location = new Point(834, 249);
            boolButton.Name = "boolButton";
            boolButton.Size = new Size(96, 30);
            boolButton.TabIndex = 0;
            boolButton.Text = "bool";
            boolButton.UseVisualStyleBackColor = true;
            boolButton.Click += boolButton_Click;
            // 
            // binaryOrderPanel
            // 
            binaryOrderPanel.AutoScroll = true;
            binaryOrderPanel.BackColor = SystemColors.ControlLight;
            binaryOrderPanel.BorderStyle = BorderStyle.FixedSingle;
            binaryOrderPanel.Location = new Point(10, 38);
            binaryOrderPanel.Name = "binaryOrderPanel";
            binaryOrderPanel.Size = new Size(710, 424);
            binaryOrderPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, バイナリオーダーToolStripMenuItem, ヘルプToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(942, 28);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "Menu";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 保存ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(65, 24);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(122, 26);
            保存ToolStripMenuItem.Text = "保存";
            // 
            // バイナリオーダーToolStripMenuItem
            // 
            バイナリオーダーToolStripMenuItem.Name = "バイナリオーダーToolStripMenuItem";
            バイナリオーダーToolStripMenuItem.Size = new Size(111, 24);
            バイナリオーダーToolStripMenuItem.Text = "バイナリオーダー";
            // 
            // ヘルプToolStripMenuItem
            // 
            ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            ヘルプToolStripMenuItem.Size = new Size(58, 24);
            ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Location = new Point(732, 38);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(44, 23);
            addLabel.TabIndex = 3;
            addLabel.Text = "追加";
            // 
            // byteButton
            // 
            byteButton.Location = new Point(732, 69);
            byteButton.Name = "byteButton";
            byteButton.Size = new Size(96, 30);
            byteButton.TabIndex = 5;
            byteButton.Text = "byte";
            byteButton.UseVisualStyleBackColor = true;
            byteButton.Click += byteButton_Click;
            // 
            // sbyteButton
            // 
            sbyteButton.Location = new Point(834, 69);
            sbyteButton.Name = "sbyteButton";
            sbyteButton.Size = new Size(96, 30);
            sbyteButton.TabIndex = 6;
            sbyteButton.Text = "sbyte";
            sbyteButton.UseVisualStyleBackColor = true;
            sbyteButton.Click += sbyteButton_Click;
            // 
            // shortButton
            // 
            shortButton.Location = new Point(732, 105);
            shortButton.Name = "shortButton";
            shortButton.Size = new Size(96, 30);
            shortButton.TabIndex = 7;
            shortButton.Text = "short";
            shortButton.UseVisualStyleBackColor = true;
            shortButton.Click += shortButton_Click;
            // 
            // ushortButton
            // 
            ushortButton.Location = new Point(834, 105);
            ushortButton.Name = "ushortButton";
            ushortButton.Size = new Size(96, 30);
            ushortButton.TabIndex = 8;
            ushortButton.Text = "ushort";
            ushortButton.UseVisualStyleBackColor = true;
            ushortButton.Click += ushortButton_Click;
            // 
            // intButton
            // 
            intButton.Location = new Point(732, 141);
            intButton.Name = "intButton";
            intButton.Size = new Size(96, 30);
            intButton.TabIndex = 9;
            intButton.Text = "int";
            intButton.UseVisualStyleBackColor = true;
            intButton.Click += intButton_Click;
            // 
            // uintButton
            // 
            uintButton.Location = new Point(834, 141);
            uintButton.Name = "uintButton";
            uintButton.Size = new Size(96, 30);
            uintButton.TabIndex = 10;
            uintButton.Text = "uint";
            uintButton.UseVisualStyleBackColor = true;
            uintButton.Click += uintButton_Click;
            // 
            // longButton
            // 
            longButton.Location = new Point(732, 177);
            longButton.Name = "longButton";
            longButton.Size = new Size(96, 30);
            longButton.TabIndex = 11;
            longButton.Text = "long";
            longButton.UseVisualStyleBackColor = true;
            longButton.Click += longButton_Click;
            // 
            // ulongButton
            // 
            ulongButton.Location = new Point(834, 177);
            ulongButton.Name = "ulongButton";
            ulongButton.Size = new Size(96, 30);
            ulongButton.TabIndex = 12;
            ulongButton.Text = "ulong";
            ulongButton.UseVisualStyleBackColor = true;
            ulongButton.Click += ulongButton_Click;
            // 
            // floatButton
            // 
            floatButton.Enabled = false;
            floatButton.Location = new Point(732, 213);
            floatButton.Name = "floatButton";
            floatButton.Size = new Size(96, 30);
            floatButton.TabIndex = 13;
            floatButton.Text = "float";
            floatButton.UseVisualStyleBackColor = true;
            // 
            // doubleButton
            // 
            doubleButton.Enabled = false;
            doubleButton.Location = new Point(834, 213);
            doubleButton.Name = "doubleButton";
            doubleButton.Size = new Size(96, 30);
            doubleButton.TabIndex = 14;
            doubleButton.Text = "double";
            doubleButton.UseVisualStyleBackColor = true;
            // 
            // decimalButton
            // 
            decimalButton.Enabled = false;
            decimalButton.Location = new Point(732, 249);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(96, 30);
            decimalButton.TabIndex = 15;
            decimalButton.Text = "decimal";
            decimalButton.UseVisualStyleBackColor = true;
            // 
            // moveLabel
            // 
            moveLabel.AutoSize = true;
            moveLabel.Location = new Point(732, 327);
            moveLabel.Name = "moveLabel";
            moveLabel.Size = new Size(44, 23);
            moveLabel.TabIndex = 16;
            moveLabel.Text = "移動";
            // 
            // upButton
            // 
            upButton.Location = new Point(732, 353);
            upButton.Name = "upButton";
            upButton.Size = new Size(40, 40);
            upButton.TabIndex = 17;
            upButton.Text = "↑";
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // downButton
            // 
            downButton.Location = new Point(778, 353);
            downButton.Name = "downButton";
            downButton.Size = new Size(40, 40);
            downButton.TabIndex = 18;
            downButton.Text = "↓";
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += downButton_Click;
            // 
            // deleteLabel
            // 
            deleteLabel.AutoSize = true;
            deleteLabel.Location = new Point(732, 406);
            deleteLabel.Name = "deleteLabel";
            deleteLabel.Size = new Size(44, 23);
            deleteLabel.TabIndex = 19;
            deleteLabel.Text = "削除";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(732, 432);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(96, 30);
            deleteButton.TabIndex = 20;
            deleteButton.Text = "削除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // stringButton
            // 
            stringButton.Enabled = false;
            stringButton.Location = new Point(834, 285);
            stringButton.Name = "stringButton";
            stringButton.Size = new Size(96, 30);
            stringButton.TabIndex = 21;
            stringButton.Text = "string";
            stringButton.UseVisualStyleBackColor = true;
            // 
            // charButton
            // 
            charButton.Enabled = false;
            charButton.Location = new Point(732, 285);
            charButton.Name = "charButton";
            charButton.Size = new Size(96, 30);
            charButton.TabIndex = 22;
            charButton.Text = "char";
            charButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { debugLabel });
            statusStrip1.Location = new Point(0, 467);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(942, 26);
            statusStrip1.TabIndex = 23;
            statusStrip1.Text = "statusStrip1";
            // 
            // debugLabel
            // 
            debugLabel.Name = "debugLabel";
            debugLabel.Size = new Size(151, 20);
            debugLabel.Text = "toolStripStatusLabel1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(statusStrip1);
            Controls.Add(charButton);
            Controls.Add(stringButton);
            Controls.Add(deleteButton);
            Controls.Add(deleteLabel);
            Controls.Add(downButton);
            Controls.Add(upButton);
            Controls.Add(moveLabel);
            Controls.Add(decimalButton);
            Controls.Add(doubleButton);
            Controls.Add(floatButton);
            Controls.Add(ulongButton);
            Controls.Add(longButton);
            Controls.Add(uintButton);
            Controls.Add(intButton);
            Controls.Add(ushortButton);
            Controls.Add(shortButton);
            Controls.Add(sbyteButton);
            Controls.Add(byteButton);
            Controls.Add(addLabel);
            Controls.Add(binaryOrderPanel);
            Controls.Add(boolButton);
            Controls.Add(menuStrip);
            Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "Main";
            Text = "Visual Binary Editor";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boolButton;
        private Panel binaryOrderPanel;
        private MenuStrip menuStrip;
        private Label addLabel;
        private Button deleteButton;
        private Button byteButton;
        private Button sbyteButton;
        private Button shortButton;
        private Button ushortButton;
        private Button intButton;
        private Button uintButton;
        private Button longButton;
        private Button ulongButton;
        private Button floatButton;
        private Button doubleButton;
        private Button decimalButton;
        private Label moveLabel;
        private Button upButton;
        private Button downButton;
        private Label deleteLabel;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem バイナリオーダーToolStripMenuItem;
        private ToolStripMenuItem ヘルプToolStripMenuItem;
        private Button stringButton;
        private Button charButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel debugLabel;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            boolButton = new Button();
            binaryOrderPanel = new Panel();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileNewToolStripMenuItem = new ToolStripMenuItem();
            fileOpenToolStripMenuItem = new ToolStripMenuItem();
            fileReloadToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            fileSaveToolStripMenuItem = new ToolStripMenuItem();
            fileNewSaveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            fileExitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddByteToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddSbyteToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddShortToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddUshortToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddIntToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddUintToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddLongToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddUlongToolStripMenuItem = new ToolStripMenuItem();
            editEntryAddBoolToolStripMenuItem = new ToolStripMenuItem();
            バイナリエントリの移動ToolStripMenuItem = new ToolStripMenuItem();
            editEntryRemoveToolStripMenuItem = new ToolStripMenuItem();
            editEntryClearToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            バイナリオーダーの保存ToolStripMenuItem = new ToolStripMenuItem();
            バイナリオーダーの保存ToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpHowToUseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            helpCheckUpdateToolStripMenuItem = new ToolStripMenuItem();
            helpLicenseToolStripMenuItem = new ToolStripMenuItem();
            helpAboutToolStripMenuItem = new ToolStripMenuItem();
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
            statusStrip = new StatusStrip();
            editingFileNameToolStripStatusLabel = new ToolStripStatusLabel();
            binaryFileSaveDialog = new SaveFileDialog();
            binaryFileOpenDialog = new OpenFileDialog();
            bottomButton = new Button();
            topButton = new Button();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
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
            binaryOrderPanel.AllowDrop = true;
            binaryOrderPanel.AutoScroll = true;
            binaryOrderPanel.BackColor = SystemColors.ControlLight;
            binaryOrderPanel.BorderStyle = BorderStyle.FixedSingle;
            binaryOrderPanel.Location = new Point(10, 38);
            binaryOrderPanel.Name = "binaryOrderPanel";
            binaryOrderPanel.Size = new Size(710, 424);
            binaryOrderPanel.TabIndex = 1;
            binaryOrderPanel.DragDrop += binaryOrderPanel_DragDrop;
            binaryOrderPanel.DragEnter += binaryOrderPanel_DragEnter;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(942, 28);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileNewToolStripMenuItem, fileOpenToolStripMenuItem, fileReloadToolStripMenuItem, toolStripSeparator3, fileSaveToolStripMenuItem, fileNewSaveToolStripMenuItem, toolStripSeparator1, fileExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(82, 24);
            fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // fileNewToolStripMenuItem
            // 
            fileNewToolStripMenuItem.Name = "fileNewToolStripMenuItem";
            fileNewToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            fileNewToolStripMenuItem.Size = new Size(311, 26);
            fileNewToolStripMenuItem.Text = "新規作成(&N)";
            fileNewToolStripMenuItem.Click += fileNewToolStripMenuItem_Click;
            // 
            // fileOpenToolStripMenuItem
            // 
            fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            fileOpenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            fileOpenToolStripMenuItem.Size = new Size(311, 26);
            fileOpenToolStripMenuItem.Text = "開く(&O)";
            fileOpenToolStripMenuItem.Click += fileOpenToolStripMenuItem_Click;
            // 
            // fileReloadToolStripMenuItem
            // 
            fileReloadToolStripMenuItem.Enabled = false;
            fileReloadToolStripMenuItem.Name = "fileReloadToolStripMenuItem";
            fileReloadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            fileReloadToolStripMenuItem.Size = new Size(311, 26);
            fileReloadToolStripMenuItem.Text = "再読み込み(&R)";
            fileReloadToolStripMenuItem.Click += fileReloadToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(308, 6);
            // 
            // fileSaveToolStripMenuItem
            // 
            fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            fileSaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            fileSaveToolStripMenuItem.Size = new Size(311, 26);
            fileSaveToolStripMenuItem.Text = "保存(&S)";
            fileSaveToolStripMenuItem.Click += fileSaveToolStripMenuItem_Click;
            // 
            // fileNewSaveToolStripMenuItem
            // 
            fileNewSaveToolStripMenuItem.Name = "fileNewSaveToolStripMenuItem";
            fileNewSaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            fileNewSaveToolStripMenuItem.Size = new Size(311, 26);
            fileNewSaveToolStripMenuItem.Text = "名前を付けて保存(&A)";
            fileNewSaveToolStripMenuItem.Click += fileNewSaveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(308, 6);
            // 
            // fileExitToolStripMenuItem
            // 
            fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            fileExitToolStripMenuItem.Size = new Size(311, 26);
            fileExitToolStripMenuItem.Text = "終了(&X)";
            fileExitToolStripMenuItem.Click += fileExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editEntryAddToolStripMenuItem, バイナリエントリの移動ToolStripMenuItem, editEntryRemoveToolStripMenuItem, editEntryClearToolStripMenuItem, toolStripSeparator2, バイナリオーダーの保存ToolStripMenuItem, バイナリオーダーの保存ToolStripMenuItem1 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(71, 24);
            editToolStripMenuItem.Text = "編集(&E)";
            // 
            // editEntryAddToolStripMenuItem
            // 
            editEntryAddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editEntryAddByteToolStripMenuItem, editEntryAddSbyteToolStripMenuItem, editEntryAddShortToolStripMenuItem, editEntryAddUshortToolStripMenuItem, editEntryAddIntToolStripMenuItem, editEntryAddUintToolStripMenuItem, editEntryAddLongToolStripMenuItem, editEntryAddUlongToolStripMenuItem, editEntryAddBoolToolStripMenuItem });
            editEntryAddToolStripMenuItem.Name = "editEntryAddToolStripMenuItem";
            editEntryAddToolStripMenuItem.Size = new Size(330, 26);
            editEntryAddToolStripMenuItem.Text = "バイナリエントリの追加";
            // 
            // editEntryAddByteToolStripMenuItem
            // 
            editEntryAddByteToolStripMenuItem.Name = "editEntryAddByteToolStripMenuItem";
            editEntryAddByteToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddByteToolStripMenuItem.Text = "byte";
            editEntryAddByteToolStripMenuItem.Click += editEntryAddByteToolStripMenuItem_Click;
            // 
            // editEntryAddSbyteToolStripMenuItem
            // 
            editEntryAddSbyteToolStripMenuItem.Name = "editEntryAddSbyteToolStripMenuItem";
            editEntryAddSbyteToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddSbyteToolStripMenuItem.Text = "sbyte";
            editEntryAddSbyteToolStripMenuItem.Click += editEntryAddSbyteToolStripMenuItem_Click;
            // 
            // editEntryAddShortToolStripMenuItem
            // 
            editEntryAddShortToolStripMenuItem.Name = "editEntryAddShortToolStripMenuItem";
            editEntryAddShortToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddShortToolStripMenuItem.Text = "short";
            editEntryAddShortToolStripMenuItem.Click += editEntryAddShortToolStripMenuItem_Click;
            // 
            // editEntryAddUshortToolStripMenuItem
            // 
            editEntryAddUshortToolStripMenuItem.Name = "editEntryAddUshortToolStripMenuItem";
            editEntryAddUshortToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddUshortToolStripMenuItem.Text = "ushort";
            editEntryAddUshortToolStripMenuItem.Click += editEntryAddUshortToolStripMenuItem_Click;
            // 
            // editEntryAddIntToolStripMenuItem
            // 
            editEntryAddIntToolStripMenuItem.Name = "editEntryAddIntToolStripMenuItem";
            editEntryAddIntToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddIntToolStripMenuItem.Text = "int";
            editEntryAddIntToolStripMenuItem.Click += editEntryAddIntToolStripMenuItem_Click;
            // 
            // editEntryAddUintToolStripMenuItem
            // 
            editEntryAddUintToolStripMenuItem.Name = "editEntryAddUintToolStripMenuItem";
            editEntryAddUintToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddUintToolStripMenuItem.Text = "uint";
            editEntryAddUintToolStripMenuItem.Click += editEntryAddUintToolStripMenuItem_Click;
            // 
            // editEntryAddLongToolStripMenuItem
            // 
            editEntryAddLongToolStripMenuItem.Name = "editEntryAddLongToolStripMenuItem";
            editEntryAddLongToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddLongToolStripMenuItem.Text = "long";
            editEntryAddLongToolStripMenuItem.Click += editEntryAddLongToolStripMenuItem_Click;
            // 
            // editEntryAddUlongToolStripMenuItem
            // 
            editEntryAddUlongToolStripMenuItem.Name = "editEntryAddUlongToolStripMenuItem";
            editEntryAddUlongToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddUlongToolStripMenuItem.Text = "ulong";
            editEntryAddUlongToolStripMenuItem.Click += editEntryAddUlongToolStripMenuItem_Click;
            // 
            // editEntryAddBoolToolStripMenuItem
            // 
            editEntryAddBoolToolStripMenuItem.Name = "editEntryAddBoolToolStripMenuItem";
            editEntryAddBoolToolStripMenuItem.Size = new Size(133, 26);
            editEntryAddBoolToolStripMenuItem.Text = "bool";
            editEntryAddBoolToolStripMenuItem.Click += editEntryAddBoolToolStripMenuItem_Click;
            // 
            // バイナリエントリの移動ToolStripMenuItem
            // 
            バイナリエントリの移動ToolStripMenuItem.Enabled = false;
            バイナリエントリの移動ToolStripMenuItem.Name = "バイナリエントリの移動ToolStripMenuItem";
            バイナリエントリの移動ToolStripMenuItem.Size = new Size(330, 26);
            バイナリエントリの移動ToolStripMenuItem.Text = "バイナリエントリの移動";
            // 
            // editEntryRemoveToolStripMenuItem
            // 
            editEntryRemoveToolStripMenuItem.Name = "editEntryRemoveToolStripMenuItem";
            editEntryRemoveToolStripMenuItem.ShortcutKeys = Keys.Delete;
            editEntryRemoveToolStripMenuItem.Size = new Size(330, 26);
            editEntryRemoveToolStripMenuItem.Text = "バイナリエントリの削除";
            editEntryRemoveToolStripMenuItem.Click += editEntryRemoveToolStripMenuItem_Click;
            // 
            // editEntryClearToolStripMenuItem
            // 
            editEntryClearToolStripMenuItem.Name = "editEntryClearToolStripMenuItem";
            editEntryClearToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            editEntryClearToolStripMenuItem.Size = new Size(330, 26);
            editEntryClearToolStripMenuItem.Text = "バイナリエントリの全削除";
            editEntryClearToolStripMenuItem.Click += editEntryClearToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(327, 6);
            // 
            // バイナリオーダーの保存ToolStripMenuItem
            // 
            バイナリオーダーの保存ToolStripMenuItem.Enabled = false;
            バイナリオーダーの保存ToolStripMenuItem.Name = "バイナリオーダーの保存ToolStripMenuItem";
            バイナリオーダーの保存ToolStripMenuItem.Size = new Size(330, 26);
            バイナリオーダーの保存ToolStripMenuItem.Text = "バイナリオーダーを開く";
            // 
            // バイナリオーダーの保存ToolStripMenuItem1
            // 
            バイナリオーダーの保存ToolStripMenuItem1.Enabled = false;
            バイナリオーダーの保存ToolStripMenuItem1.Name = "バイナリオーダーの保存ToolStripMenuItem1";
            バイナリオーダーの保存ToolStripMenuItem1.Size = new Size(330, 26);
            バイナリオーダーの保存ToolStripMenuItem1.Text = "バイナリオーダーの保存";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpHowToUseToolStripMenuItem, toolStripSeparator4, helpCheckUpdateToolStripMenuItem, helpLicenseToolStripMenuItem, helpAboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(79, 24);
            helpToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // helpHowToUseToolStripMenuItem
            // 
            helpHowToUseToolStripMenuItem.Image = (Image)resources.GetObject("helpHowToUseToolStripMenuItem.Image");
            helpHowToUseToolStripMenuItem.Name = "helpHowToUseToolStripMenuItem";
            helpHowToUseToolStripMenuItem.Size = new Size(291, 26);
            helpHowToUseToolStripMenuItem.Text = "使い方を確認(&H)";
            helpHowToUseToolStripMenuItem.Click += helpHowToUseToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(288, 6);
            // 
            // helpCheckUpdateToolStripMenuItem
            // 
            helpCheckUpdateToolStripMenuItem.Name = "helpCheckUpdateToolStripMenuItem";
            helpCheckUpdateToolStripMenuItem.Size = new Size(291, 26);
            helpCheckUpdateToolStripMenuItem.Text = "アップデートを確認(&U)";
            helpCheckUpdateToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            helpCheckUpdateToolStripMenuItem.Click += helpCheckUpdateToolStripMenuItem_Click;
            // 
            // helpLicenseToolStripMenuItem
            // 
            helpLicenseToolStripMenuItem.Image = (Image)resources.GetObject("helpLicenseToolStripMenuItem.Image");
            helpLicenseToolStripMenuItem.Name = "helpLicenseToolStripMenuItem";
            helpLicenseToolStripMenuItem.Size = new Size(291, 26);
            helpLicenseToolStripMenuItem.Text = "ソフトウェアライセンスを表示(&L)";
            helpLicenseToolStripMenuItem.Click += helpLicenseToolStripMenuItem_Click;
            // 
            // helpAboutToolStripMenuItem
            // 
            helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            helpAboutToolStripMenuItem.Size = new Size(291, 26);
            helpAboutToolStripMenuItem.Text = "Visual Binary Editor について(&A)";
            helpAboutToolStripMenuItem.Click += helpAboutToolStripMenuItem_Click;
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
            upButton.Image = (Image)resources.GetObject("upButton.Image");
            upButton.Location = new Point(788, 353);
            upButton.Name = "upButton";
            upButton.Size = new Size(40, 40);
            upButton.TabIndex = 17;
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // downButton
            // 
            downButton.Image = (Image)resources.GetObject("downButton.Image");
            downButton.Location = new Point(834, 353);
            downButton.Name = "downButton";
            downButton.Size = new Size(40, 40);
            downButton.TabIndex = 18;
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
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { editingFileNameToolStripStatusLabel });
            statusStrip.Location = new Point(0, 467);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(942, 26);
            statusStrip.TabIndex = 23;
            statusStrip.Text = "statusStrip1";
            // 
            // editingFileNameToolStripStatusLabel
            // 
            editingFileNameToolStripStatusLabel.Name = "editingFileNameToolStripStatusLabel";
            editingFileNameToolStripStatusLabel.Size = new Size(151, 20);
            editingFileNameToolStripStatusLabel.Text = "< Editing FileName >";
            // 
            // binaryFileSaveDialog
            // 
            binaryFileSaveDialog.AddExtension = false;
            binaryFileSaveDialog.Filter = "すべてのファイル|*.*";
            binaryFileSaveDialog.Title = "名前を付けて保存";
            // 
            // binaryFileOpenDialog
            // 
            binaryFileOpenDialog.Filter = "すべてのファイル|*.*";
            binaryFileOpenDialog.Title = "開く";
            // 
            // bottomButton
            // 
            bottomButton.Image = (Image)resources.GetObject("bottomButton.Image");
            bottomButton.Location = new Point(880, 353);
            bottomButton.Name = "bottomButton";
            bottomButton.Size = new Size(40, 40);
            bottomButton.TabIndex = 24;
            bottomButton.UseVisualStyleBackColor = true;
            // 
            // topButton
            // 
            topButton.Image = (Image)resources.GetObject("topButton.Image");
            topButton.Location = new Point(742, 353);
            topButton.Name = "topButton";
            topButton.Size = new Size(40, 40);
            topButton.TabIndex = 18;
            topButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(topButton);
            Controls.Add(bottomButton);
            Controls.Add(statusStrip);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "Main";
            Text = "Visual Binary Editor";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
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
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileNewSaveToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button stringButton;
        private Button charButton;
        private StatusStrip statusStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fileExitToolStripMenuItem;
        private SaveFileDialog binaryFileSaveDialog;
        private ToolStripMenuItem helpAboutToolStripMenuItem;
        private ToolStripMenuItem fileNewToolStripMenuItem;
        private ToolStripMenuItem fileOpenToolStripMenuItem;
        private ToolStripMenuItem fileSaveToolStripMenuItem;
        private OpenFileDialog binaryFileOpenDialog;
        private ToolStripStatusLabel editingFileNameToolStripStatusLabel;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editEntryAddToolStripMenuItem;
        private ToolStripMenuItem editEntryAddByteToolStripMenuItem;
        private ToolStripMenuItem editEntryAddSbyteToolStripMenuItem;
        private ToolStripMenuItem editEntryAddShortToolStripMenuItem;
        private ToolStripMenuItem editEntryAddUshortToolStripMenuItem;
        private ToolStripMenuItem editEntryAddIntToolStripMenuItem;
        private ToolStripMenuItem editEntryAddUintToolStripMenuItem;
        private ToolStripMenuItem editEntryAddLongToolStripMenuItem;
        private ToolStripMenuItem editEntryAddUlongToolStripMenuItem;
        private ToolStripMenuItem editEntryAddBoolToolStripMenuItem;
        private ToolStripMenuItem editEntryRemoveToolStripMenuItem;
        private ToolStripMenuItem editEntryClearToolStripMenuItem;
        private ToolStripMenuItem バイナリエントリの移動ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem バイナリオーダーの保存ToolStripMenuItem;
        private ToolStripMenuItem バイナリオーダーの保存ToolStripMenuItem1;
        private ToolStripMenuItem fileReloadToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem helpCheckUpdateToolStripMenuItem;
        private ToolStripMenuItem helpHowToUseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem helpLicenseToolStripMenuItem;
        private Button bottomButton;
        private Button topButton;
    }
}
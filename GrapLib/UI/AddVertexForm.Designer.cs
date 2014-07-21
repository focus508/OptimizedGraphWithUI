namespace GraphLib.UI
{
    partial class AddVertexForm
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
            this.nodeIdLabel = new DevComponents.DotNetBar.LabelX();
            this.nodeIdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.keyMapLabel = new DevComponents.DotNetBar.LabelX();
            this.keyMapRichText = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tableMapLabel = new DevComponents.DotNetBar.LabelX();
            this.tableMapRichText = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.InNodeIdListLabel = new DevComponents.DotNetBar.LabelX();
            this.inNodeIdListRichText = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.outNodeIdListLabel = new DevComponents.DotNetBar.LabelX();
            this.outNodeIdListRichText = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.saveButton = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // nodeIdLabel
            // 
            // 
            // 
            // 
            this.nodeIdLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nodeIdLabel.Location = new System.Drawing.Point(60, 27);
            this.nodeIdLabel.Name = "nodeIdLabel";
            this.nodeIdLabel.Size = new System.Drawing.Size(75, 23);
            this.nodeIdLabel.TabIndex = 0;
            this.nodeIdLabel.Text = "NodeId:";
            this.nodeIdLabel.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // nodeIdTextBox
            // 
            this.nodeIdTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nodeIdTextBox.Border.Class = "TextBoxBorder";
            this.nodeIdTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nodeIdTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.nodeIdTextBox.ForeColor = System.Drawing.Color.Black;
            this.nodeIdTextBox.Location = new System.Drawing.Point(141, 27);
            this.nodeIdTextBox.Name = "nodeIdTextBox";
            this.nodeIdTextBox.PreventEnterBeep = true;
            this.nodeIdTextBox.Size = new System.Drawing.Size(114, 22);
            this.nodeIdTextBox.TabIndex = 1;
            // 
            // keyMapLabel
            // 
            // 
            // 
            // 
            this.keyMapLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.keyMapLabel.Location = new System.Drawing.Point(58, 56);
            this.keyMapLabel.Name = "keyMapLabel";
            this.keyMapLabel.Size = new System.Drawing.Size(75, 23);
            this.keyMapLabel.TabIndex = 2;
            this.keyMapLabel.Text = "KeyMap:";
            this.keyMapLabel.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // keyMapRichText
            // 
            // 
            // 
            // 
            this.keyMapRichText.BackgroundStyle.Class = "RichTextBoxBorder";
            this.keyMapRichText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.keyMapRichText.Location = new System.Drawing.Point(141, 62);
            this.keyMapRichText.Name = "keyMapRichText";
            this.keyMapRichText.Rtf = "{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n\\viewkind4\\uc1\\pard\\la" +
    "ng2052\\f0\\fs17 key:tablename1,tablename2,...\\par\r\n}\r\n";
            this.keyMapRichText.Size = new System.Drawing.Size(262, 75);
            this.keyMapRichText.TabIndex = 3;
            this.keyMapRichText.Text = "key:tablename1,tablename2,...";
            // 
            // tableMapLabel
            // 
            // 
            // 
            // 
            this.tableMapLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableMapLabel.Location = new System.Drawing.Point(60, 147);
            this.tableMapLabel.Name = "tableMapLabel";
            this.tableMapLabel.Size = new System.Drawing.Size(75, 23);
            this.tableMapLabel.TabIndex = 4;
            this.tableMapLabel.Text = "TableMap:";
            this.tableMapLabel.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tableMapRichText
            // 
            // 
            // 
            // 
            this.tableMapRichText.BackgroundStyle.Class = "RichTextBoxBorder";
            this.tableMapRichText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableMapRichText.Location = new System.Drawing.Point(141, 153);
            this.tableMapRichText.Name = "tableMapRichText";
            this.tableMapRichText.Rtf = "{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n\\viewkind4\\uc1\\pard\\la" +
    "ng2052\\f0\\fs17 tablename:200000|field1,field2,...\\par\r\n}\r\n";
            this.tableMapRichText.Size = new System.Drawing.Size(262, 75);
            this.tableMapRichText.TabIndex = 3;
            this.tableMapRichText.Text = "tablename:200000|field1,field2,...";
            // 
            // InNodeIdListLabel
            // 
            // 
            // 
            // 
            this.InNodeIdListLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.InNodeIdListLabel.Location = new System.Drawing.Point(60, 237);
            this.InNodeIdListLabel.Name = "InNodeIdListLabel";
            this.InNodeIdListLabel.Size = new System.Drawing.Size(75, 23);
            this.InNodeIdListLabel.TabIndex = 4;
            this.InNodeIdListLabel.Text = "InNodeIdList:";
            this.InNodeIdListLabel.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // inNodeIdListRichText
            // 
            // 
            // 
            // 
            this.inNodeIdListRichText.BackgroundStyle.Class = "RichTextBoxBorder";
            this.inNodeIdListRichText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inNodeIdListRichText.Location = new System.Drawing.Point(141, 242);
            this.inNodeIdListRichText.Name = "inNodeIdListRichText";
            this.inNodeIdListRichText.Rtf = "{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n\\viewkind4\\uc1\\pard\\la" +
    "ng2052\\f0\\fs17 1000,20000,30000\\par\r\n}\r\n";
            this.inNodeIdListRichText.Size = new System.Drawing.Size(262, 61);
            this.inNodeIdListRichText.TabIndex = 5;
            this.inNodeIdListRichText.Text = "1000,20000,30000";
            // 
            // outNodeIdListLabel
            // 
            // 
            // 
            // 
            this.outNodeIdListLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.outNodeIdListLabel.Location = new System.Drawing.Point(34, 315);
            this.outNodeIdListLabel.Name = "outNodeIdListLabel";
            this.outNodeIdListLabel.Size = new System.Drawing.Size(99, 23);
            this.outNodeIdListLabel.TabIndex = 4;
            this.outNodeIdListLabel.Text = "OutNodeIdList:";
            this.outNodeIdListLabel.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // outNodeIdListRichText
            // 
            // 
            // 
            // 
            this.outNodeIdListRichText.BackgroundStyle.Class = "RichTextBoxBorder";
            this.outNodeIdListRichText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.outNodeIdListRichText.Location = new System.Drawing.Point(141, 318);
            this.outNodeIdListRichText.Name = "outNodeIdListRichText";
            this.outNodeIdListRichText.Rtf = "{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n\\viewkind4\\uc1\\pard\\la" +
    "ng2052\\f0\\fs17 1000,20000,30000\\par\r\n}\r\n";
            this.outNodeIdListRichText.Size = new System.Drawing.Size(262, 61);
            this.outNodeIdListRichText.TabIndex = 5;
            this.outNodeIdListRichText.Text = "1000,20000,30000";
            // 
            // saveButton
            // 
            this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.saveButton.Location = new System.Drawing.Point(78, 398);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 23);
            this.saveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "添       加";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(260, 398);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(131, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX2.TabIndex = 7;
            this.buttonX2.Text = "取       消";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // AddVertexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(472, 430);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.outNodeIdListRichText);
            this.Controls.Add(this.inNodeIdListRichText);
            this.Controls.Add(this.outNodeIdListLabel);
            this.Controls.Add(this.InNodeIdListLabel);
            this.Controls.Add(this.tableMapLabel);
            this.Controls.Add(this.tableMapRichText);
            this.Controls.Add(this.keyMapRichText);
            this.Controls.Add(this.keyMapLabel);
            this.Controls.Add(this.nodeIdTextBox);
            this.Controls.Add(this.nodeIdLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "AddVertexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#FFFFFF\">添加节点</font>";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX nodeIdLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX nodeIdTextBox;
        private DevComponents.DotNetBar.LabelX keyMapLabel;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx keyMapRichText;
        private DevComponents.DotNetBar.LabelX tableMapLabel;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx tableMapRichText;
        private DevComponents.DotNetBar.LabelX InNodeIdListLabel;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx inNodeIdListRichText;
        private DevComponents.DotNetBar.LabelX outNodeIdListLabel;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx outNodeIdListRichText;
        private DevComponents.DotNetBar.ButtonX saveButton;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}
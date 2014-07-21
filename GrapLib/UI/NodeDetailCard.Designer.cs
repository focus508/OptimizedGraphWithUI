namespace GraphLib.UI
{
    partial class NodeDetailCard
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleBar = new DevComponents.DotNetBar.Bar();
            this.titleLabel = new DevComponents.DotNetBar.LabelX();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel3 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.tablemapLabel = new DevComponents.DotNetBar.LabelX();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.keymapLabel = new DevComponents.DotNetBar.LabelX();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.basicLabel = new DevComponents.DotNetBar.LabelX();
            this.basicTab = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.keyMapTab = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.tableMapTab = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.cardStyleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            this.titleBar.SuspendLayout();
            this.itemPanel1.SuspendLayout();
            this.metroShell1.SuspendLayout();
            this.metroTabPanel3.SuspendLayout();
            this.metroTabPanel2.SuspendLayout();
            this.metroTabPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.AntiAlias = true;
            this.titleBar.Controls.Add(this.titleLabel);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.DockedBorderStyle = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.titleBar.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.titleBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(305, 31);
            this.titleBar.Stretch = true;
            this.titleBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.titleBar.TabIndex = 0;
            this.titleBar.TabStop = false;
            this.titleBar.Text = "titleBar";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(123)))));
            // 
            // 
            // 
            this.titleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(305, 31);
            this.titleLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "<b>TitleLabel</b>";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Controls.Add(this.metroShell1);
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(0, 31);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(305, 158);
            this.itemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.itemPanel1.TabIndex = 1;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Controls.Add(this.metroTabPanel3);
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.HelpButtonVisible = false;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.basicTab,
            this.keyMapTab,
            this.tableMapTab});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(0, 0);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.SettingsButtonVisible = false;
            this.metroShell1.ShowIcon = false;
            this.metroShell1.Size = new System.Drawing.Size(305, 154);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 0;
            this.metroShell1.TabStripDock = DevComponents.DotNetBar.Metro.eMetroTabStripDock.Bottom;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            this.metroShell1.UseCustomizeDialog = false;
            // 
            // metroTabPanel3
            // 
            this.metroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.metroTabPanel3.Controls.Add(this.tablemapLabel);
            this.metroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroTabPanel3.Name = "metroTabPanel3";
            this.metroTabPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel3.Size = new System.Drawing.Size(305, 123);
            // 
            // 
            // 
            this.metroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel3.TabIndex = 3;
            this.metroTabPanel3.Visible = false;
            // 
            // tablemapLabel
            // 
            this.tablemapLabel.BackColor = System.Drawing.Color.OldLace;
            // 
            // 
            // 
            this.tablemapLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tablemapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablemapLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tablemapLabel.ForeColor = System.Drawing.Color.Gray;
            this.tablemapLabel.Location = new System.Drawing.Point(3, 0);
            this.tablemapLabel.Name = "tablemapLabel";
            this.tablemapLabel.Size = new System.Drawing.Size(299, 120);
            this.tablemapLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.tablemapLabel.TabIndex = 0;
            this.tablemapLabel.Text = "VertexTableMapInfo";
            this.tablemapLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.tablemapLabel.WordWrap = true;
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.metroTabPanel2.Controls.Add(this.keymapLabel);
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(305, 123);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            this.metroTabPanel2.Visible = false;
            // 
            // keymapLabel
            // 
            this.keymapLabel.BackColor = System.Drawing.Color.OldLace;
            // 
            // 
            // 
            this.keymapLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.keymapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keymapLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keymapLabel.ForeColor = System.Drawing.Color.Gray;
            this.keymapLabel.Location = new System.Drawing.Point(3, 0);
            this.keymapLabel.Name = "keymapLabel";
            this.keymapLabel.Size = new System.Drawing.Size(299, 120);
            this.keymapLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.keymapLabel.TabIndex = 0;
            this.keymapLabel.Text = "VertexKeyMapInfo";
            this.keymapLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.keymapLabel.WordWrap = true;
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.metroTabPanel1.Controls.Add(this.basicLabel);
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(305, 123);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            // 
            // basicLabel
            // 
            this.basicLabel.BackColor = System.Drawing.Color.OldLace;
            // 
            // 
            // 
            this.basicLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.basicLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.basicLabel.ForeColor = System.Drawing.Color.Gray;
            this.basicLabel.Location = new System.Drawing.Point(3, 0);
            this.basicLabel.Name = "basicLabel";
            this.basicLabel.Size = new System.Drawing.Size(299, 120);
            this.basicLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.basicLabel.TabIndex = 0;
            this.basicLabel.Text = "VertexBasicInfo";
            this.basicLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.basicLabel.WordWrap = true;
            // 
            // basicTab
            // 
            this.basicTab.Checked = true;
            this.basicTab.Name = "basicTab";
            this.basicTab.Panel = this.metroTabPanel1;
            this.basicTab.Text = "<i>Basic</i>";
            // 
            // keyMapTab
            // 
            this.keyMapTab.Name = "keyMapTab";
            this.keyMapTab.Panel = this.metroTabPanel2;
            this.keyMapTab.Text = "<i>KeyMap</i>";
            // 
            // tableMapTab
            // 
            this.tableMapTab.Name = "tableMapTab";
            this.tableMapTab.Panel = this.metroTabPanel3;
            this.tableMapTab.Text = "<i>TableMap</i>";
            // 
            // cardStyleManager
            // 
            this.cardStyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.cardStyleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(123))))));
            // 
            // NodeDetailCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.titleBar);
            this.Name = "NodeDetailCard";
            this.Size = new System.Drawing.Size(305, 189);
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.itemPanel1.ResumeLayout(false);
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.metroTabPanel3.ResumeLayout(false);
            this.metroTabPanel2.ResumeLayout(false);
            this.metroTabPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar titleBar;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.LabelX titleLabel;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabItem basicTab;
        private DevComponents.DotNetBar.Metro.MetroTabItem keyMapTab;
        private DevComponents.DotNetBar.StyleManager cardStyleManager;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel3;
        private DevComponents.DotNetBar.Metro.MetroTabItem tableMapTab;
        private DevComponents.DotNetBar.LabelX basicLabel;
        private DevComponents.DotNetBar.LabelX keymapLabel;
        private DevComponents.DotNetBar.LabelX tablemapLabel;
    }
}

namespace GraghSimulatorAndAnalyze
{
    partial class MainShowForm
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
            this.components = new System.ComponentModel.Container();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.showGrapPanel = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.treeGX1 = new DevComponents.Tree.TreeGX();
            this.node1 = new DevComponents.Tree.Node();
            this.nodeConnector2 = new DevComponents.Tree.NodeConnector();
            this.elementStyle1 = new DevComponents.Tree.ElementStyle();
            this.nodeConnector1 = new DevComponents.Tree.NodeConnector();
            this.searchPathPanel = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroTabItem1 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabItem2 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.addNodeButton = new DevComponents.DotNetBar.ButtonItem();
            this.updateNodeButton = new DevComponents.DotNetBar.ButtonItem();
            this.deleteNodeButton = new DevComponents.DotNetBar.ButtonItem();
            this.clearGraphButton = new DevComponents.DotNetBar.ButtonItem();
            this.searchPathButton = new DevComponents.DotNetBar.ButtonItem();
            this.createGraphButton = new DevComponents.DotNetBar.ButtonItem();
            this.layoutCombox = new DevComponents.DotNetBar.ComboBoxItem();
            this.spared = new DevComponents.Editors.ComboItem();
            this.vertical = new DevComponents.Editors.ComboItem();
            this.horizontal = new DevComponents.Editors.ComboItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.metroShell1.SuspendLayout();
            this.showGrapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeGX1)).BeginInit();
            this.searchPathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Controls.Add(this.showGrapPanel);
            this.metroShell1.Controls.Add(this.searchPathPanel);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.HelpButtonVisible = false;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTabItem1,
            this.metroTabItem2,
            this.addNodeButton,
            this.updateNodeButton,
            this.deleteNodeButton,
            this.clearGraphButton,
            this.searchPathButton,
            this.createGraphButton,
            this.layoutCombox});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(1, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.SettingsButtonVisible = false;
            this.metroShell1.ShowIcon = false;
            this.metroShell1.Size = new System.Drawing.Size(792, 394);
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
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            this.metroShell1.TitleText = "有向图数据模型分析测试";
            // 
            // showGrapPanel
            // 
            this.showGrapPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.showGrapPanel.Controls.Add(this.treeGX1);
            this.showGrapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showGrapPanel.Location = new System.Drawing.Point(0, 67);
            this.showGrapPanel.Name = "showGrapPanel";
            this.showGrapPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.showGrapPanel.Size = new System.Drawing.Size(792, 327);
            // 
            // 
            // 
            this.showGrapPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.showGrapPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.showGrapPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.showGrapPanel.TabIndex = 1;
            // 
            // treeGX1
            // 
            this.treeGX1.AllowDrop = true;
            this.treeGX1.AutoScrollMinSize = new System.Drawing.Size(52, 33);
            this.treeGX1.BackColor = System.Drawing.Color.White;
            this.treeGX1.CommandBackColorGradientAngle = 90;
            this.treeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2;
            this.treeGX1.CommandMouseOverBackColorGradientAngle = 90;
            this.treeGX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
            this.treeGX1.ForeColor = System.Drawing.Color.Black;
            this.treeGX1.Location = new System.Drawing.Point(3, 0);
            this.treeGX1.Name = "treeGX1";
            this.treeGX1.Nodes.AddRange(new DevComponents.Tree.Node[] {
            this.node1});
            this.treeGX1.NodesConnector = this.nodeConnector2;
            this.treeGX1.NodeStyle = this.elementStyle1;
            this.treeGX1.PathSeparator = ";";
            this.treeGX1.RootConnector = this.nodeConnector1;
            this.treeGX1.Size = new System.Drawing.Size(786, 324);
            this.treeGX1.Styles.Add(this.elementStyle1);
            this.treeGX1.SuspendPaint = false;
            this.treeGX1.TabIndex = 0;
            this.treeGX1.Text = "treeGX1";
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Text = "node1";
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineWidth = 5;
            // 
            // elementStyle1
            // 
            this.elementStyle1.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2;
            this.elementStyle1.BackColorGradientAngle = 90;
            this.elementStyle1.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground;
            this.elementStyle1.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle1.BorderBottomWidth = 1;
            this.elementStyle1.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
            this.elementStyle1.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle1.BorderLeftWidth = 1;
            this.elementStyle1.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle1.BorderRightWidth = 1;
            this.elementStyle1.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle1.BorderTopWidth = 1;
            this.elementStyle1.CornerDiameter = 4;
            this.elementStyle1.CornerType = DevComponents.Tree.eCornerType.Rounded;
            this.elementStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.PaddingBottom = 3;
            this.elementStyle1.PaddingLeft = 3;
            this.elementStyle1.PaddingRight = 3;
            this.elementStyle1.PaddingTop = 3;
            this.elementStyle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineWidth = 5;
            // 
            // searchPathPanel
            // 
            this.searchPathPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.searchPathPanel.Controls.Add(this.richTextBox1);
            this.searchPathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPathPanel.Location = new System.Drawing.Point(0, 67);
            this.searchPathPanel.Name = "searchPathPanel";
            this.searchPathPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.searchPathPanel.Size = new System.Drawing.Size(792, 327);
            // 
            // 
            // 
            this.searchPathPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.searchPathPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.searchPathPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchPathPanel.TabIndex = 2;
            this.searchPathPanel.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(3, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(786, 324);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // metroTabItem1
            // 
            this.metroTabItem1.Checked = true;
            this.metroTabItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.metroTabItem1.Name = "metroTabItem1";
            this.metroTabItem1.Panel = this.showGrapPanel;
            this.metroTabItem1.Text = "&有向图模型";
            // 
            // metroTabItem2
            // 
            this.metroTabItem2.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.metroTabItem2.Name = "metroTabItem2";
            this.metroTabItem2.Panel = this.searchPathPanel;
            this.metroTabItem2.Text = "&最优寻路过程";
            // 
            // addNodeButton
            // 
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Symbol = "";
            this.addNodeButton.Text = "添加节点";
            this.addNodeButton.Tooltip = "添加节点";
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // updateNodeButton
            // 
            this.updateNodeButton.Name = "updateNodeButton";
            this.updateNodeButton.Symbol = "";
            this.updateNodeButton.Text = "更新节点";
            this.updateNodeButton.Tooltip = "更新节点";
            // 
            // deleteNodeButton
            // 
            this.deleteNodeButton.Name = "deleteNodeButton";
            this.deleteNodeButton.Symbol = "";
            this.deleteNodeButton.Text = "删除节点";
            this.deleteNodeButton.Tooltip = "删除节点";
            // 
            // clearGraphButton
            // 
            this.clearGraphButton.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.clearGraphButton.Name = "clearGraphButton";
            this.clearGraphButton.Symbol = "";
            this.clearGraphButton.Text = "清空图";
            this.clearGraphButton.Tooltip = "清空图";
            // 
            // searchPathButton
            // 
            this.searchPathButton.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.searchPathButton.Name = "searchPathButton";
            this.searchPathButton.Symbol = "";
            this.searchPathButton.Text = "最优寻路";
            this.searchPathButton.Tooltip = "最优寻路";
            // 
            // createGraphButton
            // 
            this.createGraphButton.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.createGraphButton.Name = "createGraphButton";
            this.createGraphButton.Symbol = "";
            this.createGraphButton.Text = "构建有向图";
            this.createGraphButton.Tooltip = "构建有向图";
            this.createGraphButton.Click += new System.EventHandler(this.createGraphButton_Click);
            // 
            // layoutCombox
            // 
            this.layoutCombox.ComboWidth = 120;
            this.layoutCombox.DropDownHeight = 106;
            this.layoutCombox.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.layoutCombox.ItemHeight = 20;
            this.layoutCombox.Items.AddRange(new object[] {
            this.spared,
            this.vertical,
            this.horizontal});
            this.layoutCombox.Name = "layoutCombox";
            this.layoutCombox.Text = "发散布局";
            this.layoutCombox.ComboBoxTextChanged += new System.EventHandler(this.layoutCombox_ComboBoxTextChanged);
            // 
            // spared
            // 
            this.spared.Text = "发散布局";
            // 
            // vertical
            // 
            this.vertical.Text = "纵向布局";
            // 
            // horizontal
            // 
            this.horizontal.Text = "横向布局";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(123))))));
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            this.metroStatusBar1.Location = new System.Drawing.Point(1, 374);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(792, 21);
            this.metroStatusBar1.TabIndex = 1;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "READY";
            // 
            // MainShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 396);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.metroShell1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "MainShowForm";
            this.Text = "DotNetBar Metro App Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainShowForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainShowForm_KeyDown);
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.showGrapPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeGX1)).EndInit();
            this.searchPathPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel showGrapPanel;
        private DevComponents.DotNetBar.Metro.MetroTabPanel searchPathPanel;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.Tree.TreeGX treeGX1;
        private DevComponents.Tree.Node node1;
        private DevComponents.Tree.NodeConnector nodeConnector2;
        private DevComponents.Tree.ElementStyle elementStyle1;
        private DevComponents.Tree.NodeConnector nodeConnector1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevComponents.DotNetBar.ButtonItem addNodeButton;
        private DevComponents.DotNetBar.ButtonItem updateNodeButton;
        private DevComponents.DotNetBar.ButtonItem deleteNodeButton;
        private DevComponents.DotNetBar.ButtonItem clearGraphButton;
        private DevComponents.DotNetBar.ButtonItem searchPathButton;
        private DevComponents.DotNetBar.ButtonItem createGraphButton;
        private DevComponents.DotNetBar.ComboBoxItem layoutCombox;
        private DevComponents.Editors.ComboItem spared;
        private DevComponents.Editors.ComboItem vertical;
        private DevComponents.Editors.ComboItem horizontal;

    }
}


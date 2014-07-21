using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;
using GraphLib.Core;
using GraphLib.UI;
using DevComponents.Tree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace GraghSimulatorAndAnalyze
{
    public partial class MainShowForm : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        private Graph dataGraph;

        //
        // 指示有向图是否已发生了变更，用来重建有向图
        //
        private bool graphChanged = false;

        public MainShowForm()
        {
            InitializeComponent();
        }

        //【构建有向图】按钮单击事件处理函数
        private void createGraphButton_Click(object sender, EventArgs e)
        {
            this.treeGX1.Nodes.Clear();//先清空节点
            this.treeGX1.RootConnector = this.nodeConnector1;
            this.treeGX1.NodesConnector = this.nodeConnector2;
            if (this.dataGraph.Vertexs != null && this.dataGraph.Vertexs.Count > 0)
            {
                //先创建固定的虚拟根节点
                Node startNode = this.CreateBasicNode("startNode",
                    "NewGRootVertex",
                    this.elementStyle1,
                    true);

                //添加1级节点
                if (this.dataGraph.Level1Vertexs != null && this.dataGraph.Level1Vertexs.Count > 0)
                {
                    Node[] level1Nodes = new Node[this.dataGraph.Level1Vertexs.Count];

                    int index = 0;
                    foreach (Vertex vertex in this.dataGraph.Level1Vertexs)
                    {
                        level1Nodes[index] = this.CreateDetailCardNode("level1Node" + index,
                            "Level1Node" + index + ":" + vertex.NodeId,
                            vertex.GetBasicText(),
                            vertex.GetKeysText(),
                            vertex.GetTablesText(),
                            this.elementStyle1,
                            true,
                            false);
                        index++;
                    }
                    startNode.Nodes.AddRange(level1Nodes);
                }
                this.treeGX1.Nodes.Add(startNode);
                this.treeGX1.DisplayRootNode = startNode;
                this.treeGX1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.treeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
            }
        }

        //【窗条加载事件】处理函数
        private void MainShowForm_Load(object sender, EventArgs e)
        {
            this.dataGraph = Graph.GetInstance();

            List<KeyMap> keysMap = new List<KeyMap>();
            keysMap.Add(new KeyMap("电话", (new String[] { "cu_table" }).ToList()));

            List<TableMap> tablesMap = new List<TableMap>();
            tablesMap.Add(new TableMap("cu_table", "user_name,user_tel,user_bankcode".Split(',').ToList(),220000L));

            List<Edge> inEdgeList = new List<Edge>();

            for (int i = 0; i < 7; i++)
            {
                inEdgeList.Clear();
                inEdgeList.Add(new Edge(0, 100000000 + i * 10000000));
                Vertex level1Vertex = new Vertex(100000000 + i * 10000000,
                    inEdgeList,
                    null,
                    keysMap,
                    tablesMap);
                this.dataGraph.AddVertex(level1Vertex);
            }
        }

        //【切换布局事件】处理函数
        private void layoutCombox_ComboBoxTextChanged(object sender, EventArgs e)
        {
            this.treeGX1.LayoutType = DevComponents.Tree.eNodeLayout.Map;
            if (this.layoutCombox.SelectedIndex == 2)
            {
                DevComponents.Tree.eMapFlow mapFlow = DevComponents.Tree.eMapFlow.LeftToRight;
                this.treeGX1.MapLayoutFlow = mapFlow;
                this.treeGX1.RecalcLayout();
                this.treeGX1.Refresh();
            }
            else if (this.layoutCombox.SelectedIndex == 1)
            {
                DevComponents.Tree.eMapFlow mapFlow = DevComponents.Tree.eMapFlow.TopToBottom;
                this.treeGX1.MapLayoutFlow = mapFlow;
                this.treeGX1.RecalcLayout();
                this.treeGX1.Refresh();
            }
            else
            {
                DevComponents.Tree.eMapFlow mapFlow = DevComponents.Tree.eMapFlow.Spread;
                this.treeGX1.MapLayoutFlow = mapFlow;
                this.treeGX1.RecalcLayout();
                this.Refresh();
            }

            foreach (Node subNode in this.treeGX1.DisplayRootNode.Nodes) 
            {
                ((NodeDetailCard)subNode.HostedControl).Expended = false;
            }
        }

        #region 辅助函数
        /// <summary>
        /// 创建基础的节点，包含基本信息，但不包含扩展详情
        /// </summary>
        /// <param name="nodeName">节点名称</param>
        /// <param name="nodeText">节点显示文本</param>
        /// <param name="nodeStyle">节点风格</param>
        /// <param name="expendNode">是否扩展开</param>
        /// <returns></returns>
        private Node CreateBasicNode(String nodeName, String nodeText,
            DevComponents.Tree.ElementStyle nodeStyle, bool expendNode)
        {
            Node newNode = new Node();
            newNode.Name = nodeName;
            newNode.Text = nodeText;
            newNode.Style = nodeStyle;
            newNode.Expanded = expendNode;

            return newNode;
        }

        /// <summary>
        /// 创建包含节点详情卡的节点
        /// </summary>
        /// <param name="nodeName">节点名</param>
        /// <param name="titleText">节点标题</param>
        /// <param name="basicText">基本信息</param>
        /// <param name="keysText">KeyMap信息</param>
        /// <param name="tablesText">TableMap信息</param>
        /// <param name="nodeStyle">节点风格</param>
        /// <param name="nodeExpended">节点及子节点是否展开</param>
        /// <param name="cardExpended">节点详情卡是否展开</param>
        /// <returns></returns>
        private Node CreateDetailCardNode(String nodeName, String titleText, String basicText, String keysText,
            String tablesText, DevComponents.Tree.ElementStyle nodeStyle, bool nodeExpended, bool cardExpended)
        {
            //创建详情卡
            NodeDetailCard detailCard = new NodeDetailCard(this.styleManager1);
            detailCard.TitleText = titleText;
            detailCard.BasicLableText = basicText;
            detailCard.KeysLabelText = keysText;
            detailCard.TablesLabelText = tablesText;
            detailCard.Expended = cardExpended;
            //detailCard.Size = new System.Drawing.Size(100, 70);

            //创建并关联到Node
            Node newNode = new Node();
            newNode.Name = nodeName;
            newNode.Expanded = nodeExpended;
            newNode.Style = nodeStyle;
            newNode.HostedControl = detailCard;  //关联

            return newNode;
        }
        #endregion         

        //【绑定快捷键】事件处理函数
        private void MainShowForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl+3切换到vs2012风格
            if (e.KeyCode == Keys.D3 && e.KeyCode == Keys.Control) 
            {
                e.Handled = true;
                this.styleManager1.ManagerStyle = eStyle.VisualStudio2012Light;
                //this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(123))))));
                //调用styleChanged事件处理函数
            }

            //Ctrl+4切换到OfficeMobile2014风格
            if (e.KeyCode == Keys.D4 && e.KeyCode == Keys.Control) 
            {
                e.Handled = true;
                this.styleManager1.ManagerStyle = eStyle.OfficeMobile2014;
                //调用styleChanged事件处理函数
            }
        }

        //【添加节点】按钮处理函数
        private void addNodeButton_Click(object sender, EventArgs e)
        {
            if (this.dataGraph == null) 
            {
                MessageBoxEx.Show("有向图未初始化，新建的节点往哪添加？ 添加个毛啊");
                return;
            }
            AddVertexForm avf = new AddVertexForm(this.dataGraph);
            avf.ShowDialog();
        }
    }
}
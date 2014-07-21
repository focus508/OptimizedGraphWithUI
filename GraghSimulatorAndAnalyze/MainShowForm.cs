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
        // ָʾ����ͼ�Ƿ��ѷ����˱���������ؽ�����ͼ
        //
        private bool graphChanged = false;

        public MainShowForm()
        {
            InitializeComponent();
        }

        //����������ͼ����ť�����¼�������
        private void createGraphButton_Click(object sender, EventArgs e)
        {
            this.treeGX1.Nodes.Clear();//����սڵ�
            this.treeGX1.RootConnector = this.nodeConnector1;
            this.treeGX1.NodesConnector = this.nodeConnector2;
            if (this.dataGraph.Vertexs != null && this.dataGraph.Vertexs.Count > 0)
            {
                //�ȴ����̶���������ڵ�
                Node startNode = this.CreateBasicNode("startNode",
                    "NewGRootVertex",
                    this.elementStyle1,
                    true);

                //���1���ڵ�
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

        //�����������¼���������
        private void MainShowForm_Load(object sender, EventArgs e)
        {
            this.dataGraph = Graph.GetInstance();

            List<KeyMap> keysMap = new List<KeyMap>();
            keysMap.Add(new KeyMap("�绰", (new String[] { "cu_table" }).ToList()));

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

        //���л������¼���������
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

        #region ��������
        /// <summary>
        /// ���������Ľڵ㣬����������Ϣ������������չ����
        /// </summary>
        /// <param name="nodeName">�ڵ�����</param>
        /// <param name="nodeText">�ڵ���ʾ�ı�</param>
        /// <param name="nodeStyle">�ڵ���</param>
        /// <param name="expendNode">�Ƿ���չ��</param>
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
        /// ���������ڵ����鿨�Ľڵ�
        /// </summary>
        /// <param name="nodeName">�ڵ���</param>
        /// <param name="titleText">�ڵ����</param>
        /// <param name="basicText">������Ϣ</param>
        /// <param name="keysText">KeyMap��Ϣ</param>
        /// <param name="tablesText">TableMap��Ϣ</param>
        /// <param name="nodeStyle">�ڵ���</param>
        /// <param name="nodeExpended">�ڵ㼰�ӽڵ��Ƿ�չ��</param>
        /// <param name="cardExpended">�ڵ����鿨�Ƿ�չ��</param>
        /// <returns></returns>
        private Node CreateDetailCardNode(String nodeName, String titleText, String basicText, String keysText,
            String tablesText, DevComponents.Tree.ElementStyle nodeStyle, bool nodeExpended, bool cardExpended)
        {
            //�������鿨
            NodeDetailCard detailCard = new NodeDetailCard(this.styleManager1);
            detailCard.TitleText = titleText;
            detailCard.BasicLableText = basicText;
            detailCard.KeysLabelText = keysText;
            detailCard.TablesLabelText = tablesText;
            detailCard.Expended = cardExpended;
            //detailCard.Size = new System.Drawing.Size(100, 70);

            //������������Node
            Node newNode = new Node();
            newNode.Name = nodeName;
            newNode.Expanded = nodeExpended;
            newNode.Style = nodeStyle;
            newNode.HostedControl = detailCard;  //����

            return newNode;
        }
        #endregion         

        //���󶨿�ݼ����¼�������
        private void MainShowForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl+3�л���vs2012���
            if (e.KeyCode == Keys.D3 && e.KeyCode == Keys.Control) 
            {
                e.Handled = true;
                this.styleManager1.ManagerStyle = eStyle.VisualStudio2012Light;
                //this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(123))))));
                //����styleChanged�¼�������
            }

            //Ctrl+4�л���OfficeMobile2014���
            if (e.KeyCode == Keys.D4 && e.KeyCode == Keys.Control) 
            {
                e.Handled = true;
                this.styleManager1.ManagerStyle = eStyle.OfficeMobile2014;
                //����styleChanged�¼�������
            }
        }

        //����ӽڵ㡿��ť������
        private void addNodeButton_Click(object sender, EventArgs e)
        {
            if (this.dataGraph == null) 
            {
                MessageBoxEx.Show("����ͼδ��ʼ�����½��Ľڵ�������ӣ� ��Ӹ�ë��");
                return;
            }
            AddVertexForm avf = new AddVertexForm(this.dataGraph);
            avf.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

using GraphLib.Core;
using System.Linq;

namespace GraphLib.UI
{
    public partial class AddVertexForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Graph graph = null;
        private String checkUserInputResultInfo = "";
        private int nodeId = 0;
        private List<KeyMap> keysMap = new List<KeyMap>();
        private List<TableMap> tablesMap = new List<TableMap>();
        private List<Edge> inEdgeList = new List<Edge>();
        private List<Edge> outEdgeList = new List<Edge>();

        public AddVertexForm(Graph g)
        {
            InitializeComponent();

            if (g == null) throw new ArgumentNullException("����ͼ����g����ΪNull");
            else
                this.graph = g;
        }

        //����ӡ���ť������
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.checkUserInput())
            {
                Vertex newVertex = new Vertex(this.nodeId,
                    this.inEdgeList,
                    this.outEdgeList,
                    this.keysMap,
                    this.tablesMap);
                try
                {
                    this.graph.AddVertex(newVertex);
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show("�ڵ㴴���ɹ�������ͼ�����ʱ�����쳣 \r\n" + ex.Message + "\r\n" + ex.StackTrace,
                        "AddVertex�쳣", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //��ʾ�û������д���
                MessageBoxEx.Show("�޷������ڵ㣬����û����룺\r\n" + this.checkUserInputResultInfo);
        }

        //��ȡ������ť������
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// �������û����룬��ȡ��ȷ����
        /// ����⵽��������쳣��Ӧ��ӡcheckUserInputResultInfo��Ϣ
        /// </summary>
        /// <returns></returns>
        private bool checkUserInput() 
        {
            //���NodeId�Ƿ�Ϸ��Լ��Ƿ��ظ�
            //���KeyMap
            //���TableMap
            //���InNodeIdList            
            //���OutNodeIdList����
            return this.checkNodeId() &&
                   this.checkKeysMap() &&
                   this.checkTablesMap() &&
                   this.checkInNodeIdList() &&
                   this.checkOutNodeIdList();
        }

        /// <summary>
        /// ����û������NodeId
        /// </summary>
        /// <returns></returns>
        private bool checkNodeId() 
        {
            try
            {
                this.nodeId = Int32.Parse(this.nodeIdTextBox.Text.Trim());
            }
            catch
            {
                this.checkUserInputResultInfo = "NodeId��������ֻ�ܽ��ܷǸ�����";
                return false;
            }
            if (this.graph.FindVertexById(this.nodeId) != null)
            {
                this.checkUserInputResultInfo = "ͼ���Ѵ���NodeId��" + this.nodeId + " �Ľڵ�";
                return false;
            }
            return true;
        }

        /// <summary>
        /// ����û�����KeysMap
        /// </summary>
        /// <returns></returns>
        private bool checkKeysMap() 
        {
            if (String.IsNullOrEmpty(this.keyMapRichText.Text))
            {
                this.checkUserInputResultInfo = "KeysMap����Ϊ��";
                return false;
            }
            else 
            {
                try
                {
                    foreach (String line in this.keyMapRichText.Lines)
                    {
                        KeyMap tmpKeyMap = new KeyMap(line.Split(':')[0],
                            (line.Split(':')[1]).Split(',').ToList());
                        this.keysMap.Add(tmpKeyMap);
                    }
                }
                catch (Exception ex)
                {
                    this.checkUserInputResultInfo = "�ָ��ȡKeyMapʱ�������쳣�� \r\n\t" + ex.StackTrace;
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// ����û�����TablesMap
        /// </summary>
        /// <returns></returns>
        private bool checkTablesMap() 
        {
            if (String.IsNullOrEmpty(this.tableMapRichText.Text))
            {
                this.checkUserInputResultInfo = "TablesMap����Ϊ��";
                return false;
            }
            else 
            {
                try
                {
                    foreach (String line in this.tableMapRichText.Lines)
                    {
                        TableMap tmpTableMap = new TableMap(line.Split(':')[0],
                            (line.Split('|')[1]).Split(',').ToList(),
                            Int64.Parse(line.Split('|')[0].Split(':')[1]));
                        this.tablesMap.Add(tmpTableMap);
                    }
                }
                catch (Exception ex)
                {
                    this.checkUserInputResultInfo = "�ָ��ȡTableMapʱ�������쳣��\r\n\t" + ex.StackTrace;
                    return false;
                }
            }

            return true;
        }

        private bool checkInNodeIdList() 
        {
            if (!String.IsNullOrEmpty(this.inNodeIdListRichText.Text)) 
            {
                try
                {
                    foreach (String nodeIdStr in this.inNodeIdListRichText.Text.Trim().Split(','))
                    {
                        int currentNodeId = Int32.Parse(nodeIdStr);
                        if (this.graph.FindVertexById(currentNodeId) == null)
                        {
                            this.checkUserInputResultInfo = "InNode�����ڣ��޷�����, NodeId=" + nodeIdStr;
                            return false;
                        }
                        this.inEdgeList.Add(new Edge(currentNodeId, this.nodeId));
                    }
                }
                catch (Exception ex)
                {
                    this.checkUserInputResultInfo = "����InNodeIdListʱ�����쳣 \r\n" + ex.StackTrace;
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// ����û�����OutNodeIdList
        /// </summary>
        /// <returns></returns>
        private bool checkOutNodeIdList() 
        {
            if (!String.IsNullOrEmpty(this.outNodeIdListRichText.Text))
            {
                try
                {
                    foreach (String nodeIdStr in this.outNodeIdListRichText.Text.Trim().Split(','))
                    {
                        int currentNodeId = Int32.Parse(nodeIdStr);
                        if (this.graph.FindVertexById(currentNodeId) == null)
                        {
                            this.checkUserInputResultInfo = "OutNode�����ڣ��޷�������NodeId=" + nodeIdStr;
                            return false;
                        }
                        this.outEdgeList.Add(new Edge(this.nodeId, currentNodeId));
                    }
                }
                catch (Exception ex)
                {
                    this.checkUserInputResultInfo = "������ȡOutNodeIdListʱ�����쳣��\r\n" + ex.StackTrace;
                    return false;
                }
            }

            return true;
        }
    }
}
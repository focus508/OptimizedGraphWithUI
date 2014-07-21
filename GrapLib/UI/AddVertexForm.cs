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

            if (g == null) throw new ArgumentNullException("有向图参数g不能为Null");
            else
                this.graph = g;
        }

        //【添加】按钮处理函数
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
                    MessageBoxEx.Show("节点创建成功，但往图中添加时发生异常 \r\n" + ex.Message + "\r\n" + ex.StackTrace,
                        "AddVertex异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //表示用户输入有错误
                MessageBoxEx.Show("无法创建节点，检查用户输入：\r\n" + this.checkUserInputResultInfo);
        }

        //【取消】按钮处理函数
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 检测分析用户输入，提取正确数据
        /// 若检测到错误或发生异常，应打印checkUserInputResultInfo信息
        /// </summary>
        /// <returns></returns>
        private bool checkUserInput() 
        {
            //检测NodeId是否合法以及是否重复
            //检查KeyMap
            //检查TableMap
            //检查InNodeIdList            
            //检测OutNodeIdList输入
            return this.checkNodeId() &&
                   this.checkKeysMap() &&
                   this.checkTablesMap() &&
                   this.checkInNodeIdList() &&
                   this.checkOutNodeIdList();
        }

        /// <summary>
        /// 检测用户输入的NodeId
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
                this.checkUserInputResultInfo = "NodeId输入有误，只能接受非负整数";
                return false;
            }
            if (this.graph.FindVertexById(this.nodeId) != null)
            {
                this.checkUserInputResultInfo = "图中已存在NodeId：" + this.nodeId + " 的节点";
                return false;
            }
            return true;
        }

        /// <summary>
        /// 检测用户输入KeysMap
        /// </summary>
        /// <returns></returns>
        private bool checkKeysMap() 
        {
            if (String.IsNullOrEmpty(this.keyMapRichText.Text))
            {
                this.checkUserInputResultInfo = "KeysMap不能为空";
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
                    this.checkUserInputResultInfo = "分割获取KeyMap时，发生异常： \r\n\t" + ex.StackTrace;
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 检测用户输入TablesMap
        /// </summary>
        /// <returns></returns>
        private bool checkTablesMap() 
        {
            if (String.IsNullOrEmpty(this.tableMapRichText.Text))
            {
                this.checkUserInputResultInfo = "TablesMap不能为空";
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
                    this.checkUserInputResultInfo = "分割获取TableMap时，发生异常：\r\n\t" + ex.StackTrace;
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
                            this.checkUserInputResultInfo = "InNode不存在，无法关联, NodeId=" + nodeIdStr;
                            return false;
                        }
                        this.inEdgeList.Add(new Edge(currentNodeId, this.nodeId));
                    }
                }
                catch (Exception ex)
                {
                    this.checkUserInputResultInfo = "分析InNodeIdList时发生异常 \r\n" + ex.StackTrace;
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 检测用户输入OutNodeIdList
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
                            this.checkUserInputResultInfo = "OutNode不存在，无法关联，NodeId=" + nodeIdStr;
                            return false;
                        }
                        this.outEdgeList.Add(new Edge(this.nodeId, currentNodeId));
                    }
                }
                catch (Exception ex)
                {
                    this.checkUserInputResultInfo = "分析获取OutNodeIdList时发生异常，\r\n" + ex.StackTrace;
                    return false;
                }
            }

            return true;
        }
    }
}
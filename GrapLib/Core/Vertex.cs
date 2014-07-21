using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace GraphLib.Core
{
    /// <summary>
    /// 图中各定点的结构定义
    /// 特别注意：
    ///     KeyMap与TableMap要保持同步更新，确保：
    ///     KeyMap中的每个关键字对应的数据表，在TableMap中都有一致定义
    ///     否则会出现二次查找不能精确匹配或匹配失效
    /// </summary>
    public class Vertex
    {
        private int nodeId;
        private int nodeLevel;       
        private List<Edge> inEdgeList;
        private List<Edge> outEdgeList;
        private List<KeyMap> keysMap;
        private List<TableMap> tablesMap;

        public Vertex() 
        {

        }

        /// <summary>
        /// 定点的构造函数
        /// </summary>
        /// <param name="nodeId">顶点索引编号</param>
        /// <param name="inEdgeList">入边集合</param>
        /// <param name="outEdgeList">出边集合</param>
        /// <param name="keysMap">KeyMap列表</param>
        /// <param name="tablesMap">TableMap列表</param>
        public Vertex(int nodeId, List<Edge> inEdgeList, List<Edge> outEdgeList,
            List<KeyMap> keysMap, List<TableMap> tablesMap) 
        {
            this.nodeId = nodeId;
            this.nodeLevel = GraphUtils.getNodeLevel(nodeId);
            this.inEdgeList = inEdgeList != null ? inEdgeList : new List<Edge>();
            this.outEdgeList = outEdgeList != null ? outEdgeList : new List<Edge>();
            this.keysMap = keysMap != null ? keysMap : new List<KeyMap>();
            this.tablesMap = tablesMap != null ? tablesMap : new List<TableMap>();
        }

        /// <summary>
        /// 将本节点更新为新的指定节点
        /// </summary>
        /// <param name="newVertex">新节点</param>
        public void UpdateToNewVertex(Vertex newVertex) 
        {
            this.nodeId = newVertex.nodeId;
            this.nodeLevel = newVertex.NodeLevel;
            this.inEdgeList = newVertex.InEdgeList;
            this.outEdgeList = newVertex.OutEdgeList;
            this.keysMap = newVertex.KeysMap;
            this.tablesMap = newVertex.TablesMap;
        }

        /// <summary>
        /// 获取或设置节点唯一编号
        /// </summary>
        [CategoryAttribute("节点基本信息"),DescriptionAttribute("NodeId")]
        public int NodeId
        {
            get { return this.nodeId; }
            set 
            {
                this.nodeId = value;
                this.nodeLevel = GraphUtils.getNodeLevel(value);
            }
        }

        /// <summary>
        /// 获取定点级别
        /// 级别不能单独更改，只有通过更改NodeId，才会自动升降级别
        /// 级别定义(9位整数)：
        ///       xx      xxx      xxxx
        ///      level1  level2   level3  
        /// </summary>
        [CategoryAttribute("节点基本信息"),DescriptionAttribute("NodeLevel")]
        public int NodeLevel 
        {
            get { return this.nodeLevel; }
        }

        /// <summary>
        /// 获取或设置入边集合
        /// </summary>
        [CategoryAttribute("有向边信息"), DescriptionAttribute("InEdgeList")]
        public List<Edge> InEdgeList 
        {
            get { return this.inEdgeList; }
            set { this.inEdgeList = value; }
        }

        /// <summary>
        /// 获取或设置出边集合
        /// </summary>
        [CategoryAttribute("有向边信息"), DescriptionAttribute("OutEdgeList")]
        public List<Edge> OutEdgeList 
        {
            get { return this.outEdgeList; }
            set { this.outEdgeList = value; }
        }

        /// <summary>
        /// 获取或设置关键字与数据表的对应字典
        /// </summary>
        [CategoryAttribute("二次索引信息"), DescriptionAttribute("KeyMap")]
        public List<KeyMap> KeysMap
        {
            get { return this.keysMap; }
            set { this.keysMap = value; }
        }

        /// <summary>
        /// 获取或设置数据表与字段的对应关心字典
        /// </summary>
        [CategoryAttribute("二次索引信息"), DescriptionAttribute("TableMap")]
        public List<TableMap> TablesMap 
        {
            get { return this.tablesMap; }
            set { this.tablesMap = value; }
        }

        /// <summary>
        /// 获取节点整体详情
        /// </summary>
        public String Description 
        {
            get 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("NodeId:{0}", this.nodeId);
                if(this.keysMap!=null && this.keysMap.Count>0)
                {
                    sb.Append("\r\n    KeyMap:\r\n    ----------");
                    foreach (KeyMap keymap in this.keysMap) 
                    {
                        sb.AppendFormat("\r\n    {0}:{1}", keymap.Key, String.Join(",",keymap.TableNames));
                    }
                }
                if (this.tablesMap != null && this.tablesMap.Count > 0) 
                {
                    sb.Append("\r\n\r\n    TableMap:\r\n    ----------");
                    foreach (TableMap tablemap in this.tablesMap) 
                    {
                        sb.AppendFormat("\r\n    {0}:{1} \r\n{2}", tablemap.TableName, tablemap.RecordsCount, String.Join(",",tablemap.TableFields));
                    }
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// 获取节点基本信息
        /// </summary>
        /// <returns></returns>
        public String GetBasicText() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NodeId:{0}", this.nodeId);
            if (this.keysMap != null && this.keysMap.Count > 0)
            {
                List<String> keys=new List<string>();
                sb.Append("\r\n--------------------\r\nKeys:");
                foreach (KeyMap keymap in this.keysMap) 
                {
                    keys.Add(keymap.Key);
                }
                
                sb.Append(String.Join("|", keys));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取KeyMap关联信息
        /// </summary>
        /// <returns></returns>
        public String GetKeysText() 
        {
            StringBuilder sb = new StringBuilder();
            
            if (this.keysMap != null && this.keysMap.Count > 0)
            {
                sb.AppendFormat("KeyMap:{0}", this.keysMap.Count);
                sb.Append("\r\n--------------------\r\n");
                foreach (KeyMap keymap in this.keysMap)
                {
                    sb.AppendFormat("\r\n{0}:{1}", keymap.Key, String.Join(",", keymap.TableNames));
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// 获取TableMap信息
        /// </summary>
        /// <returns></returns>
        public String GetTablesText() 
        {
            StringBuilder sb = new StringBuilder();
            if (this.tablesMap != null && this.tablesMap.Count > 0) 
            {
                sb.AppendFormat("TableMap:{0}", this.tablesMap.Count);
                sb.Append("\r\n--------------------\r\n");
                foreach (TableMap tablemap in this.tablesMap) 
                {
                    sb.AppendFormat("\r\n{0}:{1} \r\n{2}", tablemap.TableName, tablemap.RecordsCount, String.Join(",", tablemap.TableFields));
                }
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace GraphLib.Core
{
    /// <summary>
    /// 图中各边的结构定义
    /// </summary>
    public class Edge
    {
        private int startNodeId;

        private int endNodeId;

        //2014-7-11 边的权重不应是静态的数值
        //这个需根据两端顶点使用的关联表，动态计算
        //private int weight;

        public Edge() { }

        /// <summary>
        /// 构造函数，指定起止节点及有向边权重
        /// </summary>
        /// <param name="startNodeId">起始节点ID</param>
        /// <param name="endNodeId">终止节点ID</param>
        /// <param name="weight">权重</param>
        //public Edge(int startNodeId, int endNodeId, int weight) 
        //{
        //    this.startNodeId = startNodeId;
        //    this.endNodeId = endNodeId;
        //    this.weight = weight;
        //}

        /// <summary>
        /// 边的构造函数
        /// </summary>
        /// <param name="startNodeId">起始节点ID</param>
        /// <param name="endNodeId">终止节点ID</param>
        public Edge(int startNodeId, int endNodeId)
        {
            this.startNodeId = startNodeId;
            this.endNodeId = endNodeId;
        }

        /// <summary>
        /// 获取或设置起点ID
        /// </summary>
        [CategoryAttribute("有向边定义"),DescriptionAttribute("StartNodeId")]
        public int StartNodeId
        {
            get { return this.startNodeId; }
            set { this.startNodeId = value; }
        }

        /// <summary>
        /// 获取或设置边的终点
        /// </summary>
        [CategoryAttribute("有向边定义"), DescriptionAttribute("EndNodeId")]
        public int EndNodeId
        {
            get { return this.endNodeId; }
            set { this.endNodeId = value; }
        }

        /// <summary>
        /// 获取或设置边的权重
        /// </summary>
        //[CategoryAttribute("有向边定义"), DescriptionAttribute("Weight")]
        //public int Weight
        //{
        //    get { return this.weight; }
        //    set { this.weight = value; }
        //}
    }
}

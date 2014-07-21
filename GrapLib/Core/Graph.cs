using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLib.Core
{
    public class Graph
    {
        //
        // 单例模式唯一实例，保证有向图数据一致性
        //
        private static Graph instance = null;

        //
        // 顶点集合
        //
        private List<Vertex> vertexs = null;

        //
        // 有向图起点，id号固定为0
        //
        private Vertex startVertex = null;

        //
        // 一级关键字顶点集合
        //
        private List<Vertex> level1Vertexs = null;

        //
        // 二级关键字顶点集合
        //
        private List<Vertex> level2Vertexs = null;

        //
        // 三级关键字顶点集合
        //
        private List<Vertex> level3Vertexs = null;

        /// <summary>
        /// 私有构造函数，提供顶点集合
        /// </summary>
        /// <param name="vertexList">顶点集合</param>
        private Graph(List<Vertex> vertexList) 
        {
            this.vertexs = vertexList;
            this.level1Vertexs = new List<Vertex>();
            this.level2Vertexs = new List<Vertex>();
            this.level3Vertexs = new List<Vertex>();
            this.initGraph();//初始化
        }

        /// <summary>
        /// 构造函数，构造空的有向图，仅包含虚拟的起始顶点
        /// </summary>
        private Graph() 
        {
            this.startVertex = new Vertex(0, null, new List<Edge>(), null, null);
            this.vertexs = new List<Vertex>();
            this.vertexs.Add(this.startVertex);

            this.level1Vertexs = new List<Vertex>();
            this.level2Vertexs = new List<Vertex>();
            this.level3Vertexs = new List<Vertex>();
        }

        /// <summary>
        /// 不提供任何顶点，构建空的有向图
        /// </summary>
        /// <returns></returns>
        public static Graph GetInstance() 
        {
            return GetInstance(null);
        }

        /// <summary>
        /// 获取或初始化有向图，如果是初始化则提供顶点集合。
        /// </summary>
        /// <param name="vertexs">顶点集合</param>
        /// <returns></returns>
        public static Graph GetInstance(List<Vertex> vertexs) 
        {
            if (instance != null) return instance;
            else if (vertexs != null && vertexs.Count > 0)
            {
                instance = new Graph(vertexs);
                return instance;
            }
            else
                return new Graph();
        }

        /// <summary>
        /// 初始化有向图的详细信息
        /// </summary>
        private void initGraph() 
        {
            if (this.vertexs != null && this.vertexs.Count > 0)
            {
                foreach (Vertex vertex in this.vertexs)
                {
                    //获取有向图起始顶点
                    if (vertex.NodeId == 0 && vertex.InEdgeList == null)
                    {
                        this.startVertex = vertex;
                        continue;
                    }

                    //自动分级
                    try
                    {
                        this.mapNodeLevel(vertex);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //检测起始点是否设置正确
            if (this.startVertex == null || !this.checkStartVertex(this.startVertex))
                throw new ArgumentNullException("有向图没有起始顶点或起始顶点没有关联所有Level1顶点");
        }

        /// <summary>
        /// 更新有向图某个节点，自动同步分级及对应边关系
        /// </summary>
        /// <param name="newVertex">新顶点</param>
        /// <param name="oldNodeId">旧顶点编号</param>
        /// <returns></returns>
        public bool UpdateVertex (Vertex newVertex, int oldNodeId)
        {
            //起始顶点多一步处理
            if (newVertex.NodeId == 0 &&
                newVertex.InEdgeList == null &&
                oldNodeId == 0)
            {
                if (checkStartVertex(newVertex))
                {
                    this.startVertex.UpdateToNewVertex(newVertex);
                }
            }

            //查找更新节点
            foreach (Vertex vertex in this.vertexs)
            {
                if (vertex.NodeId == oldNodeId)
                {
                    vertex.UpdateToNewVertex(newVertex);
                    
                    //重建边的对应关系
                    this.RebuildVertexsEdge(newVertex, vertex);

                    //重新划分层级关系
                    this.RebuildVertexLevel(newVertex, vertex);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 添加新的顶点到有向图，自动同步分级信息及对应边关系
        /// 该顶点为非起点
        /// </summary>
        /// <param name="newVertex">新顶点</param>
        /// <returns></returns>
        public bool AddVertex(Vertex newVertex) 
        {
            try
            {
                //添加顶点到总表
                this.vertexs.Add(newVertex);
                //自动分级
                this.mapNodeLevel(newVertex);
                //重建有向边的对应关系
                this.RebuildVertexsEdge(newVertex,null);

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }
        }

        /// <summary>
        /// 根据NodeId查找指定顶点
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public Vertex FindVertexById(int nodeId) 
        {
            foreach (Vertex vertex in this.Vertexs) 
            {
                if (vertex.NodeId == nodeId)
                    return vertex;
            }
            return null;
        }

        /// <summary>
        /// 删除指定编号的节点，自动回收分级信息及重建对应边关系
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public Vertex DelVertex(int nodeId) 
        {
            Vertex deletedVer = null;
            foreach (Vertex vertex in this.vertexs) 
            {
                if (vertex.NodeId == nodeId) 
                {
                    this.vertexs.Remove(vertex);
                    deletedVer = vertex;
                }
            }

            return deletedVer;
        }

        /// <summary>
        /// 更新，删除或新建节点时，重建前后置节点到本节点出入边的对应关系
        /// 当为新建节点时，oldVertex=null
        /// 当删除节点时，newVertex=null
        /// </summary>
        /// <param name="newVertex">新节点</param>
        /// <param name="oldVertex">旧节点</param>
        public void RebuildVertexsEdge(Vertex newVertex, Vertex oldVertex) 
        {
            //删除(旧节点) 前置节点到本节点的出边
            if (oldVertex != null && oldVertex.InEdgeList != null && oldVertex.InEdgeList.Count > 0) 
            {
                foreach (Edge inEdge in oldVertex.InEdgeList)
                {
                    Vertex prevNode = this.FindVertexById(inEdge.StartNodeId);
                    foreach (Edge outEdge in prevNode.OutEdgeList)
                    {
                        if (outEdge.EndNodeId == oldVertex.NodeId)
                            prevNode.OutEdgeList.Remove(outEdge);
                    }
                }
            }
            
            //删除(旧节点) 后置节点被本节点指向的入边
            if (oldVertex != null && oldVertex.OutEdgeList != null && oldVertex.OutEdgeList.Count > 0) 
            {
                foreach (Edge outEdge in oldVertex.OutEdgeList)
                {
                    Vertex nextNode = this.FindVertexById(outEdge.EndNodeId);
                    foreach (Edge inEdge in nextNode.InEdgeList)
                    {
                        if (inEdge.StartNodeId == oldVertex.NodeId)
                            nextNode.InEdgeList.Remove(inEdge);
                    }
                }
            }          

            //添加新节点前置节点出边
            if (newVertex != null && newVertex.InEdgeList != null && newVertex.InEdgeList.Count > 0) 
            {
                foreach (Edge inEdge in newVertex.InEdgeList)
                {
                    Vertex prevNode = this.FindVertexById(inEdge.StartNodeId);
                    prevNode.OutEdgeList.Add(inEdge);
                }
            }
            
            //更新新节点后置节点入边
            if (newVertex != null && newVertex.OutEdgeList != null && newVertex.OutEdgeList.Count > 0) 
            {
                foreach (Edge outEdge in newVertex.OutEdgeList)
                {
                    Vertex nextNode = this.FindVertexById(outEdge.EndNodeId);
                    nextNode.InEdgeList.Add(outEdge);
                }
            }
            
        }

        /// <summary>
        /// 当某个顶点被新顶点替换时，
        /// </summary>
        /// <param name="newVertex">新顶点</param>
        /// <param name="oldVertex">旧顶点</param>
        public void RebuildVertexLevel(Vertex newVertex, Vertex oldVertex) 
        {
            if (newVertex.NodeLevel == oldVertex.NodeLevel) return;

            try
            {
                //新的顶点分发到新层级中
                this.mapNodeLevel(newVertex);

                //旧顶点从原来的层级删除
                this.reduceNodeLevel(oldVertex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 分发指定节点到与其匹配的等级中
        /// </summary>
        /// <param name="vertex">待分级的顶点</param>
        private void mapNodeLevel(Vertex vertex) 
        {
            switch (vertex.NodeLevel)
            {
                case 0:
                    break;
                case 1:
                    this.level1Vertexs.Add(vertex);
                    break;
                case 2:
                    this.level2Vertexs.Add(vertex);
                    break;
                case 3:
                    this.level3Vertexs.Add(vertex);
                    break;
                default:
                    throw new ArgumentException("顶点集合中存在无法分级的顶点(NodeId=" +
                        vertex.NodeId + ")，初始化失败");
            }
        }

        /// <summary>
        /// 从分级别中删除指定顶点
        /// </summary>
        /// <param name="vertex"></param>
        private void reduceNodeLevel(Vertex vertex) 
        {
            switch (vertex.NodeLevel) 
            {
                case 0:
                    break;
                case 1:
                    this.level1Vertexs.Remove(vertex);
                    break;
                case 2:
                    this.level2Vertexs.Remove(vertex);
                    break;
                case 3:
                    this.level3Vertexs.Remove(vertex);
                    break;
                default:
                    throw new Exception("未知的Level分级，无法从对应分级表中删除");
            }
        }

        /// <summary>
        /// 检测起始节点是否指向了所有Level1的顶点
        /// </summary>
        /// <param name="newStartVertex">起始节点</param>
        /// <returns></returns>
        private bool checkStartVertex(Vertex startVertex) 
        {
            if (this.level1Vertexs != null && this.level1Vertexs.Count > 0) 
            {
                //获取新起始点关联的1级顶点ID列表
                List<int> level1NodeIdList = new List<int>();
                foreach (Edge outEdge in startVertex.OutEdgeList)
                {
                    level1NodeIdList.Add(outEdge.EndNodeId);
                }

                //获取原起始点关联的1级顶点ID列表
                List<int> oldLevel1NodeIdList = new List<int>();
                foreach (Edge outEdge in this.startVertex.OutEdgeList)
                {
                    oldLevel1NodeIdList.Add(outEdge.EndNodeId);
                }

                //对比
                List<int> exceptNodeIdList = oldLevel1NodeIdList.Except(level1NodeIdList).ToList();
                if (exceptNodeIdList.Count == 0) return true;
            }
            return false;
        }


        //—————————— 属性定义 ——————————————————————

        public List<Vertex> Vertexs 
        {
            get { return this.vertexs; }
        }

        public Vertex StartVertex 
        {
            get { return this.startVertex; }
        }

        public List<Vertex> Level1Vertexs 
        {
            get 
            {
                return this.level1Vertexs;
            }
        }

        public List<Vertex> Level2Vertexs 
        {
            get { return this.level2Vertexs; }
        }

        public List<Vertex> Level3Vertexs
        {
            get { return this.level3Vertexs; }
        }
    }
}

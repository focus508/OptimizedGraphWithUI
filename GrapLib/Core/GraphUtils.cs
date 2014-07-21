using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLib.Core
{
    public class GraphUtils
    {
        /// <summary>
        /// 枚举两个节点的集合关系：
        /// 相等，
        /// 前者包含后者
        /// 前者被后者包含
        /// 前者与后者相交，但不包含
        /// 前者与后者不相交，只能取并集
        /// </summary>
        public enum SetRelationType
        {
            //
            // 两节点的KeyMap及TableMap完全一致的情况 
            //
            Equal = 0,

            //
            // 前者包含后者
            //
            FullInclude = 1,

            //
            // 前者被后者包含
            //
            FullBeenIncluded = 2,

            //
            // 前者与后者相交，但不存在包含关系
            //
            Crossing = 3,

            //
            // 前者与后者完全不相交，只能取并集
            //
            Union = 4,

            //
            // 前后者不存在比较关系
            //
            Unknow=5,
        };

        /// <summary>
        /// 比较两个节点的集合对应关系(比较KeyMap与TableMap)
        /// </summary>
        /// <param name="v1">节点1</param>
        /// <param name="v2">节点2</param>
        /// <returns></returns>
        //public static SetRelationType getSetRelationType(Vertex v1, Vertex v2) 
        //{
            
        //}

        /// <summary>
        /// 根据指定的NodeId获取对应的NodeLevel
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public static int getNodeLevel(int nodeId) 
        {
            int level = -1;
            if (nodeId < 0) 
            {
                throw new ArgumentException("NodeId不能为负");
            }

            if (nodeId / 10000000 >= 1) return level = 1;
            else if (nodeId / 10000000 < 1 && nodeId / 10000 > 1) return level = 2;
            else if (nodeId / 10000 < 1 && nodeId > 1) return level = 3;
            else if (nodeId == 0) return 0;
            else return level;
        }
    }
}

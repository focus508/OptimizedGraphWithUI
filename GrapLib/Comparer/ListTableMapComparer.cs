using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GraphLib.Core;

namespace GraphLib.Comparer
{
    /// <summary>
    /// TableMap列表比较器
    /// </summary>
    public class ListTableMapComparer : EqualityComparer<List<TableMap>>
    {
        /// <summary>
        /// 比较两个List<TableMap>泛型列表是否相同
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool Equals(List<TableMap> x, List<TableMap> y)
        {
            if (x == null || y == null) return x == y;
            if (x.Except(y).Count() == 0 && y.Except(x).Count() == 0) 
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 重载GetHashCode
        /// </summary>
        /// <param name="ltm"></param>
        /// <returns></returns>
        public override int GetHashCode(List<TableMap> ltm)
        {
            if (ltm == null) return 0;
            int hashCode = 17;

            foreach (TableMap tm in ltm) 
            {
                hashCode = hashCode * 3 + tm.GetHashCode();
            }
            return hashCode;
        }
    }
}

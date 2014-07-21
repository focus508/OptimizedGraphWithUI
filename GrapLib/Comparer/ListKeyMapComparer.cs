using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GraphLib.Core;

namespace GraphLib.Comparer
{
    /// <summary>
    /// KeyMap比较器,用于
    /// </summary>
    public class ListKeyMapComparer : EqualityComparer<List<KeyMap>>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool Equals(List<KeyMap> x, List<KeyMap> y)
        {
            if (x == null || y == null) return x == y;
            if (x.Except(y).Count() == 0 && y.Except(x).Count() == 0)
                return true;
            return false;
        }

        /// <summary>
        /// 重写GetHashCode算法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int GetHashCode(List<KeyMap> lkm)
        {
            if (lkm == null) return 0;
            int hashCode = 17;

            foreach (KeyMap km in lkm) 
            {
                hashCode = hashCode * 3 + km.GetHashCode();
            }
            return hashCode;
        }
    }
}

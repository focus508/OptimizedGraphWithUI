using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphLib.Comparer
{
    public class ListStringComparer : EqualityComparer<List<String>>
    {
        /// <summary>
        /// List<String> 比较器
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool Equals(List<string> x, List<string> y)
        {
            if (x == null || y == null) return x == y;
            if (x.Count == y.Count) 
            {
                foreach (String s in x) 
                {
                    if (y.Contains(s)) return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 重写GetHashCode算法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int GetHashCode(List<string> obj)
        {
            if (obj == null) return 0;
            int hashCode = 17;

            hashCode = hashCode * 3 + obj.Count.GetHashCode();
            foreach (String s in obj) 
            {
                hashCode = hashCode * 3 + s.GetHashCode();
            }

            return hashCode;
        }
    }
}

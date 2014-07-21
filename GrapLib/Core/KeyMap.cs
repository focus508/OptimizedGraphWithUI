using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using GraphLib.Comparer;

namespace GraphLib.Core
{
    /// <summary>
    /// 定义节点中二次索引的关键字与表名的对应关系
    /// </summary>
    public class KeyMap
    {
        private String key;
        private List<String> tableNames;

        public KeyMap() { }

        /// <summary>
        /// 构造函数 指定关键字及关联表名列表
        /// </summary>
        /// <param name="key">关键字</param>
        /// <param name="tableNames">关联表名列表</param>
        public KeyMap(String key, List<String> tableNames) 
        {
            this.key = key;
            this.tableNames = tableNames;
        }

        /// <summary>
        /// 重载Equals函数，实现KeyMap比较
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override bool Equals(object o)
        {
            //NULL及类型错误判断，NULL要优先判断
            if (o == null || !o.GetType().Equals(this.GetType())) return false;
            //指向同一个引用，直接返回True
            if (object.ReferenceEquals(this,o)) return true;

            KeyMap keymap = o as KeyMap;
            if (this.key == keymap.Key &&
                this.tableNames.Except(keymap.TableNames).Count() == 0 &&
                keymap.TableNames.Except(this.tableNames).Count() == 0) 
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 重载GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (this == null) return 0;
            int hashCode = 17;
            hashCode = hashCode * 3 + this.key.GetHashCode();
            foreach (String tname in this.tableNames) 
            {
                hashCode = hashCode * 3 + tname.GetHashCode();
            }
            return hashCode;
        }

        [CategoryAttribute("KeMap定义"), DescriptionAttribute("Key")]
        public String Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        [CategoryAttribute("KeMap定义"), DescriptionAttribute("TableNames")]
        public List<String> TableNames
        {
            get { return this.tableNames; }
            set { this.tableNames = value; }
        }
    }
}

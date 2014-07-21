using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace GraphLib.Core
{
    public class TableMap
    {
        private String tableName;
        private List<String> tableFields;
        private long recordsCount = 1;

        public TableMap() { }

        public TableMap(String tableName, List<String> tableFields, long recordsCount) 
        {
            this.tableName = tableName;
            this.tableFields = tableFields;
            this.recordsCount = (recordsCount < 1 ? recordsCount = 1 : recordsCount);
        }

        /// <summary>
        /// 获取或设置表名
        /// </summary>
        [CategoryAttribute("TableMap定义"), DescriptionAttribute("表名")]
        public String TableName
        {
            get { return this.tableName; }
            set { this.tableName = value; }
        }

        /// <summary>
        /// 获取或设置表中包含的字段
        /// </summary>
        [CategoryAttribute("TableMap定义"), DescriptionAttribute("表中字段名列表")]
        public List<String> TableFields
        {
            get { return this.tableFields; }
            set { this.tableFields = value; }
        }

        /// <summary>
        /// 获取或设置表中记录数
        /// </summary>
        [CategoryAttribute("TableMap定义"),Description("表中记录数")]
        public long RecordsCount 
        {
            get { return this.recordsCount; }
            set { this.recordsCount = value; }
        }
    }
}

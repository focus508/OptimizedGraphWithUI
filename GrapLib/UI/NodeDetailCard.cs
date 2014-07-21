using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar;

namespace GraphLib.UI
{
    public partial class NodeDetailCard : UserControl
    {
        //是否展开
        private bool m_Expended = false;

        //展开高度
        private int m_ExpendedHeight = 189;

        //展开宽度
        private int m_ExpendedWidth = 305;

        //收缩宽度
        private int m_UnExpendedWidth = 150;

        public NodeDetailCard(StyleManager styleManager)
        {
            this.cardStyleManager = styleManager;

            InitializeComponent();

            //设置展开高度
            this.m_ExpendedHeight = this.Height;
            this.Height = this.titleLabel.Height;

            this.BorderStyle = BorderStyle.None;
        }

        //【标题点击】伸缩控件处理函数
        private void titleLabel_Click(object sender, EventArgs e)
        {
            this.m_Expended = !this.m_Expended;
            this.Expended = this.m_Expended;
        }

        /// <summary>
        /// 获取或设置控件标题
        /// </summary>
        public String TitleText
        {
            get { return this.titleLabel.Text; }
            set { this.titleLabel.Text = value; }
        }

        /// <summary>
        /// 获取或设置NodeDetails的基本信息标签
        /// </summary>
        public String BasicLableText
        {
            get { return this.basicLabel.Text; }
            set { this.basicLabel.Text = value; }
        }

        /// <summary>
        /// 获取或设置NodeDetails的关键字信息标签
        /// </summary>
        public String KeysLabelText
        {
            get { return this.keymapLabel.Text; }
            set { this.keymapLabel.Text = value; }
        }

        /// <summary>
        /// 获取或设置NodeDetails的关联表信息标签
        /// </summary>
        public String TablesLabelText
        {
            get { return this.tablemapLabel.Text; }
            set { this.tablemapLabel.Text = value; }
        }

        /// <summary>
        /// 展开或收缩控件，自动重新定位尺寸
        /// </summary>
        public bool Expended
        {
            get { return this.m_Expended; }
            set
            {
                this.m_Expended = value;
                Size size = this.Size;
                //if (this.Parent is DevComponents.Tree.TreeGX)
                //{
                //    size = ((DevComponents.Tree.TreeGX)this.Parent).GetLayoutRectangle(this.Bounds).Size;
                //}
                if (this.m_Expended)
                {
                    size.Height = this.m_ExpendedHeight;
                    size.Width = this.m_ExpendedWidth;
                }
                else
                {
                    size.Height = this.titleLabel.Height;
                    size.Width = this.m_UnExpendedWidth;
                }
                this.Size = size;
            }
        }

        //重绘控件时，处理边框
        //private void NodeDetails_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Pen pen = new Pen(System.Drawing.Color.Chocolate);//边框颜色
        //    Point[] point = new Point[4];
        //    point[0] = new Point(0, 0);
        //    point[1] = new Point(this.Width, 0);
        //    point[2] = new Point(this.Width, this.Height);
        //    point[3] = new Point(0, this.Height);
        //    g.DrawPolygon(pen, point);
        //}
    }
}

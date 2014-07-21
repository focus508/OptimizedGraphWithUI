using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GraphLib;
using GraphLib.Comparer;
using GraphLib.Core;
using NUnit.Framework;
using Moq;

namespace GlibTest
{
    [TestFixture]
    public class Program
    {
        [Test]
        //[ExpectedException(typeof())]
        [ExpectedException]
        public void ListStringComparerTest() 
        {
            //无比较器版本
            Dictionary<List<String>, String> dict1 = new Dictionary<List<string>, string>();
            //带比较器版本
            ListStringComparer lsc=new ListStringComparer();
            Dictionary<List<String>, String> dict2 = new Dictionary<List<string>, string>(lsc);
            Mock<Dictionary<List<String>,String>> mockDict = new Mock<Dictionary<List<String>, String>>();
            var dict3 = mockDict.Object;
            mockDict.Setup(m => m.Add("111,222,333,444".Split(',').ToList(), "Jim"));
            //mockDict.Setup(m => m.Add("111,222,333,444".Split(',').ToList(), "Tom")).Throws<Exception>();
            mockDict.Setup(m => m.Add("111,222,333,444".Split(',').ToList(), "Tom")).Throws(new Exception("键相同，插入失败"));
            

            dict1.Add("111,222,333,444".Split(',').ToList(), "Jim");
            dict1.Add("111,222,333,444".Split(',').ToList(), "Tom");

            dict2.Add("111,222,333,444".Split(',').ToList(), "Jim");
            dict2.Add("111,222,333,444".Split(',').ToList(), "Tom"); //这一步要报异常才通过测试，因为键重名
            Assert.Fail("键相同，插入失败，并产生异常");
        }

        [Test]
        public void KeyMapTest() 
        {
            KeyMap km1 = new KeyMap("电话", "t1.t2.t3".Split(',').ToList());
            KeyMap km2 = new KeyMap("电话", "t1.t2.t3".Split(',').ToList());
            KeyMap km3 = new KeyMap("卡号", "t2,t4,t5".Split(',').ToList());

            KeyMap km1Clone = km1;

            Assert.AreSame(km1, km1Clone);
            Assert.AreEqual(km1, km2);
            Assert.AreNotEqual(km1, null);
            Assert.AreNotEqual(null, km2);
            Assert.IsFalse(km1 == km2);
            Assert.IsFalse(km2 == km3);
        }

        [Test]
        public void ListKeyMapComparerTest() 
        {
            ListKeyMapComparer lkmc=new ListKeyMapComparer();
            List<KeyMap> lkm1 = new List<KeyMap>();
            KeyMap km1 = new KeyMap("电话", "t1.t2.t3".Split(',').ToList());
            KeyMap km2 = new KeyMap("电话", "t1.t2.t3".Split(',').ToList());
            KeyMap km3 = new KeyMap("卡号", "t2,t4,t5".Split(',').ToList());
            lkm1.Add(km1);
            lkm1.Add(km2);
            lkm1.Add(km3);

            List<KeyMap> lkm2 = new List<KeyMap>();
            KeyMap km4 = new KeyMap("电话", "t1.t2.t3".Split(',').ToList());
            KeyMap km5 = new KeyMap("电话", "t1.t2.t3".Split(',').ToList());
            KeyMap km6 = new KeyMap("卡号", "t2,t4,t5".Split(',').ToList());
            lkm2.Add(km4);
            lkm2.Add(km5);
            lkm2.Add(km6);

            Assert.IsTrue(lkm1.Contains(km1));
            Assert.IsTrue(lkm1.Except(lkm2).Count() == 0 && lkm2.Except(lkm1).Count() == 0);
        }
    }
}

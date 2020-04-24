using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chadder;
using System.Windows;
using System.Windows.Forms;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Privileges privilegetest1 = new Privileges();
            privilegetest1.valuesToList();
            if (!privilegetest1.getList.Contains("checkBox3"))
            {
                var e = new Exception("test");
                e.Data.Add("List1", privilegetest1.getList);
                throw e;
            }
        }
    }
}

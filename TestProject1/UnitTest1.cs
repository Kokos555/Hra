namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Name_POSITIVE()
        {
            string name = "Vojtasdhjuidashfuidf";
            Assert.IsTrue(name.Length > 10);
        }

        [TestMethod]
        public void Name_NEGATIVE()
        {
            string name = "Vojta";
            Assert.IsTrue(name.Length > 10);
        }
        [TestMethod]
        public void Name_IsNull()
        {
            string name = "Vojta";
            Assert.IsNotNull(name);
        }
        [TestMethod]
        public void Name_IsNotNull()
        {
            string name = null;
            Assert.IsNotNull(name);
        }
        [TestMethod]
        public void Level_POSITIVE()
        {
            int level = 1;
            Assert.AreEqual(1, level);
        }
        [TestMethod]
        public void Level_NEGATIVE()
        {
            int level = 1;
            Assert.AreEqual(2, level);
        }
        [TestMethod]
        public void X_POSITIVE()
        {
            int x = 0;
            Assert.AreEqual(0, x);
        }
        [TestMethod]
        public void X_NEGATIVE()
        {
            int x = 0;
            Assert.AreEqual(80, x);
        }
        [TestMethod]
        public void Y_POSITIVE()
        {
            int y = 0;
            Assert.AreEqual(0, y);
        }
        [TestMethod]
        public void Y_NEGATIVE()
        {
            int y = 0;
            Assert.AreEqual(80, y);
        }
        [TestMethod]
        public void Specialization_POSITIVE()
        {
            string[] classes = { "Kouzelnik", "Berserker", "Inženýr", "Cizák" };
            string name_of_class = "Kouzelnik";

            for (int i = 0; i < classes.Length; i++)
            {
                
            }
        }
    }
}
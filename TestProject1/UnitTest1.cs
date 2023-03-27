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
            string[] classes = { "Kouzelnik", "Berserker", "Inzenyr", "Cizak" };
            string name_of_class = "Kouzelnik";

            for (int i = 0; i < classes.Length; i++)
            {
                if (classes[i] == name_of_class)
                {
                    Assert.AreEqual(classes[i], name_of_class);
                }
            }
        }
        [TestMethod]
        public void Specialization_NEGATIVE()
        {
            string[] classes = { "Kouzelnik", "Berserker", "Inzenyr", "Cizak" };
            string name_of_class = "Berserker";

            for (int i = 0; i < classes.Length; i++)
            {
                if (classes[i] == name_of_class)
                {
                    Assert.AreNotEqual(classes[i], name_of_class);
                }
            }
        }
        [TestMethod]
        public void XP_NEGATIVE()
        {
            int xp = 0;
            Assert.AreEqual(80, xp);
        }
        [TestMethod]
        public void XP_POSITIVE()
        {
            int xp = 0;
            Assert.AreEqual(0, xp);
        }

        [TestMethod]
        public void Pridej_XP_POSITIVE()
        {
            int level = 2;
            int xp = 100;

            Assert.IsTrue(xp <= level * 100);
        }
        [TestMethod]
        public void Pridej_XP_NEGATIVE()
        {
            int level = 2;
            int xp = 800;

            Assert.IsTrue(xp <= level * 100);
        }


    }
}
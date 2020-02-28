using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EloadasProject
{
    [TestFixture]
    class EloadasTest

    {
        Eloadas e;
        [SetUp]
        public void SetUp()
        {
            e = new Eloadas(2, 2);
        }
        [TestCase]
        public void UjEloadasMindenHelyUres()
        {
            Assert.AreEqual(4, e.SzabadHelyek, "Üres előadas nem üres minden hely");
            Eloadas r2 = new Eloadas(4, 4);
            Assert.AreEqual(16, r2.SzabadHelyek, "Üres előadasd me, üres minden hely");
        }
        [TestCase]
        public void EloadasSzabadhelyekSzamaFoglal()
        {
            e.Lefoglal();
            e.Lefoglal();
            Assert.AreEqual(2, e.SzabadHelyek, "Üres helyre, üres minden hely");
        }
        [TestCase]
        public void UjEloadasNincsTeli()
        {
            Assert.IsFalse(e.Teli, "Új előadas teli van");
        }
        [TestCase]
        public void UjEloadasTeleVan()
        {
            for (int i = 0; i < 4; i++)
            {
                e.Lefoglal();
            }
            Assert.IsTrue(e.Teli, "Új előadas teli van");
        }
        [TestCase]
        public void TeliEloadasHelyFoglalas()
        {
            for (int i = 0; i < 4; i++)
            {
                e.Lefoglal();
            }
            e.Lefoglal();
            Assert.IsTrue(e.Teli, "Új repülő teli van");
        }
        
    }
}

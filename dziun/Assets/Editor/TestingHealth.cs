using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestingHealth
    {
        public class TheCurrentHealthProperty
        {
            [Test]
            public void Heatlh_Default_To_0()
            {
                var gamer = new Hero(0);

                Assert.AreEqual(0, gamer.CurrentHealth);
            }

            [Test]
            public void Throw_Exception_When_CH_Less_Than_0()
            {
                Assert.Throws<System.ArgumentOutOfRangeException>(() => new Hero(-1));
            }

            [Test]
            public void Throw_Exception_When_CR_Greater_Than_MH()
            {
                Assert.Throws<System.ArgumentOutOfRangeException>(() => new Hero(2, 1));
            }

            public class TheDamageMethod
            {
                [Test]
                public void _0_Does_Nothing()
                {
                    var hero = new Hero(1);

                    hero.Damage(0);

                    Assert.AreEqual(1, hero.CurrentHealth);
                }

                [Test]
                public void _1_Decrements_Current_Health()
                {
                    var hero = new Hero(1);

                    hero.Damage(1);

                    Assert.AreEqual(0, hero.CurrentHealth);
                }
            }
        }

    }
}
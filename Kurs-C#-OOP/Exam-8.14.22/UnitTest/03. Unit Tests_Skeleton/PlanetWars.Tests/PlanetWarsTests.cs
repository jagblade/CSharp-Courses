using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PlanetWars.Tests
{
    public class Tests
    {
        [TestFixture]
        public class PlanetWarsTests
        {
            private Planet testPlanet;
            private Weapon testWeapon;
            private List<Weapon> testWeapons;

            [SetUp]
            public void SetUp()
            {
               
                this.testPlanet = new Planet("TestPrime", 2000);
                
                this.testWeapon = new Weapon("TestWeapon", 500, 5);
                this.testWeapons = new List<Weapon>();
                this.testWeapons.Add(this.testWeapon);
                
            }

            [Test]
            public void PlanetConstructor_ShoudCreateNewPlanetCorrectly()
            {
                Planet actual = new Planet("TestPrime", 2000);

                string expectedName = testPlanet.Name;
                double expectedBuget = testPlanet.Budget;

                string actualName = actual.Name;
                double actualBuget = actual.Budget;

                Assert.AreEqual(expectedName, actualName,
                    "Planet name shoud be correct.");
                Assert.AreEqual(expectedBuget, actualBuget,
                    "Planet buget shoud be added correctly");

            }

            [Test]
            public void PlanetName_ShoudThrowExeptionIfNullOrEmpty()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Planet input = new Planet("", 2000);
                }, "Invalid planet Name"
                    );
                
            }

            [Test]
            public void PlanetBuget_ShoudThrowExeptionIfBelowZero()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Planet input = new Planet("Poor", -500);
                }, "Budget cannot drop below Zero!");
            }



            [Test]
            public void Weapons_ShoudAddCollectionOfWeapons()
            {
                var expectedCollection = testWeapons;

                Assert.True(expectedCollection is IReadOnlyCollection<Weapon>,
                    "Weapon collection shoud be generated correctly");
            }

            [TestCase(200)]
            [TestCase(-200)]
            public void MethodProfit_ShoudAddTeCorrectChangeBuget(double amount)
            {
                

                double expected = testPlanet.Budget + amount;
                testPlanet.Profit(amount);
                double actual = testPlanet.Budget;

                Assert.AreEqual(expected, actual,
                    "Buget change shoud be correct");
            
            }

            [Test]
            public void MethodSpendFunds_ShoudThrowExpetion()
            {
                Assert.Throws<InvalidOperationException>(() =>
                {
                    testPlanet.SpendFunds(2500);
                }, "Not enough funds to finalize the deal.");
            }

            [Test]
            public void MethodAddWeapon_ShouldCorrectlyCheckIfCurrentWeaponNameAlreadyExists()
            {
                Weapon weaponToAdd = new Weapon("TestWeapon", 100, 100);

                testPlanet.AddWeapon(weaponToAdd);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    testPlanet.AddWeapon(weaponToAdd);
                });
            }

            [Test]
            public void MethodRemoveWeapon_ShoudRemoveWeaponByName()
            {
                testPlanet.RemoveWeapon("TestWeapon");

                int expectedCount = 0;
                int actualCount = testPlanet.Weapons.Count;

                Assert.AreEqual(expectedCount, actualCount);

            }

            [Test]
            public void MethodUpgradeWeapon_ShoudThrowExeptionIfWeaponIsNotFound()
            {
                Assert.Throws<InvalidOperationException>(() =>
                {
                    testPlanet.UpgradeWeapon("InvalidName");
                }, "InvalidName does not exist in the weapon repository of TestPrime");
            }

            [Test]
            public void MethodUpgradeWeapon_ShoudUpgradeCorrectly()
            {

                var weaponToAdd = new Weapon("ToAdd", 100, 5);

                var expectedUpgrade = weaponToAdd.DestructionLevel + 1;

                testPlanet.AddWeapon(weaponToAdd);

                testPlanet.UpgradeWeapon("ToAdd");

                var actualUpgrade = weaponToAdd.DestructionLevel;

                Assert.AreEqual(expectedUpgrade, actualUpgrade);
            }

            [Test]
            public void MilitaryPowerRatio_ShoudCorrectlySumAllWeaponsDestrctionLevel()
            {
                testPlanet.AddWeapon(testWeapon);
                var extraWeapon = new Weapon("Extra", 100, 4);
                testPlanet.AddWeapon(extraWeapon);
                var expectedRatio = testWeapon.DestructionLevel + extraWeapon.DestructionLevel;
                var actualRatio = testPlanet.MilitaryPowerRatio;

                Assert.AreEqual(expectedRatio, actualRatio,
                    "Planet ration shoud be the sum of all weapons");
            }

            [Test]
            public void WeaponMethodIsNuclear_ShoudReturnTrue()
            {
                var nukeWeapon = new Weapon("Nuke", 500, 15);

               var expectedState = true;
                var actualState = nukeWeapon.IsNuclear;

                Assert.AreEqual(expectedState, actualState,
                    "Nuclear flag shoud work correctly.");
            }

            [Test]
            public void WeaponPrice_ShoudThrowExpetionIfNegative()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    var newWeapon = new Weapon("new", -50, 5);
                },"Price cannot be negative.");
            }

            [Test]
            public void WeaponPrice_ShoudReturnCorrectly()
            {
                var expectedPrice = 500;
                var actualPrice = testWeapon.Price;

                Assert.AreEqual(expectedPrice, actualPrice);
            }

            [Test]

            public void MethodDestructOpponent_ShoudThrowExpetionVsStrongerOpponent()
            {
                var opponent = new Planet("Opponent", 5000);
                opponent.AddWeapon(testWeapon);
                var extraWeapon = new Weapon("ExtraWeapon", 100, 10);
                opponent.AddWeapon(extraWeapon);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    testPlanet.DestructOpponent(opponent);
                }, $"{opponent.Name} is too strong to declare war to!");
            }

            [Test]

            public void MethodDestructOpponent_ShoudDestroyWeakerOpponent()
            {
                var opponent = new Planet("Opponent", 5000);
                testPlanet.AddWeapon(testWeapon);

                var expectedResult = "Opponent is destructed!";
                var actualResult = testPlanet.DestructOpponent(opponent);

                Assert.AreEqual(expectedResult, actualResult,
                    "Method shoud return planet destruct.");
            }
        }
            
    }
            
}



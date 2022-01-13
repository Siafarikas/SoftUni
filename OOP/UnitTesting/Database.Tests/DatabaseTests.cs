using NUnit.Framework;
using DatabaseProblem;
using System;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database db;

        [SetUp]
        public void Setup()
        {
            db = new Database();
        }

        [Test]
        public void Contstructor_EmptyCollection_ShouldReturnCountZero()
        {
            Database db = new Database();
            int actualRes = db.Count;
            int expectedRes = 0;

            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void Contstructor_WithTwoNums_ShouldReturnCountTwo()
        {
            Database db = new Database(1, 2);
            int actualRes = db.Count;
            int expectedRes = 2;

            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void Contstructor_WithTwoNums_ShouldBeAddedCorrectly()
        {
            Database db = new Database(1, 2);

            int[] expectedRes = { 1, 2 };

            int[] actualRes = db.Fetch();

            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void Contstructor_WithMoreThan16Nums_ShouldThrowInvalidOperationException()
        {
            int[] nums = new int[17];

            Assert.Throws<InvalidOperationException>(() => new Database(nums));
        }

        [Test]
        public void AddMethod_WithMoreThan16Nums_ShouldThrowInvalidOperationException()
        {
            int[] nums = new int[16];
            Database db = new Database(nums);

            Assert.Throws<InvalidOperationException>(() => db.Add(0));
        }

        [Test]
        public void AddMethod_AddOneNum_ShouldIncrementCount()
        {
            Database db = new Database();

            db.Add(1);


            int expectedRes = 1;
            int actualRes = db.Count;

            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void AddMethod_AddTwoNums_ShouldBeAddedCorrectly()
        {
            Database db = new Database();

            db.Add(0);
            db.Add(1);


            int[] expectedRes = { 0, 1 };
            int[] actualRes = db.Fetch();

            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void RemoveMethod_EmptyCollection_ShouldThrowInvalidOperationException()
        {
            Database db = new Database();

            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void RemoveMethod_CollectionWithTwoNums_ShouldCountBeOne()
        {
            Database db = new Database(1, 2);
            db.Remove();

            int expectedRes = 1;
            int actualRes = db.Count;

            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void FetchMethod_Collection_ShouldReturnArray()
        {
            Database db = new Database(1, 2);

            int[] nums = db.Fetch();

            Assert.That(nums is int[]);
        }
    }
}
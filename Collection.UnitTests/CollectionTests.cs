using Collections;

namespace Collection.UnitTests
{
    public class CollectionTests
    {
        
        [Test]
        public void Test_Collection_EmptyConstructor() 
        { 
            //Arrange and Act

            var coll = new Collection<int>();  

            //Assert

            Assert.AreEqual(coll.ToString(), "[]", "Check Collection Empty Constructor");

        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            //Arrange and Act

            var coll= new Collection<int>(5);

            //Assert

            Assert.AreEqual(coll.ToString(), "[5]", "Check Collection Constructor Single Items");

        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            //Arrange and Act

            var coll = new Collection<int>(5, 6, 7);

            //Assert

            Assert.AreEqual(coll.ToString(), "[5, 6, 7]", "Check Collection Constructor Multiple Items");

        }

        [Test]
        public void Test_Collection_Add()
        {
            //Arrange 

            var coll = new Collection<int>(5, 6, 7);
            var coll1 = new Collection<string>("Petya", "Stefan");

            //Act
            coll.Add(8);
            coll1.Add("Poli");

            //Assert

            var actual = coll.ToString();
            var expected = "[5, 6, 7, 8]";

            var actual1 = coll1.ToString();
            var expected1 = "[Petya, Stefan, Poli]";

            Assert.AreEqual(actual, expected, "Check Collection Add with int");
            Assert.AreEqual(actual1, expected1, "Check Collection Add with string");

            //Assert.AreEqual(coll.ToString(), "[5, 6, 7, 8]");

        }

        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            //Arrange 
            var coll = new Collection<int>(5, 6);

            //Assert

            Assert.AreEqual(coll.Count, 2, "Check Collection Count");
            Assert.AreEqual(coll.Capacity, 16, "Check collection Capacity");

        }



    }
}
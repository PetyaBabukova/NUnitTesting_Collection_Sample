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
            /*Assert.AreEqual(0, coll.Count, "Check Collection Count");
            Assert.AreEqual(16, coll.Capacity, "Check collection Capacity");*/
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
        public void Test_Collection_AddRange()
        {
            //Arrange 

            var coll = new Collection<int>(5, 6, 7);
            var coll1 = new Collection<string>("Petya", "Stefan");

            //Act
            coll.AddRange( 8, 9); ;
            coll1.AddRange("Poli", "Iva",  "Stefan");

            //Assert

            var actual = coll.ToString();
            var expected = "[5, 6, 7, 8, 9]";

            var actual1 = coll1.ToString();
            var expected1 = "[Petya, Stefan, Poli, Iva, Stefan]";

            Assert.AreEqual(actual, expected, "Check Collection AddRange with int");
            Assert.AreEqual(actual1, expected1, "Check Collection AddRange with string");

            //Assert.AreEqual(coll.ToString(), "[5, 6, 7, 8]");

        }

        [Test]
        public void Test_Collection_AddWithGrow()
        {
            //Arrange 
            var coll = new Collection<int>(5, 6, 7);
            

            //Act

            for (int i = 0; i < 5; i++)
            {
            coll.Add(i); ;

            }
            

            //Assert

            var actual = coll.ToString();
            var expected = "[5, 6, 7, 0, 1, 2, 3, 4]";

            
            Assert.AreEqual(actual, expected, "Check Collection AddWithGrow with int");
            

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

        [Test]
        public void Test_Collection_GetByIndex()
        {
            //Arrange 
            var coll = new Collection<int>(5, 6);


            //Assert
            Assert.That(coll[0], Is.EqualTo(5)  , "Check Get By Index");

        }

        [Test]
        public void Test_Collection_SetByIndex()
        {
            //Arrange 
            var coll = new Collection<int>(5, 6, 7);
            coll[1] = 666;

            //Assert
            Assert.That(coll.ToString(), Is.EqualTo("[5, 666, 7]"), "Check Get By Index");

        }

        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            //Arrange 
            var coll = new Collection<string>("Petya", "Stefan", "Poli");

            
            //Assert
            Assert.That(() => { var item = coll[3];  }, 
                Throws.InstanceOf<ArgumentOutOfRangeException>() , "Check Get By Index Out of Count");
            Assert.That(() => { var item = coll[-1]; }, 
                Throws.InstanceOf<ArgumentOutOfRangeException>() , "Check Get By invalid (negative) Index");
            Assert.That(() => { var item = coll[100]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>(), "Check Get By Index Out of Capacity");
            

        }



    }
}
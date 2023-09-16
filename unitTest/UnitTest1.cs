/******************************************************************************
* Filename    =UnitTest.cs
*
* Author      = [Author Name]
*
* Product     = [Product Name]
* 
* Project     = [Project Name]
*
* Description = This is unit test for builder which contruct two object of housebuilder 
* and compare them
*****************************************************************************/
using BuilderClass;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void House_AddressProperty_ShouldGetAndSetCorrectly()
        {
            /// <summary>
            /// this is the creating instance of  HouseBuilder and director
            /// </summary>

            IHouseBuilder builder = new houseBuilder(); 
            HouseDirector director = new HouseDirector(builder);

            ///<summary>
            ///// Construct the house
            /// </summary>
            director.ConstructHouse(); 
            House actualHouse = director.GetHouse(); 

            /// <summary>
            /// create and expected objected and compare with our object
            /// </summary>
            House expectHouse =new House();
            expectHouse.Address = "Modern";
            expectHouse.Door = "wooden";
            expectHouse.RoofType = "flat roof";

            Assert.AreEqual(expectHouse.Address, actualHouse.Address);
            Assert.AreEqual(expectHouse.Door, actualHouse.Door);
            Assert.AreEqual(expectHouse.RoofType, actualHouse.RoofType);
         }
        [TestMethod]
        public void jungleHouse()
        {
            /// <summary>
            /// this is unit test for Builder of type 2
            /// </summary>
            IHouseBuilder builder = new houseBuilder(); 
            HouseDirector director = new HouseDirector(builder); 

           
            director.ConstructTreeHouse(); 
            House actualHouse = director.GetHouse();
           

            House expectHouse = new House();
            expectHouse.Address = "jungle";
            expectHouse.Door = "Iron";
            expectHouse.RoofType = "flatroof";

            Assert.AreEqual(expectHouse.Address, actualHouse.Address);
            Assert.AreEqual(expectHouse.Door, actualHouse.Door);
            Assert.AreEqual(expectHouse.RoofType, actualHouse.RoofType);
        }

      

    }
}
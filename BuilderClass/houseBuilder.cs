
/******************************************************************************
* Filename    = houseBuilder.cs
*
* Author      = [Author Name]
*
* Product     = [Product Name]
* 
* Project     = [Project Name]
*
* Description = This class contruct 2 type of house
*****************************************************************************/
namespace BuilderClass
{
    public class houseBuilder : IHouseBuilder
    {   
        private readonly House house;
        public houseBuilder()
        {
            house = new House();
        }
        /// <summary>
        ///Setting Address,Door ,Toof for first type house 
        /// </summary>
        public void SetAddress()
        {
            house.Address = "Modern";
        }
        public void SetDoor()
        {
            house.Door = "wooden";
        }

        public void SetRoof()
        {
            house.RoofType = "flat roof";
        }
        /// <summary>
        ///Setting Address,Door ,Toof for second type of House 
        /// </summary>
        public void SetAddress1()
        {
            house.Address = "jungle";
        }
        public void SetDoor1()
        {
            house.Door = "Iron";
        }
        public void SetRoof1()
        {
            house.RoofType = "flatroof";
        }
        ///<summary>
        ///Setting Address,Door ,Toof for first type house 
        /// </summary>
    
        public House GetHouse()
        {
            return house;
        }


    }
}

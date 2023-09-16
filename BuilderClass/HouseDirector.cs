/******************************************************************************
* Filename    = HouseDirector.cs
*
* Author      = [Author Name]
*
* Product     = [Product Name]
* 
* Project     = [Project Name]
*
* Description = Director manage the builder .Here we set builder object
*****************************************************************************/

namespace BuilderClass
{
     

    public class HouseDirector
    {
        private IHouseBuilder _builder;
        /// <summary>
        /// Set the builder 
        /// </summary>
        /// <param name="builder">The House which data need  to contructed</param>
        public HouseDirector(IHouseBuilder builder)
        {
            this._builder = builder;
        }
        /// <summary>
        /// Get the contructed House
        /// </summary>
        /// <returns>The constructed HttpRequest.</returns>
        public House GetHouse()
        {
            return _builder.GetHouse();
        }
        /// <summary>
        /// contructs the house for type 1
        /// </summary>
        public void ConstructHouse()
        {
            _builder.SetAddress();
            _builder.SetDoor();
            _builder.SetRoof();
        }
        /// <summary>
        /// contructs the house for type 2
        /// </summary>
        public void ConstructTreeHouse()
        {
            _builder.SetAddress1();
            _builder.SetDoor1();
            _builder.SetRoof1();
        }


    }
   
}

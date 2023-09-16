
/******************************************************************************
* Filename    = IHouseBuilder.cs
*
* Author      = [Author Name]
*
* Product     = [Product Name]
* 
* Project     = [Project Name]
*
* Description = Interface for HouseBuilder
*****************************************************************************/
namespace BuilderClass
{
   public interface IHouseBuilder
    {
     /// <summary>
     /// Set address for House ,Roof,Ho
     /// </summary>
    public void SetAddress();
    public void SetDoor();
    public void SetRoof();
    public House GetHouse();
    public void SetAddress1();
    public void SetDoor1();
    public void SetRoof1();
    }

}




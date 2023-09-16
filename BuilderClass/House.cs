/******************************************************************************
* Filename    = House.cs
*
* Author      = [Author Name]
*
* Product     = [Product Name]
* 
* Project     = [Project Name]
*
* Description = this class represent a house with different properties
*****************************************************************************/
namespace BuilderClass
{
    /// <summary>
    /// Represents an House with address,door,roofType.
    /// </summary>
    public class House
    {

        private string address;          //variable for storing address
        private string door;             //the type of door
        private string roofType;         //variable for type of roof

        /// <summary>
        /// Gets or sets the Address.
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        /// <summary>
        /// Gets or sets Door.
        /// </summary>
        public string Door
        {
            get { return door; }
            set { door = value; }
        }
        /// <summary>
        /// Gets or sets For Rooftype.
        /// </summary>
        public string RoofType
        {
            get { return roofType; }
            set { roofType = value; }
        }
        




    }
}
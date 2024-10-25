using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_ClassRelationships.Aggregation;
using Week4_ClassRelationships.Association;
using Week4_ClassRelationships.Composition;

namespace Week4_ClassRelationships
{
    /*
     * 1. Composition
     * - most restrictive
     * - is when a class is dependant on an instance of another class type
     * - Class A cannot exist without Class B
     * - ex: Within a auto dealer system, a vehicle cannot exist without an engine
     * - ex: Within an architect system, a house cannot exist without a room
     * 
     * 
     * 
     * 2. Aggregation
     * - avg restrictive
     * - is when a class is not fully dependant on an instance of another class but it saves an instance
     *   of class b in one of its properties
     * - Class A can exist without Class B, 
     * but at some point it may use Class B, 
     * once Class A stops existing so will Class B instance
     * 
     * - the fact that Class B instance is being added to one
            of the properties of Class A instance....
            ....makes it Aggregation
     *
     * 
     * - ex: Within an e-commerce website (e.g eBay, Amazon) ShoppingCart class can exist without an instance of Item
     * -- but at any given time instance of ShoppingCart can hold an instance of Item 
     * 
     * 
     * 
     * 
     * 3. Association
     * - less restrictive
     * - is when a class instance is indepent of another class instance 
     * - Class A uses an instance of Class B but Class B instance is never saved/assigned/stored in Class A instance
     * ex: FileHandler and File, whereby FileHandler is used to restyle/open/close/delete any specfied File instance
     * 
     * 
     * 
     * 
     * 
     * 4. Inheritance 
     * 
     */


    /* summary: to distinguish between the 3 relationships
     * 
     * Composition - you need to store class b in a property of Class A + pass class B from the only contructor of Class A
     * Aggregation - you need to store class b in a property of Class A
     * Association - no need to store class b in a property of Class A
     * 
     */



    internal class Program
    {
        static void Main(string[] args)
        {
            //composition -- 1
            Kitchen myKitchen = new Kitchen();
            House myHouse = new House(myKitchen);


            //aggregation -- 2
            ShoppingCart myShoppingCart = new ShoppingCart();
            Item myItem = new Item();
            myShoppingCart.AddToCart(myItem);

            //the fact that Item myItem is being added to one
            // of the properties of ShoppingCart....
            //....makes it Aggregation

            //association --- 3

            FileHandler fh = new FileHandler();
            TextFile tf = new TextFile();
            tf.Path = ".....txt";

            string contents = fh.ReadFromFile(tf);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Trial1
{
   public class SpecialText
    {


      
        public string rtbMessage;
        public SpecialText(Answer location, Weapon weapon)
        {
            //New Location
            if (location == World.AnswerbyID(World.ANSWER_ID_EMERGENCYEXITWEST))
            {              
                if (weapon.ID == World.ITEM_ID_FISTS)
                {
                   
                    rtbMessage = "How Can You Use Fists To Open Locked Doors???";

                }
                else if (weapon.ID == World.ITEM_ID_KEY)
                {
                    
                }
                else if (weapon.ID == World.ITEM_ID_WOODENSWORD)
                {
                    rtbMessage = "dead";
                }
                
            }

            //New Location
            if (location == World.AnswerbyID(World.ANSWER_ID_DUM))
            {
                if (weapon.ID == World.ITEM_ID_FISTS)
                {
                    rtbMessage = "Ioovedicsd";
                }
                else if (weapon.ID == World.ITEM_ID_KEY)
                {
                    rtbMessage = "Didn't the button say not to carry anything to enter?";
                }
                else if (weapon.ID == World.ITEM_ID_WOODENSWORD)
                {
                    rtbMessage = "Why would you carry a wooden sword into a non violent area? This isn't some RPG world.";
                }
            }
            
    
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]

   public class Answer
    {
        public int ID { get; set; }
        public string Button { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ActionScene { get; set; }
        
        public Items Reward { get; set; }    
        public Items WeaponEquipToTrigger { get; set; }
        public Items ItemEquipToTrigger { get; set; }

        public Answer AnswerA { get; set; }
        public Answer AnswerB { get; set; }
        public Answer AnswerC { get; set; }
        public Answer AnswerD { get; set; }

        public Hidden HiddenQuestClear { get; set; }
        public Hidden GetHiddenQuestClear { get; set; }

        public Answer(int id, string button , string name, string description, string actionScene , 
            Hidden hiddenQuestClear = null, Hidden getHiddenQuestClear = null, Items weaponEquipToTrigger = null, 
            Items itemEquipToTrigger = null, Items reward = null)
        {
            ID = id;
            Button = button;
            Name = name;
            Description = description;
            ActionScene = actionScene;
            HiddenQuestClear = hiddenQuestClear;
            GetHiddenQuestClear = getHiddenQuestClear;
            ItemEquipToTrigger = itemEquipToTrigger;
            WeaponEquipToTrigger = weaponEquipToTrigger;
            Reward = reward;

        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassLibrary
{
    [Serializable]

   public static class World
    {
        //Making a list for items and locations => ID
        public static readonly List<Hidden> hiddens = new List<Hidden>();

        public static readonly List<Answer> answers = new List<Answer>();
        public static readonly List<Items> items = new List<Items>();

        //HiddenQuestClear
        public const int HIDDEN_ID_TEST = 0;
        public const int HIDDEN_ID_TEST2 = 1;

        //Items in Making ID
        public const int ITEM_ID_FISTS = 0;
        public const int ITEM_ID_WOODENSWORD = 1;
        public const int ITEM_ID_KEY = 2;

        // Location/Answer ID
        public const int ANSWER_ID_START = 0;
        public const int ANSWER_ID_RESTART = 1;
        public const int ANSWER_ID_STARTINGLOCATION = 2;
        public const int ANSWER_ID_EMERGENCYEXITEAST = 3;
        public const int ANSWER_ID_EMERGENCYEXITWEST = 4;
        public const int ANSWER_ID_TESTINGHIDDENQUEST = 5;
        public const int ANSWER_ID_ITEM = 6;
        public const int ANSWER_ID_TESTNUMBER = 7;
        public const int ANSWER_ID_DUM = 20;
        public const int ANSWER_ID_LAG = 50;

        static World()
        {
            AddItems();
            AddHidden();
            AddAnswers();
            

        }
        private static void AddHidden()
        {
            hiddens.Add(new Hidden(ITEM_ID_WOODENSWORD, "sda"));
        }

        private static void AddItems()
        {
            items.Add(new Weapon(ITEM_ID_FISTS, "Two Fists", "Two Fists strengthen by 20 years of Life experience."));
            items.Add(new Weapon(ITEM_ID_WOODENSWORD, "Wooden Sword", "A Training sword abandoned by a Greenhorn whom overestimated himself and probably dead by now."));
            items.Add(new Weapon(ITEM_ID_KEY, "Unknown Key", "A key to open a door?"));
        }
        private static void AddAnswers()
        {
            /* 
             Answer NAME = new Answer
             (
             int id, 
             string button, 
             string name,
             string description, 
             string actionScene , 
             Hidden hiddenQuestClear = null,
             Hidden getHiddenQuestClear = null,
             Items weaponEquipToTrigger = null, 
             Items itemEquipToTrigger = null, // effect in SpecialText.cs
             Items reward = null
             );


      
        
           */
            Answer hidden = new Answer
             (
             ANSWER_ID_TESTINGHIDDENQUEST,
             "do you have hidden",
             "sa",
             "da",
             "asd",
             HiddenID(ITEM_ID_WOODENSWORD)
             );

            Answer start = new Answer
                (
                ANSWER_ID_START,
                "Re:Life\n‎(ﾉಥ益ಥ）ﾉ ┻━┻",
                "[Location]",
                "[Description]",
                "[Action Scene]",
                null,
                null
                );

            Answer restart = new Answer
               (
               ANSWER_ID_RESTART,
               "Start'o",
               "Dead",
               "",
               "Get A New Chance In Life",
               null,
               null
               );

            Answer startingLocation = new Answer
                (
                    ANSWER_ID_STARTINGLOCATION,
                    "Start the Game!",
                    "start",
                    "sstart",
                    "Start",
                    null,
                    null

                );

            Answer to = new Answer
    (
        ANSWER_ID_DUM,
        "Dum!",
        "Dum",
        "Dum",
        "Dum",
        null,
        null

    );
            Answer Lag = new Answer
    (
        ANSWER_ID_LAG,
        "Lag!",
        "Lag",
        "Lag",
        "Lag",
        null,
        null,
        null,
        null,
        ItemsbyID(ITEM_ID_WOODENSWORD)
    );
    Answer test = new Answer
(
ANSWER_ID_EMERGENCYEXITEAST,
"do you have a woodensword",
"sad",
"sad",
"sd",
null,
null,
ItemsbyID(ITEM_ID_WOODENSWORD), null, null

);

            Answer test2 = new Answer
(
ANSWER_ID_EMERGENCYEXITWEST,
"do you have a key",
"asd",
"asd",
"wf",
null,
 null,

 null,
ItemsbyID(ITEM_ID_KEY), null // effect in SpecialText.cs

);



            //link the Locations together for Paths

            restart.AnswerA = start;
            restart.AnswerB = start;
            restart.AnswerC = start;
            restart.AnswerD = start;


            start.AnswerD = startingLocation;
            // Here starts the Game <------------------------------------------------------------->
            startingLocation.AnswerA = to;
            startingLocation.AnswerB = test;
            startingLocation.AnswerC = test2;
            startingLocation.AnswerD = hidden;

            to.AnswerA = Lag;
            test.AnswerA = to;
            test2.AnswerA = to;





            //add the locations to the static list, Realise the location so it is not null.
            answers.Add(start);
            answers.Add(restart);
            answers.Add(startingLocation);
            answers.Add(to);
            answers.Add(Lag);
            answers.Add(test);
            answers.Add(test2);
            answers.Add(hidden);
        }


        //Check if the ID is correct also check the content of the list
        public static Items ItemsbyID(int id)
        {
            foreach (Weapon s in items)
            {
                if (s.ID == id)
                {
                    return s;
                }


            }
            return null;
        }


        public static Hidden HiddenID(int ID)
        {
            foreach (Hidden s in hiddens)
            {
                if (s.ID == ID)
                {
                    return s;
                }


            }
            return null;
        }

        

        public static Answer AnswerbyID(int id)
        {
            foreach(Answer answer in answers)
            {
                if(answer.ID == id)
                {
                    return answer;
                }
            }
            return null;
        }


    }
}

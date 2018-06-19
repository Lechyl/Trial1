using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Trial1
{
    public partial class Form1 : Form
    {
       public Answer CurrentLocation;

       public Player _player;

        public int LoadOrNot = 0;
        public Form1()
        {



            // this = Form1
            //title
            this.Text = "Escape Simulator";

            //Backgroundimage
            Image myimage = new Bitmap(@"C:\Users\SDE-03062\source\repos\Trial1\Trial1\Images\BackgroundImage.bmp");
                //background image stretch
                this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = myimage;



            InitializeComponent();

            _player = new Player();

            //Start location

            MoveTo(World.AnswerbyID(World.ANSWER_ID_START));


        }
        private void Guide()
        {
            if (CurrentLocation == World.AnswerbyID(World.ANSWER_ID_START))
            {
                StreamReader sr = new StreamReader(@"C:\Users\SDE-03062\source\repos\Trial1\Trial1\Files\Guide.txt");
                
                MessageBox.Show(sr.ReadToEnd());

            }
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {
            if(rtbMessage.TextLength >= 2147483647)
            {
                rtbMessage.Text = null;
            }
            // set the current caret position to the end
            rtbMessage.SelectionStart = rtbMessage.Text.Length;

            // Scroll it automatic to end
            rtbMessage.ScrollToCaret();
            

        }

        public void MoveTo(Answer newLocation)
        {

           
            Guide();



            rbtLocation.Text = newLocation.Name;

            CurrentLocation = newLocation;


            //Start Items
            if (newLocation.ID == World.ANSWER_ID_STARTINGLOCATION)
            { 
                _player.inventoryitems.Add(new Inventory(World.ItemsbyID(World.ITEM_ID_FISTS)));
                _player.inventoryitems.Add(new Inventory(World.ItemsbyID(World.ITEM_ID_KEY)));
                _player.inventoryitems.Add(new Inventory(World.ItemsbyID(World.ITEM_ID_WOODENSWORD)));


            }

            //if there is an event on a button then it is visible otherwise Invisible
            buttonA.Visible = (newLocation.AnswerA != null);
            buttonB.Visible = (newLocation.AnswerB != null);
            buttonC.Visible = (newLocation.AnswerC != null);
            buttonD.Visible = (newLocation.AnswerD != null);

            //This code is for seeing if there is an event on that button (Refeshing).
            if (newLocation.AnswerA != null)
            {
                buttonA.Text = newLocation.AnswerA.Button;
            }
            if (newLocation.AnswerB != null)
            {
                buttonB.Text = newLocation.AnswerB.Button;
            }
            if (newLocation.AnswerC != null)
            {
                buttonC.Text = newLocation.AnswerC.Button;
            }
            if (newLocation.AnswerD != null)
            {
                buttonD.Text = newLocation.AnswerD.Button;
            }

            rbtLocation.Text = newLocation.Name + Environment.NewLine + Environment.NewLine;
            rbtLocation.Text += newLocation.Description + Environment.NewLine;
            rtbMessage.Text = newLocation.ActionScene + Environment.NewLine;
            Weapon CurrentWeapon = (Weapon)comboBoxItems.SelectedItem;




            //checking if the Locatioin has a Item Equip to Trigger
            if (newLocation.WeaponEquipToTrigger != null)
            {
                bool HasTheWeaponEquipToTrigger = false;

                //Now we need to check if your iventory has the item
                if (CurrentWeapon != null)
                {
                    if (CurrentWeapon.ID == CurrentLocation.WeaponEquipToTrigger.ID)
                    {
                        HasTheWeaponEquipToTrigger = true;


                    }
                }

                if (CurrentWeapon is Weapon)
                {
                    if (HasTheWeaponEquipToTrigger == true)
                    {
                        return;
                    }
                    else
                    {
                        MoveTo(World.AnswerbyID(World.ANSWER_ID_RESTART));
                        rtbMessage.Text = "Your " + CurrentWeapon.Name + " wasn't strong enough. Thus you died horrible.\nOr you chose the Wrong Item to Interact with.";
                    }
                }


            }





            // does this location have a reward

            if (newLocation.Reward != null)
            {
                bool IHaveThisItemAlready = false;


                foreach (Inventory ii in _player.inventoryitems)
                {
                    if (ii.Details == CurrentLocation.Reward)
                    {
                        IHaveThisItemAlready = true;
                        return;

                    }

                }

                if (!IHaveThisItemAlready)
                {
                    _player.inventoryitems.Add(new Inventory(CurrentLocation.Reward));
                }
            }

            if (CurrentLocation.ID == World.ANSWER_ID_RESTART)
            {

                comboBoxItems.DataSource = null;

                ItemDescriptionBox.Text = null;

            }

            if (LoadOrNot > 0)
            {
                LoadOrNot = 0;

                DeSerialize();

                MoveTo(World.AnswerbyID(LoadLocation));

            }

            UpdateWeapon();
            InventoryEndUpdate(newLocation);

        }

        //update the inventory and move the items to Combobox.
        // UpdateWeapon add the items in Player Inventory to weapon List then add from weapon List to Combobox.

        public void UpdateWeapon()
        {
            List<Weapon> weapon = new List<Weapon>();

            foreach (Inventory ii in _player.inventoryitems)
            {
                if (ii.Details is Weapon)
                {
                    weapon.Add((Weapon)ii.Details);

                }

            }

            List<Hidden> hiddens = new List<Hidden>();

            foreach (HiddenObjectInventory ii in _player.hiddenObjectInventories)
            {
                if (ii.HiddenObject is Hidden)
                {
                    hiddens.Add((Hidden)ii.HiddenObject);

                }

            }

            if (weapon.Count > 0)
            {
                for (int i = 0; i < weapon.Count; i++)
                { 
                comboBoxItems.DataSource = weapon;
                comboBoxItems.DisplayMember = "Name";
                comboBoxItems.ValueMember = "ID";   
                comboBoxItems.SelectedIndex = 0;
                }
            }
        }

        private void comboBoxItems_SelectionChangeCommitted(object sender, EventArgs e)
        {

            
            if(comboBoxItems.SelectedItem != null)
            { 
            Weapon CurrentWeapon = (Weapon)comboBoxItems.SelectedItem;
            ItemDescriptionBox.Text = CurrentWeapon.Description;
            }

        }

        // This code combines with DataSource to delete content in combobox;
        private void InventoryEndUpdate(Answer location)
        {   
            List<Weapon> weapon = new List<Weapon>();
            Answer ThisLocation;
            ThisLocation = location;
            if (ThisLocation.ID == World.ANSWER_ID_RESTART)
            {

                foreach (Inventory ii in _player.inventoryitems.ToList())
                {

                    if (ii.Details is Weapon)
                    {
                        _player.inventoryitems.Remove(ii);

                    }


                }

            }
            else
            {
                return;
            }

        }
        
        private void buttonA_Click(object sender, EventArgs e)
        {
 
                ItemTrigger_Move(CurrentLocation.AnswerA);

        }

        private void buttonB_Click(object sender, EventArgs e)
        {

            ItemTrigger_Move(CurrentLocation.AnswerB);  

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
             ItemTrigger_Move(CurrentLocation.AnswerC);

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ItemTrigger_Move(CurrentLocation.AnswerD);

        }

        private void WhenIsSaveAvailable()
        {
            if (CurrentLocation.ID != World.ANSWER_ID_START)
            {
                SaveButton.Visible = true;

            }

        }
        
        private void  ItemTrigger_Move(Answer nextPath)
        {

            WhenIsSaveAvailable();

            bool WrongItem = false;
            List<Weapon> weapon = new List<Weapon>();
            Weapon currentWeapon = (Weapon)comboBoxItems.SelectedItem;

            AddHiddenToInventory(nextPath);

            


            // The Paths for Opening secrets, Special Messages for wrong answer
            

            if (nextPath.HiddenQuestClear != null)
            {

                if (_player.hiddenObjectInventories.Count > 0)
                { 

                    foreach (var s in _player.hiddenObjectInventories.ToList())
                    {
                        if (s.HiddenObject.ID == nextPath.HiddenQuestClear.ID)
                        {
                            MoveTo(nextPath);

                        }
                        else
                        {
                            rtbMessage.Text = "You haven't activated the easter egg yet.";
                            WrongItem = true;
                        }

                    }
                }
                else
                {
                    rtbMessage.Text = "You haven't activated the easter egg yet.";
                    WrongItem = true;

                }
            }

            if (nextPath.ItemEquipToTrigger != null)
            {
                if (nextPath.ItemEquipToTrigger.ID == currentWeapon.ID)
                {
                    foreach (Inventory ii in _player.inventoryitems.ToList())
                    {

                        if (ii.Details == nextPath.ItemEquipToTrigger)
                        {
                            comboBoxItems.DataSource = null;
                            _player.inventoryitems.Remove(ii);

                        }
                        MoveTo(nextPath);
                    }
                    UpdateWeapon();
                }
                else
                {
                    WrongItem = true;
                }

            }


            if (WrongItem == false)
            {
                MoveTo(nextPath);
            }
            else
            {
                //Trigger special text if wrong button triggered.
                SpecialText specialText = new SpecialText(nextPath, currentWeapon);
                rtbMessage.Text = specialText.rtbMessage;


            }



        }

        private void AddHiddenToInventory(Answer location)
        {
            if (location.GetHiddenQuestClear != null)
            {
                _player.hiddenObjectInventories.Add(new HiddenObjectInventory(location.GetHiddenQuestClear));

            }

            
        }

        private void ButtonMap_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.ShowDialog();

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open(@"C:\Users\SDE-03062\dataLocation.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, CurrentLocation.ID);
                }

                using (Stream stream = File.Open(@"C:\Users\SDE-03062\dataHiddenInv.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, _player.hiddenObjectInventories);
                }
                using (Stream stream = File.Open(@"C:\Users\SDE-03062\dataInv.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, _player.inventoryitems);
                }
            }
            catch (IOException)
            {
                rtbMessage.Text = "Your Files has been corrupted";
            }
            SaveButton.Visible = false;
        }

        private int LoadLocation;

        public void DeSerialize()
        {
            try
            {
               
                using (Stream stream = File.Open(@"C:\Users\SDE-03062\dataLocation.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    var location = (int)bin.Deserialize(stream);
                    LoadLocation = location;

                    
                }

                using (Stream stream = File.Open(@"C:\Users\SDE-03062\dataHiddenInv.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    var hiddenobjectinv = (List<HiddenObjectInventory>)bin.Deserialize(stream);
                    foreach (HiddenObjectInventory hidden in hiddenobjectinv)
                    {
                        _player.hiddenObjectInventories.Add(hidden);

                    }

                }
                using (Stream stream = File.Open(@"C:\Users\SDE-03062\dataInv.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    var inventoryitems = (List<Inventory>)bin.Deserialize(stream);

                    foreach (Inventory inv in inventoryitems)
                    {

                        if (CurrentLocation.Reward != null)
                        {
                            if(inv.Details.ID == CurrentLocation.Reward.ID)
                            {
                                _player.inventoryitems.Remove(inv);
                            }
                        }

                        foreach (Inventory ii in _player.inventoryitems.ToList())
                        {
                            if(inv.Details.ID == ii.Details.ID)
                            {
                                _player.inventoryitems.Remove(inv);

                            }

                        }

                        
                    }


                }

            }
            catch (IOException)
            {
                rtbMessage.Text = "Your Files has been corrupted";

            }

        }
    }
}

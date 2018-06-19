namespace Trial1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.rbtLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel = new System.Windows.Forms.Label();
            this.ItemDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.ButtonMap = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.AutoSize = true;
            this.buttonA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonA.Location = new System.Drawing.Point(497, 57);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(53, 23);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "button1";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.AutoSize = true;
            this.buttonB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonB.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonB.Location = new System.Drawing.Point(497, 120);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(53, 23);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "button2";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.AutoSize = true;
            this.buttonC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonC.Location = new System.Drawing.Point(497, 185);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(53, 23);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "button3";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.AutoSize = true;
            this.buttonD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonD.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonD.Location = new System.Drawing.Point(497, 254);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(53, 23);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "button4";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.AllowDrop = true;
            this.comboBoxItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.comboBoxItems.Location = new System.Drawing.Point(496, 361);
            this.comboBoxItems.MaxDropDownItems = 20;
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItems.TabIndex = 9;
            this.comboBoxItems.TabStop = false;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectionChangeCommitted);
            // 
            // rbtLocation
            // 
            this.rbtLocation.Location = new System.Drawing.Point(168, 29);
            this.rbtLocation.Name = "rbtLocation";
            this.rbtLocation.ReadOnly = true;
            this.rbtLocation.Size = new System.Drawing.Size(224, 77);
            this.rbtLocation.TabIndex = 7;
            this.rbtLocation.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.rtbMessage.Location = new System.Drawing.Point(168, 133);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(224, 179);
            this.rtbMessage.TabIndex = 8;
            this.rtbMessage.Text = "";
            this.rtbMessage.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // lamgoingtoKillyouDontEverClickOnThisThisisJustALabel
            // 
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.AutoSize = true;
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.BackColor = System.Drawing.SystemColors.Control;
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.Location = new System.Drawing.Point(497, 342);
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.Name = "lamgoingtoKillyouDontEverClickOnThisThisisJustALabel";
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.Size = new System.Drawing.Size(114, 15);
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.TabIndex = 10;
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.Text = "Current Item Equipped";
            this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemDescriptionBox
            // 
            this.ItemDescriptionBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ItemDescriptionBox.Cursor = System.Windows.Forms.Cursors.No;
            this.ItemDescriptionBox.Location = new System.Drawing.Point(187, 342);
            this.ItemDescriptionBox.Name = "ItemDescriptionBox";
            this.ItemDescriptionBox.ReadOnly = true;
            this.ItemDescriptionBox.Size = new System.Drawing.Size(182, 96);
            this.ItemDescriptionBox.TabIndex = 11;
            this.ItemDescriptionBox.Text = "";
            // 
            // ButtonMap
            // 
            this.ButtonMap.Location = new System.Drawing.Point(13, 13);
            this.ButtonMap.Name = "ButtonMap";
            this.ButtonMap.Size = new System.Drawing.Size(75, 36);
            this.ButtonMap.TabIndex = 12;
            this.ButtonMap.Text = "Map";
            this.ButtonMap.UseVisualStyleBackColor = true;
            this.ButtonMap.Click += new System.EventHandler(this.ButtonMap_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Merriweather Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(30, 381);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 39);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ButtonMap);
            this.Controls.Add(this.ItemDescriptionBox);
            this.Controls.Add(this.lamgoingtoKillyouDontEverClickOnThisThisisJustALabel);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rbtLocation);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.RichTextBox rbtLocation;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label lamgoingtoKillyouDontEverClickOnThisThisisJustALabel;
        private System.Windows.Forms.RichTextBox ItemDescriptionBox;
        private System.Windows.Forms.Button ButtonMap;
        private System.Windows.Forms.Button SaveButton;
    }
}


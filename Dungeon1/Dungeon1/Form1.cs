using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double page = 1;
        int item1 = 0, item2 = 0, item3 = 0, health = 10, enemyhealth, chanse;
        int damage;
        bool enemyfocus = true;
        private void lose()
        {
            MessageBox.Show("game over");
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            switch (page)
            {
                case 4:
                    label1.Text += "\nYep, it's still locked.";
                    break;
                case 4.2:
                    label1.Text += "\nYep, it's still locked.";

                    break;
                case 4.3:
                    label1.Text += "\nYep, it's still locked.";

                    break;
                case 4.4:
                    label1.Text += "\nYep, it's still locked.";

                    break;
                case 4.1:
                    chanse = rnd();
                    if ((item1 == 4) || (item2 == 4) || (item3 == 4)) { chanse += 2; label1.Text += "\nYou move faster in your boots"; }
                    if (chanse > 3)
                    {
                        label1.Text += "\nYou managed to dodge vampire's attack.";
                        enemyfocus = false;
                    }
                    else
                    {
                        label1.Text += "\nYou didn't manage to dodge vampire's attack.";
                        damage = rnd();
                        damage += 3;
                        if ((item1 == 3) || (item2 == 3) || (item3 == 3))
                        {
                            label1.Text += "\nWith your armor you reduce part of the damage";
                            damage -= 2;
                        }
                        if (damage < 0) damage = 0;
                        label1.Text += "\nYou lost " + damage + " health";
                        health -= damage;
                        if (health < 0) health = 0;
                        takedamage();
                        enemyfocus = true;

                    }

                    break;
                case 3.1:

                    chanse = rnd();
                    if ((item1 == 4) || (item2 == 4)) { chanse += 2; label1.Text += "\nYou move faster in your boots"; }
                    if (chanse > 3)
                    {
                        label1.Text += "\nYou managed to dodge vampire's attack.";
                        enemyfocus = false;
                    }
                    else
                    {
                        label1.Text += "\nYou didn't manage to dodge vampire's attack.";
                        damage = rnd();
                        damage += 2;
                        if ((item1 == 3) || (item1 == 4))
                        {
                            label1.Text += "\nWith your armor you reduce part of the damage";
                            damage -= 2;
                        }
                        if (damage < 0) damage = 0;
                        label1.Text += "\nYou lost " + damage + " health";
                        health -= damage;
                        if (health < 0) health = 0;
                        takedamage();
                        enemyfocus = true;

                    }
                    break;
                case 1: lose(); break;
                case 1.1: lose(); break;
                case 2:
                    page = 1.1;
                    label1.Text = "There is a door and a chest in the corner.\nWhat are you going to do? ";
                    button1.Text = "Enter the door.";
                    button2.Text = "Look inside the chest.";
                    button3.Text = "I like it here, i wont go anywhere.";
                    break;
                case 2.1:
                    chanse = rnd();
                    if (item1 == 4) { chanse += 2; label1.Text += "\nYou mmove faster in your boots"; }
                    if (chanse > 3)
                    {
                        label1.Text += "\nYou managed to dodge goblin's attack.";
                        enemyfocus = false;
                    }
                    else
                    {
                        label1.Text += "\nYou didn't manage to dodge goblin's attack.";
                        damage = rnd();
                        damage += 1;
                        if (item1 == 3)
                        {
                            label1.Text += "\nWith your armor you reduce part of the damage";
                            damage -= 2;
                        }
                        if (damage < 0) damage = 0;
                        label1.Text += "\nYou lost " + damage + " health";
                        health -= damage;
                        if (health < 0) health = 0;
                        takedamage();
                        enemyfocus = true;

                    }
                    break;
                case 2.2:
                    label1.Text += "\nSomebody closed the door. You can't get back.";
                    break;
                case 2.3:
                    label1.Text += "\nSomebody closed the door. You can't get back.";
                    break;
                case 3:
                    label1.Text += "\nThat's strange. Door is already locked.";
                    break;
                case 3.2:
                    label1.Text += "\nDoor is still closed.";
                    break;
                case 3.3:
                    label1.Text += "\nDoor is still closed.";
                    break;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            switch (page)
            {
                case 3.2:
                    page = 4;
                    label1.Text = "You are in a huge room with a huge dragon in it, lying between you and a tiny door.\nWhat are you going to do?";
                    button1.Text = "Attack mighty dragon.";
                    button2.Text = "Ask if you can pass him and go into the door he standing infront of;";
                    button3.Text = "Check if the door you just entered.";
                    enemyhealth = 10;
                    break;
                case 3.3:
                    page = 4;
                    label1.Text = "You are in a huge room with a huge dragon in it, lying between you and a tiny door.\nWhat are you going to do?";
                    button1.Text = "Attack mighty dragon.";
                    button2.Text = "Ask if you can pass him and go into the door he standing infront of;";
                    button3.Text = "Check if the door you just entered is closed.";
                    enemyhealth = 10;
                    break;
                case 4.1:
                    damage = rnd();
                    label1.Text += "\nYou attack dragon";
                    if (item1 == 1 || (item2 == 1) || (item3 == 1))
                    {
                        damage += 2;
                        label1.Text += " with your sword";
                    }
                    else
                    {
                        label1.Text += " with your hand";
                    }
                    if (enemyfocus == true)
                    {
                        label1.Text += ", but he is ready for your hit.";
                        label1.Text += "\nHe blocks it and strikes back.";
                        damage -= 3;
                        if (damage < 0) { damage = 0; }
                        enemyhealth -= damage;
                        if (enemyhealth < 0) enemyhealth = 0;
                        enemydamaged();
                        damage = rnd();
                        damage += 2;
                        if ((item1 == 3) || (item2 == 3) || (item3 == 3))
                        {
                            label1.Text += "\nWith your armor you reduce part of the damage.";
                            damage -= 2;
                        }
                        label1.Text += "\nYou lost " + damage + " health";
                        health -= damage;
                        if (health < 0) { health = 0; }
                        takedamage();
                        if (enemyhealth == 0)
                        {
                            page = 4.2;
                            label1.Text = "You won!\nNothing stands between you and the chest or the door now.\n What are you going to do?";
                            button1.Text = "Enter the tiny door.";
                            button2.Text = "Search dragon's body.";
                            button3.Text = "Check if the door you entered is closed.";
                        }
                        enemyfocus = true;
                    }
                    else
                    {
                        enemyhealth -= damage;
                        if (enemyhealth < 0) enemyhealth = 0;
                        label1.Text += "\nDragon lost " + damage + " health";
                        enemydamaged();
                        if (enemyhealth == 0)
                        {
                            page = 4.2;
                            label1.Text = "You won!\nNothing stands between you and the door now.\n What are you going to do?";
                            button1.Text = "Enter the tiny door.";
                            button2.Text = "Search dragon's body.";
                            button3.Text = "Check if the door you entered is closed.";
                        }
                        enemyfocus = true;


                    }
                    break;
                case 4.2:
                    label1.Text += "\nThe door is closed.";
                    break;
                case 4.3:
                    label1.Text += "\nThe door is closed.";
                    break;
                case 4.4:
                    MessageBox.Show("You got out and won!");
                    System.Windows.Forms.Application.Exit();
                    break;
                case 4:
                    damage = rnd();
                    label1.Text += "\nYou attack dragon";
                    if (item1 == 1 || (item2 == 1) || (item3 == 1))
                    {
                        damage += 2;
                        label1.Text += " with your sword";
                    }
                    else
                    {
                        label1.Text += " with your hand";
                    }
                    if (enemyfocus == true)
                    {
                        label1.Text += ", but he is ready for your hit.";
                        label1.Text += "\nHe blocks it and strikes back.";
                        damage -= 3;
                        if (damage < 0) { damage = 0; }
                        enemyhealth -= damage;
                        if (enemyhealth < 0) enemyhealth = 0;
                        enemydamaged();
                        damage = rnd();
                        damage += 2;
                        if ((item1 == 3) || (item2 == 3) || (item3 == 3))
                        {
                            label1.Text += "\nWith your armor you reduce part of the damage.";
                            damage -= 2;
                        }
                        label1.Text += "\nYou lost " + damage + " health";
                        health -= damage;
                        if (health < 0) { health = 0; }
                        takedamage();
                        enemyfocus = true;
                    }
                    button1.Text = "Attack";
                    button2.Text = "Block";
                    button3.Text = "Dodge";
                    page = 4.1;
                    break;
                case 3.1:
                    damage = rnd();
                    label1.Text += "\nYou attack vampire";
                    if (item1 == 1 || (item2 == 1))
                    {
                        damage += 2;
                        label1.Text += " with your sword";
                    }
                    else
                    {
                        label1.Text += " with your hand";
                    }
                    if (enemyfocus == true)
                    {
                        label1.Text += ", but he is ready for your hit.";
                        if (rnd() > 3)
                        {
                            label1.Text += "\nHe dodged it and striked back.";
                            damage = rnd();
                            damage += 2;
                            if (item1 == 3 || (item2 == 3))
                            {
                                label1.Text += "\nWYour armor reduces part of the damage.";
                                damage -= 2;
                            }
                            label1.Text += "\nYou lost " + damage + " health";
                            health -= damage;
                            if (health < 0) health = 0;
                            takedamage();
                            enemyfocus = true;
                        }
                        else
                        {
                            label1.Text += "\nHe didn't manage to dodge your attack.";
                            enemyhealth -= damage;
                            if (enemyhealth < 0) enemyhealth = 0;
                            label1.Text += "\nVampire lost " + damage + " health";
                            enemydamaged();
                            if (enemyhealth == 0)
                            {
                                page = 3.2;
                                label1.Text = "You won!\nNothing stands between you and the chest or the door now.\n What are you going to do?";
                                button1.Text = "Enter the door.";
                                button2.Text = "Look inside the chest.";
                                button3.Text = "Go back to the previous room.";
                            }
                            enemyfocus = true;

                        }
                    }
                    else
                    {
                        enemyhealth -= damage;
                        if (enemyhealth < 0) enemyhealth = 0;
                        label1.Text += "\nVampire lost " + damage + " health";
                        enemydamaged();
                        if (enemyhealth == 0)
                        {
                            page = 3.2;
                            label1.Text = "You won!\nNothing stands between you and the chest or the door now.\n What are you going to do?";
                            button1.Text = "Enter the door.";
                            button2.Text = "Look inside the chest.";
                            button3.Text = "Go back to the previous room.";
                        }
                        enemyfocus = true;
                    }
                    break;
                case 3:
                    damage = rnd();
                    label1.Text += "\nYou attack vampire";
                    if (item1 == 1 || (item2 == 1))
                    {
                        damage += 2;
                        label1.Text += " with your sword";
                    }
                    else
                    {
                        label1.Text += " with your hand";
                    }
                    if (enemyfocus == true)
                    {
                        label1.Text += ", but he is ready for your hit.";
                        if (rnd() > 3)
                        {
                            label1.Text += "\nHe dodged it and striked back.";
                            damage = rnd();
                            damage += 2;
                            if (item1 == 3 || (item2 == 3))
                            {
                                label1.Text += "\nWYour armor reduces part of the damage.";
                                damage -= 2;
                            }
                            label1.Text += "\nYou lost " + damage + " health";
                            health -= damage;
                            if (health < 0) health = 0;
                            takedamage();
                            enemyfocus = true;
                        }
                        else
                        {
                            label1.Text += "\nHe didn't manage to dodge your attack.";
                            enemyhealth -= damage;
                            if (enemyhealth < 0) enemyhealth = 0;
                            label1.Text += "\nVampire lost " + damage + " health";
                            enemydamaged();
                            enemyfocus = true;

                        }
                    }
                    else
                    {
                        enemyhealth -= damage;
                        if (enemyhealth < 0) enemyhealth = 0;
                        label1.Text += "\nVampire lost " + damage + " health";
                        enemydamaged();
                        enemyfocus = true;
                    }
                    button1.Text = "Attack";
                    button2.Text = "Block";
                    button3.Text = "Dodge";
                    page = 3.1;
                    break;
                case 1:
                    label1.Text = "You can see an ugly goblin, a door and a chest behind him.\nWhat are you going to do?";
                    enemyhealth = 10;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox19.Image = Properties.Resources.hpbar;
                    pictureBox20.Image = Properties.Resources.hpbar;
                    pictureBox21.Image = Properties.Resources.hpbar;
                    pictureBox22.Image = Properties.Resources.hpbar;
                    pictureBox23.Image = Properties.Resources.hpbar;
                    pictureBox24.Image = Properties.Resources.hpbar;
                    pictureBox25.Image = Properties.Resources.hpbar;
                    button1.Text = "Attack the goblin.";
                    button2.Text = "Try to make friend with gibin.";
                    button3.Text = "Go back to the previous room.";
                    page = 2;
                    break;
                case 1.1:
                    label1.Text = "You can see an ugly goblin, \n a door and a chest behind him.";
                    enemyhealth = 10;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox19.Image = Properties.Resources.hpbar;
                    pictureBox20.Image = Properties.Resources.hpbar;
                    pictureBox21.Image = Properties.Resources.hpbar;
                    pictureBox22.Image = Properties.Resources.hpbar;
                    pictureBox23.Image = Properties.Resources.hpbar;
                    pictureBox24.Image = Properties.Resources.hpbar;
                    pictureBox25.Image = Properties.Resources.hpbar;
                    button1.Text = "Attack the goblin.";
                    button2.Text = "Try to make friend with gibin.";
                    button3.Text = "Go back to the previous room.";
                    page = 2;
                    break;
                case 2:
                    damage = rnd();
                    label1.Text += "\nYou attack goblin";
                    if (item1 == 1)
                    {
                        damage += 2;
                        label1.Text += " with your sword";
                    }
                    else
                    {
                        label1.Text += " with your hand";
                    }
                    if (enemyfocus == true)
                    {
                        label1.Text += ", but he is ready for your hit.";
                        if (rnd() > 3)
                        {
                            label1.Text += "\nHe dodged it and striked back.";
                            damage = rnd();
                            damage += 1;
                            if (item1 == 3)
                            {
                                label1.Text += "\nYour armor reduce part of the damage";
                                damage -= 2;
                            }
                            label1.Text += "\nYou lost " + damage + " health";
                            health -= damage;
                            if (health < 0) health = 0;
                            takedamage();
                            enemyfocus = true;
                        }
                        else
                        {
                            label1.Text += "\nhe didn't manage to dodge your attack.";
                            enemyhealth -= damage;
                            if (enemyhealth < 0) enemyhealth = 0;
                            label1.Text += "\nGoblin lost " + damage + " health";
                            enemydamaged();
                            enemyfocus = true;

                        }
                    }
                    else
                    {
                        damage += 1;
                        enemyhealth -= damage;
                        if (enemyhealth < 0) enemyhealth = 0;
                        label1.Text += "\nGoblin lost " + damage + " health";
                        enemydamaged();
                        enemyfocus = true;
                    }
                    button1.Text = "Attack";
                    button2.Text = "Block";
                    button3.Text = "Dodge";
                    page = 2.1;
                    break;

                case 2.1:
                    damage = rnd();
                    label1.Text += "\nYou attack goblin";
                    if (item1 == 1) { damage += 2; }
                    if (enemyfocus == true)
                    {
                        label1.Text += ",but he is ready for your hit.";
                        if (rnd() > 4)
                        {
                            label1.Text += "\nHe dodged it and striked back.";
                            damage = rnd();
                            damage += 1;
                            if (item1 == 3)
                            {
                                label1.Text += "\nWith your armor you reduce part of the damage";
                                damage -= 2;
                            }
                            label1.Text += "\n You lost " + damage + " health";
                            health -= damage;
                            if (health < 0) health = 0;
                            takedamage();
                            enemyfocus = true;
                        }
                        else
                        {
                            label1.Text += "\nhe didn't managed to dodge your attack.";
                            enemyhealth -= damage;
                            if (enemyhealth < 0) enemyhealth = 0;
                            label1.Text += "\nGoblin lost " + damage + " health";
                            enemydamaged();
                            enemyfocus = true;
                            if (enemyhealth == 0)
                            {
                                page = 2.2;
                                label1.Text = "You won!\nNothing stands between you and the chest or the door now.\n What are you going to do?";
                                button1.Text = "Enter the door.";
                                button2.Text = "Look inside the chest.";
                                button3.Text = "Go back to the previous room.";
                            }

                        }
                    }
                    else
                    {
                        damage += 1;
                        enemyhealth -= damage;
                        if (enemyhealth < 0) enemyhealth = 0;
                        label1.Text += "\nGoblin lost " + damage + " health";
                        enemydamaged();
                        if (enemyhealth == 0)
                        {
                            page = 2.2;
                            label1.Text = "You won!\nNothing stands between you and the chest or the door now.\n What are you going to do?";
                            button1.Text = "Enter the door.";
                            button2.Text = "Look inside the chest.";
                            button3.Text = "Go back to the previous room.";
                        }
                        enemyfocus = true;
                    }
                    break;
                case 2.2:
                    label1.Text = "You can see terrifying vampire and another door and chest behind him.\nWhat are you going to do?";
                    button1.Text = "Attack blood-drinking creature";
                    button2.Text = "Try to sneak behind vampire.";
                    button3.Text = "Go back to the previous room.";
                    page = 3;
                    enemyhealth = 10;
                    break;
                case 2.3:
                    label1.Text = "You can see terrifying vampire and another door and chest behind him.\nWhat are you going to do?";
                    button1.Text = "Attack blood-drinking creature";
                    button2.Text = "Try to sneak behind vampire.";
                    button3.Text = "Go back to the previous room.";
                    page = 3;
                    enemyhealth = 10;
                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            switch (page)
            {
                case 4:
                    if (rnd() > 3)
                    {
                        page = 4.3; label1.Text = "\"Sure, here is a key from this door.\"\n What are you going to do?";
                        button1.Text = "Enter the door.";
                        button2.Text = "Open door with the key.";
                        button3.Text = "Go back to the previous room.";
                    }
                    else
                    {
                        label1.Text += "\nLooks like dragon don't understand human language.\nHe attacks you.";
                        damage = rnd();
                        damage += 3;
                        if ((item1 == 3) || (item2 == 3) || (item3 == 3)) { damage -= 2; label1.Text += "\nWith your armor you reduce part of the damage"; }
                        if (damage < 0) damage = 0;
                        label1.Text += "\nDragon damaged you for " + damage + " health points";
                        health -= damage;
                        if (health < 0) health = 0;
                        takedamage();
                        page = 4.1;
                        button1.Text = "Attack";
                        button2.Text = "Block";
                        button3.Text = "Dodge";
                        enemyfocus = true;
                    }

                    break;
                case 4.1:
                    //block
                    damage = rnd();
                    damage += 3;
                    if ((item1 == 2) || (item2 == 2) || (item3 == 2))
                    {
                        label1.Text += "\nYou use your shield and block 4 points of damage";
                        damage -= 4;
                    }
                    else
                    {
                        label1.Text += "\nYou block enemy attack with your hands and reduce damage by 2";
                        damage -= 2;
                    }
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    health -= damage;
                    if (health < 0) health = 0;
                    label1.Text += "\nYou lost " + damage + " health.";
                    takedamage();
                    enemyfocus = false;
                    break;
                case 4.2:
                    label1.Text += "\nYou found a key, looks like it opens that tiny door.";
                    button2.Text = "Unlock the door";
                    page = 4.3;
                    break;
                case 4.3:
                    label1.Text += "\nYou unlocked the door.";
                    page = 4.4;
                    break;
                case 4.4:
                    label1.Text += "\nThe door is already unlocked.";
                    break;
                case 3.1:
                    //block
                    damage = rnd();
                    damage += 2;
                    if ((item1 == 2) || (item2 == 2))
                    {
                        label1.Text += "\nYou use your shield and block 4 points of damage";
                        damage -= 4;
                    }
                    else
                    {
                        label1.Text += "\nYou block enemy attack with your hands and reduce damage by 2";
                        damage -= 2;
                    }
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    health -= damage;
                    if (health < 0) health = 0;
                    label1.Text += "\nYou lost " + damage + " health.";
                    takedamage();
                    enemyfocus = false;
                    break;
                case 3:
                    if (rnd() > 3)
                    {
                        page = 3.2; label1.Text = "Wow! This vampire blind and deaf.\nNothing stands between you and chest or door.\n What are you going to do?";
                        button1.Text = "Enter the door.";
                        button2.Text = "Look inside the chest.";
                        button3.Text = "Go back to the previous room.";
                    }
                    else
                    {
                        label1.Text += "\nVampire don't understand what are you doing and decides to attack you.";
                        damage = rnd();
                        damage += 2;
                        if ((item1 == 3) || (item2 == 3)) { damage -= 2; label1.Text += "\nWith your armor you reduce part of the damage"; }
                        if (damage < 0) damage = 0;
                        label1.Text += "\nVampire damaged you for " + damage + " health points";
                        health -= damage;
                        if (health < 0) health = 0;
                        takedamage();
                        page = 3.1;
                        button1.Text = "Attack";
                        button2.Text = "Block";
                        button3.Text = "Dodge";
                        enemyfocus = true;
                    }

                    break;
                case 2.3:
                    label1.Text += "\nThis chest is empty.";
                    break;
                case 3.3:
                    label1.Text += "\nThis chest is empty.";
                    break;
                case 3.2:
                    do
                    {
                        item3 = rnd();
                    }
                    while ((item3 == item1) || (item3 == item2));
                    page = 3.3;
                    switch (item3)
                    {
                        case 1:
                            pictureBox13.Image = Properties.Resources.swordtest4;
                            label1.Text += "\nYou found a sword. You can hit with it harder.";
                            break;
                        case 3:
                            pictureBox13.Image = Properties.Resources.armor;
                            label1.Text += "\nYou found an armor. Yoy take less damage in it";
                            break;
                        case 2:
                            pictureBox13.Image = Properties.Resources.shield;
                            label1.Text += "\nYou found a shield. You can block with it better";
                            break;
                        case 4:
                            pictureBox13.Image = Properties.Resources.boots2;
                            label1.Text += "\nYou found boots. You move faster in it.";
                            break;
                    }

                    break;
                case 2.2:
                    do
                    {
                        item2 = rnd();
                    }
                    while (item2 == item1);
                    page = 2.3;
                    switch (item2)
                    {
                        case 1:
                            pictureBox12.Image = Properties.Resources.swordtest4;
                            label1.Text += "\nYou found a sword. You can hit with it harder.";
                            break;
                        case 3:
                            pictureBox12.Image = Properties.Resources.armor;
                            label1.Text += "\nYou found an armor. Yoy take less damage in it";
                            break;
                        case 2:
                            pictureBox12.Image = Properties.Resources.shield;
                            label1.Text += "\nYou found a shield. You can block with it better";
                            break;
                        case 4:
                            pictureBox12.Image = Properties.Resources.boots2;
                            label1.Text += "\nYou found boots. You move faster in it.";
                            break;
                    }

                    break;
                case 1:
                    page += 0.1;
                    item1 = rnd();
                    switch (item1)
                    {
                        case 1:
                            pictureBox11.Image = Properties.Resources.swordtest4;
                            label1.Text += "\nYou found a sword. You can hit with it harder.";
                            break;
                        case 3:
                            pictureBox11.Image = Properties.Resources.armor;
                            label1.Text += "\nYou found an armor. Yoy take less damage in it";
                            break;
                        case 2:
                            pictureBox11.Image = Properties.Resources.shield;
                            label1.Text += "\nYou found a shield. You can block with it better";
                            break;
                        case 4:
                            pictureBox11.Image = Properties.Resources.boots2;
                            label1.Text += "\nYou found boots. You move faster in it.";
                            break;
                    }
                    break;
                case 1.1:
                    label1.Text += "\nThis chest is empty.";
                    break;
                case 2:
                    if (rnd() > 3)
                    {
                        page = 2.2; label1.Text = "Turned out, that goblin is friendly and his name is Piotr.\nNothing stands between you and chest or door.\n What are you going to do?";
                        button1.Text = "Enter the door.";
                        button2.Text = "Look inside the chest.";
                        button3.Text = "Go back to the previous room.";
                    }
                    else
                    {
                        label1.Text += "\nGoblin said, that he have enough friends and attacked you.";
                        damage = rnd();
                        damage += 1;
                        if (item1 == 3) { damage -= 2; label1.Text += "\nWith your armor you reduce part of the damage"; }
                        if (damage < 0) damage = 0;
                        label1.Text += "\nGoblin damaged you for " + damage + " health points";
                        health -= damage;
                        if (health < 0) health = 0; takedamage();
                        page = 2.1;
                        button1.Text = "Attack";
                        button2.Text = "Block";
                        button3.Text = "Dodge";
                        enemyfocus = true;
                    }
                    break;
                case 2.1:
                    damage = rnd();
                    damage += 1;
                    if (item1 == 2)
                    {
                        label1.Text += "\nYou use your shield and block 4 points of damage";
                        damage -= 4;
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                    }
                    else
                        label1.Text += "\nYou block enemy attack with your hands and reduce damage by 2";
                    damage -= 2;
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    health -= damage;
                    if (health < 0) health = 0;
                    label1.Text += "\nYou lost " + damage + " health.";
                    takedamage();
                    enemyfocus = false;
                    break;
            }


        }
        private int rnd()
        {
            int x = 0;
            Random rand = new Random();
            x = rand.Next(1, 5);
            return x;
        }
        private void enemydamaged()
        {
            switch (enemyhealth)
            {
                case 9:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar;
                    pictureBox23.Image = Properties.Resources.hpbar;
                    pictureBox22.Image = Properties.Resources.hpbar;
                    pictureBox21.Image = Properties.Resources.hpbar;
                    pictureBox20.Image = Properties.Resources.hpbar;
                    pictureBox19.Image = Properties.Resources.hpbar;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 8:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar;
                    pictureBox22.Image = Properties.Resources.hpbar;
                    pictureBox21.Image = Properties.Resources.hpbar;
                    pictureBox20.Image = Properties.Resources.hpbar;
                    pictureBox19.Image = Properties.Resources.hpbar;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 7:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar2;
                    pictureBox22.Image = Properties.Resources.hpbar;
                    pictureBox21.Image = Properties.Resources.hpbar;
                    pictureBox20.Image = Properties.Resources.hpbar;
                    pictureBox19.Image = Properties.Resources.hpbar;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 6:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar2;
                    pictureBox22.Image = Properties.Resources.hpbar2;
                    pictureBox21.Image = Properties.Resources.hpbar;
                    pictureBox20.Image = Properties.Resources.hpbar;
                    pictureBox19.Image = Properties.Resources.hpbar;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 5:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar2;
                    pictureBox22.Image = Properties.Resources.hpbar2;
                    pictureBox21.Image = Properties.Resources.hpbar2;
                    pictureBox20.Image = Properties.Resources.hpbar;
                    pictureBox19.Image = Properties.Resources.hpbar;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 4:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar2;
                    pictureBox22.Image = Properties.Resources.hpbar2;
                    pictureBox21.Image = Properties.Resources.hpbar2;
                    pictureBox20.Image = Properties.Resources.hpbar2;
                    pictureBox19.Image = Properties.Resources.hpbar;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 3:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar2;
                    pictureBox22.Image = Properties.Resources.hpbar2;
                    pictureBox21.Image = Properties.Resources.hpbar2;
                    pictureBox20.Image = Properties.Resources.hpbar2;
                    pictureBox19.Image = Properties.Resources.hpbar2;
                    pictureBox18.Image = Properties.Resources.hpbar;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 2:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar2;
                    pictureBox22.Image = Properties.Resources.hpbar2;
                    pictureBox21.Image = Properties.Resources.hpbar2;
                    pictureBox20.Image = Properties.Resources.hpbar2;
                    pictureBox19.Image = Properties.Resources.hpbar2;
                    pictureBox18.Image = Properties.Resources.hpbar2;
                    pictureBox17.Image = Properties.Resources.hpbar;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 1:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar2;
                    pictureBox22.Image = Properties.Resources.hpbar2;
                    pictureBox21.Image = Properties.Resources.hpbar2;
                    pictureBox20.Image = Properties.Resources.hpbar2;
                    pictureBox19.Image = Properties.Resources.hpbar2;
                    pictureBox18.Image = Properties.Resources.hpbar2;
                    pictureBox17.Image = Properties.Resources.hpbar2;
                    pictureBox16.Image = Properties.Resources.hpbar;
                    break;
                case 0:
                    pictureBox25.Image = Properties.Resources.hpbar2;
                    pictureBox24.Image = Properties.Resources.hpbar2;
                    pictureBox23.Image = Properties.Resources.hpbar2;
                    pictureBox22.Image = Properties.Resources.hpbar2;
                    pictureBox21.Image = Properties.Resources.hpbar2;
                    pictureBox20.Image = Properties.Resources.hpbar2;
                    pictureBox19.Image = Properties.Resources.hpbar2;
                    pictureBox18.Image = Properties.Resources.hpbar2;
                    pictureBox17.Image = Properties.Resources.hpbar2;
                    pictureBox16.Image = Properties.Resources.hpbar2;
                    break;
            }
        }
        private void takedamage()
        {
            switch (health)
            {
                case 10:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar;
                    pictureBox4.Image = Properties.Resources.hpbar;
                    pictureBox5.Image = Properties.Resources.hpbar;
                    pictureBox6.Image = Properties.Resources.hpbar;
                    pictureBox7.Image = Properties.Resources.hpbar;
                    pictureBox8.Image = Properties.Resources.hpbar;
                    pictureBox9.Image = Properties.Resources.hpbar;
                    pictureBox10.Image = Properties.Resources.hpbar;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar;
                    pictureBox4.Image = Properties.Resources.hpbar;
                    pictureBox5.Image = Properties.Resources.hpbar;
                    pictureBox6.Image = Properties.Resources.hpbar;
                    pictureBox7.Image = Properties.Resources.hpbar;
                    pictureBox8.Image = Properties.Resources.hpbar;
                    pictureBox9.Image = Properties.Resources.hpbar;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar;
                    pictureBox4.Image = Properties.Resources.hpbar;
                    pictureBox5.Image = Properties.Resources.hpbar;
                    pictureBox6.Image = Properties.Resources.hpbar;
                    pictureBox7.Image = Properties.Resources.hpbar;
                    pictureBox8.Image = Properties.Resources.hpbar;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar;
                    pictureBox4.Image = Properties.Resources.hpbar;
                    pictureBox5.Image = Properties.Resources.hpbar;
                    pictureBox6.Image = Properties.Resources.hpbar;
                    pictureBox7.Image = Properties.Resources.hpbar;
                    pictureBox8.Image = Properties.Resources.hpbar2;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar;
                    pictureBox4.Image = Properties.Resources.hpbar;
                    pictureBox5.Image = Properties.Resources.hpbar;
                    pictureBox6.Image = Properties.Resources.hpbar;
                    pictureBox7.Image = Properties.Resources.hpbar2;
                    pictureBox8.Image = Properties.Resources.hpbar2;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar;
                    pictureBox4.Image = Properties.Resources.hpbar;
                    pictureBox5.Image = Properties.Resources.hpbar;
                    pictureBox6.Image = Properties.Resources.hpbar2;
                    pictureBox7.Image = Properties.Resources.hpbar2;
                    pictureBox8.Image = Properties.Resources.hpbar2;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar;
                    pictureBox4.Image = Properties.Resources.hpbar;
                    pictureBox5.Image = Properties.Resources.hpbar2;
                    pictureBox6.Image = Properties.Resources.hpbar2;
                    pictureBox7.Image = Properties.Resources.hpbar2;
                    pictureBox8.Image = Properties.Resources.hpbar2;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar;
                    pictureBox4.Image = Properties.Resources.hpbar2;
                    pictureBox5.Image = Properties.Resources.hpbar2;
                    pictureBox6.Image = Properties.Resources.hpbar2;
                    pictureBox7.Image = Properties.Resources.hpbar2;
                    pictureBox8.Image = Properties.Resources.hpbar2;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar;
                    pictureBox3.Image = Properties.Resources.hpbar2;
                    pictureBox4.Image = Properties.Resources.hpbar2;
                    pictureBox5.Image = Properties.Resources.hpbar2;
                    pictureBox6.Image = Properties.Resources.hpbar2;
                    pictureBox7.Image = Properties.Resources.hpbar2;
                    pictureBox8.Image = Properties.Resources.hpbar2;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.hpbar;
                    pictureBox2.Image = Properties.Resources.hpbar2;
                    pictureBox3.Image = Properties.Resources.hpbar2;
                    pictureBox4.Image = Properties.Resources.hpbar2;
                    pictureBox5.Image = Properties.Resources.hpbar2;
                    pictureBox6.Image = Properties.Resources.hpbar2;
                    pictureBox7.Image = Properties.Resources.hpbar2;
                    pictureBox8.Image = Properties.Resources.hpbar2;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    break;
                case 0:
                    pictureBox1.Image = Properties.Resources.hpbar2;
                    pictureBox2.Image = Properties.Resources.hpbar2;
                    pictureBox3.Image = Properties.Resources.hpbar2;
                    pictureBox4.Image = Properties.Resources.hpbar2;
                    pictureBox5.Image = Properties.Resources.hpbar2;
                    pictureBox6.Image = Properties.Resources.hpbar2;
                    pictureBox7.Image = Properties.Resources.hpbar2;
                    pictureBox8.Image = Properties.Resources.hpbar2;
                    pictureBox9.Image = Properties.Resources.hpbar2;
                    pictureBox10.Image = Properties.Resources.hpbar2;
                    lose();
                    break;
            }
        }
    }
}


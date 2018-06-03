using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        ICharacter c;
        public Form1()
        {
            InitializeComponent();
            rbMage.Checked = false;
            rbWarrior.Checked = false;
            this.lbAvailableOptions.Items.Add("Weapon");
            this.lbAvailableOptions.Items.Add("Shield");
            this.lbAvailableOptions.Items.Add("Armor");
            this.lbAvailableOptions.Items.Add("PVP Gear");
            this.lbAvailableOptions.Items.Add("Damage Potion");
            this.lbAvailableOptions.Items.Add("Intelligence scroll");


        }

        private void rbWarrior_CheckedChanged(object sender, EventArgs e)
        {
            c = new Warrior();
            this.lblPrice.Text = c.Price().ToString() +" gold ";
            this.lblIntelligence.Text = c.Intelligence().ToString() +" points";
            this.lblDamage.Text = c.Damage().ToString() + " points";

            this.pictureBox1.Image = Properties.Resources.warrior;
            this.lbAddedOptions.Items.Clear();
            this.lblInfo.Text = "";
        }

        private void rbMage_CheckedChanged(object sender, EventArgs e)
        {
            c = new Mage();
            this.lblPrice.Text =  c.Price().ToString() +" gold";
            this.lblIntelligence.Text =  c.Intelligence().ToString() +" points";
            this.lblDamage.Text =  c.Damage().ToString()+ " points";
            this.pictureBox1.Image = Properties.Resources.mage;
            this.lbAddedOptions.Items.Clear();
            this.lblInfo.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lbAddedOptions.Items.Add(Convert.ToString(this.lbAvailableOptions.SelectedItem));
           
                switch (lbAvailableOptions.SelectedItem.ToString())
                {
                    case "Weapon":
                    this.lblDamage.Text =new AddWeapon(null).getDamage().ToString() +" points";
                    this.lblIntelligence.Text =  new AddWeapon(null).getIntelligence().ToString() + " points";
                    this.lblPrice.Text = new AddWeapon(null).getPrice()+ " gold";
                        break;
                    case "Intelligence scroll":
                    this.lblDamage.Text =  new AddScrolls(null).getDamage().ToString() + " points";
                    this.lblIntelligence.Text = new AddScrolls(null).getIntelligence().ToString() + " points";
                    this.lblPrice.Text =  new AddScrolls(null).getPrice() + " gold";
                        break;
                    case "Armor":
                    this.lblDamage.Text =  new AddArmor(null).getDamage().ToString() + " points";
                    this.lblIntelligence.Text =  new AddArmor(null).getIntelligence().ToString() + " points";
                    this.lblPrice.Text =  new AddArmor(null).getPrice() + " gold";
                    break;
                    case "Damage potion":
                    this.lblDamage.Text = new AddDamagePotions(null).getDamage().ToString() + " points";
                    this.lblIntelligence.Text =  new AddDamagePotions(null).getIntelligence().ToString() + " points";
                    this.lblPrice.Text =  new AddScrolls(null).getPrice() + " gold";
                    break;
                    case "PVP Gear":
                    this.lblDamage.Text =  new AddPVPGear(null).getDamage().ToString() + " points";
                    this.lblIntelligence.Text =new AddPVPGear(null).getIntelligence().ToString() + " points";
                    this.lblPrice.Text = new AddPVPGear(null).getPrice() + " gold";
                    break;
                    case "Shield":
                    this.lblDamage.Text =  new AddShield(null).getDamage().ToString() + " points";
                    this.lblIntelligence.Text =  new AddShield(null).getIntelligence().ToString() + " points";
                    this.lblPrice.Text = new AddShield(null).getPrice() + " gold";
                    break;
                }

            }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            foreach (string s in lbAddedOptions.Items)
            {
                switch (s)
                {
                    case "Weapon":
                        c = new AddWeapon(c);
                        break;
                    case "Intelligence scroll":
                        c = new AddScrolls(c);
                        break;
                    case "Armor":
                        c = new AddArmor(c);
                        break;
                    case "Damage potion":
                        c = new AddDamagePotions(c);
                        break;
                    case "PVP Gear":
                        c = new AddPVPGear(c);
                        break;
                    case "Shield":
                        c = new AddShield(c);
                        break;
                }

            }
            this.lblInfo.Text = "Character purchased for " + c.Price() +"gold" + "\n"+"Description: "+ c.Description() +"\n Damage points: "+ c.Damage()+"\n Intelligence points: "+ c.Intelligence();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void lbAddedOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

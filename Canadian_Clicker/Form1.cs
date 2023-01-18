﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Canadian_Clicker
{
    public partial class Form1 : Form
    {
        int Ehamount;
        int clickerpower = 1;
        int igloopower = 1;
        int plowpower = 5;
        int timspower = 20;
        int hockeypower = 50;
        int riderpower = 200;

        int iglooamount;
        int plowamount;
        int timsamount;
        int hockeyamount;
        int rideramount;

        int iglooadded;
        int plowadded;
        int timsadded;
        int hockeyadded;
        int rideradded;

        int finaladd;
        int finalupgrade;

        int igloovalue = 25;
        int plowvalue = 50;
        int timsvalue = 100;
        int hockeyvalue = 150;
        int ridervalue = 250;

        SoundPlayer button1sound = new SoundPlayer(Properties.Resources.Door_Close_SoundBible_com_1305692306);
        SoundPlayer button2sound = new SoundPlayer(Properties.Resources.Button_Push_Mike_Koenig_1659525069);
        SoundPlayer button3sound = new SoundPlayer(Properties.Resources.Click2_Sebastian_759472264);
        SoundPlayer staticsound = new SoundPlayer(Properties.Resources.Radio_Static_SoundBible_com_629277574);
        SoundPlayer templebellsound = new SoundPlayer(Properties.Resources.Temple_Bell_SoundBible_com_756181215);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scoreLabel.Text = $"eh? Amount:{Ehamount}";
            numberofiglooLabel.Text = $" Cost:25  Total Owned:{iglooamount}";
            numberofsnowplowLabel.Text = $"Cost:50   Total Owned:{plowamount}";
            numberoftimsLabel.Text = $"Cost:100  Total Owned:{timsamount}";
            numberofhockeyLabel.Text =  $"Cost:150  Total Owned:{hockeyamount}";
            numberofmooseLabel.Text = $"Cost:250   Total Owned:{rideramount}";

            clickpowerLabel.Text = $"Click POWER: {clickerpower}";

            if (iglooamount >= 0)
            {
                iglooadded = iglooamount * igloopower;
                finaladd = Ehamount;
                Ehamount = finaladd + iglooadded;
            }
            if (plowamount >= 0)
            {
                plowadded = plowamount * plowpower;
                finaladd = Ehamount;
                Ehamount = finaladd + plowadded;
            }
            if (timsamount >= 0)
            {
                timsadded = timsamount * timspower;
                finaladd = Ehamount;
                Ehamount = finaladd + timsadded;
            }
            if (hockeyamount >= 0)
            {
                hockeyadded = hockeyamount * hockeypower;
                finaladd = Ehamount;
                Ehamount = finaladd + hockeyadded;
            }
            if (rideramount >= 0)
            {
                rideradded = rideramount * riderpower;
                finaladd = Ehamount;
                Ehamount = finaladd + rideradded;
            }
        }

        private void mapleLeafImage_Click(object sender, EventArgs e)
        {
            finaladd = Ehamount;
            Ehamount = finaladd + clickerpower;
            button3sound.Play();
        }

        private void buyiglooButton_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 25)
            {
                iglooamount++;
                finaladd = Ehamount;
                Ehamount = finaladd - igloovalue;
                button1sound.Play();
            }
        }

        private void buysnowplowButton_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 50)
            {
                plowamount++;
                finaladd = Ehamount;
                Ehamount = finaladd - plowvalue;
                button1sound.Play();
            }
        }

        private void buytimsButton_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 100)
            {
                timsamount++;
                finaladd = Ehamount;
                Ehamount = finaladd - timsvalue;
                button1sound.Play();
            }
        }

        private void buyhockeyplayerButton_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 150)
            {
                hockeyamount++;
                finaladd = Ehamount;
                Ehamount = finaladd - hockeyvalue;
                button1sound.Play();
            }
        }

        private void buymooseriderButton_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 250)
            {
                rideramount++;
                finaladd = Ehamount;
                Ehamount = finaladd - ridervalue;
                button1sound.Play();
            }
        }

        private void powerup2Xlabel_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 1000)
            {
                finaladd = Ehamount;
                Ehamount = finaladd - 1000;
                finalupgrade = clickerpower * 2;
                clickerpower = finalupgrade;
                button1sound.Play();
            }
            if (clickerpower == 512)
            {
                powerup2Xlabel.Enabled = false;
            }
        }

        private void powerupIglooLabel_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 10000)
            {
                finaladd = Ehamount;
                Ehamount = finaladd - 10000;
                finalupgrade = igloopower * 2;
                igloopower = finalupgrade;
                powerupIglooLabel.Enabled = false;
                button2sound.Play();
            }
        }

        private void timsMilkAndSugar2X_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 20000)
            {
                finaladd = Ehamount;
                Ehamount = finaladd - 20000;
                finalupgrade = timspower * 2;
                timspower = finalupgrade;
                timsMilkAndSugar2X.Enabled = false;
                button2sound.Play();
            }
        }

        private void hockeypowerupLabel_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 50000)
            {
                finaladd = Ehamount;
                Ehamount = finaladd - 50000;
                finalupgrade = hockeypower * 3;
                hockeypower = finalupgrade;
                hockeypowerupLabel.Enabled=false;
                button2sound.Play();
            }
        }

        private void floridianMooseRider10x_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 100000)
            {
                finaladd = Ehamount;
                Ehamount = finaladd - 100000;
                finalupgrade = riderpower * 10;
                riderpower = finalupgrade;
                floridianMooseRider10x.Enabled = false;
                button2sound.Play();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Ehamount = 0;
            iglooamount = 0;
            plowamount = 0;
            timsamount = 0;
            hockeyamount = 0;
            rideramount = 0;
            clickerpower = 1;
            igloopower = 1;
            plowpower = 5;
            timspower = 20;
            hockeypower = 50;
            riderpower = 200;
            powerupIglooLabel.Enabled = true;
            timsMilkAndSugar2X.Enabled = true;
            hockeypowerupLabel.Enabled = true;
            floridianMooseRider10x.Enabled=true;
            powerup2Xlabel.Enabled=true;
            staticsound.Play();
        }

        private void winButton_Click(object sender, EventArgs e)
        {
            if (Ehamount >= 100000000 && clickerpower == 512)
            {
                costtowinLabel.Text = $"What was the point? like, are you THAT bored?";
                powerupIglooLabel.Visible = false;
                timsMilkAndSugar2X.Visible = false;
                hockeypowerupLabel.Visible = false;
                floridianMooseRider10x.Visible = false;
                powerup2Xlabel.Visible = false;
                numberofhockeyLabel.Visible = false;
                numberofiglooLabel.Visible = false;
                numberofmooseLabel.Visible = false;
                numberofsnowplowLabel.Visible = false;
                numberoftimsLabel.Visible = false;
                buyhockeyplayerButton.Visible = false;
                buyiglooButton.Visible = false;
                buymooseriderButton.Visible = false;
                buysnowplowButton.Visible = false;
                buytimsButton.Visible = false;
                winButton.Visible = false;
                templebellsound.Play();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Choose
{
    public partial class optionOne : Form
    {
        int page = 1;

        Random randGen = new Random();

        public optionOne()
        {
            InitializeComponent();
            output.Text = "Start the game?";
            opt.Text = "No";
            optiontwo.Text = "Yes";
            hud.BackgroundImage = Properties.Resources.babaya;
        }

        private void optiontwo_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 100;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 100;
            }
            else if (page == 6)
            {
                page = 100; 
            }
            else if (page == 99)
            {
                page = 100; 
            }
            else if (page == 9)
            {
                page = 100;
            }
            switch (page)
            {
                case 1:
                    output.Text = "Start?";

                    opt.Text = "No";
                    optiontwo.Text = "Yes";
                    hud.BackgroundImage = Properties.Resources.babaya;

                    break;
                case 2:
                    output.Text = "You wake up in a strange town, the cars are all little tike cars. What will be your next action?";

                    opt.Text = "Walk down the road";
                    optiontwo.Text = "Ask where you are";

                    hud.BackgroundImage = Properties.Resources.IMG_4040;
                    break;
                case 4:
                    output.Text = "You walk towards a massive pyramid, guarded by a few bodyguards";

                    opt.Text = "FIGHT EM";
                    optiontwo.Text = "Sneak in";
                    hud.BackgroundImage = Properties.Resources.B169944B_01E6_4579_B80B_664C1A1835E8;
                    break;
                case 3:
                    output.Text = "You walk up to the Baby Man, He starts to scream and cry so loud you die";

                    opt.Text = "Reset";
                    optiontwo.Text = "Don't";
                    hud.BackgroundImage = Properties.Resources.hqdefault;
                    break;
                case 6:
                    output.Text = "You sneak too loudly are are caught, you get thrown in to Time Out until you ROT";

                    opt.Text = "Reset";
                    optiontwo.Text = "Dont";
                    hud.BackgroundImage = Properties.Resources.hqdefault;
                    break;
                case 7:
                    output.Text = "You fight your way through the gaurds and enter the pyramid, now face to face with K I N G...";

                    optiontwo.Text = "Establish Peace";
                    opt.Text = "Assasinate him";
                    hud.BackgroundImage = Properties.Resources.IMG_4046; 
                    break;
                case 8:
                    output.Text = "You approach the king with a peace treaty and become his friend, good job you won and you aren't a monster!";

                    opt.Text = "RESTART";
                    optiontwo.Text = "end";
                    hud.BackgroundImage = Properties.Resources.WINER; 
                    break;
                   
                case 99:
                    output.Text = "LEAVE NOW!!";

                    opt.Text = "RESTART";
                    optiontwo.Text = "end";
                    hud.BackgroundImage = Properties.Resources.hqdefault;
                    break;
                case 100:
                    output.Text = "Vanish";
                    opt.Text = "no turning back";
                    optiontwo.Text = "no turning back";
                    hud.BackgroundImage = Properties.Resources.bi45zvq82wg71;

                    break;
                case 9:
                    output.Text = "You approach the king and assasinate him and take his place as ruler, you won but you're also a monster";

                    opt.Text = "RESTART";
                    optiontwo.Text = "end";
                    hud.BackgroundImage = Properties.Resources.WINER;

                    break;
            }
        }
        private void opt_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 9; 
            }
            else if (page == 3)
            {
                page = 1; 
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 99)
            {
                page = 1; 
            }
            else if (page == 8)
            {
                page = 1; 
            }
              

                switch (page)
                {
                    case 1:
                        output.Text = "Start?";

                        opt.Text = "No";
                        optiontwo.Text = "Yes";
                    hud.BackgroundImage = Properties.Resources.babaya;

                    break;
                    case 2:
                        output.Text = "You wake up in a strange town, the cars are all little tike cars. What will be your next action?";

                        opt.Text = "Walk down the road";
                        optiontwo.Text = "Ask where you are";

                        ;
                        break;
                    case 4:
                        output.Text = "You walk towards a massive pyramid, guarded by a few bodyguards";

                        opt.Text = "FIGHT EM";
                        optiontwo.Text = "Sneak in";
                    hud.BackgroundImage = Properties.Resources.B169944B_01E6_4579_B80B_664C1A1835E8;
                    break;
                    case 3:
                        output.Text = "You walk up to the Baby Man, He starts to scream and cry so loud you die";

                        opt.Text = "Reset";
                        optiontwo.Text = "Don't";
                        break;
                    case 6:
                        output.Text = "You sneak too loudly are are caught, you get thrown in to Time Out until you ROT";

                        opt.Text = "Reset";
                        optiontwo.Text = "Dont";
                        break;
                    case 7:
                        output.Text = "You fight your way through the gaurds and enter the pyramid, now face to face with K I N G...";

                        optiontwo.Text = "Establish Peace";
                        opt.Text = "Assasinate him";
                    hud.BackgroundImage = Properties.Resources.IMG_4046; 
                    break;
                    case 8:
                        output.Text = "You approach the king with a peace treaty and become his friend, good job you won and you aren't a monster!";

                        opt.Text = "RESTART";
                        optiontwo.Text = "end";
                    hud.BackgroundImage = Properties.Resources.WINER; 
                    break;
                    case 99:
                        output.Text = "LEAVE NOW!!";

                        opt.Text = "RESTART";
                        optiontwo.Text = "end";
                        break;
                    case 100:
                        output.Text = "Vanish";
                        opt.Text = "no turning back";
                        optiontwo.Text = "no turning back";
                    hud.BackgroundImage = Properties.Resources.bi45zvq82wg71; 
                    break;
                    case 9:
                        output.Text = "You approach the king and assasinate him and take his place as ruler, you won but you're also a monster";

                        opt.Text = "RESTART";
                        optiontwo.Text = "end";
                    hud.BackgroundImage = Properties.Resources.WINER;


                        break;
                }
            }

        private void optionOne_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
    }




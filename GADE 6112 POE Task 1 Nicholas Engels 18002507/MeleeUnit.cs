using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_POE_Task_1_Nicholas_Engels_18002507
{
    class MeleeUnit : Unit
    {
        private Random r = new Random();
        public int xPos//This saves the X position of the Melee Unit
        {
            get { return base.XPos; }
            set { base.XPos = value; }
        }

        public int yPos//This saves the Y Position of the Melee Unit
        {
            get { return base.YPos; }
            set { base.YPos = value; }
        }

        public int Meleehealth//This would save the health of the melee Unit which is capped at 20
        {
            get { return base.Health; }
            set { base.Health = value; }
        }

        public int speed //This is the speed that the Melee Unit is able to attack with
        {
            get { return base.Speed; }
            set { base.Speed = value; }
        }

        public int attack//This saves the amount of damage that the unit can inflict to the enemy
        {
            get { return base.Attack; }
            set { base.Attack = value; }
        }

        public int projectileRange//This is how close the melee unit has to be in order to attack
        {
            get { return base.ProjectileRange; }
            set { base.ProjectileRange = value; }
        }

        public string faction//This stores the allaigence of the unit
        {
            get { return base.Faction; }
            set { base.Faction = value; }
        }

        public string image // this is the colour of the team
        {
            get { return base.Image; }
            set { base.Image = value; }
        }

        public override void Move()//This method is used to show how a unit it supposed to move
        {
            xPosMove = xPos + r.Next(-1, 1);
            yPosMove = yPos + r.Next(-1, 1);
            xPos = xPosMove;
            yPos = yPosMove;

            throw new NotImplementedException();
        }

        public override void Battle()
        {
            int MeleeHealth = 20;
            int RetreatHealth = 5;
            if (xPos == (xPos + projectileRange))
            {
                if (yPos == (yPos + projectileRange))
                {
                    InRange = true;
                }
            }

            if (MeleeHealth <= RetreatHealth)
            {
                Move();
            }
            throw new NotImplementedException();
        }

        public override bool IsInRange()
        {
            if (InRange == true)
            {
                Battle();
            }
            throw new NotImplementedException();
        }

        public override Unit Closest()
        {

            throw new NotImplementedException();
        }

        public override void Destroy()
        {

            throw new NotImplementedException();
        }

        public override string toString()
        {

            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_POE_Task_1_Nicholas_Engels_18002507
{
    class RangedClass : Unit
    {
        private Random r = new Random();
        public int xPos//This saves the X position of the Ranged Unit
        {
            get { return base.XPos; }
            set { base.XPos = value; }
        }

        public int yPos//This saves the Y Position of the Ranged Unit
        {
            get { return base.YPos; }
            set { base.YPos = value; }
        }

        public int Rangedhealth
        {
            get { return base.Health; }
            set { base.Health = value; }
        }

        public int speed
        {
            get { return base.Speed; }
            set { base.Speed = value; }
        }

        public int attack
        {
            get { return base.Attack; }
            set { base.Attack = value; }
        }

        public int projectileRange
        {
            get { return base.ProjectileRange; }
            set { base.ProjectileRange = value; }
        }

        public string faction
        {
            get { return base.Faction; }
            set { base.Faction = value; }
        }

        public string image
        {
            get { return base.Image; }
            set { base.Image = value; }
        }

        public override void Move()
        {
            xPosMove = xPos + r.Next(-1, 1);
            yPosMove = yPos + r.Next(-1, 1);
            xPos = xPosMove;
            yPos = yPosMove;
            
        }

        public override void Battle()
        {
            int MeleeHealth = 20;
            int RetreatHealth = 5;
            if (xPos == (xPos + projectileRange))
            {
                if(yPos == (yPos + projectileRange))
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
            if(InRange == true)
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

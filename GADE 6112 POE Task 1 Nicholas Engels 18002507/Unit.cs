using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_POE_Task_1_Nicholas_Engels_18002507
{
    abstract class Unit
    {
        protected int XPos;
        protected int YPos;
        protected int xPosMove;
        protected int yPosMove;
        protected int Health;
        protected int Speed;
        protected int Attack;
        protected int ProjectileRange;
        protected bool InRange;
        protected string Faction;
        protected string Image;

        abstract public void Move();
        abstract public void Battle();
        abstract public bool IsInRange();
        abstract public Unit Closest();
        abstract public void Destroy();
        abstract public string toString();

    }
}

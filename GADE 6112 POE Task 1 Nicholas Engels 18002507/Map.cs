using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_POE_Task_1_Nicholas_Engels_18002507
{
    class Map
    {
        public MeleeUnit[] MeleeGreen = new MeleeUnit[5];
        public MeleeUnit[] MeleeRed = new MeleeUnit[5];
        public RangedClass[] RangedGreen = new RangedClass[10];
        public RangedClass[] RangedRed = new RangedClass[10];
        private Random r = new Random();
        private bool isFound;

        public void GenerateUnits()
        {
            

            for(int x = 0; x < 5; x++)
            {

                MeleeGreen[x] = new MeleeUnit();
                MeleeGreen[x].Meleehealth = 50;
                MeleeGreen[x].speed = r.Next(1,4);
                MeleeGreen[x].image = "image";
                MeleeGreen[x].faction = " Green ";

                do
                {
                    isFound = true;
                    MeleeGreen[x].xPos = r.Next(1, 21);
                    MeleeGreen[x].yPos = r.Next(1, 21);
                    for (int i = 0; i < x; i++)
                    { 
                        if (!((MeleeGreen[x].xPos == MeleeGreen[i].xPos)&&(MeleeGreen[x].yPos == MeleeGreen[i].yPos)))
                        {
                            isFound = false;
                        }
                    }
                } while (isFound == true);

                RangedGreen[x] = new RangedClass();
                RangedGreen[x].projectileRange = r.Next(2, 5);  
            }

            for (int x = 0; x < 5; x++)
            {

                MeleeRed[x] = new MeleeUnit();
                MeleeRed[x].Meleehealth = 50;
                MeleeRed[x].speed = r.Next(1, 4);
                MeleeRed[x].image = "image";
                MeleeRed[x].faction = " Red ";

                do
                {
                    isFound = true;
                    MeleeRed[x].xPos = r.Next(1, 21);
                    MeleeRed[x].yPos = r.Next(1, 21);
                    for (int i = 0; i < x; i++)
                    {
                        if (!((MeleeRed[x].xPos == MeleeRed[i].xPos) && (MeleeRed[x].yPos == MeleeRed[i].yPos)))
                        {
                            isFound = false;
                        }
                    }
                } while (isFound == true);

                RangedRed[x] = new RangedClass();
                RangedRed[x].projectileRange = r.Next(2, 5);
            }
        }

        public void GenerateMap()
        {

        }
    }
}

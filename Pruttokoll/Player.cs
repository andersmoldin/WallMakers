﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruttokoll
{
    public class Player
    {
        public int y;
        public int x;
        public string userName;
        public int imageIndex;
        //@"C:\Users\Administrator\Downloads\Martin.png";

        //public Player(int x, int y, string userName, string imageLocation)
        //{
        //    this.y = x;
        //    this.x = y;
        //    this.userName = userName;
        //    this.imageLocation = imageLocation;
        //}

        public Player(int x, int y, int imageIndex)
        {
            this.y = x;
            this.x = y;
            this.userName = "Default";
            this.imageIndex = imageIndex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class BtException : Exception
    {
        string myCostumMessage;
        public BtException(string message)
        {
            this.myCostumMessage = "BT Exception: " + message ;
        }

        public BtException() : base("BT EXCEPTION : ")
        {

        }
        public override string ToString()
        {
            return myCostumMessage + base.ToString();
        }
    }
}

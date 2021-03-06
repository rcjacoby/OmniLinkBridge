﻿using HAI_Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniLinkBridgeTest.Mock
{
    public class SendCommandEventArgs : EventArgs
    {
        public enuUnitCommand Cmd;
        public byte Par;
        public ushort Pr2;

        public override bool Equals(object other)
        {
            var toCompareWith = other as SendCommandEventArgs;

            if (toCompareWith == null)
                return false;

            return this.Cmd == toCompareWith.Cmd &&
                this.Par == toCompareWith.Par &&
                this.Pr2 == toCompareWith.Pr2;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

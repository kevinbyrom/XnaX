using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using XnaX.Framework.Messaging;


namespace XnaX.Framework
{
    public interface IState : IMessageReceiver, IUpdateable 
    {
        void Entered();
        void Exited();
    }
}

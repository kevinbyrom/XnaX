using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using XnaX.Framework.Messaging;


namespace XnaX.Framework
{
    public interface IGameEntity : IUpdateable, IDrawable, IMessageReceiver
    {
        public int ID { get; set; }
    }
}

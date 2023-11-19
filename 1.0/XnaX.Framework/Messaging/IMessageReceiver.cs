using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;


namespace XnaX.Framework.Messaging
{
    public interface IMessageReceiver
    {
        void ReceiveMessage(GameMessage message, GameTime gameTime);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;


namespace XnaX.Framework
{

    public interface IMessageTarget
    {
        void SendMessage(Message msg);
    }


    public interface IMessageManager : IUpdateable 
    {
        void RegisterTarget(IMessageTarget target);
        void UnregisterTarget(IMessageTarget target);
        void UnregisterAllTargets();

        void SendMessage(Message msg);
        void UpdateMessage(Message msg);
        void PurgeMessage(Message msg);
        void PurgeAllMessages();
        void PurgeAllMessagesByType(int type);
        void PurgeAllMessagesByTarget(
        void DeliverMessage(Message msg);
        void DeliverAllMessages();
        
    }
}

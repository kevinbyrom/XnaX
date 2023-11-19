using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace XnaX.Framework
{
    public interface IGameState : IUpdateable, IDrawable 
    {
        event EventHandler Entered;
        event EventHandler Exiting;

        void Enter();
        void Exit();
    }
}

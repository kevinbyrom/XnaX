using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public abstract class ScreenEntityBase : GameEntityBase, IScreenEntity 
    {
        public Vector2 Origin;
        public Vector2 Position;
        public Vector2 Size;
        public float Depth;
        public bool IsVisible;

        protected IScreenManager screenManager;


        public ScreenEntityBase(Game game) : base(game)
        {

        }


        public override void Initialize()
        {
            base.Initialize();

            this.screenManager = (IScreenManager)this.Game.Services.GetService(typeof(IScreenManager));
        }

    }
}

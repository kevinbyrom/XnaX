using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public class Sprite : ScreenEntityBase
    {
        public Texture2D Texture;
        public Rectangle TextureRect;
        public float Scale;
        public float Rotation;
        public Color Color;
        public SpriteEffects Effects;


        public Sprite(Game game) : base(game)
        {
        }


        /// <summary>
        /// Handles drawing of the component
        /// </summary>
        /// <param name="gameTime"></param>
        
        public override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = this.screenManager.CurrentSpriteBatch;

            spriteBatch.Draw(this.Texture, this.Position, this.TextureRect, this.Color, this.Rotation, this.Origin, this.Scale, this.Effects, this.Depth);
        }

    }
}

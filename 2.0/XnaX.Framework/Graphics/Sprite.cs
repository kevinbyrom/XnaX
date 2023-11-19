using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public class Sprite : ScreenElement
    {
        public Texture2D Texture { get; set; }        
        public Rectangle TextureRect { get; set; }
        public SpriteEffects Effects { get; set; }


        #region Draw Routines

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(this.Texture, this.Position, this.TextureRect, this.Color, this.Rotation, this.Origin, this.Scale, this.Effects, this.Depth);
        }

        #endregion

    }
}

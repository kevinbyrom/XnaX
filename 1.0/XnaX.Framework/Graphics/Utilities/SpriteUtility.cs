using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics.Utilities
{
    public static class SpriteUtility
    {

        public static Sprite CreateSprite(Game game, Texture2D texture, Rectangle textureRect)
        {
            Sprite sprite = new Sprite(game);

            sprite.Texture = texture;
            sprite.TextureRect = textureRect;

            return sprite;
        }

    }
}

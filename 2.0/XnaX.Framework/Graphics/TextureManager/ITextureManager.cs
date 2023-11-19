using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework
{
    public interface ITextureManager
    {
        Texture2D LoadTexture(string name, string filename);
        void UnloadTexture(string name);
        void UnloadAllTextures();
    }
}

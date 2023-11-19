using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public class TextureManager : GameComponent, ITextureManager 
    {
        private Dictionary<string, Texture2D> textures;


        public TextureManager(Game game) : base(game)
        {
            this.textures = new Dictionary<string, Texture2D>();
        }


        /// <summary>
        /// Loads a texture from a file
        /// </summary>
        /// <param name="name">Name of the texture</param>
        /// <param name="filename">File to load</param>
        /// <returns>Returns the loaded texture</returns>
        
        public Texture2D LoadTexture(string name, string filename)
        {
            Texture2D texture = null;

            if (this.textures.ContainsKey(name.ToUpper()))
                texture = this.textures[name.ToUpper()];
            else
            {
                texture = Texture2D.FromFile(this.Game.GraphicsDevice, System.IO.Path.Combine(GameManager.AssetsPath, filename));
                this.textures.Add(name.ToUpper(), texture);
            }

            return texture;
        }


        /// <summary>
        /// Unloads a texture from memory
        /// </summary>
        /// <param name="name">Name of the texture to unload</param>
        
        public void UnloadTexture(string name)
        {
            if (this.textures.ContainsKey(name.ToUpper()))
            {
                Texture2D texture = this.textures[name.ToUpper()];

                texture.Dispose();

                this.textures.Remove(name.ToUpper());
            }
        }


        /// <summary>
        /// Unloads all textures from memory
        /// </summary>
        
        public void UnloadAllTextures()
        {
            foreach (Texture2D texture in this.textures.Values)
                texture.Dispose();

            this.textures.Clear();
        }
        
    }
}

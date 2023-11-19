using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;


namespace XnaX.Framework
{
    public enum GameUpdateMode
    {
        All,
        Current
    }

    public enum GameDrawMode
    {
        All,
        Current
    }

    public class XnaXGame : Microsoft.Xna.Framework.Game
    {
        public GameUpdateMode UpdateMode { get; set; }
        public GameDrawMode DrawMode { get; set; }

        protected GraphicsDeviceManager graphicsManager = null;
        protected ContentManager contentManager = null;

        protected Stack<Stage> stages                   = new Stack<Stage>();
        protected Stack<RenderTarget2D> renderTargets   = new Stack<RenderTarget2D>();


        public GraphicsDeviceManager GraphicsManager
        {
            get
            {
                return this.graphicsManager;
            }
        }
        
        public ContentManager ContentManager
        {
            get
            {
                return this.contentManager;
            }
        }

        public Stage CurrentStage
        {
            get
            {
                return stages.Peek();
            }
        }

        public string AssetsPath                     = "";
        
        public SpriteFont DebugFont                  = null;

        protected 
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }



        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        
        protected override void Update(GameTime gameTime)
        {
            
            // Update the input manager

            // If UpdateMode is all, update each stage
            // Otherwise, update the current stage

            if (this.UpdateMode == GameUpdateMode.All)
            {
                foreach (Stage stage in this.stages)
                    stage.Update(gameTime);
            }
            else
            {
                this.CurrentStage.Update(gameTime);
            }

            base.Update(gameTime);
        }



        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        
        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);


            // If DrawMode is all, draw each stage
            // Otherwise, draw the current stage

            if (this.DrawMode == GameDrawMode.All)
            {
                foreach (Stage stage in this.stages)
                    stage.Draw(gameTime);
            }
            else
            {
                this.CurrentStage.Draw(gameTime);
            }

        }
    }
}

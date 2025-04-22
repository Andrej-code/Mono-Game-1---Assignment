using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_Game_1___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D robloxoffice2Texture, zsaqr19_3Texture, friendsTexture, friends1Texture, friends2Texture, strangegirlTexture;
        Vector2 redguyLocation;
        Random generator;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            generator = new Random();
            redguyLocation = new Vector2(generator.Next(0, 550), generator.Next(0, 450));

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

            this.Window.Title = " Graphics Assignment";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            robloxoffice2Texture = Content.Load<Texture2D>("robloxoffice2");
            zsaqr19_3Texture = Content.Load<Texture2D>("zsaqr19_3");
            friendsTexture = Content.Load<Texture2D>("friends");
            friends1Texture = Content.Load<Texture2D>("friends1");
            friends2Texture = Content.Load<Texture2D>("friends2");
            strangegirlTexture = Content.Load<Texture2D>("strangegirl");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();


            _spriteBatch.Draw(robloxoffice2Texture, new Vector2(0, 0), Color.White);

            _spriteBatch.Draw(zsaqr19_3Texture, redguyLocation, Color.White);

            _spriteBatch.Draw(friends1Texture, new Vector2(200, 150), Color.White);

            _spriteBatch.Draw(friends2Texture, new Vector2(400, 150), Color.White);

            _spriteBatch.Draw(friendsTexture, new Vector2(0, 150), Color.White);

            _spriteBatch.Draw(strangegirlTexture, new Vector2(300, 150), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

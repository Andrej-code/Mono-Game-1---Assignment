using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_Game_1___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D robloxoffice2Texture, zsaqr19_3Texture, baconhairTexture;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
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
            baconhairTexture = Content.Load<Texture2D>("baconhair");
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

            _spriteBatch.Draw(zsaqr19_3Texture, new Vector2(300, 150), Color.White);

            _spriteBatch.Draw(baconhairTexture, new Vector2(100, 150),Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

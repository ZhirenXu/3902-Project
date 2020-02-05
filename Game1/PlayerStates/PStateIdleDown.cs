using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerStates
{
    class PStateIdleDown : IPlayerState
    {
        ISprite sprite;
        IPlayer player;
        public PStateIdleDown(IPlayer player)
        {
            this.player = player;
            //this.sprite = new SpriteIdleDown(player);
        }
        public void MoveUp()
        {
           //player.SetState(new PStateMovingUp(player));
        }

        public void MoveDown()
        {

        }
        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        public void Attack()
        {

        }

        public void Update()
        {
            sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }

    }
}

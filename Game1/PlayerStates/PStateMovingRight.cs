using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerStates
{
    class PStateMovingRight : IPlayerState
    {
        ISprite sprite;
        IPlayer player;
        public PStateMovingRight(IPlayer player)
        {
            this.player = player;
            //this.sprite = new LinkMovingDown(player);
        }
        public void MoveUp()
        {
           
        }

        public void MoveDown()
        {
            
        }
        public void MoveLeft()
        {
            //player.SetState(new PStateMovingLeft(player));
        }

        public void MoveRight()
        {
            //player.SetState(new PStateMovingRight(player));
        }

        public void SlotA()
        {

        }

        public void SlotB()
        {

        }

        public void Stop()
        {
            player.SetState(new PStateIdleRight(player));
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

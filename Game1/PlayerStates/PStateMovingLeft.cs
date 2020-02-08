using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerStates
{
    class PStateMovingLeft : IPlayerState
    {
        ISprite sprite;
        IPlayer player;
        public PStateMovingLeft(IPlayer player)
        {
            this.player = player;
            this.sprite = SpriteFactory.Instance.GetLinkMovingLeft(player);
        }
        public void MoveUp()
        {
            player.SetState(new PStateMovingUp(player));
        }

        public void MoveDown()
        {
            player.SetState(new PStateMovingDown(player));
        }
        public void MoveLeft()
        {
            
        }

        public void MoveRight()
        {
       
        }

        public void SlotA()
        {

        }

        public void SlotB()
        {

        }

        public void Stop()
        {
            player.SetState(new PStateIdleLeft(player));
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

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerStates
{
    class PStateMovingUp : IPlayerState
    {
        ISprite sprite;
        IPlayer player;
        public PStateMovingUp(IPlayer player)
        {
            this.player = player;
            this.sprite = SpriteFactory.Instance.GetLinkMovingUp(player);
        }
        public void MoveUp()
        {
           
        }

        public void MoveDown()
        {
            player.SetState(new PStateMovingDown(player));
        }
        public void MoveLeft()
        {
            player.SetState(new PStateMovingLeft(player));
        }

        public void MoveRight()
        {
            player.SetState(new PStateMovingRight(player));
        }

        public void SlotA()
        {
            player.SetState(new PStateStabbingUp(player));
        }

        public void SlotB()
        {

        }

        public void Stop()
        {
            player.SetState(new PStateIdleUp(player));
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

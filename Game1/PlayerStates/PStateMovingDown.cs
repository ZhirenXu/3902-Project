using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerStates
{
    class PStateMovingDown : IPlayerState
    {
        ISprite sprite;
        IPlayer player;
        public PStateMovingDown(IPlayer player)
        {
            this.player = player;
            this.sprite = SpriteFactory.Instance.GetLinkMovingDown(player);
        }
        public void MoveUp()
        {
            player.SetState(new PStateMovingUp(player));
        }

        public void MoveDown()
        {
            
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
            player.SetState(new PStateStabbingDown(player));
        }

        public void SlotB()
        {

        }

        public void Stop()
        {
            player.SetState(new PStateIdleDown(player));
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

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerStates
{
    class PStateIdleDown : IPlayerState
    {
        ISprite sprite;
        IPlayer player;
        int coolDown;
        int timer = 0;
        public PStateIdleDown(IPlayer player, int coolDown = 0)
        {
            this.player = player;
            this.sprite = SpriteFactory.Instance.GetLinkIdleDown(player);
            this.coolDown = coolDown;
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
            player.SetState(new PStateMovingLeft(player));
        }

        public void MoveRight()
        {
            player.SetState(new PStateMovingRight(player));
        }

        public void SlotA()
        {
            if (timer == coolDown)
            {
                player.SetState(new PStateStabbingDown(player));
            }
        }

        public void SlotB()
        {

        }

        public void Stop()
        {

        }

        public void Update()
        {
            if (coolDown != 0)
            {
                timer++;
            }
            sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }

    }
}

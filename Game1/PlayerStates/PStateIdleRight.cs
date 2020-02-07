using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerStates
{
    class PStateIdleRight : IPlayerState
    {
        ISprite sprite;
        IPlayer player;
        public PStateIdleRight(IPlayer player)
        {
            this.player = player;
            //this.sprite = new SpriteLinkIdleDown(player);
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
            //player.SetState(new PStateAttackingRight(player));
        }

        public void SlotB()
        {

        }

        public void Stop()
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

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.Projectiles
{
    class ProjLinkArrowDown : IProjectile
    {
        bool shooting;
        bool exploding;
        ISprite sprite;
        IPlayer player;
        Vector2 position;

        public ProjLinkArrowDown(IPlayer player)
        {
            shooting = false;
            exploding = false;
            this.player = player;
            this.Size = player.Size;
            this.position = new Vector2(0);
            this.Speed = 10; /*Changeable */
            sprite = SpriteFactory.Instance.GetLinkArrowDown(this);
        }
        public int Size { get; set; }
        public int Speed { get; set; }
        public int ShotDistance { get; set; }
        public void SetPosition(int x, int y)
        {
            this.position.X = x;
            this.position.Y = y;
        }
        public Vector2 GetPosition()
        {
            return this.position;
        }
        public void Shoot()
        { 
            if (!shooting)
            {
                this.ShotDistance = 0;
                this.position = player.GetPosition();
            }
            shooting = true;
        }

        public void Explode()
        {
            shooting = false;
            exploding = true;

        }

        public void Update()
        {
            if(shooting && ShotDistance >= 300)
            {
                Explode();
            }
            if (shooting)
            {
                sprite.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (shooting)
            {
                sprite.Draw(spriteBatch);
            }
        }

    }
}

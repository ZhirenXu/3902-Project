﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.Projectiles
{
    class ProjLinkArrowRight : IProjectile
    {
        bool shooting;
        bool exploding;
        ISprite sprite;
        IPlayer player;
        Vector2 position;
        int explodeTimer;

        public ProjLinkArrowRight(IPlayer player)
        {
            shooting = false;
            exploding = false;
            this.player = player;
            this.Size = player.Size;
            this.position = new Vector2(0);
            this.Speed = 10; /*Changeable */
            sprite = SpriteFactory.Instance.GetLinkArrowRight(this);
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
                sprite = SpriteFactory.Instance.GetLinkArrowRight(this);
                this.ShotDistance = 0;
                this.position = player.GetPosition();
                this.position.X += 8;
            }
            shooting = true;
        }

        public void Explode()
        {
            explodeTimer = 5;
            shooting = false;
            exploding = true;
            this.sprite = SpriteFactory.Instance.GetLinkArrowExplode(this);
        }

        public void Update()
        {
            if (shooting && ShotDistance >= 300)
            {
                Explode();
            }
            else if (exploding && explodeTimer > 0)
            {
                explodeTimer--;
            }
            if (explodeTimer <= 0)
            {
                exploding = false;
            }
            if (shooting || exploding)
            {
                sprite.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (shooting || exploding)
            {
                sprite.Draw(spriteBatch);
            }
        }

    }
}
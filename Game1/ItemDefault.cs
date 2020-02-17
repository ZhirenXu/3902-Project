﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;
using Game1.Projectiles;
using System.Collections.Generic;

namespace Game1
{
    public class ItemDefault : IItem
    {
        private Vector2 position;
        private Vector2 Boundary;
        List<IItem> items;

        public ItemDefault(int x, int y, GraphicsDevice window)
        {           
            /*Changeable*/
            this.Size = 3;      

            this.position = new Vector2();
            this.position.X = x;
            this.position.Y = y;

            this.Boundary = new Vector2();
            this.Boundary.X = window.Viewport.Width;
            this.Boundary.Y = window.Viewport.Height;

            items = new List<IItem>();           /*Items*/
        }

        public int Size { get; set; }

        public List<IItem> GetItems()
        {
            return this.items;
        }
        public void SetPosition(int x, int y)
        {
            this.position.X = x;
            this.position.Y = y;
        }

        public Vector2 GetPosition()
        {
            return this.position;
        }
        public Vector2 GetBoundary()
        {
            return Boundary;
        }
        public void Stop()
        {

        }
        public void Update()
        {
            foreach (IItem item in items)
            {
                item.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (IItem item in items)
            {
                item.Draw(spriteBatch);
            }
        }
    }
}
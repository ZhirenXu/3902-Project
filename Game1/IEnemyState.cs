using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    public interface IEnemyState
    {
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void MoveToPlayer();
        void Stop();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}

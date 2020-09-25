using System;

namespace TestECS
{
    class Game
    {
        public void Update(float gameTime)
        {
            TransformSystem.Update(gameTime);
            SpriteSystem.Update(gameTime);
            ColliderSystem.Update(gameTime);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TestECS
{
    class MyAwesomeCharacter : Entity
    {
        public MyAwesomeCharacter(/* Texture2D tex */)
        {
            // add a `Transform` component to store the character's position
            Transform transform = new Transform();
            transform.position = new Vector2(100, 100);
            AddComponent(transform);

            // add a `Sprite` component to store the character's texture
            Sprite sprite = new Sprite();
            // sprite.texture = tex;
            AddComponent(sprite); // Assume `Sprite : Component`
        }
    }

}

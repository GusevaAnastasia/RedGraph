using SFML.Graphics;
using SFML.System;

namespace RedGraph
{
    public interface IDrawable
    {
        void Draw(RenderWindow window, uint width, uint height, SFML.Graphics.Color color, float phi, float teta, float zc);

        bool CheckClick(Vector2i position, uint width, uint height, float phi, float teta, float zc);

        void Click();
    }
}
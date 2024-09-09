using Damas.Entities;
using Damas.Renderer;

namespace Damas
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            BoardRender.BoardRendering(board);
        }
    }
}
using Damas.Entities;
using Damas.Renderer;

namespace Damas;

class GameLoop
{
    private int Player1 = 12;
    private int Player2 = 12;
    private Board? GameBoard;
    private bool GameRunning = true;

    public void GameStart()
    {
        GameRun();
    }

    private void GameRun()
    {
        GameBoard = new Board();

        while (GameRunning)
        {
            BoardRender.BoardRendering(GameBoard);
        }
    }

    private void PlayerInput()
    {
        
    }
}
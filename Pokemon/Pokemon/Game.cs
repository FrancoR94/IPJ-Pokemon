using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


class Game
{
    private static Game instance;
    
    public static Game GetInstence()
    {
        if (instance == null)
        {
            instance = new Game();
        }
        return instance;
    }
    enum State { GamePlay, Menu, Pause };
    private Menu menu;
    private GamePlay gamePlay;
    private static State state;
    private Game()
    {
        menu = new Menu();
        gamePlay = new GamePlay();
        state = State.Menu;
    }
    public bool GameStart()
    {
        
        switch (state)
        {
            case State.GamePlay:
                gamePlay.Gameplay();
                break;
            case State.Menu:
                menu.MainMenu();
                state = State.GamePlay;
                break;
            case State.Pause:
                menu.PauseMenu();
                break;
        }
        return true;
        
    }
    public void GoToPause()
    {
        state = State.Pause;
    }

    public void GoToGameplay()
    {
        state = State.GamePlay;
    }
}

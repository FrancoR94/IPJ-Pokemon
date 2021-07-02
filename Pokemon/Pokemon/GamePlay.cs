using System;
using System.Collections.Generic;
using System.Text;


class GamePlay
{
    enum MenuSelection { Start = 1, Exit, Error };
    public GamePlay()
    {
        Menu menu = new Menu();
        Gameplay();
    }
    public void Gameplay()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        MenuSelection menuSelection;
        if (input >= 1 && input < (int)MenuSelection.Error)
        {
            menuSelection = (MenuSelection)input;
        }
        else
        {
            menuSelection = MenuSelection.Error;
        }
        switch (menuSelection)
        {
            case MenuSelection.Start:
                break;
            case MenuSelection.Exit:
                break;
        }
    }

}


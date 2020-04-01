using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    //game state
    int level;
    enum Screen { MainMenu, Password, Win }
    Screen currentScreen;


    void Start()
    {

        ShowMainMenu();

    }
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to into hack first?");
        Terminal.WriteLine("Press 1 for the school (Easy)");
        Terminal.WriteLine("Press 2 for the FBI (Hard)");
        Terminal.WriteLine("Enter your selection:");
    }
    void OnUserInput(string input)
    {

        if (input == "menu")
        {
            ShowMainMenu();

        }
        else if (currentScreen == Screen.MainMenu)
            RunMainMenu(input);
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();

        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "420")

        {
            Terminal.WriteLine("haha, nice");
        }
        else
        {
            Terminal.WriteLine("Invalid Entry, please choose a level");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("you have chosen level " + level);
        Terminal.WriteLine("please enter password");
        currentScreen = Screen.Password;
    }

} 
    

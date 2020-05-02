using UnityEngine;

public class Hacker : MonoBehaviour{

     const string menuHint = "You may type menu at anytime";
    string[] level1Password = { "Zo", "Shark", "Sheep", "Bird", "Cat" };
    string[] level2Password = { "Zoro", "Luffy", "Doffy", "Sanji", "Franky" };
    string[] level3Password = { "Iron Man", "Hulk", "Black Widow", "Thenos", "Spider Man" };
    int level;
    string Password;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;




    // Start is called before the first frame update
    void Start()
    {

        ShowMainMenu();

        
        
    }

    void ShowMainMenu()
    {
      currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("where would you like to hack?");
        Terminal.WriteLine("choose 1 to hack an animal farm");
        Terminal.WriteLine("choose 2 to hack One Piece");
        Terminal.WriteLine("choose 3 to hack Marvel Heroes");
        Terminal.WriteLine("enter your selection:");
    }

    void OnUserInput(string input)
    {

        if (input == "menu")

        {
            ShowMainMenu();

        }
        else if (currentScreen == Screen.MainMenu)
        {

            SetRandomPassword(input);
           
        }
        else if (currentScreen == Screen.Password)
        {

            CheckPassword(input);
        }
    }

     void CheckPassword(string input)
    { 
        if (level == 1 && input == Password)
        {
            DisplayWinScreen();
        }
        else if (level == 2 && input == Password)
        {
            DisplayWinScreen();
        }
       else if (level == 3 && input == Password)
        {
            DisplayWinScreen();
        }
      else
        {
            AskForPassword(level);
        }
    }

  

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(menuHint);
    }

    void ShowLevelReward()
    {
       switch(level)
        {case 1: Terminal.WriteLine("here is an animal");
                Terminal.WriteLine(@"
 _________        .    .
(..       \_    ,  |\  /|
 \       O  \  /|  \ \/ /
  \______    \/ |   \  / 
     vvvv\    \ |   /  |
     \^^^^  ==   \_/   |
      `\_   ===    \.  |
      / /\_   \ /      |
      |/   \_  \|      /
             \________/
"
);
                Terminal.WriteLine("Baby Shark will eat you for your win!");
                break;
            case 2:
                Terminal.WriteLine("here is an animal");
                Terminal.WriteLine(@"
               _____
              /     \
              vvvvvvv  /|__/|
                 I   /O,O   |
                 I /_____   |      /|/|
                J|/^ ^ ^ \  |    /00  |    _//|
                 |^ ^ ^ ^ |W|   |/^^\ |   /oo |
                  \m___m__|_|    \m_m_|   \mm_|
"
);
                Terminal.WriteLine("Totoro congragulates you for your win!");
                break;

                             case 3:
                Terminal.WriteLine("here is an animal");
                Terminal.WriteLine(@"
      ^._.^
    _ 'h i' _
   /-\|---|/-\
  / //\-^-/\\ \
 ;_//.=(Y)=.\\_;
; mn :-._.-: nm ;
|  .  || ||  .  |
|/' '/_I L_\' '\|
"
);
                Terminal.WriteLine("Batman congragulates you for your win!");
                break;




        }

    }
        
    
    
    
    

    

    void SetRandomPassword(string input)
    {
        if (input == "1")
        {
            level = 1;
            Password = level1Password[Random.Range(0, 5)];
            AskForPassword(1);

         }

        else if (input == "2")
        {
            level = 2;
            Password = level2Password[Random.Range(0,5)];
            AskForPassword(2);
        }
        else if (input == "3")
        {
            level = 3;
            Password = level3Password[Random.Range(0, 5)];
            AskForPassword(3);
        }
        else if (input == "007")
        {

            Terminal.WriteLine("Welcome Ms Zo");
        }
        else if (input == "menu")
        {

            ShowMainMenu();
        }
        else
        {
            Terminal.WriteLine("WRONG INPUT!");
            Terminal.WriteLine(menuHint);
        }
    }

    void AskForPassword(int level)
    {
        print(level1Password.Length);
        print(level2Password.Length);
        print(level3Password.Length);
        currentScreen = Screen.Password;
        Terminal.WriteLine("you have chosen level  " + level);
        Terminal.WriteLine("Please enter your password,hint:"+Password.Anagram());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}


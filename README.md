
# GeforyAPI

This API is not really a longer Project I just want to make my API opensource


## How the control panel is build

| File     | Description                |
| :------- | :------------------------- |
| `calculator.compute` | Computes a equasion from a String and returns it via String| 
| `calculator.compute3inputs` | Even worse isn't even finished , I will probably delete it  |
| `content.save` | Saves a String array to a file (example (.txt, .blabla)) need's an path to save the file| 
| `content.load` | Reads all lines from a file and retruns it as an String array needs' an path to load| 
| `content.explode` | I'm a PHP developer ok, XD, leave me alone. You know what I mean if u ever used it| 
| `DownloadItem.DownloadFileasync` | Downloads a file async while not interrupting the programm | 
| `DownloadItem.DownloadFile` | Downloads a file without async | 
| `Menu.run` | Runs the menu but u have to define the variables earlier as u difine the object| 
| `oneline.calc` | Is a simple calc and was only made for fun
| `value.ToWritten` | Converts a double into an spoken number |
| `ProgressBar` | Well it's a ascii ProgressBar |
 

## TODO


- Nodes
- Master
- Managers


## Installation

ProgressBar example

```cs
Console.Write("Downloading Menu.cs... ");
    using (var progress = new ProgressBar(50))
    {
        for (int i = 0; i <= 100; i++)
        {
            progress.Report((double)i / 100);
            Thread.Sleep(40);
        }
    }
Console.WriteLine("Done.");
```
Menu Example

```cs
string text = @"
                                        ▄████  ██░ ██  ▒█████    ██████ ▄▄▄█████▓  ██████ 
                                      ██▒ ▀█▒▓██░ ██▒▒██▒  ██▒▒██    ▒ ▓  ██▒ ▓▒▒██    ▒ 
                                     ▒██░▄▄▄░▒██▀▀██░▒██░  ██▒░ ▓██▄   ▒ ▓██░ ▒░░ ▓██▄   
                                     ░▓█  ██▓░▓█ ░██ ▒██   ██░  ▒   ██▒░ ▓██▓ ░   ▒   ██▒
                                      ░▒▓███▀▒░▓█▒░██▓░ ████▓▒░▒██████▒▒  ▒██▒ ░ ▒██████▒▒
                                      ░▒   ▒  ▒ ░░▒░▒░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░  ▒ ░░   ▒ ▒▓▒ ▒ ░
                                        ░   ░  ▒ ░▒░ ░  ░ ▒ ▒░ ░ ░▒  ░ ░    ░    ░ ░▒  ░ ░
                                       ░ ░   ░  ░  ░░ ░░ ░ ░ ▒  ░  ░  ░    ░      ░  ░  ░  
                                         ░  ░  ░  ░    ░ ░        ░                 ░  
                                                                            
";

            string[] options = new string[] { "Singelplayer", "Multiplayer", "Options", "Exit" };
            Menu menu = new Menu("*", " >> ", " << ", text, options, true);
            int selected = menu.Run();
```
    

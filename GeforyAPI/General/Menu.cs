using System;

namespace GeforyAPI
{
    public class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prefixbeforeoption;
        private string Prefix;
        private string Suffix;
        private string Text;
        private bool center;

        public Menu(string prefixbeforeoption, string prefix, string suffix, string text, string[] options, bool center)
        {
            Prefixbeforeoption = prefixbeforeoption;
            Prefix = prefix;
            Suffix = suffix;
            Text = text;
            Options = options;
            SelectedIndex = 0;
        }

        private void DisplayOptions()
        {
            string prefixbeforeoption;
            Console.WriteLine(Text);

            for (int i = 0; i < Options.Length; i++)
            {
                if(i == SelectedIndex)
                {
                    prefixbeforeoption = Prefixbeforeoption;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    prefixbeforeoption = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                string toprint = $"{prefixbeforeoption}{Prefix}{Options[i]}{Suffix}";

                if (center)
                {
                    Console.SetCursorPosition((Console.WindowWidth - toprint.Length) / 2, Console.CursorTop);
                }
                
                Console.WriteLine(toprint);
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keypressed;
            do
            {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                keypressed = keyinfo.Key;

                if(keypressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if(SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keypressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keypressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}

namespace BusShuttle;

using Spectre.Console;
//UI class incorporating file saver class
//incorporate file saver here instead of in Main!!!
public class ConsoleUI{
    FileSaver fileSaver;

    public ConsoleUI(){
        fileSaver = new FileSaver("passenger-data.txt");
    }

    //method for showing ui
    public void Show(){
    //Without a function:
    //Console.Write("Please select mode (driver OR manager):  ");
    //string mode = Console.ReadLine();

    //With a function AskForInput:
        // boring, no fancy ui user input
        // string mode = AskForInput("Please select mode (driver OR manager): ");

        // Fancy UI version of user input
        var mode = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please select [green]mode [/]")
                //.PageSize(10)
                //.MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .AddChoices(new[] {
                    "driver", "manager"
                }));

        if(mode=="driver"){

            string command;

            do{
                //without function AskForInput:
                //Console.WriteLine("Enter stop name: ");
                //string stopName = Console.ReadLine();

                //with function AskForInput:
                string stopName = AskForInput("Enter a stop name: ");

                //without a function:
                //Console.Write("Enter number of boarded passengers: ");
                //int boarded = int.Parse(Console.ReadLine());
                
                //with function AskForInput:
                int boarded = int.Parse(AskForInput("Enter number of boarded passengers: "));

                //without public class FileSaver
                //File.AppendAllText("passenger-data.txt", stopName+":"+boarded+Environment.NewLine);//must add 'using System.IO' when creating a file!!!

                //with class FileSaver
                fileSaver.AppendLine(stopName + ":" + boarded);

                //without a function:
                //Console.Write("Enter command (end OR continue): ");
                //command = Console.ReadLine();

                //with function AskForInput:
                //boring ui version
                //command = AskForInput("Enter command (end OR continue): ");

                // Fancy UI version of user input
                command = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Do you want to [green]continue[/] or [red]end[/]? ")
                        //.PageSize(10)
                        //.MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                        .AddChoices(new[] {
                            "continue", "end"
                        }));
           
            } while (command!="end");

        }
    }

    //create a function
    public static string AskForInput(string message){
        Console.Write(message);
        return Console.ReadLine();
    }
}
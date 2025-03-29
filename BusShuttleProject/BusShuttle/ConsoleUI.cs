namespace BusShuttle;

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
        string mode = AskForInput("Please select mode (driver OR manager): ");

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
                command = AskForInput("Enter command (end OR continue): ");
           
            } while (command!="end");

        }
    }

    //create a function
    public static string AskForInput(string message){
        Console.Write(message);
        return Console.ReadLine();
    }
}
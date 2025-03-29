namespace BusShuttle;

using System.IO;

public class FileSaver{
    string fileName;

    public FileSaver(string fileName){
        this.fileName = fileName;
        File.Create(this.fileName).Close();//always close your file!!
    }

    public void AppendLine(string line){
        File.AppendAllText(this.fileName, line + Environment.NewLine);
    }
}
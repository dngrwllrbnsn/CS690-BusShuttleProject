/*
code to create test proj, references, and add projects to the solution
@dngrwllrbnsn ➜ /workspaces/CS690-BusShuttleProject/BusShuttleProject (main) $ dotnet new xunit -o BusShuttle.Tests
The template "xUnit Test Project" was created successfully.

Processing post-creation actions...
Restoring /workspaces/CS690-BusShuttleProject/BusShuttleProject/BusShuttle.Tests/BusShuttle.Tests.csproj:
  Determining projects to restore...
  Restored /workspaces/CS690-BusShuttleProject/BusShuttleProject/BusShuttle.Tests/BusShuttle.Tests.csproj (in 4.4 sec).
Restore succeeded.


@dngrwllrbnsn ➜ /workspaces/CS690-BusShuttleProject/BusShuttleProject (main) $ dotnet add BusShuttle.Tests/BusShuttle.Tests.csproj reference BusShuttle/BusShuttle.csproj
Reference `..\BusShuttle\BusShuttle.csproj` added to the project.
@dngrwllrbnsn ➜ /workspaces/CS690-BusShuttleProject/BusShuttleProject (main) $ dotnet sln add BusShuttle.Tests/BusShuttle.Tests.csproj
Project `BusShuttle.Tests/BusShuttle.Tests.csproj` added to the solution.
@dngrwllrbnsn ➜ /workspaces/CS690-BusShuttleProject/BusShuttleProject (main) $ dotnet sln add BusShuttle/BusShuttle.csproj
Project `BusShuttle/BusShuttle.csproj` added to the solution.
@dngrwllrbnsn ➜ /workspaces/CS690-BusShuttleProject/BusShuttleProject (main) $ 
*/


namespace BusShuttle.Tests;

using BusShuttle;

public class FileSaverTests
{
    FileSaver fileSaver;
    string testFileName; //test name file

    public FileSaverTests(){
      testFileName = "test-doc.txt"; //test file will be saved to this
      fileSaver = new FileSaver(testFileName); //create test file
    }

    [Fact]
    public void Test_FileSaver_Append()
    {
      fileSaver.AppendLine("Hello, World!");//append content to test file
      var contentFromFile = File.ReadAllText(testFileName); //read test file

      Assert.Equal("Hello, World!" + Environment.NewLine, contentFromFile);//check (assert) the expected value is present (string Hello World and a new line)
    }
}
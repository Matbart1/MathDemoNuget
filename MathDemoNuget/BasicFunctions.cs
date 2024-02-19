namespace MathDemoNuget
{
    public class BasicFunctions
    {
        // https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio?tabs=netcore-cli
        // Step 1, make a class library

        // Step 2, download the NuGet.exe CLI function and add it to a folder
        //within the user directory or higher (for permissions)
        //THEN go to advance system settings -> enviornment variables -> add new + edit
        //and link the folder containing nuget.exe

        // Step 3, build the solution to form a .dll

        // Step 4, this library needs to be converted into an SDK, to do this, right click the SOLUTION
        //select CONFIGURATION MANAGER and change the solution from debug to release, then build solution

        // Step 5, configure properties for the package by right clicking Project -> Properties -> Package

        public void print(string wordToPrint)
        {
            // Give it a method for a test
            Console.WriteLine(wordToPrint);
        }
    }
}

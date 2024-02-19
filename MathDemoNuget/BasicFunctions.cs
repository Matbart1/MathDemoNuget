namespace MathDemoNuget
{
    public class BasicFunctions
    {
        // https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio?tabs=netcore-cli
        // Step 1, make a class library

        // Step 2, download the NuGet.exe CLI function and add it to a folder
        //within the user directory or higher (for permissions)
        //THEN go to advance system settings -> environment variables -> add new + edit
        //and link the folder containing nuget.exe

        // Step 3, build the solution to form a .dll

        // Step 4, configure properties for the package by right clicking Project -> Properties -> Package

        // Step 4.1, create this as a github repository, this will be used in project url and application/solution url
        //within the package properties

        // Step 5, this library needs to be converted into a nuget package, to do this, right click the SOLUTION
        //select CONFIGURATION MANAGER and change the solution from debug to release, then right click
        //the project and select 'pack'

        // Step 6, visit nuget.org and sign up, then navigate to your profile in the top right corner and
        //select API Keys, create a key with a unique name, and a glob pattern of *, copy the key code and
        //save this somewhere private

        // Step 7, under Tools -> Command Line -> Developer Console
        //enter this:
        //nuget push
        //<C:\Users\test\testSource\testRepos\Solution\Project\bin\Release\Project.1.0.0.nupkg>
        //--api-key <Enter copied API Key>
        //--source https://api.nuget.org/v3/index.json

        // This must all be in one line, to find your .nupkg select 'show all files' in the solution explorer
        //tab on the right, and inside of bin/Release/ you will find the nupkg, right click, copy full path

        // If all goes well, the console will say "Your package has been pushed"

        // You can view your published packages on your account on nuget.org, these will appear as unlisted for 
        //an hour or so upon creation, and then may be indexable on the website for download.
        public void print(string wordToPrint)
        {
            // Give it a method for a test
            Console.WriteLine(wordToPrint);
        }
    }
}
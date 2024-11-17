using RemoveLongUnusedNugetPackages;

// Load language
var langs = Language.Get();
Console.Title = langs[0];

// Get path
var path = Environment.GetEnvironmentVariable("userprofile") + "/.nuget/packages";
// string path;
// if (OperatingSystem.IsWindows()) path = Environment.GetEnvironmentVariable("userprofile") + "/.nuget/packages";
// else if (OperatingSystem.IsLinux()) path = null;
// else if (OperatingSystem.IsMacOS()) path = null;
Console.WriteLine(langs[1]);

// Get a time from 3 months ago
var time = DateTime.Now.AddMonths(-3);

// Remove start
var dir_list = new DirectoryInfo(path).GetDirectories();
foreach (var dir in dir_list)
{
    if (dir.LastWriteTime < time) dir.Delete(true);
}

Console.WriteLine(langs[2]);
Console.ReadLine();
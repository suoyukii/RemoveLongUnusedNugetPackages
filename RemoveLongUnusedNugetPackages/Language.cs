using System.Globalization;

namespace RemoveLongUnusedNugetPackages;

public static class Language
{
    public static string[] Get()
    {
        return CultureInfo.CurrentUICulture.Name switch
        {
            "zh-CN" =>
            [
                "清除长期未使用的 Nuget 包",
                "清除中...",
                "清除结束，这个窗口可以关闭了"
            ],
            _ =>
            [
                "Remove Long Unused Nuget Packages",
                "Removing...",
                "Remove is complete, the window can be closed."
            ]
        };
    }
}
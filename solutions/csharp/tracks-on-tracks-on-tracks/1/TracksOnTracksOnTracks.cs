public static class Languages
{
    public static List<string> NewList()
    => [];

    public static List<string> GetExistingLanguages()
    => new() { "C#", "Clojure", "Elm" };

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    => languages.Count;

    public static bool HasLanguage(List<string> languages, string language)
    => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    =>CountLanguages(languages) > 0 && (languages[0] == "C#" || (languages[1] == "C#" && CountLanguages(languages) > 1 && CountLanguages(languages) <= 3));

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    => languages.GroupBy(x => x).Max(x => x.Count()) == 1;
}

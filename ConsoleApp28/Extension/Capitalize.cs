namespace ConsoleApp28.Extension
{
    static class Capitalize
    {
        public static string Capitalize(this string name)
        {
            return String.Concat(name.Substring(0,1).ToUpper(),name.Substring(1).ToLower());
        }
    }
}

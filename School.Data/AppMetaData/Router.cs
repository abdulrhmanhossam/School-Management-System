namespace School.Data.AppMetaData;

public static class Router
{
    public const string root = "Api";
    public const string version = "V1";
    public const string Rule = $"{root}/{version}";
    public const string SingleRoute = "/{id}";


    public static class StudentRouting
    {
        public const string Prefix = $"{Rule}/Student";
        public const string List = $"{Prefix}/List";
        public const string GetById = $"{Prefix}{SingleRoute}";
        public const string Create = $"{Prefix}/Create";
    }
}

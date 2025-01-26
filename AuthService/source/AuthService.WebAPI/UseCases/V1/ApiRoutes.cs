namespace AuthService.WebAPI.UseCases.V1
{
    public class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "1";

        public const string Base = Root + "/" + Version;
        public static class Auth
        {
            public const string Register = Base + "/auth/register";
            public const string Login = Base + "/auth/login";
        }
    }
}

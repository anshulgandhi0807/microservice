namespace AttachmentService.WebAPI.UseCases.V1
{
    public class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "1";

        public const string Base = Root + "/" + Version;
        public static class Attachment
        {
            public const string Upload = Base + "/attachment/upload";
            public const string List = Base + "/attachment/list";
            public const string Download = Base + "/attachment/download";
            public const string Delete = Base + "/attachment/delete";
        }
    }
}

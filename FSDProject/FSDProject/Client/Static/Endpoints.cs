namespace FSDProject.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string JobsEndpoint = $"{Prefix}/jobs";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string CompanyEndpoint = $"{Prefix}/companys";
    }
}

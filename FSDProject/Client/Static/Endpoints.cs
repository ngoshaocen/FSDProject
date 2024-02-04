using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDProject.Client.Static


{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string ConsultationSessionsEndpoint = $"{Prefix}/consultationSessions";
        public static readonly string ConsultantsEndpoint = $"{Prefix}/consultants";
        public static readonly string JobSeekersEndpoint = $"{Prefix}/jobSeekers";


    }
}

using System;
namespace Testik.Services
{
	public static class Constants
	{
		
        // URL of REST service (Android does not use localhost)
        // Use http cleartext for local deployment. Change to https for production
        public static string LocalhostUrl = "91.210.169.67/";
        public static string Scheme = "http"; // or http
        
        public static string RestUrl = $"{Scheme}://{LocalhostUrl}/";
    }
}


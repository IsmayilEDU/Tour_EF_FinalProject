using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfigurations
{
    public static class MyConfigurations
    {
        #region Static constructor
        static MyConfigurations()
        {
            Configuration = GetConfiguration();
            ConnectionString = Configuration["ConnectionString"];
            UsernameOfAdmin = Configuration["Admin:Username"];
            PasswordOfAdmin = Configuration["Admin:Password"];
        }
        #endregion

        #region Fields
        private static IConfiguration Configuration { get; set; }
        public static string ConnectionString { get; set; }
        public static string UsernameOfAdmin { get; set; }
        public static string PasswordOfAdmin { get; set; }


        #endregion

        #region Methods
        private static IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        }
        #endregion
    }
}

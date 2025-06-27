using System.Configuration;
using SuperFlightsApp.Repository;
using SuperFlightsApp.Services;
using SuperFlightsApp.TopForms;

namespace SuperFlightsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            IRepoFlights repoFlights = new RepoFlights(connectionString);
            IRepoUsers repoUsers = new RepoUsers(connectionString);
            IRepoTickets repoTickets = new RepoTickets(connectionString);

            Service service = new Service(repoUsers, repoFlights, repoTickets);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(service));
        }
    }
}
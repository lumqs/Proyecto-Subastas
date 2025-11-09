using SubastasForms.Controller;
using SubastasForms.Models.Entidades;
using SubastasForms.Views;

namespace SubastasForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SubastadorController controller = new SubastadorController();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ArticuloView(controller) );
            //Application.Run(new GrillaPrueba());
        }
    }
}
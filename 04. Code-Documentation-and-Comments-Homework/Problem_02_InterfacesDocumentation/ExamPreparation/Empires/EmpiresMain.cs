using Empires.Core;
using Empires.Factories;
using Empires.IO;

namespace Empires
{
    /// <summary>
    /// Entry point of the application.
    /// </summary>
    class EmpiresMain
    {
        static void Main(string[] args)
        {
            var buildingFactory=new BuildingFactory();
            var unitFactory=new UnitFactory();
            var resourceFactory=new ResourceFactory();
            var database=new EmpireDatabase();
            var reader = new InputReader();
            var writter=new OutputWritter();

            Engine engine=new Engine(buildingFactory,unitFactory,resourceFactory,database,reader,writter);
            engine.Run();
        }
    }
}

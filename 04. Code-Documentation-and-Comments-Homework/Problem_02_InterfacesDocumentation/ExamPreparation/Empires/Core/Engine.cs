using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.IO;
using Empires.Models;

namespace Empires.Core
{
    /// <summary>
    /// Class for containing the internal logic of the application. 
    /// </summary>
    public class Engine : IRunnable
    {
        private readonly IBuildingFactory buildingFactory;
        private readonly IUnitFactory unitFactory;
        private readonly IResourceFactory resourceFactory;
        private readonly EmpireDatabase database;
        private readonly IInputReader reader;
        private readonly IOutputWritter writter;


        public Engine(IBuildingFactory buildingFactory, IUnitFactory unitFactory, IResourceFactory resourceFactory,EmpireDatabase database, 
            IInputReader reader, IOutputWritter writter)
        {
            this.buildingFactory = buildingFactory;
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
            this.database = database;
            this.reader = reader;
            this.writter = writter;
        }

        /// <summary>
        /// Initial start of the application, reading from the current Environment and passing the information to the other methods.
        /// </summary>
        public void Run()
        {
            while (true)
            {
                string[] inputParams = this.reader.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                ExecuteCommand(inputParams);
            }
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
           
            switch (inputParams[0])
            {
                case "build":
                    this.BuildBuilding(inputParams[1]);
                    break;
                case "empire-status":
                    this.EmpireStatus();
                    
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case"skip":
                    break;
                default:
                    throw new ArgumentException("Invalid command entered");
            }

            foreach (var building in this.database.Buildings)
            {
                building.Update();
                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.database.AddUnit(unit);
                }
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.database.Resources[resource.Type] += resource.Quantity;
                }
            }
        }

        private void BuildBuilding(string buildingType)
        {
           switch(buildingType)
           {
               case"archery":
                   this.database.AddBuilding(new Archery());
                   break;
               case"barracks":
                   this.database.AddBuilding(new Barracks());
                   break;
               default :
                   throw new ArgumentException("Invalid building creation");
           }
        }

        private void EmpireStatus()
        {
            StringBuilder output=new StringBuilder();

            output.AppendLine("Treasury:");
            foreach (var resource in this.database.Resources)
            {
                output.AppendFormat("--{0}: {1}\n", resource.Key, resource.Value);
            }
            output.AppendLine("Buildings:");
            foreach (var building in this.database.Buildings)
            {
                output.AppendLine(building.ToString());
            }
            output.AppendLine("Units:");
            if (this.database.Units.Count == 0)
            {
                output.AppendLine("N/A");
            }
            else
            {
                foreach (var unit in this.database.Units)
                {
                    output.AppendFormat("--{0}: {1}\n", unit.Key, unit.Value);
                }
            }
            
            this.writter.WriteLine(output.ToString().Trim());
        }
    }
}

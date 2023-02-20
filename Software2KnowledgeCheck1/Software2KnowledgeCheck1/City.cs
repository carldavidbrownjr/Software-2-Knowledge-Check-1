using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Using SOLID principles, refactor the City class to follow best practices.
// The City class should only have properties.
// You will need to make a new class to contain the logic dealing with construction.
//
namespace Software2KnowledgeCheck1
{
    internal class City
    {
        private int ZipCode { get; set; }
        private string Name { get; set; }
        private string State { get; set; }
        private int Population { get; set; }

        private List<Building> Buildings { get; } = new List<Building>();
        public City()
        {
            Random rnd = new Random();
            int numberOfBuildings = rnd.Next(1, 500);
            Console.WriteLine("City");
            for(int i = 0; i< numberOfBuildings; i++)
            {
               
                int NumberOfUnits = rnd.Next(1, 100);
                int NumberOfLeasedUnits = rnd.Next(1, NumberOfUnits);
                int NumberOfOpenUnits = NumberOfUnits - NumberOfLeasedUnits;
                int hasParkingInt = rnd.Next(1, 10) - 1;
                bool HasParking = Convert.ToBoolean(hasParkingInt);
                CreateApartment(new Apartment(NumberOfUnits, NumberOfOpenUnits, HasParking));

            }
        }
        public void CreateApartment(Apartment apartment)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                Console.WriteLine("Successful Construction!");
                Buildings.Add(apartment);
            }
        }

        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

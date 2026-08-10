using _090826_ovelse;
//Opretter nye dyr:
Animal animalAmphibian01 = new Animal("Amphibian 01: Toad 'Todd'", "Amphibian", 4, "Carnivore");
Animal animalBird01 = new Animal("Bird 01: Falcon 'Frej'", "Bird", 4, "Carnivore");
Animal animalBird02 = new Animal("Bird 02: ShoeBill 'Billie'", "Bird", 3, "Carnivore");
Animal animalFish01 = new Animal("Fish 01: Clownfish 'Nemo'", "Fish", 5, "Omnivore");
Animal animalInsect01 = new Animal("Insect 01: Ladybug 'Buzz'", "Insect", 5, "Herbivore");
Animal animalMammal01 = new Animal("Mammal 01: Cheetah 'Simba'", "Mammal", 1, "Carnivore");
Animal animalMammal02 = new Animal("Mammal 02: Elephant 'Dumbo'", "Mammal", 2, "Herbivore"); 
Animal animalMammal03 = new Animal("Mammal 03: Bear 'Bruno'", "Mammal", 1, "Omnivore");
Animal animalReptile01 = new Animal("Reptile 01: Snake 'Kaa'", "Reptile", 3, "Carnivore");
Animal animalReptile02 = new Animal("Reptile 02: Snake 'Spike'", "Reptile", 3, "Herbivore");

//Opretter en animalList, så jeg bagefter kan tilføje dyrene:
List<Animal> animalList = new List<Animal>();
animalList.Add(animalAmphibian01);
animalList.Add(animalBird01);
animalList.Add(animalBird02);
animalList.Add(animalFish01);
animalList.Add(animalInsect01);
animalList.Add(animalMammal01);
animalList.Add(animalMammal02);
animalList.Add(animalMammal03);
animalList.Add(animalReptile01);
animalList.Add(animalReptile02);

Console.WriteLine("Welcome to the Zoo");
Console.WriteLine($"Number of animals in our zoo: {animalList.Count}");
Console.WriteLine(" ");
Console.WriteLine("The animals ID is mentioned with their respective names:");

for (int i = 0; i < animalList.Count; i++)
{
    Console.WriteLine($"- {animalList[i].NameAnimal}");
}

Building building1 = new Building("Toilet building one", 1, "Toilet facilities for both men, women and handicapped", "Silkeborg", "Toilet", 5, 20);
Building building2 = new Building("Restaurant building one", 2, "Restaurant for families", "Viborg", "Restaurant", 15, 100);
Building building3 = new Building("Restaurant building two", 3, "Restaurant for business people", "Herning", "Restaurant", 10, 70);
Building building4 = new Building("Restaurant building three", 4, "Restaurant for schools", "Aarhus C", "Restaurant", 30, 210);

List<Building> buildingList = new List<Building>();
buildingList.Add(building1);
buildingList.Add(building2);
buildingList.Add(building3);
buildingList.Add(building4);

Employee employee1 = new Employee("Ellen", "Hansson", "Cleaning", 2015);
Employee employee2 = new Employee("Hans", "Ehmsen", "Janitor", 2005);
Employee employee3 = new Employee("Janice", "Brown", "Cook", 2025);
Employee employee4 = new Employee("Veronica", "Bronson", "Cook", 2026);
Employee employee5 = new Employee("Anna", "Carlsson", "Waitress", 2018);
List<Employee> employeeList = new List<Employee>();
employeeList.Add(employee1);
employeeList.Add(employee2);
employeeList.Add(employee3);
employeeList.Add(employee4);
employeeList.Add(employee5);

Habitat habitat1 = new Habitat("Cage1", "Max Safety", 1, 20, 1, 5);
Habitat habitat2 = new Habitat("Cage2", "Middle Safety", 5, 50, 1, 5);
Habitat habitat3 = new Habitat("Cage3", "Low Safety", 10, 5, 1, 2);
Habitat habitat4 = new Habitat("Enclosure1", "Low Safety", 9, 3, 2, 4);
Habitat habitat5 = new Habitat("Enclosure2", "Middle Safety", 6, 10, 2, 5);
Habitat habitat6 = new Habitat("Enclosure3", "High Safety", 2, 50, 1, 5);
Habitat habitat7 = new Habitat("Fishtank1", "Middle Safety", 6, 100, 2, 10);
Habitat habitat8 = new Habitat("Fishtank2", "High Safety", 6, 60, 3, 5);











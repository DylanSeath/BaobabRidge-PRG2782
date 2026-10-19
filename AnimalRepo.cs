using System;
using System.Collections.Generic;
using System.Text;

namespace BaobaRidge
{
    public class AnimalRepo
    {
        private readonly string filepath = "animals.txt";
        public bool UniqueID(string animalId)
        {
            if (!File.Exists(filepath)) return true;

            try
            {

               
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                   
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    string[] parts = line.Split('|');

                   
                    string existingId = parts[0].Trim();

                    
                    if (existingId.Equals(animalId, StringComparison.OrdinalIgnoreCase))
                    {
                        return false; 
                    }
                }
            }
            catch (Exception)
            {
                
            }
            return true;
        }

       
        public void AddAnimalRecord(string animalDataLine)
        {
            try
            {
                
                File.AppendAllLines(filepath, new[] { animalDataLine }, Encoding.UTF8);
            }
            catch (IOException ex)
            {
                throw new IOException("This file is already being used by another program. Please try again.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException("Permission denied. Check file attributes.", ex);
            }
        }


        public bool UpdateAnimal(Animal updatedAnimal)
        {
            string path = "animals.txt";

            // get the animals that are already saved
            int skippedCount;
            List<Animal> animals = FileHandler.LoadAnimals(out skippedCount);

            // dont overwrite the file if some records could not be loaded
            if (skippedCount > 0)
            {
                throw new IOException("Some animal records could not be loaded.");
            }

            bool animalFound = false;

            // go through the list to find the animal
            foreach (Animal animal in animals)
            {
                if (animal.Id == updatedAnimal.Id)
                {
                    // change the old information to the new information
                    animal.Name = updatedAnimal.Name;
                    animal.Species = updatedAnimal.Species;
                    animal.Age = updatedAnimal.Age;
                    animal.Score = updatedAnimal.Score;
                    animal.Status = updatedAnimal.Status;
                    animal.HousingUnit = updatedAnimal.HousingUnit;

                    animalFound = true;
                    break;
                }
            }

            // only save if the animal was found
            if (animalFound)
            {
                List<string> lines = new List<string>();

                // change the animal objects back into text
                foreach (Animal animal in animals)
                {
                    lines.Add(animal.ToFileLine());
                }

                // save the updated information into the file
                File.WriteAllLines(path, lines);
            }

            return animalFound;
        }


        public bool DeleteAnimal(string animalId)
        {

         string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"animals.txt"); 

            // get all the animals saved in the file
            int skippedCount;
            List<Animal> animals = FileHandler.LoadAnimals(out skippedCount);

            // dont delete anything if some records could not be loaded
            if (skippedCount > 0)
            {
                throw new IOException("Some animal records could not be loaded.");
            }

            bool animalFound = false;

            // go through the animals to find the matching ID
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].Id == animalId)
                {
                    // remove the animal from the list
                    animals.RemoveAt(i);
                    animalFound = true;
                    break;
                }
            }

            // only save the file if the animal was found
            if (animalFound)
            {
                List<string> lines = new List<string>();

                // change the remaining animals back into text
                foreach (Animal animal in animals)
                {
                    lines.Add(animal.ToFileLine());
                }

                File.WriteAllLines(path, lines);
            }

            return animalFound;
        }



    }
}

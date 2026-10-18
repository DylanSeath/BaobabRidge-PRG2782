using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BaobaRidge
{
    public static class FileHandler
    {
        // loads animals from txt file and give back list
        //reports ksipped lines through var 'SkippedCount'
        public static List<Animal> LoadAnimals(out int skippedCount)
        {
            var animals = new List<Animal>(); //empty list
            skippedCount = 0;

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");

            try
            {
                if (!File.Exists(path)) File.WriteAllText(path, "");  //so that if a file doesn't ecist, create new one

                foreach (string line in File.ReadAllLines(path))  //loop over every line
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;  //no blank lines, blnk lines are skipped and aren't counted

                    if (Animal.TryParse(line, out Animal? animal) && animal != null) animals.Add(animal);
                    else skippedCount++;
                }
            }
            catch (UnauthorizedAccessException)
            {

                throw;
            }
            catch (IOException)
            {

                throw;
            }

            return animals;


        }


        // Updates an existing animal in animals.txt
        public static bool UpdateAnimal(Animal updatedAnimal)
        {
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "animals.txt"
            );

            if (!File.Exists(path))
                return false;

            var lines = new List<string>(File.ReadAllLines(path));

            for (int i = 0; i < lines.Count; i++)
            {
                if (Animal.TryParse(lines[i], out Animal? animal)
                    && animal != null
                    && animal.Id.Equals(
                        updatedAnimal.Id,
                        StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = updatedAnimal.ToFileLine();
                    File.WriteAllLines(path, lines);
                    return true;
                }
            }

            return false;
        }

        // Deletes an existing animal from animals.txt
        public static bool DeleteAnimal(string animalId)
        {
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "animals.txt"
            );

            if (!File.Exists(path))
                return false;

            var lines = new List<string>(File.ReadAllLines(path));

            for (int i = 0; i < lines.Count; i++)
            {
                if (Animal.TryParse(lines[i], out Animal? animal)
                    && animal != null
                    && animal.Id.Equals(
                        animalId,
                        StringComparison.OrdinalIgnoreCase))
                {
                    lines.RemoveAt(i);
                    File.WriteAllLines(path, lines);
                    return true;
                }
            }

            return false;
        }

    }
}

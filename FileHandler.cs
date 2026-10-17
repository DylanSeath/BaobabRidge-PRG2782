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
                MessageBox.Show("Program isn't alloowed to open file");   //cannot open file
            }
            catch (IOException)
            {
                MessageBox.Show("File may be open in another program");  //eaither file is open or used somewhere else
            }

            return animals;


        }
    }
}

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

    }
}

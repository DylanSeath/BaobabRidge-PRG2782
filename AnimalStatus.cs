using System;
using System.Collections.Generic;
using System.Text;

namespace BaobaRidge
{
    public static class AnimalStatus
    {
        public static (string Status, string HousingUnit) GetClassification(int recoveryScore)
        {
            switch (recoveryScore)
            {
                case  >= 0 and <= 19:
                    return ("Critical", "Intensive Care Unit");

                case  >= 20 and  <= 39:
                    return ("Serious", "High-Dependency Ward");

                case  >= 40 and <= 59:
                    return ("Stable", "Recovery Ward");

                case  >= 60 and <= 79:
                    return ("Recovering", "Outdoor Enclosure");

                case  >= 80 and <= 100:
                    return ("Release-Ready", "Pre-Release Camp");

                default:
                    throw new ArgumentOutOfRangeException(nameof(recoveryScore), "Recovery score is invalid. Please enter a number between 0 and 100.");
            }
        }

    }
}

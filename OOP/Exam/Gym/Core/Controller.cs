using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipment;
        private ICollection<IGym> gyms;

        public Controller()
        {
            equipment = new EquipmentRepository();
            gyms = new List<IGym>();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete athlete;
            var gym = gyms.FirstOrDefault(g => g.Name == gymName);

            if (athleteType == "Boxer")
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);
                if (gyms.FirstOrDefault(g => g.Name == gymName).GetType().Name == "BoxingGym")
                {
                    gym.AddAthlete(athlete);
                }
                else
                {
                    return OutputMessages.InappropriateGym;
                }
            }
            else if (athleteType == "Weightlifter")
            {
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                athlete = new Boxer(athleteName, motivation, numberOfMedals);
                if (gyms.FirstOrDefault(g => g.Name == gymName).GetType().Name == "WeightliftingGym")
                {
                    gym.AddAthlete(athlete);
                }
                else
                {
                    return OutputMessages.InappropriateGym;
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAthleteType);
            }

            return $"Successfully added {athleteType} to {gymName}.";
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment currentEquipment;
            if (equipmentType == "BoxingGloves")
            {
                currentEquipment = new BoxingGloves();
            }
            else if (equipmentType == "Kettlebell")
            {
                currentEquipment = new Kettlebell();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }

            equipment.Add(currentEquipment);
            return $"Successfully added {equipmentType}.";
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym;
            if (gymType == "BoxingGym")
            {
                gym = new BoxingGym(gymName);
            }
            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }

            gyms.Add(gym);
            return $"Successfully added {gymType}.";
        }

        public string EquipmentWeight(string gymName)
        {
            var gym = gyms.FirstOrDefault(g => g.Name == gymName);

            return string.Format(OutputMessages.EquipmentTotalWeight, gym.Name, gym.EquipmentWeight);
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            var currEquipment = equipment.Models.FirstOrDefault(e => e.GetType().Name.ToString() == equipmentType);
            if (currEquipment == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentEquipment, equipmentType));
            }
            var gym = gyms.FirstOrDefault(g => g.Name == gymName);
            gym.AddEquipment(currEquipment);
            equipment.Remove(currEquipment);
            return $"Successfully added {equipmentType} to {gymName}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var gym in gyms)
            {
                sb.AppendLine(gym.GymInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string TrainAthletes(string gymName)
        {
            var gym = gyms.FirstOrDefault(g => g.Name == gymName);
            foreach (var athlete in gym.Athletes)
            {
                athlete.Exercise();
            }

            return $"Exercise athletes: {gym.Athletes.Count}.";
        }
    }
}

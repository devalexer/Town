using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class House
    {
        // member variables
        public string Name { get; set; }
        public string BuildingType { get; set; }
        public int NumberOfRoom { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int Floors { get; set; }
        public int BathRooms { get; set; }
        public int CurrentOccupants { get; set; }
        private double AmountOfMoney { get; set; }
        public string FullAddress { get; set; }
        private string Address1 { get; set; }
        private string Address2 { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string Zip { get; set; }
        private double Deposit { get; set; }
        private double Withdrawal { get; set; }
        public double NumberOfFloors { get; set; }


        public string DisplayName()
        {
            return this.Name;
        }

        public override string ToString()
        {
            return $"{BuildingType} : {Name}";
        }


        public double SquareFootage
        {
            get
            {
                return Length * Width * this.NumberOfFloors;
            }
        }


        public double Volume
        {
            get
            {
                return Length * Width * Height;
            }
        }

        public string FullAddress
        {
            get
            {
                return $"{Address1}, {Address2}, {City}, {State}, {Zip}";
            }
        }

        public int IncreaseOcupants()
        {
            CurrentOccupants++;
            return CurrentOccupants;
        }

        public int DecreaseOcupants()
        {
            CurrentOccupants--;
            return CurrentOccupants;
        }

        public List<Person> Occupants { get; set; } = new List<Person>();

        //If you wanted to create method to accomplish above line instead:
        //public void AddPersonToBuilding(Person peep)
        //{
        //this.Occupants.Add(peep)
        //}

        //public void RemovePersonFromBuilding(Person peep)
        //{
        //    this.Occupans.Remove(peep);
        //}
    }
}


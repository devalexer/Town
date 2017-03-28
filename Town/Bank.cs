using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class Bank
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
        public string _fullAddress { get; set; }
        public int CurrentOccupants { get; set; }
        private double AmountOfMoney { get; set; }
        private string Address1 { get; set; }
        private string Address2 { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string Zip { get; set; }
        private double Deposit { get; set; }
        private double Withdrawal { get; set; }


        public string DisplayName()
        {
            return this.Name;
        }

        public override string ToString()
        {
            return $"{BuildingType} : {Name}";
        }


        private double _squareFootage; 

        public double SquareFootage
        {
            get
            {
                _squareFootage = Length * Width;
                return _squareFootage;
            }
        }

        private double _volume;

        public double Volume
        {
            get
            {
                _volume = Length * Width * Height;
                return _volume;
            }
        }

        public string FullAddress
        {
            get
            {
                _fullAddress = $"{Address1}, {Address2}, {City}, {State}, {Zip}";
                return _fullAddress;
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

        public double DepositMoney(double Amount)
        {
            AmountOfMoney += Amount;
            return AmountOfMoney;
        }

        public double WithdrawMoney(double Amount)
        {
            AmountOfMoney -= Amount;
            return AmountOfMoney;
        }

        public Bank(string amountofMoney)
        {

        }
    }
}


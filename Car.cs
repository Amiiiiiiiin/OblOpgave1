using System;

namespace OblOpgave1
{
    public class Car
    {
        private int _id;
        private string _model;
        private int _price;
        private string _licensePlate;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Model
        {
            get => _model;
            set
            {
                if (value.Length >= 4)
                {
                    _model = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        } 

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value.Length >=2 && value.Length <= 7)
                {
                    _licensePlate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        //Denne ToString er bare her bare for at gøre det muligt at oprette unit test
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

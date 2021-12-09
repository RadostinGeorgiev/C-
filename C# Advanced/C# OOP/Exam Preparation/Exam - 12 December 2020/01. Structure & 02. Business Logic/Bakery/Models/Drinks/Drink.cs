﻿namespace Bakery.Models.Drinks
{
    using System;
    using Contracts;
    using static Utilities.Messages.ExceptionMessages;

    public abstract class Drink : IDrink
    {
        private string name;
        private int portion;
        private decimal price;
        private string brand;

        protected Drink(string name, int portion, decimal price, string brand)
        {
            Name = name;
            Portion = portion;
            Price = price;
            Brand = brand;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidName);
                }

                this.name = value;
            }
        }

        public int Portion
        {
            get => this.portion;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidPortion);
                }
                
                this.portion = value;
            }
        }

        public decimal Price
        {
            get => this.price;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidPrice);
                }

                this.price = value;
            }
        }

        public string Brand
        {
            get => this.brand;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidBrand);
                }

                this.brand = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Brand} - {Portion}ml - {Price:f2}lv";
        }
    }
}
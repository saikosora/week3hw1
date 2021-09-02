using System;
using System.Collections.Generic;

namespace week_3_hw
{
    class Program
    {
        static void Main(string[] args)
        {

            User jame = new User("Jame", "jame@gmail.com");

            Tshirt tshirtorder1 = new Tshirt("L ", "Red ","kod ", 500.0f);
            Tshirt tshirtorder2 = new Tshirt("M ", "Black ", "yag ", 750.0f);
            Tshirt tshirtorder3 = new Tshirt("S ", "White ", "ley ", 625.0f);

            Address addressjame = new Address("131/75 phutthamonthon ", "nakornpathom ", "10180");

            ShoppingCart jameCart = new ShoppingCart();

            jameCart.addshirt(tshirtorder1);
            jameCart.addshirt(tshirtorder2);
            jameCart.addshirt(tshirtorder3);
            jameCart.addlocal(addressjame);

            jame.showname(jame);
            jameCart.ShowAddress();
            jameCart.ShowOrder();
            jameCart.TotalCost();

        }
    }

    class Tshirt
    {
        public string size;
        public string color;
        public string image;
        public float cost;

        public Tshirt(string valueSize, string valueColor, string valueImage, float valueCost)
        {
            size = valueSize;
            color = valueColor;
            image = valueImage;
            cost = valueCost;
        }
    }

    class User
    {
        public string name;
        public string email;

        public User(string valueName, string valueEmail)
        {
            name = valueName;
            email = valueEmail;
            
        }

        public void showname(User name)
        {
            Console.WriteLine(name.name);
            Console.WriteLine(name.email);
        }
        
    }

    class Address
    {
        public string street;
        public string city;
        public string zipcode;

        public Address(string valueStreet, string valueCity, string valueZipcode)
        {
            street = valueStreet;
            city = valueCity;
            zipcode = valueZipcode;
        }
    }

    class ShoppingCart
    {
        public List<Tshirt> tshirts;
        public List<Address> addressorder;
        public ShoppingCart()
        {
            tshirts = new List<Tshirt>();
            addressorder = new List<Address>();
        }

        public void addshirt(Tshirt shirt)
        {
            tshirts.Add(shirt);
        }

        public void addlocal(Address local)
        {
            addressorder.Add(local);
        }

        public void ShowOrder()
        {
            foreach (Tshirt jamebuy in tshirts)
            {
                Console.Write(jamebuy.size);
                Console.Write(jamebuy.color);
                Console.Write(jamebuy.image);
                Console.WriteLine(jamebuy.cost);
            }
        }

        public void ShowAddress()
        {
            foreach (Address jamehome in addressorder)
            {
                Console.Write(jamehome.street);
                Console.Write(jamehome.city);
                Console.WriteLine(jamehome.zipcode);
            }
        }

        public void TotalCost()
        {
            float TotalCost = 0.0f;

            foreach (Tshirt ordercost in tshirts)
            {
                TotalCost += ordercost.cost;
            }
            Console.WriteLine(TotalCost);
        }
    }
}

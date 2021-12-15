using System;

namespace AdapterExample
{
    interface ITerrestrialTransport
    {
        void Drive();
    }
    // Машина може їздити тільки по дорогах
    class Car : ITerrestrialTransport
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving down the road");
        }
    }

    interface IOtherTransport
    {
        void Move();
    }

    // Корабель плаває морями та океанами
    class Ship : IOtherTransport
    {
        public void Move()
        {
            Console.WriteLine("Ship is sailing across the sea");
        }
    }

    class Traveler
    {
        public void Travel(ITerrestrialTransport tr)
        {
            tr.Drive();
        }
    }

    // Доїхавши до моря мандрівнику потрібно пересісти на корабель:
    class Transfer : ITerrestrialTransport
    {
        Ship ship;

        public Transfer(Ship sh)
        {
            ship = sh;
        }

        public void Drive()
        {
            ship.Move();
        }
    }


    public class AdapterDemo
    {
        static void Main()
        {
            // мандрівник
            Traveler traveler = new Traveler();

            // машина
            Car car = new Car();

            // мандрівник починає поїздку
            traveler.Travel(car);

            // корабель
            Ship ship = new Ship();

            // доїхав до моря, потрібно пересісти на корабель
            ITerrestrialTransport shipVoyage = new Transfer(ship);

            // пливе далі по морю
            traveler.Travel(shipVoyage);

            Console.Read();
        }
    }
}
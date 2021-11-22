using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{

    class MainApp
    {
        public static void Main()
        {
            SmartPhone VasyaPhone = new SmartPhone();
            User Vasya = new User(VasyaPhone);
            Console.WriteLine("Vasya starts using his smartphone...");
            Vasya.UseSmartPhone();
            Console.Read();
        }
    }

    class Phone
    {
        public void CallContact()
        {
            Console.WriteLine("Calling contact");
        }
        public void SendMessage()
        {
            Console.WriteLine("Sending message");
        }
    }

    class Camera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking photo");
        }
        public void FilmVideo()
        {
            Console.WriteLine("Filming video");
        }
    }

    class Browser
    {
        public void GoogleInformation()
        {
            Console.WriteLine("Googling information");
        }
    }
    class Navigator
    {
        public void NavigateWay()
        {
            Console.WriteLine("Mavigating some way");
        }
    }

    class SmartPhone
    {
        Phone phone;
        Camera camera;
        Browser browser;
        Navigator navigator;

        public SmartPhone()
        {
            phone = new Phone();
            camera = new Camera();
            browser = new Browser();
            navigator = new Navigator();
        }

        public void UseSmartPhoneOffline()
        {
            Console.WriteLine("\nWhat smartphone does without internet connection:");
            phone.CallContact();
            phone.SendMessage();
            camera.FilmVideo();
            camera.TakePhoto();
        }

        public void UseSmartPhoneOnline()
        {
            Console.WriteLine("\nWhat smartphone does with internet connection:");
            browser.GoogleInformation();
            navigator.NavigateWay();
        }
    }

    class User
    {
        SmartPhone ownphone;

        public User(SmartPhone phone)
        {
            ownphone = phone;
        }
        public void UseSmartPhone()
        {
            ownphone.UseSmartPhoneOnline();
            ownphone.UseSmartPhoneOffline();
        }
    }
}

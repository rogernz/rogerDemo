using System;
namespace RogerTest
{
    public class AbstractFactory
    {
            
    }
    //IAbstractProductA
    public interface ISmartPhone
    {
        string getName();
    }
    //IAbstractProductB
    public interface INormalPhone
    {
        string getName();
    }
    //concorate product
    public class iphone4 : ISmartPhone
    {
        public string getName() {
            return "iphone4";
        }
    }
   
    public class Nokia9 : ISmartPhone
    {
        public string getName()
        {
            return "Nokia9";
        }
    }

    public class iphone3gs : INormalPhone
    {
        public string getName()
        {
            return "iphone3gs";
        }
    }

    public class Nokia8210 : INormalPhone
    {
        public string getName()
        {
            return "Nokia8210";
        }
    }
    //IAbstractFactory
    interface ICreatePhone
    {
          ISmartPhone getSmartPhone();
          INormalPhone getNormalPhone();
    }

    //concorate Factory

     class createIphone : ICreatePhone
    {
        public ISmartPhone getSmartPhone()
        {
            return new iphone4();
        }
        public INormalPhone getNormalPhone()
        {
            return new iphone3gs();
        }
    }

    class createNokia : ICreatePhone
    {
        public ISmartPhone getSmartPhone()
        {
            return new Nokia9();
        }
        public INormalPhone getNormalPhone()
        {
            return new Nokia8210();
        }
    }

    //client
    enum brand {
        Iphone,
        Nokia
    }
    class createIphoneByClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalphone;
        ICreatePhone createPhone;
        brand bd;
        public createIphoneByClient(brand br)
        {

            bd = br; 
        }

        public void generatePhone() {

            switch (bd)
            {
                case brand.Iphone:
                    createPhone = new createIphone();
                    break;
                case brand.Nokia:
                    createPhone = new createNokia();
                    break;
            }

            Console.WriteLine("This brand's normal phone is " + createPhone.getNormalPhone().getName() + " and this brand's smart phone is " + createPhone.getSmartPhone().getName());
        }
    }



}

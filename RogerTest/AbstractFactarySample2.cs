using System;
namespace RogerTest
{
    public class AbstractFactarySample2
    {
        public AbstractFactarySample2()
        {
        }
    }
    //abstract product

    interface IsizeSixEgg
    {
        string showMyName();
    }

    interface IsizeEightEgg
    {
        string showMyName();
    }
    //concrate product
    class size6EggMengNiu:IsizeSixEgg {
        public string showMyName() {
            return "I am a size 6 egg from MengNiu.";
        }

    }
    //concrate product
    class size8EggMengNiu : IsizeEightEgg
    {
        public string showMyName()
        {
            return "I am a size 8 egg from MengNiu.";
        }

    }
    //concrate product
    class size8EggYiLi : IsizeEightEgg
    {
        public string showMyName()
        {
            return "I am a size 8 egg from YiLi.";
        }

    }

    class size6EggYiLi : IsizeSixEgg
    {
        public string showMyName()
        {
            return "I am a size 6 egg from YiLi.";
        }

    }

   
    //abstract factory
    interface IeggFactory
    {
        IsizeSixEgg createSize6Egg();
        IsizeEightEgg createSize8Egg();
    }
    //concrate factory
    class MengNiuFactory : IeggFactory
    {
        public IsizeSixEgg createSize6Egg() {
            return new size6EggMengNiu();
        }
        public IsizeEightEgg createSize8Egg()
        {
            return new size8EggMengNiu();
        }
    }
    class YiLiFactory : IeggFactory
    {
        public IsizeSixEgg createSize6Egg()
        {
            return new size6EggYiLi();
        }
        public IsizeEightEgg createSize8Egg()
        {
            return new size8EggYiLi();
        }
    }

    //client
    enum factoryName
    {
        MengNiu,
        YiLi
    }

    class createEggs
    {
        IeggFactory factory;
        factoryName name;
        public createEggs(factoryName fn)
        {
            name = fn;
        }

        public void generateEgg()
        {
            switch (name)
            {
                case factoryName.MengNiu:
                    factory = new MengNiuFactory();
                    break;
                case factoryName.YiLi:
                    factory = new YiLiFactory();
                    break;
            }

            Console.WriteLine(factory.createSize6Egg().showMyName());
            Console.WriteLine(factory.createSize8Egg().showMyName());
        }
    }



}

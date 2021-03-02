using System;
using System.Collections.Generic;

namespace RogerTest
{
    public class FactoryMethod
    {
        public FactoryMethod()
        {
        }
    }


    //abstract product.

    abstract class page
    {
        //public page(string pageName) {

        //   Console.WriteLine(pageName+" page created");
        //}
        public string testResult;
        public page() {
           
        }
        public virtual void generateDetail() {
            Console.WriteLine(testResult + " show parent page");
        }

    }


    //concrate product.

    class cover : page
    {
        private string pageName = "cover";
        public cover() :base() {
            testResult = "cover";
            this.generateDetail();
        }

        public override void generateDetail()
        {
            
            Console.WriteLine("stest");
            base.generateDetail();

        }

    }
    class end : page
    {
        private string pageName = "end";
        public end() : base()
        {
            testResult = pageName;
            this.generateDetail();
        }

    }

    class introduce : page
    {
        private string pageName = "introduce";
        public introduce() : base()
        {
            testResult = pageName;
            this.generateDetail();
        }
    }

    class reference : page
    {
        private string pageName = "reference";
        public reference() : base()
        {
            testResult = pageName;
            this.generateDetail();
        }

    }

    class testResult : page
    {
        private string pageName = "testResult";
        public testResult() : base()
        {
            testResult = pageName;
            this.generateDetail();
        }
    }
    //abstract factory.
    abstract class doucuments
    {
        private List<page> list = new List<page>();
        public doucuments() {

            this.generateDoc();
        }

        public List<page> pages
        {
            get { return list; }
        }

        public abstract void generateDoc();
    }



    //concrate factory.

    class Resume : doucuments {

        public override void generateDoc()
        {
            pages.Add(new cover());
            pages.Add(new introduce());
            pages.Add(new end());
        }
    }

    class report : doucuments
    {
        public override void generateDoc()
        {
            pages.Add(new cover());
            pages.Add(new testResult());
            pages.Add(new end());
        }
    }

}

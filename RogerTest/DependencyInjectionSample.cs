using System;
namespace RogerTest
{
    public class DependencyInjectionSample
    {
        public DependencyInjectionSample()
        {
        }
    }

    
    class CustomerBussinessLogic
    {
        DataAccess db;
        public CustomerBussinessLogic() {
            db = new DataAccess();
        }

        public void getInfoByID(int id)
        {
            db.getInfoByID(id);
        }
    }

    class DataAccess
    {
        public void getInfoByID(int i) {
            //do someting
        }
    }

    //if we use Ioc,we need to use factory method to get the instance of data access

    class CustomerBussinessLogicIoc
    {
        DataAccessIoc db;
        public CustomerBussinessLogicIoc()
        {
            db = factoryIoc.getObjectOfDb();
        }

        public void getInfoByID(int id)
        {
            db.getInfoByID(id);
        }
    }

    public class factoryIoc
    {
        public static DataAccessIoc getObjectOfDb()
        {
            return new DataAccessIoc();
        }
    }

    public class DataAccessIoc
    {
        public void getInfoByID(int i)
        {
            Console.WriteLine("here is getInfoByID method from DataAccessIoc");
        }
    }
    // DIP
    //Dependency Invesion priciple
    //the higher level module can't depends on low level module ,it should depend
    //on abstraction
    class CustomerBussinessLogicDIP
    {
        private IDataAccess _db;
        public CustomerBussinessLogicDIP()
        {
            _db = factoryDIP.GetObjectOfDb();
        }

        public void getInfoByID(int id)
        {
            _db.getInfoByID(id);
        }
    }

    public interface IDataAccess
    {
        public void getInfoByID(int i);
    }

    public class DataAccessDIP : IDataAccess
    {
        public void getInfoByID(int i)
        {
            Console.WriteLine("here is getInfoByID method from DataAccessDIP");
        }
    }

    public class factoryDIP
    {
        public static IDataAccess GetObjectOfDb()
        {
            return new DataAccessDIP();
        }
    }

    //DI
    //

    class CustomerBussinessLogicDI
    {
        private IDataAccessDI _db;


        public CustomerBussinessLogicDI(IDataAccessDI dataAccessDI)
        {
            _db = dataAccessDI  ;
        }

        public void getInfoByID(int id)
        {
            _db.getInfoByID(id);
        }
    }

    public class CustomerService
    {
        CustomerBussinessLogicDI _CustomerBussinessLogicDI;
        CustomerService ()
        {
            _CustomerBussinessLogicDI = new CustomerBussinessLogicDI(new DataAccessDI());

        }
        public void getInfoById(int i)
        {
            _CustomerBussinessLogicDI.getInfoByID(i);
        }

    }


    public interface IDataAccessDI
    {
        public void getInfoByID(int i);
    }

    public class DataAccessDI : IDataAccessDI
    {
        public void getInfoByID(int i)
        {
            Console.WriteLine("here is getInfoByID method from DataAccessDIP");
        }
    }

    public class factoryDI
    {
        public static IDataAccessDI GetObjectOfDb()
        {
            return new DataAccessDI();
        }
    }

}

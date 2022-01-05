using System;
using AliBaba.Daos;
using Model;

namespace AliBaba
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDao userDao = new UserDao();

            //test FindAll:
            foreach (var user in userDao.FindAll())
                Console.WriteLine(user);

            //test FindById:
            var userById = userDao.FindById(9);
            Console.WriteLine("\n" + userById);
        }
    }
}

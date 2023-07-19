using DataAccess;
using System;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = ServiceDAO.getAllServiceCus().Where(s => s.ServiceName != "Vip" && s.ServiceName != "Normal");
            foreach (var item in list)
            {
                Console.WriteLine(item.ServiceName);
            }
        }
    }
}

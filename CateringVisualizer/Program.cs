using Catering.Controllers;
using Catering.Models.PostModels;
using System;

namespace CateringVisualizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var chefController = new ChefController();
            var chef = new ChefPostModel
            {
                FullName = "Jonas Svensson",
                ChefType = "Scandinavian Chef"
            };
            chefController.CreateChef(chef);
            Console.WriteLine(chefController.GetById(3).FullName);

            var userController = new UserController();
            var user = new UserPostModel()
            {
                FullName = "Jane Doe",
                Phone = "+48059993333"
            };
            userController.CreateUser(user);
            foreach (var person in userController.GetAll())
            {
                Console.Write(person.FullName);
                Console.WriteLine(person.Phone);
            }
            Console.WriteLine();

            var orderController = new CateringOrderController();
            var order = new CateringOrderPostModel()
            {
                UserId = 1,
                ChefId = 2,
                Date = new DateTime(2021, 01, 27),
                NumberOfPeople = 35,
                Outdoors = false,
                Address = "13 Elm Street"
            };

            var newOrder = orderController.CreateCateringOrder(order);
            Console.WriteLine(newOrder.Address);
            Console.WriteLine(orderController.GetById(8).User.FullName);
        }
    }
}

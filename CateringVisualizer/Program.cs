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
                ChefId = 3,
                Date = new DateTime(2021, 03, 14),
                NumberOfPeople = 36,
                Outdoors = true,
                Address = "35 Jason Ave"
            };

            var newOrder = orderController.CreateCateringOrder(order);
            Console.WriteLine(newOrder.Id);
            Console.WriteLine(orderController.GetById(newOrder.Id).User.FullName);
        }
    }
}

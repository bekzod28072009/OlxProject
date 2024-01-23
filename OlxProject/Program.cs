


using Olx.Domain.Entities;
using Olx.Service.IServices;
using Olx.Service.Services;

IUserService service = new Userservice();

User user = new User()
{
    Id = 1,
    FirstName = "sdgfsd",
    LastName = "sdfsd",
    Email = "sdf",
    PhoneNumber = 789787654,
};


service.CreateAsync(user);


var res = service.GetAll(p => p.Id > 1);

foreach (var item in res)
{
    Console.WriteLine(item.FirstName);
}


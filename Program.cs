using CRUD.Data;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;

var user = new User
{
    Name = "Richard",
    Age = 27,
    BirthDate = DateTime.Now
};



var context = new DataContext();

//context.Add(user);
//context.SaveChanges();

var result = context.Users.AsNoTracking().ToList();

//context.Remove(x => x.Id);
//context.SaveChanges();

    
// See https://aka.ms/new-console-template for more information
using YetGenAkbankJump.OOPConsole.Enums;
using YetGenAkbankJump.OOPConsole.Entities;


var student = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "Alper",
    LastName = "Alper",
    Gender = Gender.Unknown,
    No = 1,
    CreatedOn = DateTimeOffset.Now,
    RegistrationDate = DateTimeOffset.Now.AddHours(-1),

};
 
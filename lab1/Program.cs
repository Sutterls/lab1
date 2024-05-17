using lab1;

var Manager = new Manager
{
    Name = "Главный М.Р",
    OfficeNumber = "07",
    BonusSize = 7157,
    ClientList = new string[] { "Иванов П.С", "Петров П.С", "Сидоров П.С" }
};

var SecurityGuard = new SecurityGuard
{
    Name = "Сильный О.К",
    OfficeNumber = "12Ф",
    MaterialLiability = 308.40f,
    PhoneNumber = "+74950987864"
};

var Accountant = new Accountant
{
    Name = "Грамотный Б.Р",
    OfficeNumber = "32",
    JobDescription = "раздает большие премии",
    BonusSize = 13080
};

var Director = new Director
{
    Name = "Управляющий Д.Р",
    OfficeNumber = "1к54",
    BonusSize = 100000,
    CompanyCar = "Тайота Камри"
};
var SystemAdministrator = new EmployeeWithPhone
{
    Name = "Системный С.Р",
    OfficeNumber = "807",
    PhoneNumber = "89173045567"
};
Manager manager = new Manager();
Employee employee = new Employee();

DoWork(manager);
DoWork(employee);

manager.ManageTeam();

void DoWork(IWorkable worker)  
{
    worker.Work();
}

interface IWorkable
{
    void Work();
}

interface IManageable
{
    void ManageTeam();
}

class Manager : IWorkable, IManageable
{
    public void Work()
    {
        Console.WriteLine("Manager is working.");
    }

    public void ManageTeam()
    {
        Console.WriteLine("Manager is managing the team.");
    }
}

class Employee : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Employee is working.");
    }
}
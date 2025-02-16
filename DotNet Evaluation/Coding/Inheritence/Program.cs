// MultiLevelBankingSystem Question
class CentralBank
{
    public virtual void InterestRate()
    {
        Console.WriteLine("Central Bank");
    }
}

class NationalBank : CentralBank
{
    public override void InterestRate()
    {
        Console.WriteLine("National Bank");
    }
}

class LocalBank : NationalBank
{
    public override void InterestRate()
    {
        Console.WriteLine("Local Bank");
    }
}


// SmartVehicle Question
class Vehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("Vehicle");
    }
}

class ElectricCar : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Electric Car");
    }
}

class GasCar : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Gas Car");
    }
}

class SelfDrivingCar : ElectricCar
{
    public override void Drive()
    {
        Console.WriteLine("Self-driving");
    }
}

class HybridCar : ElectricCar
{
    public override void Drive()
    {
        Console.WriteLine(" hybrid car");
    }
}


// EmployeeHierarchy Question 
class Employee
{
    public string Name { get; set; }

    public virtual void CalculateBonus()
    {
        Console.WriteLine("Employee Class");
    }
}

class Manager : Employee
{
    public override void CalculateBonus()
    {
        Console.WriteLine("Manager Related To employee");
    }
}

class Director : Employee
{
    public override void CalculateBonus()
    {
        Console.WriteLine("Director Related To employee");
    }
}


// SecureMessagingSystem



// ECommercePlatform



class Program
{
    static void Main()
    {
        // MultiLevel Banking System
        CentralBank central = new CentralBank();
        central.InterestRate();
        
        NationalBank national = new NationalBank();
        national.InterestRate();
        
        LocalBank local = new LocalBank();
        local.InterestRate();

        // Smart Vehicle System
        Vehicle vehicle = new Vehicle();
        vehicle.Drive();

        ElectricCar electric = new ElectricCar();
        electric.Drive();

        GasCar gas = new GasCar();
        gas.Drive();

        SelfDrivingCar selfDriving = new SelfDrivingCar();
        selfDriving.Drive();

        HybridCar hybrid = new HybridCar();
        hybrid.Drive();

        // Employee Hierarchy
        Employee emp = new Employee { Name = "John" };
        emp.CalculateBonus();

        Manager mgr = new Manager { Name = "Alice" };
        mgr.CalculateBonus();

        Director dir = new Director { Name = "Bob" };
        dir.CalculateBonus();

        // Secure Messaging System
        // ECommercePlatform
      
    }
}

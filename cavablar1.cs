using System;

class Program
{
    static void Main() {
        string cavab;
        Car bmw = new Car("BMW","E36","Black",2,75);
        cavab = bmw.brandAndModel();
        Console.WriteLine(cavab);
        cavab = bmw.gedilenYol(10); //Km Basina Gedilen Yol
        Console.WriteLine(cavab);
        
        Bicyrcle bmx = new Bicyrcle("BMX","Velo","Yellow",26); 
        cavab = bmx.brandAndModel();
        Console.WriteLine(cavab);
        
        
        Employee isci1 = new Employee("Davud","Haci","Programmer",30);
        cavab = isci1.montlySalary();
        Console.WriteLine(cavab);
    }
}

class Car:Vehicle
{
    string model;
    string brand;
    string color;
    int doorCount;
    int fuelCapacity;
    
    public Car(string model, string brand, string color, int doorCount, int fuelCapacity):base(brand,model,color)
    {
        this.doorCount = doorCount;
        this.fuelCapacity = fuelCapacity;
        
    }
    
   
    public string gedilenYol(int consumption){
        string cavab;
        cavab = ("Polnu Bakla Gedilen Yol: "+(consumption*fuelCapacity)+"KM");
        
        return cavab;
        
    }
    
}

class Bicyrcle:Vehicle
{
    string brand;
    string model;
    string color;
    int wheelSize;
    
    public Bicyrcle(string brand,string model,string color,int wheelSize):base(brand,model,color)
    {
        this.wheelSize = wheelSize;
        
        this.brand = brand;
        this.model = model;
        this.color = color;
        
    }
    
    
    
    
}

class Vehicle
{
    string brand;
    string model;
    string color;
    
    public Vehicle(string brand,string model,string color){
        this.brand = brand;
        this.model = model;
        this.color = color;
    }
    
    public string brandAndModel(){
        string ret = ("\nBrand: "+brand+"\nModel: "+model);
        return ret;
    }
    
}


class Employee
{
    string name;
    string surname;
    string position;
    int dailySalary;
    
    public Employee(string name,string surname,string position,int dailySalary)
    {
        this.name = name;
        this.surname = surname;
        this.position = position;
        this.dailySalary = dailySalary; 
    }
    
    public string montlySalary(){
        string cavab = "\nMontly Salary: "+(dailySalary*30);
        return cavab;
    }
   
}
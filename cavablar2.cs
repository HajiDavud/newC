using System;

class Program
{
    static void Main() {
        Student davud = new Student();
        davud.SetAge(20);
        davud.ShowAge();
    }
    
}

class Person
{
    public int age;
    public void Greet(){
        Console.WriteLine("This GREEETT");
    }
    public void SetAge(int age){
        this.age = age;
    }
    
}

class Teacher:Person{
    
    public void Explain(){
        Console.WriteLine("I am Explaining");
    }
}

class Student:Person{
    public void Study(){
        Console.WriteLine("I am Studiyng");
    }
    public void ShowAge(){
        Console.WriteLine("My age is: "+base.age+" years old");
    }
}
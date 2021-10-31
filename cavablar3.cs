using System;

class Program
{
    static void Main() {
        volumeOfBox box = new volumeOfBox(5,15,15);
        volumeOfBox2(5,5,5);
    }
    
    public static void volumeOfBox2(int with,int lenght,int height){
        Console.WriteLine(with*lenght*height);
    }
}
class volumeOfBox
{
    public volumeOfBox(int with,int lenght,int height){
        int cavab = with*lenght*height;
        Console.WriteLine(cavab);
        
    }
}
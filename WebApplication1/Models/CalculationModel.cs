namespace WebApplication1.Models

{
    public class Calculation{
        
        public int Numone{get;set;}

        public int Numtwo{get;set;}


     public Calculation(){
        Random rand = new Random();

        Numone=rand.Next(10);
        Numtwo=rand.Next(10);

    }

    public Calculation(int a, int b) 
        {
            Numone = a;
            Numtwo = b;
        }

    }


   
}
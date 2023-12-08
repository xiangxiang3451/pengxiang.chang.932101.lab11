
namespace WebApplication1.Services{

    public class Calculation{
        Random rand=new Random();

        public int getNumber(){
            return rand.Next(10);
        }
        public int add(int a,int b){

            return(a+b);

        }
        public int sub(int a,int b){
            return(a-b);

        }

        public int mult(int a,int b){

            return(a*b);

        }
        public string div(int a,int b){

            if(b==0)
            return "something was wrong";
            else
            return(a/b).ToString();

        }
    }

}

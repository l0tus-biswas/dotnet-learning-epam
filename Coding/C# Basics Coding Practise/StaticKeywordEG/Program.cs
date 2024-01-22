using System;
namespace ThisKeywordEG{

    class Account{
        int accountNo; string name; 
       public static float rateOfInterest = 8.8f;

        public Account(int accountNo, string name){
            this.accountNo = accountNo;
            this.name = name;
        }
        
        public void display(){
            Console.WriteLine("Account No = {0}, Name = {1}, ROI = {2}", accountNo, name, rateOfInterest);
        }
    }
    class Program{
        static void Main(string[] args){
            Account.rateOfInterest = 10.5f;
            Account obj = new Account(1, "Lotus Biswas");
            obj.display();
        }
    }
}
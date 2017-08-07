using System;

namespace Rock_Scissor_Paper
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game Rock-Scissor-Paper!");
            Console.WriteLine("It's time for you to pick (Rock=r,Scissor=s,Paper=p");
            Random rand = new Random();
            string playerinput =Console.ReadLine();
            playerChoice(playerinput);
            int computerinput = rand.Next(1,3); 
            CPUChoice(computerinput);
            Battle(playerinput,computerinput);

            Console.ReadKey();
        }
        public static void Battle(string p,int c){
        

            if (p =="R"||p=="r" && c == 1)
            Console.WriteLine ("Tie..");
            if (p =="R"||p=="r" && c == 2)
            Console.WriteLine ("You win! (Rock beats the Scissor)");
            if (p =="R"||p=="r" && c == 3)
            Console.WriteLine ("You lose.. (Paper beats the Rock)");

            if (p =="S"||p=="s" && c == 1)
             Console.WriteLine ("You lose.. (Rock beats the Scissor)");
            if (p =="S"||p=="s" && c == 2)
            Console.WriteLine ("Tie..");
            if (p =="S"||p=="s" && c == 3)
            Console.WriteLine("You win! (Scissor beats the Paper)");

            if (p =="P"||p=="p" && c == 1)
             Console.WriteLine ("You win! (Paper beats the Rock)");
            if (p =="P"||p=="p" && c == 2)
            Console.WriteLine ("You lose..(Scissor beats the Paper)");
            if (p =="P"||p=="p" && c == 3)
            Console.WriteLine("Tie");
        }

        public static string playerChoice(string input){
           
            if (input=="R"||input=="r"){
                Console.WriteLine("You have choose the Rock!");
            }if (input=="S"||input=="s"){
                Console.WriteLine("You have choose the Scissor!");
            }
            if (input=="P"||input=="p"){
                Console.WriteLine("You have choose the Paper!");
            }

            return input;
        }
         public static int CPUChoice(int cpuchoice){
            
           
            if (cpuchoice==1)
            Console.WriteLine("Computer has choose the Rock!"); // 1 = rock, 2 = scissor , 3 = paper
             else if (cpuchoice==2)
            Console.WriteLine("Computer has choose the Scissor!"); 
            else if (cpuchoice==3)
            Console.WriteLine("Computer has choose the Paper!");

            return cpuchoice;
         }
         
         
    }
}

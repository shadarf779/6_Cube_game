using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shad_Arf_Sadiq___Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(" 6 Cube game , Player can spin the Cube Untill 3 Times ");
            //Telling USer Player can spin the cybe for 3 Times the game is 6 Cube
            Console.Write("Enter name of player 1 : ");
            //Tell User to Enter name of Player 1 
            string player1 = Console.ReadLine();
            //User Entered the Name of Player 1 
            Console.Write("Enter name of player 2 : ");
            //tell USer to Enter name of Player 2 
            string player2 = Console.ReadLine();
            //User Entered the Name of Player 2 
            int num =1 , Foul1=0 ,Foul2=0 ;  
            //idenfy the Variable of num and Foul1 and Foul2 
            Console.WriteLine("\n Robot is Starting ...");
            //Telling Usrer the the Robot is starting spining
            Console.WriteLine("please Enter Number of your chance");
            //And Tell USer to Enter Number 
            Console.WriteLine("***************************");          
            for (int i = 0; i < 3; i++)
                //Using For loop To Let User To Spin the Cube 3 Times
            {
                int Chance1 = 0, Chance2 = 0;                
                //Idenfy the Chance1 And Chance2 Which User can Use
                Random x = new Random();
                //Random of x The bot is Starting To Chosse Random Number
                 num = x.Next(1, 7);
                //THE Number Which Bot Chosee should be Between 1 And 7 
                while (Chance1 > 6 || Chance1 < 1) 
                    //USeing While loop if User Make Mistack Number it will be Foul Foul isnt allow in This Game because the Game Cant be Countinus IF USer Just make Fouling
                {
                    Console.WriteLine("***************************");
                    Console.Write("player 1 : " + player1 + "=");
                    //Player Can Chosee a Number 
                    Chance1 = Convert.ToInt32(Console.ReadLine());
                    //Converting Number to Int32
                    if (Chance1 == num)
                        // IF Chance 1 Will be equl to num
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("..................");
                        Console.WriteLine("congratulations!!");
                        Console.WriteLine($"{player1} is Won \n {player1} is {Chance1} \n Robot is {num} \n ..................");
                        //So player 1 is wining the Game 
                        break;                        
                        //And Make break of While loop because User Didnt made any foul
                    }
                    else if (Chance1 > 6 || Chance1 < 1)
                        //But if User Didnot Entered the right Number 
                    {
                        Console.WriteLine("Foul !! you didnt Entered right Number please Enter right Number if You Foul 3 Times You will lose");
                        Console.WriteLine($"You have {++Foul1} Foul");
                        //So User made a Foul And telling User that Foul isnt Allawed if player1 Enter 3 Foul he/she Lose the Game
                        if (Foul1 == 2)
                            //If User made 2 Foul
                        {
                            Console.WriteLine("You Have 2 Foul if you make Anathor Foul You will Lose");
                            //Just Alert User the User Entered 2 Foul just 1 Foul is left
                        }
                    }
                    if (Foul1 == 3)
                        //But is Player 1 Reached 3 Foul
                    {
                        Console.WriteLine($"{player1} is losed the game ");
                        //Player 1 will lose the game 
                        Console.WriteLine("\n");

                        Console.WriteLine("..................");
                        Console.WriteLine("congratulations!!");
                        Console.WriteLine($"{player2} is Won \n ..................");
                        //And tell USer that Player is Won the Game 
                        break;                       
                       //And The loop will be break because player1 is Entered enagh foul 
                    }

                    else
                    {
                        Console.WriteLine("Failed");
                        //if Player1 didnt Entered Any Foul and chance1 Didnt equl to num player1 will miss the chance
                    }
                    
                }
                if (Chance1 == num || Foul1==3)
                    //if Chance1 will be equl to num or plaer 1 Entered 3 Foul
                {
                    break;
                    //The game will be End and The for loop will be break
                }
                Random y = new Random();
                //and bot of Random 2 is starting
                num = y.Next(1, 7);              
                //and the random is between 1 and 7
                while (Chance2 > 6 || Chance2 < 1)
                    //if the user entered Erorr Number this loop will be countise 
                {
                    Console.WriteLine("***************************");
                    Console.Write("player 2 : " + player2 + ":");
                    //player2 can Enter NUmber 
                    Chance2 = Convert.ToInt32(Console.ReadLine());
                    //Converting the Number to int32
                    if (Chance2 == num)
                        //if player Enter the Number that is Equl to num 
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("..................");
                        Console.WriteLine("congratulations!!");
                        Console.WriteLine($"{player2} is Won \n {player2} is {Chance2} \n Robot is {num} \n ..................");
                        //Player2 will won the Game                         
                        break;                      
                        //and the loop will be stop because user didnt any foul 
                    }
                    else if (Chance2 > 6 || Chance2 < 1)
                        //but is user Entered Erorr NUmber 
                    {
                        Console.WriteLine("Foul !! you didnt Entered right Number please Enter right Number if You Foul 3 Times You will lose");
                        Console.WriteLine($"You have {++Foul2} Foul");
                        //So Because foul isnt allowed telling user that Foul isnt Allowed in this game 
                        if (Foul2 == 2)
                            //If Foul wil lbe equl to 2 
                        {
                            Console.WriteLine("You Have 2 Foul if you make Anathor Foul You will Lose");
                            //Alerting Player 2 if User do Another foul player 2 will lose the game 
                        }
                        if (Foul2 == 3)
                            //if foul will be equl to 3 
                        {
                            Console.WriteLine($"{player2} is losed the game ");
                            //so Player2 Entered 3 foul so player2 is losed the game
                            Console.WriteLine("\n");
                            Console.WriteLine("..................");
                            Console.WriteLine("congratulations!!");
                            Console.WriteLine($"{player1} is Won \n ..................");
                            //and player1 will won the game 
                            break;
                            //and because player2 Entered 3 foul the loop will be break
                        }

                    }
                    else
                    //but it wasnt 
                    {
                        Console.WriteLine("Failed");    
                        //player2 is missed the chance
                    }
                    
                }
                if (Chance2 == num || Foul2==3)
                    //If player2 will won the game or losed the game 
                {
                    break;
                    //So the game will be stop
                }
                if (i == 2
                    //if the game will countise for 3 times
                    )
                {
                    Console.WriteLine("***************************");
                    Console.WriteLine("Game Finished");
                    //alerting User that the game is Ended
                    Console.Write("If you want to Countinse press 1 if you Want to End press 0");
                    //and tell user to Enter  NUmber 1 To Countinse and Enter 0 to break the loop
                    int loop = Convert.ToInt32(Console.ReadLine());
                    //and useing loop variable to Let user Enter a Number 
                    if (loop == 1)
                        //if User Entered 1 
                    {
                        i--;
                        //So USer can Get Another Chance 
                        //Because value of i will be decrece by 1 
                    }
                    else
                    //But if User ENtered Another Number
                    {
                        Console.WriteLine("The game has been fnished");
                        //Tell User That the game is Ended
                    }
                }
            }
            

            Console.ReadKey();
        }
    }

}

// using System;

// namespace InterestRates
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /*  Title: Calculating an Interest Rate 
//                 Description: We are looking to determine an interest rate based on inputs of a person’s age, gender, and credit score.
//                 Ingredients:
//                     int age;
//                     int creditScore;
//                     char gender;
//                     float interestRate;
//                 Instructions:
//                    1. Create the variables. 
//                    2. Get user input for the variables.
//                    3. Create a switch statement (?) to determine a base interest rate based of the credit score.
//                    4. Create ranges of credit scores that will assign a specific interest rate.
//                    5. Minimally adjust the interest rate depending on age. Younger people get higher interest rates. Middle aged people 
//                       tend to get decent to good rates. Older people tend to get lower interest rates.
//                    6. Minimally adjust the interest rate depending on gender. Men tend to require higher interest rates. Women tend to 
//                       keep the same interest rates, not lower ones. 
//                 Completeness: We’ll know it’s complete when there is a final interest rate.
//              */


//             //Create the variables.
//             int age = 18;
//             int creditScore = 300;
//             char gender = 'A';
//             float interestRate = 0;

//             //Get user input for the credit score.
//             Console.Write("Enter the person's credit score: ");
//             try
//             {
//                 creditScore = Convert.ToInt32(Console.ReadLine());
//             }
//             catch
//             {
//                 Console.WriteLine("You have entered an invalid score. Please try again.");
//             }
//             while ((creditScore < 300) || (creditScore > 850))
//             {
//                 Console.Write("Enter the person's credit score: ");
//                 try
//                 {
//                     creditScore = Convert.ToInt32(Console.ReadLine());
//                 }
//                 catch
//                 {
//                     Console.WriteLine("You have entered an invalid score. Please try again.");
//                 }
//             }

//             //Get user input for the age.
//             Console.Write("Enter the person's age: ");
//             try
//             {
//                 age = Convert.ToInt32(Console.ReadLine());
//             }
//             catch
//             {
//                 Console.WriteLine("You have entered an invalid age. Please try again.");
//             }
//             while ((age < 18) || (age > 105))
//             {
//                 Console.Write("Enter the person's age: ");
//                 try
//                 {
//                     creditScore = Convert.ToInt32(Console.ReadLine());
//                 }
//                 catch
//                 {
//                     Console.WriteLine("You have entered an invalid age. Please try again.");
//                 }
//             }

//             //Get user input for the gender.
//             Console.Write("Enter the person's gender (M or F): ");
//             try
//             {
//                 gender = Convert.ToChar(Console.ReadLine());
//             }
//             catch
//             {
//                 Console.WriteLine("You have entered an invalid gender. Please try again.");
//             }
//             while ((gender != 'F') && (gender != 'M'))
//             {
//                 Console.Write("Enter the person's gender (M or F): ");
//                 try
//                 {
//                     gender = Convert.ToChar(Console.ReadLine());
//                 }
//                 catch
//                 {
//                     Console.WriteLine("You have entered an invalid gender. Please try again.");
//                 }
//             }

//             //Determining base interest rate based on credit score
//                 /* Credit Score Scale
//                  * Very Bad = 300 - 599 = 28%
//                  * Poor = 600 - 649 = 24%
//                  * Fair = 650 - 699 = 20%
//                  * Good = 700 - 749 = 16%
//                  * Very Good = 750 - 799 = 12%
//                  * Excellent = 800 - 850 = 8%
//                  */
            
//             if (creditScore >= 300 && creditScore < 600)
//             {
//                 interestRate = 0.28F;
//             }
//             else if (creditScore >= 600 && creditScore < 650)
//             {
//                 interestRate = 0.24F;
//             }
//             else if (creditScore >= 650 && creditScore < 700)
//             {
//                 interestRate = 0.2F;
//             }
//             else if (creditScore >= 700 && creditScore < 750)
//             {
//                 interestRate = 0.16F;
//             }
//             else if (creditScore >= 750 && creditScore < 800)
//             {
//                 interestRate = 0.12F;
//             }
//             else if (creditScore >= 800 && creditScore <= 850)
//             {
//                 interestRate = 0.08F;
//             }

//             //Checking the interest rate has been determined based off credit score
//             //interestRate = interestRate * 100;
//             //Console.WriteLine("The interest rate is: {0}%", interestRate);

//             //Adjusting interest rate based on age
//                 /* Age Scale
//                  * Young = 18 - 24
//                  * Young Adult = 25 - 29
//                  * Adult = 30 - 39
//                  * Middle-Aged Adult = 40 - 54
//                  * Older Adult = 55 - 64
//                  * Retired Age = 65 - 105
//                  */

//             if (age >= 18 && age < 25)
//             {
//                 interestRate = interestRate + 0.003F;
//             }
//             else if (age >= 25 && age < 30)
//             {
//                 interestRate = interestRate + 0.001F;
//             }
//             else if (age >= 30 && age < 40)
//             {
//                 interestRate = interestRate - 0.006F;
//             }
//             else if (age >= 40 && age < 55)
//             {
//                 interestRate = interestRate - 0.01F;
//             }
//             else if (age >= 55 && age < 65)
//             {
//                 interestRate = interestRate - 0.02F;
//             }
//             else if (age >= 65 && age < 105)
//             {
//                 interestRate = interestRate - 0.03F;
//             }

//             //Adjusting interest rate based on gender
//             /* Gender Scale
//              * Women = no change
//              * Men = higher interest rate of 0.05%
//              */

//             if (gender == 'M')
//             {
//                 interestRate = interestRate + 0.005F;
//             }

//             //Return the interest rate to the user
//             interestRate = interestRate * 100;
//             Console.WriteLine("The interest rate is: {0}%", interestRate);


//             /* Title: Calculating the Compuound Interest
//              * Description: We are looking to determine the compound interest based on the principal amount, the above calculated interest
//              * rate, the number of times that interest is compounded per year, and the number of years that the interest will be compounded.
//                Ingredients:
//                     int principal;
//                     int timesCompounded;
//                     int years;
//                Instructions:
//                    1. Create the variables. 
//                    2. Get user input for the variables.
//                    3. Plug in the variables into the formula
//                    //The formula is Compounded Interest = principal * Math.Pow((1 + (interestRate / <double>timesCompounded)), ()
//                 Completeness: We’ll know it’s complete when there is a final interest rate.
//              */
//         }
//     }
// }

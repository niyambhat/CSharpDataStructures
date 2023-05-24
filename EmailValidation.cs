//using System;
//using System.Text.RegularExpressions;

//namespace IntroCS
//{
//	public class EmailValidation
//	{

//		static void EmailValidatior(string emailAdress)
//		{
//            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
//            Regex regex = new Regex(pattern);
//			bool valid = regex.IsMatch(emailAdress);
//			Console.WriteLine(emailAdress.Length);
//			if (valid)
//			{
//				Console.WriteLine("This email is valid");
//			}
//			else {
//                Console.WriteLine("This email is invalid");
//            }
            
//        }
//        static void Main()
//		{
//			EmailValidatior("info@niyam.com");
//		}
//	}
//}


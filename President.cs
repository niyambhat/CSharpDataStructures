//using System;
//namespace IntroCS
//{
//	public class President
//	{
//		int age;
//		string name;
//		int numberOfPresidentsVotedFor = 0;
//        public President(string name,int age) {
//            this.age = age;
//			this.name = name;
//        }

//		public int CalculatePresidents() {
//			int votingSpan = age - 18;
//			if (age <= 18) {
//				Console.WriteLine("You are not eligible to vote");
//				numberOfPresidentsVotedFor = 0;
//			}
//			else {
//				for (int i = 0; i <= votingSpan; i++) {
//					if (i % 4 == 0) {
//						numberOfPresidentsVotedFor++;
//                    }
//				}
//			}
//			return numberOfPresidentsVotedFor;	
//		}

//		public void DisplayInfo() {
//			Console.WriteLine(name + " has voted "+ numberOfPresidentsVotedFor + " times");
//		}
//		static void Main() {
//			Console.WriteLine("What is your name?");
//			string name = Console.ReadLine();
//            Console.WriteLine("What is your age?");
//            int age = int.Parse(Console.ReadLine());
//            President person = new President(name, age);
//            int noOfTimesVoted = person.CalculatePresidents();
//            person.DisplayInfo();
//        }
//	}
//}


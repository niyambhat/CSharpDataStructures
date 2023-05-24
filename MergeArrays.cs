//using System;
//using System.Linq;

//namespace IntroCS
//{
//	public class MergeArrays
//	{
//		int[] x;
//		int[] y;
//		public MergeArrays(int[] x, int[] y)
//		{
//			this.x = x;
//			this.y = y;
//		}
//		public int[] MergeThis() {
//			int[] res = x.Concat(y).ToArray();
//			return res;
//		}
//		static void Main() {
//			int[] a = { 1, 3 };
//			int[] b = { 2, 3 };
//            MergeArrays program = new MergeArrays(a,b);
//			int[] answers=program.MergeThis();
//            string arrayAsString = string.Join(", ", answers);
//            Console.WriteLine(arrayAsString);
//        }
//	}
//}


using System;
class module1
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome to Muhammad Sreywel's quadratic equation solver [version 2.5.0]");
		Console.WriteLine("Please make sure that the equation you want to solve is in the form { ax^2 + bx + c = 0 } before you start.");
		Console.WriteLine("press enter to start...".ToUpper());
		Console.ReadLine();
		solve();
	}
	static void solve()
	{
		int a=0, b=0, c=0;
		string ans = "";
		do
		{
			try
			{
				Console.Write("a: ");
				a=int.Parse(Console.ReadLine());
				Console.Write("b: ");
				b=int.Parse(Console.ReadLine());
				Console.Write("c: ");
				c=int.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Please use decimal numbers only..");
				solve();
			}
			float d = (b*b)-(4*a*c);
			if(a==0){
				Console.Write("x = " + (-c/b));}
			else{if(d==0){
				Console.Write("x = " + (-b/2/a));}
			else{if(d<0){
				Console.WriteLine("x1 = "+((Math.Sqrt(Math.Abs(d))-b)/(2*a))+"i");
				Console.WriteLine("x2 = "+((-b-Math.Sqrt(Math.Abs(d)))/(2*a))+"i");}
			else{
				Console.WriteLine("x1 = "+((Math.Sqrt(d)-b)/(2*a)));
				Console.WriteLine("x2 = "+((-b-Math.Sqrt(d))/(2*a)));
			}}}
			Console.WriteLine();
			Console.Write("Do you want to solve another equation?(y/n)");
			ans = Console.ReadLine();
		}while(ans.ToLower()=="y");
	}
}
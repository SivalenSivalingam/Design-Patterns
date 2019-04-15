using System;

namespace StrategyPattern
{
	//This is a class that contains a property to hold the reference of a Strategy object. This property will be set at run-time according to the algorithm that is required.
	public class Client
	{
		public IStrategy Strategy { get; set; }

		public void CallAlgorithm()
		{
			Console.WriteLine(Strategy.Algorithm());
		}
	}

	//This is an interface that is used by the Context object to call the algorithm defined by a ConcreteStrategy.
	public interface IStrategy
	{
		string Algorithm();
	}

	//These are classes that implements Strategy interface.
	public class ConcreteStrategyA : IStrategy
	{
		public string Algorithm()
		{
			return "Concrete Strategy A";
		}
	}

	//These are classes that implements Strategy interface.
	public class ConcreteStrategyB : IStrategy
	{
		public string Algorithm()
		{
			return "Concrete Strategy B";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client();
			client.Strategy = new ConcreteStrategyA();
			client.CallAlgorithm();

			client.Strategy = new ConcreteStrategyB();
			client.CallAlgorithm();

			Console.Read();
		}
	}
}

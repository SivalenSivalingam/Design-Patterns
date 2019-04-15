using System;

namespace TemplatePattern
{
	//This is an abstract class that contains template method and abstract operations for each of the steps that may be implemented by subclasses.
	public abstract class AbstractClass
	{
		public void TemplateMethod()
		{
			Step1();
			Step2();
			Step3();
		}

		public abstract void Step1();

		public abstract void Step2();

		public abstract void Step3();
	}

	//These are subclasses which inherits the AbstractClass and override the abstract class operations.
	public class ConcreteClassA : AbstractClass
	{
		public override void Step1()
		{
			Console.WriteLine("Concrete Class A, Step 1");
		}

		public override void Step2()
		{
			Console.WriteLine("Concrete Class A, Step 2");
		}

		public override void Step3()
		{
			Console.WriteLine("Concrete Class A, Step 3");
		}
	}

	//These are subclasses which inherits the AbstractClass and override the abstract class operations.
	public class ConcreteClassB : AbstractClass
	{
		public override void Step1()
		{
			Console.WriteLine("Concrete Class B, Step 1");
		}

		public override void Step2()
		{
			Console.WriteLine("Concrete Class B, Step 2");
		}

		public override void Step3()
		{
			Console.WriteLine("Concrete Class B, Step 3");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var concreteClassA = new ConcreteClassA();
			concreteClassA.TemplateMethod();

			var concreteClassB = new ConcreteClassB();
			concreteClassB.TemplateMethod();

			Console.Read();
		}
	}
}

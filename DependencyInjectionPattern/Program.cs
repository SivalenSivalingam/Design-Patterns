using System;

namespace DependencyInjectionPattern
{
	public interface IService
	{
		void Serve();
	}

	public class Service1 : IService
	{
		public void Serve() { Console.WriteLine("Service1 Called"); }
	}
	public class Service2 : IService
	{
		public void Serve() { Console.WriteLine("Service2 Called"); }
	}

	public class Client
	{
		private IService _service;

		//Property/Setter Injection
		public IService Service
		{
			set { this._service = value; }
		}

		//Constructor Injection
		public Client(IService service)
		{
			this._service = service;
		}

		public void ServeMethod() {
			this._service.Serve();
		}

		//Method Injection
		public void Start(IService service)
		{
			service.Serve();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//Constructor Injection + Property/Setter Injection
			var client = new Client(new Service2());
			client.Service = new Service1();
			client.ServeMethod();

			//Constructor Injection + Method Injection
			new Client(new Service1()).Start(new Service1());

			Console.Read();
		}
	}
}

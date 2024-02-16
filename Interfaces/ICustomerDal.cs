using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public interface ICustomerDal
	{
		void Add();
		void Update();
		void Delete();
	}

	public class SqlServerCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Sql Added.");
		}

		public void Delete()
		{
			Console.WriteLine("Sql Deleted.");
		}

		public void Update()
		{
			Console.WriteLine("Sql Updated.");
		}
	}
	public class OracleCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Oracle Added.");
		}

		public void Delete()
		{
			Console.WriteLine("Oracle Deleted.");
		}

		public void Update()
		{
			Console.WriteLine("Oracle Updated.");
		}
	}

	public class PostgreSQLCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("PostgreSQL Added.");
		}

		public void Delete()
		{
			Console.WriteLine("PostgreSQL Deleted.");
		}

		public void Update()
		{
			Console.WriteLine("PostgreSQL Updated.");
		}
	}

	public class CustomerManager
	{
		public void Add(ICustomerDal customerDal)
		{
			customerDal.Add();
		}
	}
}

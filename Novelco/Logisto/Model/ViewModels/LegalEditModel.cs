﻿using System;
using System.Collections.Generic;

namespace Logisto.ViewModels
{
	public class LegalEditModel
	{
		public int ID { get; set; }
		public int ContractorId { get; set; }
		public int? TaxTypeId { get; set; }

		public int? DirectorId { get; set; }
		public int? AccountantId { get; set; }

		public string Name { get; set; }
		public string DisplayName { get; set; }
		public string EnName { get; set; }
		public string EnShortName { get; set; }
		public string TIN { get; set; }
		public string OGRN { get; set; }
		public string KPP { get; set; }
		public string OKPO { get; set; }
		public string OKVED { get; set; }
		public string Address { get; set; }
		public string EnAddress { get; set; }
		public string AddressFact { get; set; }
		public string EnAddressFact { get; set; }
		public string PostAddress { get; set; }
		public string EnPostAddress { get; set; }
		public string WorkTime { get; set; }
		public string TimeZone { get; set; }
		public bool IsNotResident { get; set; }

		public bool IsDeleted { get; set; }

		public List<EmployeeEditModel> Employees { get; set; }
		public List<BankAccountEditModel> BankAccounts { get; set; }
		public List<ContractEditModel> Contracts { get; set; }

		public LegalEditModel()
		{
			Employees = new List<EmployeeEditModel>();
			BankAccounts = new List<BankAccountEditModel>();
			Contracts = new List<ContractEditModel>();
		}
	}
}





















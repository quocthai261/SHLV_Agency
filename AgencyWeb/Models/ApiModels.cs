using DevExtreme.AspNet.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.VisualBasic;

namespace AgencyWeb.Models
{
    public class SysRolesModel 
    {
        public long RoleID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class UserTypeModel
    {
        public int ID { get; set; }
        public string Name { get; set; } 
    }

    public class SysUsersModel
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
    }

    public class SysUsersModelExt : SysUsersModel
    {
        public long[] RoleIDs { get; set; }
    }

    public class ProductModel
    {
        public long ProductID { get; set; }
        public required string ProductName { get; set; }
        public required string ProductCode { get; set; }
        public required string PayMode { get; set; }
        public bool IsAllowSale { get; set; }
        public string POAge { get; set; }
        public string LAAge { get; set; }
        public int MaturityAge { get; set; }
        public double InsureAmountMin { get; set; }
        public double InsureAmountMax { get; set; }
    }

    public class RiderModel
    {
        public long ProductID { get; set; }
        public long RiderID { get; set; }
        public required string RiderName { get; set; }
        public required string RiderCode { get; set; }
        public double InsureAmountMin { get; set; }
        public double InsureAmountMax { get; set; }
    }

    public class PayModeModel
    {
        public long PayModeID { get; set; }
        public required string PayModeName { get; set; }
    }
    
    public class NationalityModel
	{
        public required string Code { get; set; }
        public required string Name { get; set; }
    }

	public class CustomerModel
	{
		public required long CustomerID { get; set; }
		public required string FullName { get; set; }
		public string Gender { get; set; }
		public DateTime Birthday { get; set; }
		public string IDType { get; set; }
		public bool HasIN { get; set; }
		public string IdentificationNumber { get; set; }
		public string BirthNumber { get; set; }
		public string IdNumber { get; set; }
		public DateTime IssuedDate { get; set; }
		public string IssuedPlace { get; set; }
	}

	public class QuotationModel
    {
		public required long QuotationID { get; set; }
		public required string QuotationNo { get; set; }
		public required string FullName { get; set; }
		public string ProductName { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public double SumAssured { get; set; }
		public string PremiumType { get; set; }
		public string PolicyTerm { get; set; }
		public int PremiumTerm { get; set; }
		public double Premium { get; set; }
		public string Status { get; set; }
		public string Progress { get; set; }
	}

	public class RiderByCustomerModel
    {
		public required long RiderID { get; set; }
		public required string Group { get; set; }
		public required string ProductName { get; set; }
		public double SumAssured { get; set; }
		public int PolicyTerm { get; set; }
		public int PremiumTerm { get; set; }
		public double Premium { get; set; }
	}

	public class QuotationInformationModel
    {
		public required string Group { get; set; }
		public required string ProductName { get; set; }
		public double SumAssured { get; set; }
		public int PolicyTerm { get; set; }
		public int PremiumTerm { get; set; }
		public double Premium { get; set; }
	}

	public class FinancialAnalysisModel
    {
		public required string FinancialPlan { get; set; }
		public required string Fullname { get; set; }
		public double NecessarySmount { get; set; }
		public double CurrentAmount { get; set; }
		public double CurrentFinancialStatus { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime UpdatedDay { get; set; }
    }
    
	public class FinancialPlanModel
    {
		public required string FinancialPlan { get; set; }
		public double NecessarySmount { get; set; }
		public double CurrentAmount { get; set; }
		public double CurrentFinancialStatus { get; set; }
		public bool IsSelected { get; set; }
	}

	public class eApplicationModel
    {
        public string eAppNo { get; set; }
        public string PolicyNo { get; set; }
        public string PoName { get; set; }
        public string LaName { get; set; }
        public string ProductName { get; set; }
        public string Status { get; set; }
        public string NextStep { get; set; }
        public string VoiceRecord { get; set; }
        public string CreationUser { get; set; }
        public string Step { get; set; }
        public bool? IsExpertised { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class GenderModel
    {
        public string GenderCode { get; set; }

        public string GenderName { get; set;}
    }

    public class MarriageStatusModel
    {
        public string MarriageCode { get; set; }

        public string MarriageName { get; set; }
    }

    public class CityProvinceModel
    {
        public string CityCode { get; set;}

        public string CityName { get; set;}
    }

    public class  CertiTypeModel
    {
        public string CertiTypeCode { get; set; }

        public string CertiTypeName { get; set;}
    }

    public class RelationshipModel
    {
        public string Code { get; set; }

        public string Name { get; set;}
    }

    public class PolicyModel
    {
        public string Code { get; set; }

        public string Status { get; set; }

        public string ProductName { get; set; }

        public string POName { get; set; }

        public string LAName { get; set; }

        public double InsuredAmount { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PremiumTerm { get; set; }

    }
    public class OrderPaymentByCustomerModel
    {
        public required long OrderID { get; set; }
        public required string OrderNo { get; set; }
        public required string FullName { get; set; }
        public required string ProductName { get; set; }
        public string Currency { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime UpdatedDay { get; set; }
    }
    public class PaymentMethodModel
    {
        public long PaymentMethodID { get; set; }
        public required string PaymentMethodName { get; set; }
    }

    public class FinancialReportModel
    {
        public required string Type { get; set; }
        public bool IsSelected { get; set; }
        public string Reason { get; set; }
    }

    public class DocumenteAppModel
    {
        public string DocumentName { get; set; }
        public string FileName { get; set; }
        public string DocumentType { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Seen { get; set; }
    }

    public class DocumentModel
    {
        public string Group { get; set; }
        public string DocumentName { get; set; }
        public string FileName { get; set; }
        public string DocumentType { get; set; }
    }




    //Agency Portal

    public class FrequentlyUsedFunctionModel
    {
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public bool IsSelected { get; set; }
    }


    public class SchedulerModel
    {
        public int SchedulerId { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool AllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public string RecurrenceException { get; set; }
    }
    public class AgentModel
    {
        public string AgentCode { get; set; }
        public string FullName { get; set; }
        public string Hierarchy { get; set; }
        public DateTime JoinDate { get; set; }
        public string Status { get; set; }
        public string IdNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ManagerCode { get; set; }
        public string ManagerName { get; set; }
        public DateTime Date01 { get; set; }
        public DateTime Date02 { get; set; }
        public DateTime Date03 { get; set; }
        public DateTime Date04 { get; set; }
    }
}

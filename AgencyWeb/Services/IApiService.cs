using AgencyWeb.Models;

namespace AgencyWeb.Services
{
    public interface IApiService
    {
        //List<ChungLoaiDTO> GetListChungLoai();

        List<SysRolesModel> GetRoleListApi();

        List<UserTypeModel> GetUserTypeListApi();

        List<SysUsersModelExt> GetUserListApi();

        List<SysRolesModel> GetRolesForUserApi();

        List<ProductModel> GetProductListApi();

        List<PayModeModel> GetPayModeListApi();

        List<RiderModel> GetRiderListApi(int productId);

        List<CustomerModel> GetCustomerListApi();

        List<NationalityModel> GetNationalityListApi();

        List<QuotationModel> GetQuotationListApi();

        List<RiderByCustomerModel> GetRiderByCustomerListApi();

        List<QuotationInformationModel> GetQuotationInformationApi();

        List<FinancialAnalysisModel> GetFinancialAnalysisListApi();

        List<FinancialPlanModel> GetFinancialPlanListApi();

        List<eApplicationModel> GeteApplicationListApi();

        List<GenderModel> GetGenderListApi();

        List<MarriageStatusModel> GetMarriageStatusListApi();

        List<CityProvinceModel> GetCityProvinceListApi();

        List<CertiTypeModel> GetCertiTypeListApi();

        List<RelationshipModel> GetRelationListApi();

        List<PolicyModel> GetPolicyListApi();

        List<OrderPaymentByCustomerModel> GetOrderPaymentByCustomerListApi();

        List<PaymentMethodModel> GetPaymentMethodListApi();

        List<FinancialReportModel> GetFinancialConsultingListApi();

        List<DocumentModel> GetDocumentListApi();

        List<DocumenteAppModel> GetDocumenteAppListApi();


        //AgencyWeb Portal

        List<FrequentlyUsedFunctionModel> GetFrequentlyUsedFunctionListApi();

        List<SchedulerModel> GetSchedulerListApi();

        List<AgentModel> GetAgentListApi();

    }
}

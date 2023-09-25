using DAL;

namespace DALTest
{
    internal interface ICustLogInfoRepository
    {
        object SaveCustLogInfo(CustLogInfo custLogInfo);
        object GetAllLogInfoes();
    }
}
namespace Salus_2._0.Models
{
    public class BaseDataResponse<T> : BaseResponse
    {
        public T? Dados{ get; set; }
    }
}

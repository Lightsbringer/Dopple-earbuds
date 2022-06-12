using DoppleApi.Entities;

namespace DoppleApi.Models;

public class OrderModel
{
    
    public string OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public string FaceplateText { get; set; }
    public float EarshellSize { get; set; }
    public string EarshellColor { get; set; }
    public string CradleColor { get; set; }
    public string StatusOrder { get; set; }

    //public virtual StationModel Station { get; set; }


}


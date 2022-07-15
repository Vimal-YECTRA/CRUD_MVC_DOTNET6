using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUD_MVC_DOTNET6.Models
{
    public class EntireName
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }
        public List<SelectListItem> Operations { get; set; }
        public int Result { get; set; }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }
        public int Sub(int FN, int SN)
        {
            return FN - SN;
        }
        public int Mul(int FN, int SN)
        {
            return FN * SN;
        }
        public int Div(int FN, int SN)
        {
            return FN / SN;
        }
        public int Rem(int FN, int SN)
        {
            return FN % SN;
        }
    }
}

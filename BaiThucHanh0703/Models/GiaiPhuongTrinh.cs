namespace BaiThucHanh0703.Models
{
    public class GiaiPhuongTrinh
    {
     public string GiaiPhuongTrinhbac2(double a, double b, double c)
     {
        double delta, x1, x2;
        string ketqua;
         delta = Math.Pow(b,2) - 4*a*c;
            if(delta<0) ketqua = "pt vo nghiem";
            else if(delta==0)
            {
                x1 = -b/(2*a);
                ketqua = "pt co nghiem kep = " + x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta))/(2*a);
                x2 = (-b - Math.Sqrt(delta))/(2*a);
                ketqua = "pt cos 2 nghiem: x1 =" + x1 + ", x2 = " + x2;
            }
      return ketqua;
     }

    }
}
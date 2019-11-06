using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample
{
    partial class Partial : Public
    {
        public void Method()
        {
            Method2(); //Parçalı sınıfdaki method

            //ÜST SINIFDAN TANIMLANAN ÖZELLİKLERE ERİŞMEK

            base.Ipublic = 0;                   //Tam erişime açık
            //base.Iprivate = 0;                //private ulaşılamıyor ulaşılmak istenen şey ile aynı classda olunmadığı için
            base.Iprotected = 0;                //protected olarak erişim sağlanabiliyor çünkü istenen şey ile aynı classda olunmasada o classdan türetilmiş bir classdan çağrılmakta.
            base.Iinternal = 0;                 //internal olarak erişim sağlanabiliyor çünkü istenen şey ile aynı namespace (exe, dll) içinden çağırılıyor.
            base.IprotectedInternal = 0;        //PROTECTED VEYA INTERNAL ŞARTINDAN İKİSİDE SAĞLANDIĞI İÇİN ERİŞİLEBİLİYOR.
            base.IprivateProtected = 0;         //PRİVATE VEYA PROTECTED ŞARTINDAN PROTECTED SAĞLANDIĞI İÇİN ERİŞİLEBİLİYOR!



            //ÜST SINIFTAN TANIMLANAN NESNEYE ERİŞMEK

            Public @public = new Public();
            @public.Ipublic = 0;
            //@public.Iprivate = 0;
            //@public.Iprotected = 0;
            @public.Iinternal = 0;
            @public.IprotectedInternal = 0;

            Public.Sprotected = 0;



            //SINIFTAN TANIMLANAN NESNEYE ERİŞMEK

            Partial @partial = new Partial();
            @partial.Ipublic = 0;
            //@partial.Iprivate = 0;
            @partial.Iprotected = 0;
            @partial.Iinternal = 0;
            @partial.IprotectedInternal = 0;

        }
    }
}

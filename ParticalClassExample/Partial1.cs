using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample
{
    partial class Partial
    {
        //Parçalı sınıflarda normal sınıflarda olduğu gibi aynı isimle iki tanım (method veya değişken) olması hataya sebep olur.
        //Parçalı sınıflarda normal sınıflarda olduğu gibi tek bir kalıtım yapılabilir, bir parçada yapılan katılım bütün parçaları etkiler.

        //public olarak tanımlanan öğe, kod bloğunun içinde ve dışında tamamen erişilebilirdir. Yani, hiçbir kısıtlama yoktur.
        //protected olarak tanımlanan öğe, sadece tanımlandığı class’ın içinde ve o class’tan türetilmiş diğer class’ların içinde erişilebilirdir.
        //internal olarak tanımlanan öğe, bulunduğu assembly’nin(Dll veya Exe dosyası) içinde erişilebilirdir.Dll veya Exe dosyasının içerisinde erişim için kısıtlama yoktur, ama dışarıdan erişilemez.
        //protected internal erişim belirleyicisi, protected ve internal erişim belirleyicilerinin VEYA (OR) işlemiyle birleştirilmiş halidir. protected internal olarak tanımlanmış öğe, tanımlandığı class’ın içinde ve o class’tan türetilmiş diğer class’ların içinde erişilebilir. Ayrıca, aynı assembly içinde olmasalar dahi, tanımlandığı class’tan türetilmiş diğer class’ların içinde de erişilebilirdir.
        //private olarak tanımlanan öğe, sadece tanımlandığı class’ın içerisinde erişilebilirdir. En katı erişim belirleyicidir.

        public void Method2()
        {
            //Bu method Partial2.cs dosyası içindeki Partial sınıfındanda erişilebilir.
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample2
{
    class Class1
    {
        public void Method1()
        {
            AccessModifiersExample.Public @public = new AccessModifiersExample.Public();

            @public.Ipublic = 0;
            //@public.Iprivate = 0;
            //@public.Iprotected = 0;
            //@public.Iinternal = 0;
            //@public.IprotectedInternal = 0;
            //@public.IprivateProtected = 0;


        }
    }
}

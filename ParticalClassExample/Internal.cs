using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample
{
    internal class Internal
    {
        public int Ipublic;
        private int Iprivate;
        protected int Iprotected;
        internal int Iinternal;
        protected internal int IprotectedInternal;
        private protected int IprivateProtected;

        public void Method()
        {
            Internal @internal = new Internal();
            @internal.Ipublic = 0;
            @internal.Iprivate = 0;
            @internal.Iprotected = 0;
            @internal.Iinternal = 0;
            @internal.IprotectedInternal = 0;

            Public @public = new Public();
            @public.Ipublic = 0;
            //@public.Iprivate = 0;     //private ulaşılamıyor
            //@public.Iprotected = 0;   //protected ulaşılamıyor
            @public.Iinternal = 0;
            @public.IprotectedInternal = 0;
            //@public.IprivateProtected = 0; //private protected ulaşılamıyor

            //Public.Sprotected = 0; //Static Protected ulaşılamıyor
        }
    }
}

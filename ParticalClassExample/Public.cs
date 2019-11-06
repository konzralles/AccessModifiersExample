using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample
{
    public class Public
    {
        static protected int Sprotected;

        public int Ipublic;
        private int Iprivate;
        protected int Iprotected;
        internal int Iinternal;
        protected internal int IprotectedInternal;
        private protected int IprivateProtected;

        public void Method()
        {
            Public @public = new Public();
            @public.Ipublic = 0;
            @public.Iprivate = 0;
            @public.Iprotected = 0;
            @public.Iinternal = 0;
            @public.IprotectedInternal = 0;
            @public.IprivateProtected = 0;

            Internal @internal = new Internal();
            @internal.Ipublic = 0;
            //@internal.Iprivate = 0;    //private ulaşılamıyor
            //@internal.Iprotected = 0;  //protected ulaşılamıyor
            @internal.Iinternal = 0;
            @internal.IprotectedInternal = 0;
            //@internal.IprivateProtected = 0; //private protected ulaşılamıyor

            //---------------------------------------------------------------------------
            //InnerClasslar
            PublicInner publicInner = new PublicInner();
            publicInner.Ipublic = 0;
            //publicInner.Iprivate = 0;     //private ulaşılamıyor
            //publicInner.Iprotected = 0;   //protected ulaşılamıyor
            publicInner.Iinternal = 0;
            publicInner.IprotectedInternal = 0;
            //publicInner.IprivateProtected = 0; //private protected ulaşılamıyor

            PrivateInner privateInner = new PrivateInner();
            privateInner.Ipublic = 0;
            //privateInner.Iprivate = 0;     //private ulaşılamıyor
            //privateInner.Iprotected = 0;   //protected ulaşılamıyor
            privateInner.Iinternal = 0;
            privateInner.IprotectedInternal = 0;
            //privateInner.IprivateProtected = 0; //private protected ulaşılamıyor

            ProtectedInner protectedInner = new ProtectedInner();
            protectedInner.Ipublic = 0;
            //protectedInner.Iprivate = 0;     //private ulaşılamıyor
            //protectedInner.Iprotected = 0;   //protected ulaşılamıyor
            protectedInner.Iinternal = 0;
            protectedInner.IprotectedInternal = 0;
            //protectedInner.IprivateProtected = 0; //private protected ulaşılamıyor

            InternalInner internalInner = new InternalInner();
            internalInner.Ipublic = 0;
            //internalInner.Iprivate = 0;     //private ulaşılamıyor
            //internalInner.Iprotected = 0;   //protected ulaşılamıyor
            internalInner.Iinternal = 0;
            internalInner.IprotectedInternal = 0;
            //internalInner.IprivateProtected = 0; //private protected ulaşılamıyor

            ProtectedInternalInner protectedInternalInner = new ProtectedInternalInner();
            protectedInternalInner.Ipublic = 0;
            //protectedInternalInner.Iprivate = 0;     //private ulaşılamıyor
            //protectedInternalInner.Iprotected = 0;   //protected ulaşılamıyor
            protectedInternalInner.Iinternal = 0;
            protectedInternalInner.IprotectedInternal = 0;
            //protectedInternalInner.IprivateProtected = 0; //private protected ulaşılamıyor

            PrivateProtectedInner privateProtectedInner = new PrivateProtectedInner();
            privateProtectedInner.Ipublic = 0;
            //privateProtectedInner.Iprivate = 0;     //private ulaşılamıyor
            //privateProtectedInner.Iprotected = 0;   //protected ulaşılamıyor
            privateProtectedInner.Iinternal = 0;
            privateProtectedInner.IprotectedInternal = 0;
            //privateProtectedInner.IprivateProtected = 0; //private protected ulaşılamıyor
        }

        //Inner Class
        public class PublicInner
        {
            public int Ipublic;
            private int Iprivate;
            protected int Iprotected;
            internal int Iinternal;
            protected internal int IprotectedInternal;
            private protected int IprivateProtected;
        }

        private class PrivateInner
        {
            public int Ipublic;
            private int Iprivate;
            protected int Iprotected;
            internal int Iinternal;
            protected internal int IprotectedInternal;
            private protected int IprivateProtected;
        }

        protected class ProtectedInner
        {
            public int Ipublic;
            private int Iprivate;
            protected int Iprotected;
            internal int Iinternal;
            protected internal int IprotectedInternal;
            private protected int IprivateProtected;
        }

        internal class InternalInner
        {
            public int Ipublic;
            private int Iprivate;
            protected int Iprotected;
            internal int Iinternal;
            protected internal int IprotectedInternal;
            private protected int IprivateProtected;
        }

        protected internal class ProtectedInternalInner
        {
            public int Ipublic;
            private int Iprivate;
            protected int Iprotected;
            internal int Iinternal;
            protected internal int IprotectedInternal;
            private protected int IprivateProtected;
        }

        private protected class PrivateProtectedInner
        {
            public int Ipublic;
            private int Iprivate;
            protected int Iprotected;
            internal int Iinternal;
            protected internal int IprotectedInternal;
            private protected int IprivateProtected;
        }
    }
}

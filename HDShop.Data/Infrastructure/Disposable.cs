using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDShop.Data.Infrastructure
{
    //cho phép tự động hủy.. 24p30
    public class Disposable : IDisposable
    {
        private bool isDisposed;
        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            //thu hoạch bộ nhớ
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
        protected virtual void DisposeCore()
        {

        }
    }
}

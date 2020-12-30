using Castle.DynamicProxy;
using EDBackendAPI.Core.Utilities.Interceptors.Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace EDBackendAPI.Core.Aspects.Autofac.Transaction
{
    public class TransactionScopeAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch (Exception)
                {
                    transactionScope.Dispose();
                    throw;
                }
            }
        }
    }
}

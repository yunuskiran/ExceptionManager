using ExceptionManager.Exceptions;
using ExceptionManager.RuleFactory;
using ExceptionManager.Rules;
using System;

namespace ExceptionManager
{
    public class ExceptionManager : IExceptionManager
    {
        private static readonly Lazy<ExceptionManager> _instance = new Lazy<ExceptionManager>(() => new ExceptionManager());
        public static ExceptionManager Instance => _instance.Value;

        public void Initalize()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            var exception = unhandledExceptionEventArgs.ExceptionObject as Exception;
            Handle(exception);
        }

        public void Handle(Exception exception)
        {
            if (exception.GetType() == typeof(BusinessException))
                new CriticalExceptionRuleFactory().GetExceptionRule().Execute(exception);
            else if (exception.GetType() == typeof(UserException))
                new UserExceptionRuleFactory().GetExceptionRule().Execute(exception);
            else
                new DefaultExceptionRuleFactory().GetExceptionRule().Execute(exception);
        }

        public void Handle(Exception e, ExceptionRule exceptionRule)
        {
            exceptionRule.Execute(e);
        }
    }
}

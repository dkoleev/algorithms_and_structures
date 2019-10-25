using System;
using System.Collections.Generic;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace Algorithms_and_Structures.AOP {
    public class LoggingAspect : IInterceptionBehavior {
        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext) {
            // Before invoking the method on the original target.   
            WriteLog(String.Format("Invoking method {0} at {1}",   input.MethodBase, DateTime.Now.ToLongTimeString())); 
            // Invoke the next behavior in the chain. 
            var result = getNext()(input, getNext); 
            // After invoking the method on the original target. 
            if (result.Exception != null) 
            { 
                WriteLog(String.Format("Method {0} threw exception {1} at {2}", input.MethodBase, result.Exception.Message, DateTime.Now.ToString())); 
            } 
            else 
            { 
                WriteLog(String.Format("Method {0} returned {1} at {2}", input.MethodBase, result.ReturnValue, DateTime.Now.ToString())); 
            } 
       
            return result; 
        }

        public IEnumerable<Type> GetRequiredInterfaces() {
            return Type.EmptyTypes; 
        }

        public bool WillExecute => true;

        private void WriteLog(string message) 
        { 
            Console.WriteLine("LOG:" + message); 
        } 
    }
}

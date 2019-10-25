using System;
using Algorithms_and_Structures.AOP;
using Algorithms_and_Structures.AOP.Workers;
using Algorithms_and_Structures.AOP.Works;
using Unity;
using Unity.Interception;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;

namespace Algorithms_and_Structures {
    class Program {
        static void Main(string[] args) {
            var conteiner = new UnityContainer();
            conteiner.AddNewExtension<Interception>();
            
            conteiner.RegisterType<IWork, Programming>(new Interceptor<InterfaceInterceptor>(), new InterceptionBehavior<LoggingAspect>());
            
            //var worker = new Worker(new Programming()); // without DI
            var worker = conteiner.Resolve<Worker>();
            
            Console.WriteLine(worker.Work()); 
            Console.ReadLine(); 
        }
    }
}

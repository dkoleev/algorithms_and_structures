using System;
using Algorithms_and_Structures.AOP;
using Algorithms_and_Structures.AOP.Workers;
using Algorithms_and_Structures.AOP.Works;
using Algorithms_and_Structures.SortingAlgorithms;
using Unity;
using Unity.Interception;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;

namespace Algorithms_and_Structures {
    class Program {
        static void Main(string[] args) {
            //TestAop();
           // TestBubbleSort();
           // TestMergeSort();
            TestQuickSort();
        }

        #region Sorting algorithms
        private static void TestBubbleSort() {
            var array = new int[] {5, 3, 4, 8, 2, 1};
            var res = BubbleSort.Sort(array);
            for (int i = 0; i < res.Length; i++) {
                Console.WriteLine(res[i]);
            }

        }
        
        private static void TestMergeSort() {
            var array = new int[] {5, 3, 4, 8, 2, 1};
            var res = MergeSort.Sort(array);
            for (int i = 0; i < res.Length; i++) {
                Console.WriteLine(res[i]);
            }

        }
        
        private static void TestQuickSort() {
            var array = new int[] {5, 3, 4, 8, 2, 1};
            var res = QuickSort.Sort(array);
            for (int i = 0; i < res.Length; i++) {
                Console.WriteLine(res[i]);
            }

        }
        #endregion

        private static void TestAop() {
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

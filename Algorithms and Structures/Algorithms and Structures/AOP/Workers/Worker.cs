using Algorithms_and_Structures.AOP.Works;

namespace Algorithms_and_Structures.AOP.Workers {
    public class Worker : IWorker {
        private IWork _work;

        public Worker(IWork work) {
            _work = work;
        }

        public string Work() {
            return _work.Start();
        }
    }
}

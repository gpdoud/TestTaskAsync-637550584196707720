using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestTaskAsync {
    class Program {

        void Run() {
            var t = Task.Run(() => CallApi());
            t.Wait();
        }
        void CallApi() {
            
        }
        static void Main(string[] args) {
            (new Program()).Run();
            Thread.Sleep(5000);
        }
    }
}

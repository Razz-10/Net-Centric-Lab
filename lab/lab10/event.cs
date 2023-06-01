using System;


namespace lab10
{
    public delegate void Notify();//delegate
    public class Process
    {
        public event Notify ProcessCompleted;//event

        public void startprocess()
        {
            Console.WriteLine("Process started");
            Console.WriteLine(".......continued");
            OnProcessCompleted();//raise an event
        }
        protected virtual void OnProcessCompleted()
        {
            //If ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();//"?>" is null conditionsl operator

        }
    }
    public class Demo
    {
        static void Main(string[] args) { 
        Process P1 = new Process();
            P1.ProcessCompleted += P1_ProcessCompleted;//register event
            P1.startprocess();
        }
        public static void P1_ProcessCompleted()
        {
            Console.WriteLine("\t Process completed");
            Console.WriteLine("\nQN(10F) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}

using System;


namespace Mankind
{
    class ManKind
    {
        static void Main(string[] args)
        {
            try
            {
                string[] studentData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student(studentData[0], studentData[1], studentData[2]);
                string[] workerData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Worker worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), int.Parse(workerData[3]));
                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

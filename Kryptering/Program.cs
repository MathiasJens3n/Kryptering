using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Kryptering
{
    internal class Program
    {
        List<uint> goodRndList = new List<uint>();
        List<int> badRndList = new List<int>();

        byte[] randomBytes = new byte[4];

        uint randomNumber;

        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GenerateRandomNumberBad();
            program.GenerateRandomNumberGood();
            //program.badRndList
            Console.WriteLine(Encrypter.Encrypt("TESTJGLKNALWJKNLFJLJWFAÅÅÅÅ"));
            Console.WriteLine(Encrypter.Decrypt("UFTUKHMLOBMXKLOMGKMKXGBAAAA"));

            //Action actionGenerateRandomNumberBad = program.GenerateRandomNumberBad;
            //Action actionGenerateRandomNumberGood = program.GenerateRandomNumberGood;

            //program.RunBenchmark(actionGenerateRandomNumberBad, "Bad Rnd Numbers");

            //program.RunBenchmark(actionGenerateRandomNumberGood, "Good Rnd Numbers");

            //Console.WriteLine("badRndList:\n");
            //foreach (var item in program.badRndList)
            //{
            //    Console.Write($"{item}, ");
            //}
            //Console.WriteLine("\ngoodRndList:\n");
            //foreach (var item in program.goodRndList)
            //{
            //    Console.Write($"{item}, ");
            //}

            Console.ReadKey();
        }

        public void GenerateRandomNumberGood()
        {
            RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();

            for (int i = 0; i < 9999; i++)
            {
                randomNumberGenerator.GetBytes(randomBytes);

                goodRndList.Add(randomNumber = BitConverter.ToUInt32(randomBytes, 0) %1000 );

            }
        }
        public void GenerateRandomNumberBad()
        {
            Random rnd = new Random();

            for (int i = 0; i < 9999; i++)
            {
                badRndList.Add(rnd.Next(0,999));
            }
        }
        private void RunBenchmark(Action benchmarkMethod, string methodName)
        {
            long startTime = DateTime.Now.Ticks;
            benchmarkMethod();
            long endTime = DateTime.Now.Ticks;
            long elapsedTime = endTime - startTime;
            Console.WriteLine($"{methodName} tid (ticks): {elapsedTime}");
        }
    }
}

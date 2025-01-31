using System.Reflection;

namespace BasicCalculator {
    static class Program {
        public delegate int MathOperation(int a, int b);

        public static void Main(string[] args) {
            MathOperation mathOperation = GetMathOperation();
            Console.WriteLine(mathOperation.GetMethodInfo().Name + "-Result: " + mathOperation(GetNumber(), GetNumber()));

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        private static MathOperation GetMathOperation() {
            Console.Write("Coose a math operation(1/2/3/4):  ");
            int chosenOperation = int.Parse(Console.ReadLine());
            switch(chosenOperation) {
                case 1: return Sum;
                case 2: return Subtract;
                case 3: return Multiply;
                case 4: return Divide;
            }

            return Sum;
        }

        private static int GetNumber() {
            Console.Write("Number: ");
            return int.Parse(Console.ReadLine());
        }


        private static int Sum(int a, int b) { return a+b; }
        private static int Subtract(int a, int b) { return a-b; }
        private static int Multiply(int a, int b) { return a*b; }
        private static int Divide(int a, int b) { return a/b; }
    }
}

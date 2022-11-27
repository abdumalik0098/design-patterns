using TemplateMethod.Lib;

Console.WriteLine("Hello, Template Method!");
double res;

TemplateMethodArray methodA = new ConcreteClassA();
res = methodA.OperationWithArray();
Console.WriteLine("\nResult A: " + res);

Console.WriteLine(new String('-',20));

TemplateMethodArray methodB = new ConcreteClassB();
res = methodB.OperationWithArray();
Console.WriteLine("\nResult B: " + res);
// See https://aka.ms/new-console-template for more information
using CSharp_1._0;

Console.WriteLine("Welcome to c# 1.0");

Console.WriteLine("Major features::");

Console.WriteLine("**Classes");

Console.WriteLine("**Structs");

Console.WriteLine("**Interfaces");

Console.WriteLine("**Events");

Console.WriteLine("**Properties");

Console.WriteLine("**Delegates");

Console.WriteLine("**Operators and expressions");

Console.WriteLine("**Statements");

Console.WriteLine("**Attributes");

Console.WriteLine("Class Example");

ClassExample classExample = new ClassExample();

classExample.Aboout();

Console.WriteLine("Defaul Full Name:" + classExample.FullName);

classExample.SetPrivateAttributes("Class", "Example");

Console.WriteLine(classExample.FullName);

Console.WriteLine("Struct Example");

StructureExample structExample = new StructureExample();

structExample.Aboout();

Console.WriteLine("Defaul Full Name:" + structExample.FullName);
structExample.StructEvent += StructExample_StructEvent;
structExample.SetPrivateAttributes("Struct", "Example");
Console.WriteLine(structExample.FullName);

void StructExample_StructEvent(string arg1, string arg2)
{
    Console.WriteLine("struct event example:" + arg1 + arg2);
}

Console.WriteLine("struct indexers example:");

structExample[0] = "Struct indexer";
structExample[1] = "Example";
Console.WriteLine(structExample.Names[0]+ structExample.Names[1]);

Console.WriteLine("Interface Example");

IInterfaceExample interfaceExample = new InterfaceExample();

interfaceExample.Aboout();

interfaceExample.SetPrivateAttributes("Struct", "Example");

Console.WriteLine(interfaceExample.FullName);


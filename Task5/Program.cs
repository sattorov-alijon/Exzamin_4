var stack1=new Stack<int> ();
stack1.Push(25);
stack1.Push(70);
stack1.Push(2);
stack1.Push(39);
foreach (var item in stack1)
{
    System.Console.Write(item+" ");
}
System.Console.WriteLine();
System.Console.WriteLine(stack1.Pop());//Okhiron elementa mebrora va udalit mekunad
System.Console.WriteLine(stack1.Peek());//Okhiron elementa mebrora

System.Console.WriteLine();
System.Console.WriteLine("---------------");
System.Console.WriteLine();
var stack2=new Stack<string>();
stack2.Push("Alijon");
stack2.Push("Mansur");
stack2.Push("Yusuf");
stack2.Push("Alisho");
foreach (var item in stack2)
{
    System.Console.Write(item+" ");
}
System.Console.WriteLine();
System.Console.WriteLine(stack2.Pop());//Okhiron elementa mebrora va udalit mekunad
System.Console.WriteLine(stack2.Peek());//Okhiron elementa mebrora

var list = new MyLinkedList<string>();
list.AddToFront("aaa");
list.AddToFront("bbb");
list.AddToFront("ccc");
list.AddToFront("ddd");
list.AddToFront("eee");

foreach (var item in list)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("Counts = " + list.Count);

System.Console.WriteLine("Press any key to exit...");
Console.ReadKey();
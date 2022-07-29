using System.Reflection;
using Task_002;

Assembly? a = null;
TemperatureConverter tc = new TemperatureConverter();
Type? t = tc.GetType();

try
{
    a = Assembly.LoadFrom(@"C:\Users\Admin\Desktop\Pro\Home_006\Task_002\bin\Debug\net6.0\Task_002");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

DisplayInfo(a);
ListMethods(t);
ListFields(t);
ListProps(t);
ListInterfaces(t);

static void DisplayInfo(Assembly a)
{
    Console.WriteLine($"Assembly Name : {a.GetName().Name}");
    Console.WriteLine($"Assembly Version : {a.GetName().Version}");
    Console.WriteLine($"Assembly Culture : {a.GetName()?.CultureInfo?.DisplayName}");
    Console.WriteLine("");
}

static void ListMethods(Type t)
{
    MethodInfo[] mi = t.GetMethods();
    foreach (var item in mi)
    {
        Console.WriteLine(item.Name);
    }
    Console.WriteLine("");
}

static void ListFields(Type t)
{
    var fieldNames = from p in t.GetFields() select p.Name;

    foreach (var item in fieldNames)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("");
}

static void ListProps(Type t)
{
    var propsFields = from p in t.GetProperties() select p.Name;

    foreach (var item in propsFields)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("");
}

static void ListInterfaces(Type t)
{
    var iFaces = from p in t.GetInterfaces() select p.Name;

    foreach (var item in iFaces)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("");
}
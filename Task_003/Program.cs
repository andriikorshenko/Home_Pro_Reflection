using System.Reflection;

Assembly? a = null;

try
{
    a = Assembly.LoadFrom(@"C:\Users\Admin\Desktop\Pro\Home_006\Task_002\bin\Debug\net6.0\Task_002.dll");
}
catch(FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

if (a != null)
{
    CreateUsingLastBind(a);
}

static void CreateUsingLastBind(Assembly a)
{
    try
    {
        // Получаем метаданные для типа TemperatureConverter.
        Type? temperatureConverter = a.GetType("Task_002.TemperatureConverter");

        // Создать экземпляр TemperatureConverter на лету. 
        dynamic? instance = Activator.CreateInstance(temperatureConverter!);

        instance!.ConvertFromCelsiusToKelvin(30);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
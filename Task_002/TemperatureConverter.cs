namespace Task_002
{
    [MyCustom("A very good app!")]
    public class TemperatureConverter : IDisposable
    {
        [MyCustom("This is a field")]
        public const float KELVIN = 273.15f;

        public int TestProp { get; set; }

        [MyCustom("This is a method")]
        public void ConvertFromCelsiusToKelvin(float celsius)
        {
            float result = 273.15f + celsius;
            Console.WriteLine($"We've converted {celsius}C to {result}K");
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

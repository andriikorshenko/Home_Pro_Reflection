namespace Task_002
{
    internal sealed class MyCustomAttribute : Attribute
    {
        public string Description { get; set; }

        public MyCustomAttribute(string description)
        {
            Description = description;
        }
        public MyCustomAttribute()
        {

        }
    }
}

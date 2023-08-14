
namespace AlısverisSepetiMvc.Shared
{
    public static class EnvorinmentClass
    {
        public static IWebHostEnvironment _environment;

        public static void Invoke(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
    }
}

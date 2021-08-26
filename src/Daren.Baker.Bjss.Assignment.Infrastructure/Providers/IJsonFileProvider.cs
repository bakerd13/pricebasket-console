namespace Daren.Baker.Bjss.Assignment.Infrastructure.Providers
{
    internal interface IJsonFileProvider<T>
    {
        T Get(string file, string section);
    }
}

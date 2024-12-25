using System.Text;
namespace Flower.Utilities
{
    public class Function
    {
        public static string? TittleGenerationAlias(string tittle)
        {
            return SlugGenerator.SlugGenerator.GenerateSlug(tittle);
        }
    }
}

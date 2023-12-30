using NanoidDotNet;

namespace LivrariaOnline.Backend.Infra.Utils;

public class IdGenerator
{
    public readonly static int ID_SIZE = 21;

    public static string GenerateId()
      => Nanoid.Generate(size: ID_SIZE);
}

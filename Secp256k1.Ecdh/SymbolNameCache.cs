using System.Reflection;

namespace Secp256k1Ecdh
{
    static class SymbolNameCache<TDelegate>
    {
        public static readonly string SymbolName;

        static SymbolNameCache()
        {
            SymbolName = typeof(TDelegate).GetCustomAttribute<SymbolNameAttribute>().Name;
        }
    }


}
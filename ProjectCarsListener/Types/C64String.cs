using System.Runtime.InteropServices;

namespace ProjectCarsListener.Types
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct C64String
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string Value;

        public static implicit operator string(C64String source)
        {
            return source.Value;
        }

        public static implicit operator C64String(string source)
        {
            return new C64String { Value = source };
        }
    }
}
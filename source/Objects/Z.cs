using System;

namespace Draw.Objects
{
    public class Z : ILetter
    {
        private readonly int _size;

        public Z() { }
        public Z(int size)
        {
            _size = size;
        }
        public void Draw()
        {
            var len = _size - 1;
            for (var row = 0; row < _size; row++)
            {
                for (var col = 0; col <= len; col++)
                {
                    if (row == 0 || row == len)
                    {
                        Console.Write("*");
                        continue;
                    }

                    Console.Write(col == len - row ? "*" : " ");
                }
                Console.Write("\n");
            }

        }
    }
}

using System;

namespace Draw.Objects
{
    public class X : ILetter
    {
        private readonly int _size;
        public X() { }

        public X(int size)
        {
            _size = size;
        }
        public void Draw()
        {
            for (var row = 0; row < _size; row++)
            {
                var maxcol = _size - 1;
                for (var col = 0; col <= maxcol; col++)
                {
                    Console.Write(col == row || col == maxcol - row ? "*" : " ");
                }
                Console.Write("\n");
            }
        }
    }
}

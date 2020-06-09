using System;

namespace Draw.Objects
{
    public class Y : ILetter
    {
        private readonly int _size;
        public Y() { }

        public Y(int size)
        {
            _size = size;
        }
        public void Draw()
        {
            var mid = _size / 2;
            for (var row = 0; row < _size; row++)
            {
                var maxcol = _size - 1;
                for (var col = 0; col <= maxcol; col++)
                {
                    if (row <= mid)
                    {
                        if (col == row || col == maxcol - row)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.Write(row > mid && col == mid ? "*" : " ");
                }
                Console.Write("\n");
            }
        }
    }
}

using System;

namespace Draw.Objects
{
    public class O : ILetter
    {
        private readonly int _size;

        public O() { }
        public O(int size)
        {
            _size = size;
        }

        public void Draw()
        {
            for (var row = 0; row < _size; row++)
            {
                for (var col = 0; col < _size; col++)
                {
                    if (row == 0 || row == _size - 1)
                    {
                        Console.Write(col > 0 && col < _size - 1 ? "*" : " ");
                    }
                    else
                    {
                        Console.Write(col == 0 || col == _size - 1 ? "*" : " ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}

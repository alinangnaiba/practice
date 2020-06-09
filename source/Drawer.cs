using Draw.Objects;

namespace Draw
{
    public class Drawer
    {
        public void Draw(string letter, int size)
        {
            switch (letter)
            {
                case Letters.O:
                    var o = Letter.Create<O>(size);
                    o.Draw();
                    break;
                case Letters.X:
                    var x = Letter.Create<X>(size);
                    x.Draw();
                    break;
                case Letters.Y:
                    var y = Letter.Create<Y>(size);
                    y.Draw();
                    break;
                default:
                    var z = Letter.Create<Z>(size);
                    z.Draw();
                    break;
            }
        }
    }
}

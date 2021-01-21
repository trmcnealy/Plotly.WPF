
namespace Plotly
{
    public static class Utilities
    {
        public static object[][] BuildColorscale(double min, double max, params Color[] colors)
        {
            double step = (max - min) / (colors.Length - 1);

            object[][] array = new object[colors.Length][];

            for (int i = 0; i < colors.Length; ++i)
            {
                array[i] = new object[]
                {
                    min + step * i,
                    colors[i].ToString()
                };
            }

            return array;
        }
    }
}
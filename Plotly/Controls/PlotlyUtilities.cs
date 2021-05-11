namespace Plotly
{
    public static class Utilities
    {
        public static ColorScaleEntry[] BuildColorscale(double         min,
                                                        double         max,
                                                        params Color[] colors)
        {
            double step = (max - min) / (colors.Length - 1);

            ColorScaleEntry[] array = new ColorScaleEntry[colors.Length];

            for(int i = 0; i < colors.Length; ++i)
            {
                array[i] = new ColorScaleEntry(min + step * i, colors[i]);
            }

            return array;
        }
    }
}

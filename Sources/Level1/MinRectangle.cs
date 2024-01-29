class MinRectangle
{
    public int Solution(int[,] sizes)
    {
        int maxWidth = 0;
        int maxHeight = 0;
        int width = 0;
        int height = 0;

        for(var i = 0; i < sizes.GetLength(0); i++)
        {
            width = sizes[i, 0] > sizes[i, 1] ? sizes[i, 0] : sizes[i, 1];
            height = sizes[i, 0] > sizes[i, 1] ? sizes[i, 1] : sizes[i, 0];

            maxWidth = maxWidth < width ? width : maxWidth;
            maxHeight = maxHeight < height ? height : maxHeight;
        }

        return maxWidth * maxHeight;
    }
}

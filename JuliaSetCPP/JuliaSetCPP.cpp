// Kod C++ dla biblioteki DLL
#include "pch.h"

extern "C"
{
    __declspec(dllexport) void GenerateJuliaSet(int width, int height, int maxIter, double realPart, double imgPart, float zoom, int* output)
    {
        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                double zx = 1.5 * (x - width / 2.0) / (0.5 * width * zoom);
                double zy = (y - height / 2.0) / (0.5 * height * zoom);
                int iter = maxIter;
                while (zx * zx + zy * zy < 4 && iter > 0)
                {
                    double tmp = zx * zx - zy * zy + realPart;
                    zy = 2.0 * zx * zy + imgPart;
                    zx = tmp;
                    --iter;
                }
                output[y * width + x] = iter;
            }
        }
    }
}
# JuliaSetGenerator
This project is a Julia fractal visualizer, written in C# and utilizing DLL libraries written in C++ and Assembly. The user can choose which DLL library (C++ or Assembly) to use for generating the fractals.

The project consists of a user interface that allows for manipulation of fractal parameters such as the number of iterations, the real and imaginary part of the complex number, as well as the choice of color schemes.

Additionally, the project includes zooming of the generated fractal image and selecting the color scheme.

The time taken to generate the fractal is measured and displayed for each of the DLL libraries, allowing for a comparison of the performance of the C++ and Assembly implementations.

The source code of the project is well-commented (in Polish), making it easier to understand how the program works.


## Example of use: 

![image](https://github.com/rosarz/JuliaSetGenerator/assets/40793013/c3f2c2bb-5a96-46ff-a4c6-29169cedfe1b)

![image](https://github.com/rosarz/JuliaSetGenerator/assets/40793013/d683811a-274d-4858-a104-d590ef65fc96)


## **What to remember:**
- Assembly code doesn't support window resize but C++ dll does also like the zoom function
- Codebase doesn't support multithread even if there is a textBox for it
- There is base set a variables in Windows Forms like number of iterations, x0 or y0 that you can easily change in user interface 
- Comments are in Polish language so if you need an English translation just put the code into ChatGPT, Copilot etc. 

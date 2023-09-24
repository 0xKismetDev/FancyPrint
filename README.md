# FancyPrint
Simple C# Lib too match my Printing across projects.


## Usage 

> ⚠ Import Library in VisualStudio by right-clicking on your solution and going to Add -> Project Reference -> Browse, find the dll, and done.

```c#
using FancyPrint; // import library

fPrint.Info("Hi!"); // Info
fPrint.Okay("Success!"); // Okay/Success (Green)
fPrint.Error("Oops!"); // Error (Red)
fPrint.Warn("Watch out!"); // Warning (Yellow)
```

The above example will output:
![image](https://github.com/0xKismetDev/FancyPrint/assets/131729061/64d9dfd8-f314-4aa5-b4a7-7a8c61127d46)



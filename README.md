# SIFT-Demo

Build Instructions:
1. Download the OpenCV C# wrapper from https://sourceforge.net/projects/emgucv/files/latest/download
2. Install the OpenCV Wrapper.
3. Once Installed, Goto C:\Emgu\emgucv-windesktop 3.4.1.2976\bin\x64 or the location that emgu was installed to and copy the .DLLs to the Lib folder in SIFT-Demo
4. Open the project in Visual Studio 2017
5. Change the Target platform of the solution to x64
6. Goto the Lib folder in SIFT-Demo and add the Emgu.CV.UI.dll and Emgu.CV.World.dll to the references of the project
7. Build the application
8. You should now be able to run the application in 64 bit

NOTE** THIS APPLICATION WILL NOT RUN WHEN BUILDING THE APPLICATION IN 32BIT. 
IT WILL ONLY WORK WHEN BUILT WITH 64BIT.

If you have any issues installing the application, please visit: http://www.emgu.com/wiki/index.php/Download_And_Installation

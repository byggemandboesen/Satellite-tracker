# Satellite-tracker
Program for interacting with satellite TLE and mapping/predicting satellite locations

To use the program, run the python program first and then the C# second. I have yet to figure out why pyinstaller can't create an executable file, which the C# program could execute automatically.

Please do note that you need a wifi connection for running the "tracking" part of the program. An offline solution may be added to future releases.

The TLE will be downloaded into the folder you give the directory for. That means the program doesn't create a separate folder to store the TLE files.

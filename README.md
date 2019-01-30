# C# .Net Muse Monitor OSC Receiver Example by James Clutterbuck

This code sample is to demonstrate streaming live OSC brainwave data from Muse Monitor (connected to a Muse device), to a PC program, which can then process and work with the brainwave data.

This example displays the data in a live stream to the display.

It was build with Microsoft Visual Studio 2015, but will be compatible with later versions.

## Requirements
* [Sharp OSC](https://github.com/ValdemarOrn/SharpOSC) (v0.1.1.0 DLL included)
* Microsoft ILMerge - This is used in the post build to merge the SharpOSC.DLL into the main EXE. This makes a single EXE with no dependencies, which is nice to have, but not strictly necessary.

## Notes
The OSC specification for Muse Monitor is available here: [MuseMonitor.com/FAQ.php#oscspec](https://musemonitor.com/FAQ.php#oscspec)

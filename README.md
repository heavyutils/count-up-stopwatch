# Count-Up Stopwatch
A minimal stopwatch for speedruns and the like.

## Introduction
WELCOME TO COUNT-UP STOPWATCH! - 
This is an extremely simple stopwatch, with military-grade tracking of elapsed time, down to milliseconds. There are zero unnecessary interfaces, only the clock, and, if enabled, timer start delay UI. There are no buttons though; you will rely on hotkeys. The keys are mapped similar to many game layouts, for compact and easy access. You can also use the new context menu by right-clicking it, if you prefer.


BASIC CONTROLS - 
	Space: Startnstop timer,
	E: Startnstop timer,
	R: Reset timer,
	Mouse Button Hold: Drag window around,
	Alt+F4: Close window.


DETAILED VIEW - SHOWS FRACTIONS OF SECOND INSTEAD OF HOURS - 
	Q: Toggle detailed view (default on)
 
You can see if detailed view is on by checking whether the decimal
point is there. You can't use detailed view if an hour has elapsed.


TIMER START COUNTDOWNS - DELAY THE START OF THE STOPWATCH - 
	0: Set timer start countdown to 0S,
	1: Set timer start countdown to 1S,
	2: Set timer start countdown to 2S,
	3: Set timer start countdown to 3S,
	4: Set timer start countdown to 4S,
	5: Set timer start countdown to 5S,
	6: Set timer start countdown to 6S,
	7: Set timer start countdown to 7S,
	8: Set timer start countdown to 8S,
	9: Set timer start countdown to 9S.
 
The start countdown timer doesn't use military-grade time tracking,
because it's too resource hungry to have multiple running. Therefore
it is not recommended to use this feature where 100% time tracking
accuracy is important. This may or may not change in the future.


POSITION - SNAP THE TIMER - 
	W: Set timer position to top,
	S: Set timer position to bottom,
	A+W: Set timer position to top-left,
	W+D: Set timer position to top-right,
	A+S: Set timer position to bottom-left,
	S+D: Set timer position to bottom-right.
 
These hotkeys can quickly change the timer's position, without using
a mouse. The keys might be slow to respond, to allow for diagonals.

## Downloading source and editing for absolute beginners
**You don't need to do this to download normally. If you're just a normal users, head to the [releases](http://github.com/heavyutils/count-up-stopwatch/releases) page.**
1. Download and install Visual Studio 2022. Visual Studio 2019 is also usable.
2. Head to the top of this page, and click the "Code" button.
3. Click "Download ZIP".
4. Extract that ZIP file a place you remember.
5. Go inside the folder you just extracted, and look for "count_up.sln".
6. Double-click it, or right click, select "Open With...", then choose "Visual Studio 2022" or another Visual Studio.
7. Wait for the project to load.
8. Make your desired changes, if any.
9. Click "Start Without Debugging", the green hollow play button, or press Ctrl+F5.
10. Alternatively, if you want debugging enabled, you can simply click "Start".
11. It should build without errors.
12. The count-up stopwatch should appear after the build.

### Compiler errors or problems? Try these fixes
There might occur errors if:
1. Make sure that .NET 4.8 is installed together with Visual Studio. You can try converting it to the closest version of .NET newer than .NET 4.8, if that version isn’t installed. Otherwise, you can download and install .NET 4.8 on the linked .NET website.
2. Make sure to actually open the solution, and not the project files. Visual Studio doesn’t find the solution if you don’t open the solution.
3. Make sure that you’re opening it with Visual Studio and not another editor.
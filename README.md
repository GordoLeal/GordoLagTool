# GordoLagTool

This tool forces "Lag" by changing the game limit FPS value from the memory.

At first it has intended to be used with Battle For Bikini Bottom: Rehydrated but since the version 2.0 in preparation for "SpongeBob: Cosmic Shake" and other speedrun community requests for support, you can create a .game file (a basic .json/.txt file) and make it work for your UE4 game. 

it uses the windows api functions ReadMemory and WriteMemory to change the limit fps values inside the game, the same way you would lag by click/dragging the window top.

To make it work for your game, you can find a .game file made by other runners, just ask on the game speedrun community (if they allow the use of this tool) or you can add support by yourself.

How to create a .game file:
https://youtu.be/4r5ZPHJPSEw

## OS Support

Currently the tool only works with:

Windows x64 (.net Core/runtime 4.7 or above)

### Credits
Made By [Pedro "Gordo" Leal](https://twitter.com/OGordoLeal)

Inspired by [HatLag](https://github.com/doesthisusername/hatutils). 

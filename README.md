# GordoLagTool

This tool forces "Lag" by changing the game limit FPS value from the memory.
at first it has intended to be used with Battle For Bikini Bottom: Rehydrated but since the version 2.0 you can create a .game file (a basic .json/.txt file) and make it work for your UE4 game. 

it uses the windows api functions ReadMemory and WriteMemory to change the limit fps values inside the game, the same way you would lag by click/dragging the window top.

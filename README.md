#FFX Monster Randomizer

This is a Monster randomizer for FFX! This is currently only capable of shuffling fights around(and not the monsters themselves).

##Things to Note

Before you dive into randomizing, there's a few things that you must know.

1. Only the Monster Arena and Dark Aeons are currently able to be randomized.
2. Shinryu and Ultima Buster cannot be randomized, as they cause crashes/soft locks(looking into why this is).
3. This is currently experimental and known crashes/soft locks can happen. Save before attempting any fights you shuffle!
4. You are required to use VBF Browser for extracting the files and re-inserting them.
5. Generate the seed file when making your first few randomizers, as you can run into a crash in Monster Arena or when running into a Dark Aeon fight.
6. If you run into a crash or soft lock, open an issue and provide the 'seed.txt' that was generated.

###What You Will Need

1. VBF Browser(I used version 3.2.0.5) - This can be found on NexusMods under Final Fantasy 12's mod section.
2. A way to read .EXE files. This was made originally on a Windows computer, but can be compiled for other machines I'm sure(if not then I can look into it).
3. This program. Just click the 'Code' button just above and make sure to download as .zip and extract it where you want on your PC. Run the .EXE to use it.

####The Steps

1. Open up VBF Browser and navigate to the following folder path~ \ffx_ps2\ffx\master\jppc\battle\
2. Extract the entirety of the 'btl' folder and place that in the 'Input' folder. An example path should be '\Input\btl\zzzz03_00\zzzz03_00.bin'
3. Open up the randomizer and select your options and randomize to your liking.
4. Once randomization is complete, open the VBF Browser to the main directory(the first folder) and open the 'Output' folder.
5. Drag the folder 'ffx_ps2' on the right side of the VBF Browser window(make sure the folder with the same name is on the right side of the window. This will merge them properly).
 - Alternatively, you can click the 'Insert' button and then click yes(we're using a whole folder), then select the ffx_ps2 folder and hit OK.
6. Wait till the process is done(a small window will pop-up and click ok). Open FFX and enjoy.
 
#####Reverting the Changes/Fixing the Changes for Fresh Randomization

1. Open up VBF Browser and navigate to the following folder path~ \ffx_ps2\ffx\master\jppc\battle\
2. Drag your 'btl' folder you extracted from randomizing the first time, into the VBF Browser on the right side of the window(or use the 'Insert' button and follow the steps there).
3. When this is done, the randomization process was reverted to vanilla state, fixing any missed randomzation fixes from different options.
 - This means if you only shuffled Dark Aeons around, then decided to randomize only Monster Arena fights, the Dark Aeons will still be shuffled as it was before.

####About the Randomizer

This randomizer is still in the works and may be included in my FFX Randomizer Pack in the future, but only when this is fully done and most crashes are resolved.
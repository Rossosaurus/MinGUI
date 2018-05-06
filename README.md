# MinGUI: A GUI for MinGW the minimialist GNU for Windows
### MinGUI is a compact, lightweight and portable compiler for any language supported by MinGW32. More languages and compilers may be added in the future but for now C and C++ are the only languages fully supported.
![Img](https://imgur.com/qbfPxGW.png)
## How to use
#### To compile a file:
![Img](https://imgur.com/ltg8YNr.png)
##### 1. Right click or enter the source files location into the first input
##### 2. Right click or enter the location including file name of the exe that will be output to
##### 3. Select gcc (the only compiler from the drop down box)
##### 4. Select which method you wish to build the source with, currently "Build and Output to exe" is the only fullproof method
##### 5. Select the desired libraries that you wish to use
##### 6. Select Build and an executable of your source should be output to the chosen location.
#
#### To add a library:
![Img](https://imgur.com/DVwZQcj.png)
![Img](https://imgur.com/o7mUFYA.png)
##### 1. Manual
#
    a. Type the libraries name
    b. Right click or enter the libraries include folder location
	c. Right click or enter the libraries bin folder location
	d. Right click or enter the libraries lib folder location
	e. Enter the syntax for the library, this can be more than one condition as some libraries require more than one, however be sure they are entered in the correct order. This input must also contain the "-" character before the condition
	f. Click "Add Library"
	g. If you have copied all the required folders manually, you only need to enter the libraries name and syntax
##### 2. MinGW Install Manager
#
    a. Click on the MinGW32 icon and install the library or other dependancy from there
	b. Enter the library name and syntax is you need to
#
#### To remove a library simply right click on the library and select delete

# More features to come...
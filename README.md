# RecieveDataFromSerialConnection
![thumb](https://github.com/minfaox3/RecieveDataFromSerialConnection/blob/master/thumb.png?raw=true)

## Description
This is an application that can receive strings via serial communication, display "X,Y,Z" formatted items as graphs, and save them as images.  
I hope this will be helpful for those who want to do serial communication in C#.  

## Supported Languages
| Language | README |
| -- | -- |
| English | here |
| 日本語 | 準備中 |
| 中文 | 准备中 |

## Dependences
OS：Windows  
Develop Language：C#  
Framework：.NET Framework 4.8  
Build with Microsoft Visual Studio Community 2022.  

## Usage
Simply follow the text displayed on each button in the screen.  

### How to connect
A list of connected devices will appear in a drop-down box, from which you select the device you wish to connect.  
※Set DTR and baud rate as needed. Depends on device.  
The list of connected devices can be updated from "Reload Devices" in "SerialCommunication" at the top of the window.  

### Receive string
Press the "connect" button to start reception.  
The received string is displayed in real time in the lower text box.  
The "clear" button(left side) deletes the contents of the text box, and the "CopyText" button copies the contents of the text box to the clipboard.  
Check "SetEditable" to make the text box editable.  

### Draw graph
If a string in the format "X,Y,Z" is received, it will be displayed in the graph.  
The amount of data to be drawn is set by "X-Range".   
※This X has nothing to do with the X in the screen.  
If the graph is not drawn, check if "Draw Graph" in "SerialCommunication" at the top of the screen is turned on.  
  
The various buttons below the graph allow you to clear, copy, and save the graph.  
Image files can be saved as "PNG", "JPEG", "BMP" or "GIF".  

### Environment settings
The language and "X,Y,Z" delimiter (default is ",") can be specified in "Environment Settings" in "File" at the top of the screen.  

## LICENSE
[MIT](https://github.com/minfaox3/RecieveDataFromSerialConnection/blob/master/LICENSE.txt)
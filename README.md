# RTF_to_PNG
It works and is a high quality output. It should also be same size in terms of pixel count as the RTF (C#) so will fit on a page. 

So, this code is in no way pretty - it was a quick make for a single purpose. This was rough to get this to work due to the background not being seethrough and when it was it caused fuzzy edges and broken text. This is now a working version and needs some serious code cleanup. The main file is the https://github.com/Rubicen/RTF_to_PNG/blob/master/RTFtoJPEG/TextBoxDrawer.cs file. It is basically the guts of it. 

Customizing it is a chore, but can change the stuff in Program.cs to try get different widths, the stuff I set keeps it pretty much the same as a generic rtf file but I wanted it the same as another apps RTF width thus 555 was picked in the Program file. 
Good luck :D

# RTF_to_PNG
Yeah, its odd but it works and is high quality output. It should also be same size in terms of pixel count as the RTF so will fit on a page. 

So, this code is in no way pretty. This was 2-3 days of pain to get this to work due to the background not being seethrough and when it was it caused fuzzy edges and broken text. This is now a working version and needs some serious code cleanup. The main file is the https://github.com/Rubicen/RTF_to_PNG/blob/master/RTFtoJPEG/TextBoxDrawer.cs file. It is basically the guts of it. 

Customizing it is a chore, but can change the stuff in Program.cs to try get different widths, the stuff i set keeps it pretty much the same as a generic rtf file but I wanted it the same as another apps RTF width thus 555 was picked in the Program file. Probably best to just trial and error, I don't have the ability to understand it in full anymore, been too long.

Good luck :D

# RTF_to_PNG
Yeah, its odd but it works and is high quality output. It should also be same size in terms of pixel count as the RTF so will fit on a page. 

So, this code is in no way pretty. This was 2-3 days of pain to get this to work due to the background not being seethrough and when it was it caused fuzzy edges and broken text. This is now a working version and needs some serious code cleanup. The main file is the https://github.com/Rubicen/RTF_to_PNG/blob/master/RTFtoJPEG/TextBoxDrawer.cs file. It is basically the guts of it. 

Customizing it is a chore, but can change the stuff in Program.cs to try get different widths, the stuff i set keeps it pretty much the same as a generic rtf file but i had a requirement to keep it the same layout as a rtf box in another app so 555 was used for the RTF width in c# which changes the output. 

Good luck :D

run:
	csc picmaker.cs
	mono picmaker.exe
	convert image.ppm image.png

clean:
	-rm -f *.ppm *.png *.exe

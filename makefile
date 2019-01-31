run:
	csc picmaker.cs
	mono picmaker.exe

clean:
	-rm -f *.ppm *.png *.exe

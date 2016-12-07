module module1
	dim a, b, c as integer
	sub main
		console.writeline("Welcome to Muhammad Sreywel's quadratic equation solver [version 1.3.1]")
		console.writeline("Please make sure that the equation you want to solve is in the form { ax^2 + bx + c = 0 } before you start.")
		console.writeline("press enter to start...".toupper)
		console.readline()
		solve
	end sub
	sub solve
		try
			console.write("a: ")
			a=console.readline()
			console.write("b: ")
			b=console.readline()
			console.write("c: ")
			c=console.readline()
		catch n as exception
			console.writeline("Please use decimal numbers only..")
			solve
		end try
		dim d as single = (b*b)-(4*a*c)
		if a=0
			console.write("x = " & cstr(-c/b))
		elseif d=0
			console.write("x = " & cstr(-b/2/a))
		elseif d<0
			console.write("x is not a real number")
		else
			console.writeline("x1 = "+cstr((math.Sqrt(d)-b)/(2*a)))
			console.writeline("x2 = "+cstr((-b-math.sqrt(d))/(2*a)))
		end if
		console.readline()
	end sub
end module
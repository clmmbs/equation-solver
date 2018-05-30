module module1
	dim a, b, c as integer
	Sub main
		console.writeline("Welcome to Muhammad Sreywel's quadratic equation solver [version 2.5.0]")
		console.writeline("Please make sure that the equation you want to solve is in the form { ax^2 + bx + c = 0 } before you start.")
		console.writeline("press enter to start...".toupper)
		console.readline()
		solve
	end sub
	Sub solve
		Dim ans As String=""
		Do
			Try
				console.write("a: ")
				a=console.readline()
				console.write("b: ")
				b=console.readline()
				console.write("c: ")
				c=console.readline()
			Catch n As exception
				console.writeline("Please use decimal numbers only..")
				solve
			End Try
			Dim d As Single = (b*b)-(4*a*c)
			If a=0
				console.write("x = " & CStr(-c/b))
			ElseIf d=0
				console.write("x = " & CStr(-b/2/a))
			ElseIf d<0
				console.writeline("x1 = "+CStr((math.Sqrt(math.abs(d))-b)/(2*a))+"i")
				console.writeline("x2 = "+CStr((-b-math.sqrt(math.abs(d)))/(2*a))+"i")
			Else
				console.writeline("x1 = "+CStr((math.Sqrt(d)-b)/(2*a)))
				console.writeline("x2 = "+CStr((-b-math.sqrt(d))/(2*a)))
			End If
			console.writeline()
			console.write("Do you want to solve another equation?(y/n)")
			ans = console.readline()
		Loop While ans.tolower="y"
	end sub
end module
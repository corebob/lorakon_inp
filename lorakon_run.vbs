﻿
function Execute(Dsc,Phase)	

	On Error Resume Next
	
    ' CREATE FILESYSTEM AND SCRIPTING OBJECTS
	set csh = CreateObject("WScript.Shell")
	set fso = CreateObject("Scripting.FileSystemObject")

    ' GET GENIE2K PATH FROM REGISTRY
	geniePath = csh.RegRead("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Canberra Industries, Inc.\Genie-2000 Environment\GENIE2K")

    ' CREATE ENVIRONMENT
	if not fso.FolderExists(geniePath & "Lorakon") then
		fso.CreateFolder(geniePath & "Lorakon")
	end if
    if not fso.FolderExists(geniePath & "Lorakon\System") then
		fso.CreateFolder(geniePath & "Lorakon\System")
	end if
  
	paramFile = geniePath & "Lorakon\System\input-params.txt"	

    ' CHECK IF DATA SOURCE IS A DETECTOR (NOT FILE)
	isDet = False
	If InStr(Dsc.Information(7), "DET:") = 1 Then
		isDet = True
	End If
	
    ' SKRIV DATA SOURCE VERDIER TIL INPUT FIL
	set f = fso.OpenTextFile(paramFile, 2, True)
	
	lab = Dsc.Parameter(CAM_T_SSPRSTR1) ' LABORATORIUM
	If IsNull(lab) or IsEmpty(lab) Then
		f.WriteLine ""
	Else
		f.WriteLine lab
	End If
		
	pt = Dsc.Parameter(CAM_T_SCOLLNAME) ' OPERATØR
	If IsNull(pt) or IsEmpty(pt) Then
		f.WriteLine ""
	Else
		f.WriteLine pt
	End If
	
	title = Dsc.Parameter(CAM_T_STITLE) ' PROSJEKT
	If IsNull(title) or IsEmpty(title) Then
		f.WriteLine ""
	Else
		f.WriteLine title
	End If
	
	samptype = Dsc.Parameter(CAM_T_SUCSTRING1) ' PRØVETYPE
	If IsNull(samptype) or IsEmpty(samptype) Then
		f.WriteLine ""
	Else
		f.WriteLine samptype
	End If
		
	pc = Dsc.Parameter(CAM_T_SUCSTRING2) ' PRØVE KOMPONENT
	If IsNull(pc) or IsEmpty(pc) Then
		f.WriteLine ""
	Else
		f.WriteLine pc
	End If
	
	If isDet Then
		f.WriteLine ""
	Else
		id = Dsc.Parameter(CAM_T_SIDENT) ' PRØVE ID
		If IsNull(id) or IsEmpty(id) Then
			f.WriteLine ""
		Else
			f.WriteLine id
		End If		
	End If
		
	comm = Dsc.Parameter(CAM_T_SUCSTRING3) ' FYLKE / KOMMUNE
	If IsNull(comm) or IsEmpty(comm) Then
		f.WriteLine ""
	Else
		f.WriteLine comm
	End If
	
	lat = Dsc.Parameter(CAM_G_SGPSLATITUDE) ' BREDDEGRAD
	If IsNull(lat) or IsEmpty(lat) Then
		f.WriteLine ""
	Else
		f.WriteLine CStr(lat)
	End If
		
	lon = Dsc.Parameter(CAM_G_SGPSLONGITUD) ' LENGDEGRAD
	If IsNull(lon) or IsEmpty(lon) Then
		f.WriteLine ""
	Else
		f.WriteLine CStr(lon)
	End If
		
	alt = Dsc.Parameter(CAM_G_SGPSALTITUDE) ' METER OVER HAVET
	If IsNull(alt) or IsEmpty(alt) Then
		f.WriteLine ""
	Else
		f.WriteLine CStr(alt)
	End If
	
	loctype = Dsc.Parameter(CAM_T_SUCSTRING10) ' LOKASJONSTYPE
	If IsNull(loctype) or IsEmpty(loctype) Then
		f.WriteLine ""
	Else
		f.WriteLine loctype
	End If
	
	loc = Dsc.Parameter(CAM_T_SUCSTRING9) ' LOKASJON
	If IsNull(loc) or IsEmpty(loc) Then
		f.WriteLine ""
	Else
		f.WriteLine loc
	End If
	
	If isDet Then
		f.WriteLine ""
	Else
		quant = Dsc.Parameter(CAM_F_SQUANT) ' PRØVEMENGDE
		If IsNull(quant) or IsEmpty(quant) Then
			f.WriteLine ""
		Else
			f.WriteLine CStr(quant)
		End If		
	End If
	
	If isDet Then
		f.WriteLine ""
	Else		
		quanterr = Dsc.Parameter(CAM_F_SQUANTERR) ' PRØVEMENGDE ERROR
		If IsNull(quanterr) or IsEmpty(quanterr) Then
			f.WriteLine ""
		Else
			f.WriteLine CStr(quanterr)
		End If		
	End If
	
	If isDet Then
		f.WriteLine ""
	Else		
		unit = Dsc.Parameter(CAM_T_SUNITS) ' PRØVE ENHET
		If IsNull(unit) or IsEmpty(unit) Then
			f.WriteLine ""
		Else
			f.WriteLine unit
		End If		
	End If
		
	geom = Dsc.Parameter(CAM_T_SGEOMTRY) ' GEOMETRI
	If IsNull(geom) or IsEmpty(geom) Then
		f.WriteLine ""
	Else
		f.WriteLine geom
	End If		
		
	ref = Dsc.Parameter(CAM_X_STIME) '  REFERENASE DATO
	If IsNull(ref) or IsEmpty(ref) Then
		f.WriteLine ""
	Else
		f.WriteLine ref
	End If		
	
	sys = Dsc.Parameter(CAM_F_SSYSERR) ' RANDOM ERROR
	If IsNull(sys) or IsEmpty(sys) Then
		f.WriteLine ""
	Else
		f.WriteLine CStr(sys)
	End If			
		
	syst = Dsc.Parameter(CAM_F_SSYSTERR) ' SYSTEM ERROR
	If IsNull(syst) or IsEmpty(syst) Then
		f.WriteLine ""
	Else
		f.WriteLine CStr(syst)
	End If		
	
	If isDet Then
		f.WriteLine ""
	Else		
		f.WriteLine Dsc.Parameter(CAM_T_SUCSTRING4) ' KOMMENTAR
		comment = Dsc.Parameter(CAM_T_SUCSTRING4)
		If IsNull(comment) or IsEmpty(comment) Then
			f.WriteLine ""
		Else
			f.WriteLine comment
		End If		
	End If
	
	f.Close
	
    ' KJØR INPUT VINDU
	returnValue = csh.Run(geniePath & "exefiles\lorakon_inp.exe", 1, true)
	If returnValue <> 0 Then
		set fso = Nothing
		set csh = Nothing	
		Execute = 0		
		Exit Function
	End If

    ' SKRIV INPUT FIL VERDIER TIL DATA SOURCE
	set f = fso.OpenTextFile(paramFile, 1)
	idx = 0
	do until f.AtEndOfStream
		line = f.ReadLine
		
		select case idx
		case 0
            Dsc.Parameter(CAM_T_SSPRSTR1) = line ' LABORATORIE
		case 1
            Dsc.Parameter(CAM_T_SCOLLNAME) = line ' OPERATØR
		case 2
            Dsc.Parameter(CAM_T_STITLE) = line ' PROSJEKT
		case 3
            Dsc.Parameter(CAM_T_SUCSTRING1) = line ' PRØVETYPE
		case 4
            Dsc.Parameter(CAM_T_SUCSTRING2) = line ' PRØVETYPE KOMPONENT
		case 5
            Dsc.Parameter(CAM_T_SIDENT) = line ' PRØVE ID
		case 6
            Dsc.Parameter(CAM_T_SUCSTRING3) = line ' FYLKE / KOMMUNE
		case 7
            If line <> "" Then
                Dsc.Parameter(CAM_G_SGPSLATITUDE) = CDbl(line) ' BREDDEGRAD
			Else
				Dsc.Parameter(CAM_G_SGPSLATITUDE) = 0
            End If
		case 8
            If line <> "" Then
                Dsc.Parameter(CAM_G_SGPSLONGITUD) = CDbl(line) ' LENGDEGRAD
			Else
				Dsc.Parameter(CAM_G_SGPSLONGITUD) = 0
            End If
		case 9
            If line <> "" Then
                Dsc.Parameter(CAM_G_SGPSALTITUDE) = CDbl(line) ' METER OVER HAVET
			Else
				Dsc.Parameter(CAM_G_SGPSALTITUDE) = 0
            End If
		case 10
            Dsc.Parameter(CAM_T_SUCSTRING10) = line ' LOKASJONSTYPE
		case 11
            Dsc.Parameter(CAM_T_SUCSTRING9) = line ' LOKASJON
		case 12
            If line <> "" Then
                Dsc.Parameter(CAM_F_SQUANT) = CDbl(line) ' PRØVEMENGDE
            End If
		case 13
            If line <> "" Then
                Dsc.Parameter(CAM_F_SQUANTERR) = CDbl(line) ' PRØVEMENGDE ERROR
            End If
		case 14
            Dsc.Parameter(CAM_T_SUNITS) = line ' PRØVEMENGDE ENHET
		case 15
            Dsc.Parameter(CAM_T_SGEOMTRY) = line ' GEOMETRI
		case 16
            If line <> "" Then
                Dsc.Parameter(CAM_X_STIME) = CDate(line) ' REFERANSE DATO
            End If
		case 17
            If line <> "" Then
                Dsc.Parameter(CAM_F_SSYSERR) = CDbl(line) ' RANDOM ERROR
			Else
				Dsc.Parameter(CAM_F_SSYSERR) = 0	
            End If
		case 18
            If line <> "" Then
                Dsc.Parameter(CAM_F_SSYSTERR) = CDbl(line) ' SYSTEM ERROR
			Else
				Dsc.Parameter(CAM_F_SSYSTERR) = 0
            End If
		case 19
			Dsc.Parameter(CAM_T_SUCSTRING4) = line ' KOMMENTAR
		case else
			exit do
		end select
		idx = idx + 1
	loop
	f.Close
	
	Dsc.Parameter(CAM_T_SSPRSTR2) = "LORAKON"
	Dsc.Parameter(CAM_T_STYPE) = ""
	Dsc.Parameter(CAM_T_SLOCTN) = ""
	Dsc.Parameter(CAM_T_SDESC1)	= "LORAKON"
	Dsc.Parameter(CAM_T_SDESC2)	= ""
	Dsc.Parameter(CAM_T_SDESC3) = ""
	Dsc.Parameter(CAM_T_SDESC4) = ""
	
	set fso = Nothing
	set csh = Nothing	

	Execute = 0

end function

function Setup(Dsc,Phase)
	
	Setup = 0

end function

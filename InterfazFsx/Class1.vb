Imports System.IO.Ports
Imports FSUIPC
Public Class arranca
    Public valscope As Integer
    Public valhdg As Integer

    Private port As New SerialPort("COM4", 9600)

    Public Sub ProcesarFSX()

        port.ReadTimeout = 1000
        Dim f As New Form2
        f.Show()
        'Dim Throttle As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H88C) ' Basic integer read example
        'Dim Throttle1 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H924) ' Basic integer read example
        'Dim Throttle2 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H9BC) ' Basic integer read example
        'Dim Throttle3 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HA54) ' Basic integer read example

        'Dim Flaps As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HBDC) ' Basic integer read example   
        'Dim Spoitler As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)'(&HBD0) ' Basic integer read example   
        'Dim AutoSpeed As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H66F2) 'H7DC) ' Basic integer read example   
        Dim Airspeedk As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7E2) ' Basic integer read example   
        Dim Altitude As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7D4) ' Basic integer read example   
        Dim Heading As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7CC)  'Basic integer read example   
        Dim VelVert As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7F2) ' Basic integer read example   
        'Dim Timon As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HBB2) ' Basic integer read example   
        'Dim N1 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H800) ' Basic integer read example   
        Dim at As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H810) ' Basic integer read example   
        Dim navgps As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H132C) ' Basic integer read example   
        Dim fd As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H2EE0) ' Basic integer read example   
        Dim sp As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7DC) ' Basic integer read example   
        Dim hdg As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7C8) ' Basic integer read example   

        Dim Course As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HC4E) ' Basic integer read example   
        Dim althold As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7D0) ' Basic integer read example   
        Dim app As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H800) ' Basic integer read example   
        Dim CMD As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7BC) ' Basic integer read example   

        Dim Gears As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HBE8) ' Basic integer read example   
        Dim Gear1 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HBEC) ' Basic integer read example   
        Dim Gear3 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HBF0) ' Basic integer read example   
        Dim Gear2 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HBF4) ' Basic integer read example   

        Dim vorloc As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7C4) ' Basic integer read example   
        Dim Pau As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H262) ' Basic integer read example   
        Dim gscope As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H7FC) ' Basic integer read example   
        Dim aaa As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HC4A) ' Basic integer read example   
        Dim bbb As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HC4C) ' Basic integer read example   
        'Dim IFLY As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H9400) ' Basic integer read example   
        'Dim AutoSpeedIFLY As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H94F3) ' Basic integer read example   
        'Dim tant As Integer
        Dim Belowgs As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H4FE) ' Basic integer read example   
        'Dim guarde As Boolean
        'Dim estadoR As Integer
        'Dim estadoRant As Integer
        'Dim estadoV As Integer
        'Dim estadoVant As Integer  
        'Dim estadoR1 As Integer
        'Dim estadoRant1 As Integer
        'Dim estadoV1 As Integer
        'Dim estadoVant1 As Integer
        'Dim estadoR2 As Integer
        'Dim estadoRant2 As Integer
        'Dim estadoV2 As Integer
        'Dim estadoVant2 As Integer
        'Dim spant As Integer

        Dim veltiempo As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HC1A) ' Basic integer read examp
        Dim save As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H3F00) ' Basic integer read examp
        Dim savename As Offset(Of String) = New Offset(Of String)(&H3F04, 256)
        'port1.Close()
        'port1.Open()
        ' port.Close()

        port.Open()
        'Me.Show()
        Try
            ' Attempt to open a connection to FSUIPC (running on any version of Flight Sim)
            FSUIPCConnection.Open()
            ' Opened OK so disable the Connect button

        Catch ex As Exception
            ' Badness occurred - show the error message
            MessageBox.Show(ex.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        '  Label2.Text = Throttle1.Value

        '16838/8  =>   0 = 0% , 2048 = 2% , 4096=5% , 6144 = 10% , 8192 =15%, 16838=40%
        ' Flaps.Value = 16838
        'Flaps.Value = 8196
        'Dim Proceso As New Process
        'If Me.RIFLY.Checked Then

        '    Proceso.StartInfo.FileName = "IFlyToFsuipc.exe"
        '    Proceso.StartInfo.Arguments = ""
        '    Proceso.Start()

        'End If



        ' If port.IsOpen Then
        'Me.Show()
        Dim t As String '= port.ReadLine()
        Dim x As Double 'Integer '= Integer.Parse(t)
        Dim y As Double
        Dim ARR As String() = Nothing
        Dim cadena As String = Nothing
        Dim cadenaant As String = Nothing
        Dim valor1ant As Integer = 0
        Dim valor2ant As Integer = 0
        Dim valor3ant As Integer = 0
        Dim valor4ant As Integer = 0
        Dim valor5ant As Integer = 0
        Dim valor6ant As Integer = 0
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0
        Dim valor3 As Integer = 0
        Dim valor4 As Integer = 0
        Dim valor5 As Integer = 0
        Dim valor6 As Integer = 0
        Dim tempor As Integer = 0
        Dim tempant As String = "0"
        f.Show()
        While (True)
            '  Me.valscope =
            ' Me.valhdg = hdg.Value
            Form2.Label1.Text = CStr(Airspeedk.Value) + "-" + Belowgs.Value

            ' cadena = nRead
            If port.BytesToRead > 0 Then
                cadena = port.ReadLine()
                f.Label1.Text = cadena
                f.Refresh()
                ARR = cadena.Split(",")

                If cadena <> cadenaant And cadena <> "" And ARR.Length = 19 And cadena.Length < 75 Then
                    '     Form1.Label1.Text = cadena
                    cadenaant = cadena

                    ' port.Write(1)
                    Airspeedk.Value = IIf(IsNumeric(Trim(ARR(1))), CLng(Trim(ARR(1))), 0)
                    Heading.Value = ((ARR(7) * 65536) / (360))
                    Course.Value = ARR(0)
                    Altitude.Value = ((ARR(11) * 100) * 65536) * (0.3048)
                    VelVert.Value = CInt(ARR(14)) * 100
                    '  f.Label1.Text = VelVert.Value
                    '  f.Refresh()
                    '     'Label2.Text = Int(VelVert.Value)
                    CMD.Value = CInt(ARR(12))
                    '  AutoSpeed.Value = CInt(ARR(2))
                    sp.Value = CInt(ARR(2))
                    althold.Value = CInt(ARR(10))
                    app.Value = CInt(ARR(9))
                    hdg.Value = CInt(ARR(8))
                    vorloc.Value = CInt(ARR(6))
                    at.Value = CInt(ARR(3))
                    navgps.Value = CInt(ARR(5))
                    If CInt(ARR(4)) = 0 And CInt(ARR(15)) = 0 Then
                        fd.Value = 1
                    Else
                        fd.Value = 0
                    End If
                    Gears.Value = CInt(ARR(16))

                    If ARR(18) <> tempant Then
                        If Trim(ARR(18)) <> "" Then
                            Select Case CInt(ARR(18))
                                Case 0 : tempor = 1
                                Case 1 : tempor = 2
                                Case 2 : tempor = 4
                                Case 3 : tempor = 8
                                Case 4 : tempor = 16
                                Case 5 : tempor = 32
                                Case 6 : tempor = 64
                                Case Else : tempor = 1
                            End Select
                        Else
                            tempor = 1
                        End If
                        If ARR(18) < tempant Then
                            Pau.Value = 1
                        End If
                        tempant = ARR(18)
                        veltiempo.Value = tempor * 256
                        If tempor <> 1 Then
                            savename.Value = "1GUARDADOCHOVA" & 0
                            save.Value = 1
                            FSUIPCConnection.Process()
                        End If
                        If veltiempo.Value < 256 Then
                            veltiempo.Value = 256
                        End If

                    End If
                    '   Pau.Value = IIf(ARR(18) = 255, 1, 0)
                    'If Pau.Value = 1 Then
                    '    savename.Value = "1GUARDADOCHOVA" & 0
                    '    save.Value = 1
                    '    FSUIPCConnection.Process()
                    'End If
                Else
                    'port.Write("a")
                    'port.Write("c")
                    'port.Write("e")

                End If
            Else


                port.ReadExisting()

                Try

                    Dim message As String = port.ReadLine()

                Catch generatedExceptionName As TimeoutException
                End Try

            End If

            ' port.Write("1")


            '  FSUIPCConnection.Process()

            'VERDES

            If CInt(Gear3.Value) < 16210 Then ' 1RA LUZ
                valor3 = 3 ' apaga
            End If
            If CInt(Gear3.Value) >= 16210 Then
                valor3 = 4
            End If

            If CInt(Gear2.Value) < 16210 Then '2DA LUZ
                valor2 = 1 ' apaga
            End If
            If CInt(Gear2.Value) >= 16210 Then
                valor2 = 2 ' prende
            End If

            If CInt(Gear1.Value) < 16210 Then ' 3RA LUZ
                valor1 = 5 ' apaga
            End If

            If CInt(Gear1.Value) >= 16210 Then
                valor1 = 6 'prende
            End If


            '''''''''''''''''''''''''''''''''''''''''''''''
            If CInt(Gear2.Value) < 16383 Then
                If CInt(Gear2.Value) = 0 Then
                    valor5 = 1 ' PRENDE
                Else
                    valor5 = 2 ' PRENDE
                End If
            End If
            If CInt(Gear2.Value) >= 16383 Then
                valor5 = 1 ' APAGA
            End If

            If CInt(Gear1.Value) < 16383 Then
                If CInt(Gear1.Value) = 0 Then
                    valor4 = 3
                Else
                    valor4 = 4
                End If

            End If
            If CInt(Gear1.Value) >= 16383 Then
                valor4 = 3
            End If

            If CInt(Gear3.Value) < 16383 Then
                If CInt(Gear3.Value) = 0 Then
                    valor6 = 5
                Else
                    valor6 = 6
                End If

            End If
            If CInt(Gear3.Value) >= 16383 Then
                valor6 = 5
            End If



            'Label3.Text = CStr(valor1ant) + "   " + CStr(valor1) + "   " + CStr(Gear1.Value) + "   " + CStr(valor4)
            ' Form1.Label4.Text = CStr(valor2ant) + "   " + CStr(valor2) + "   " + CStr(Gear2.Value) + "   " + CStr(valor5)
            ' Form1.Label5.Text = CStr(valor3ant) + "   " + CStr(valor3) + "   " + CStr(Gear3.Value) + "   " + CStr(valor6)

            Form1.Refresh()

            If (valor1ant <> valor1) Then
                If valor1 = 6 Then
                    port.Write("e") 'verde arriba encendido
                Else
                    port.Write("f") 'verde arriba apaga
                End If
            End If

            If (valor2ant <> valor2) Then
                If valor2 = 2 Then
                    port.Write("c") 'verde arriba encendido
                Else
                    port.Write("d") ''verde arriba apaga
                End If
            End If

            If (valor3ant <> valor3) Then
                If valor3 = 4 Then
                    port.Write("a") 'verde arriba encendido
                Else
                    port.Write("b") ''verde arriba apaga
                End If
            End If
            valor1ant = valor1
            valor2ant = valor2
            valor3ant = valor3


            '''''''''''''''''''ROJOS
            If (valor4ant <> valor4) Then
                If valor4 = 4 Then
                    'port.Write("g") 'verde arriba encendido
                    port.Write("k") 'verde arriba encendido
                Else
                    'port.Write("h") 'verde arriba encendido
                    port.Write("l") 'verde arriba encendido
                End If
            End If

            If (valor5ant <> valor5) Then
                If valor5 = 2 Then
                    port.Write("i") 'verde arriba encendido
                Else
                    port.Write("j") 'verde arriba encendido
                End If
            End If

            If (valor6ant <> valor6) Then
                If valor6 = 6 Then
                    '    port.Write("k") 'verde arriba encendido
                    port.Write("g") 'verde arriba encendido
                Else
                    port.Write("h") 'verde arriba encendido
                    '   port.Write("l") 'verde arriba encendido
                End If
            End If
            valor4ant = valor4
            valor5ant = valor5
            valor6ant = valor6

            'If (g2ant <> valor2) Then

            '    If (Gear2.Value = 0) Then 'Or Gear1.Value = 16383
            '        port.Write("b") 'verde arriba encendido
            '        g2ant = 2
            '    Else
            '        If (Gear2.Value = 16383) Then
            '            port.Write("a") 'verde arriba apagado
            '            g2ant = 1
            '        Else
            '            port.Write("b") 'verde arriba apagado
            '            g2ant = 2
            '        End If
            '    End If


            'End If


            'If (g1ant <> valor1) Then

            '    If (Gear1.Value = 0) Then 'Or Gear1.Value = 16383
            '        port.Write("d") 'verde arriba encendido
            '        g1ant = 4
            '    Else
            '        If (Gear1.Value = 16383) Then
            '            port.Write("c") 'verde arriba apagado
            '            g1ant = 3
            '        Else
            '            port.Write("d") 'verde arriba apagado
            '            g1ant = 4
            '        End If
            '    End If

            'End If

            'If (g3ant <> valor3) Then
            '    If (Gear3.Value = 0) Then 'Or Gear1.Value = 16383
            '        port.Write("f") 'verde arriba encendido
            '        g3ant = 6
            '    Else
            '        If (Gear3.Value = 16383) Then
            '            port.Write("e") 'verde arriba apagado
            '            g3ant = 5
            '        Else
            '            port.Write("f") 'verde arriba apagado
            '            g3ant = 6
            '        End If
            '    End If

            'End If







            'Dim s As String
            'For Each s In ARR
            '    Console.WriteLine(s)
            'Next s
            '  AutoSpeed.Value = True 'CInt(ARR(2))
            ' FSUIPCConnection.Process()
            '    ' leer potenciómetro 1: coordenada x
            '    port.Write("x")
            '    t = port.ReadLine()
            '    't = t - 10
            '    ' x = double.parse(t)
            '    x = map(t, 0, 275)
            '    'label1.text = x
            '    'leer potenciómetro 2: coordenada y
            '    port.Write("y")
            '    t = port.ReadLine()
            '    ' t = t - 6
            '    ' dim y as integer
            '    'int(y = integer.parse(t))
            '    y = map(t, 1, 280)
            '    'leer(botón) : borrar()
            '    'port.write("b")
            '    't = port.readline()
            '    y = x - 855
            '    x = y
            '    ' si el botón se oprime, borrar
            '    'if (t = 0) then
            '    ' salir(port)
            '    ' exit while
            '    ' end if


            '    ' reversores
            '    'port.Write("r")
            '    port.Write("o")
            '    t = port.ReadLine()
            '    If t = 1 And y <= 0 Then
            '        Throttle.Value = -4096
            '        Throttle3.Value = -4096
            '        Throttle1.Value = -4096
            '        Throttle2.Value = -4096
            '    Else
            '        Throttle.Value = y '* 500
            '        Throttle3.Value = y '* 500
            '        Throttle1.Value = x '* 500
            '        Throttle2.Value = x '* 500
            '    End If

            '    'port.Write("o")
            '    't = port.ReadLine()
            '    'If t = 1 And x = 0 Then
            '    '    Throttle1.Value = -4096
            '    '    Throttle2.Value = -4096
            '    'Else
            '    '    Throttle1.Value = x '* 500
            '    '    Throttle2.Value = x '* 500
            '    'End If
            '    '    '          '
            'End If

            ' ''flaps
            'port.Write("f")
            't = port.ReadLine()
            'If (t >= 0) Then
            '    Flaps.Value = t
            'End If

            ' ''spoitler
            'port.Write("s")
            't = port.ReadLine()
            'If (t = 0) Then
            '    Spoitler.Value = 16383 ' cint(rtrim(ltrim(t)))
            'Else
            '    Spoitler.Value = 0 ' cint(rtrim(ltrim(t)))
            'End If



            '' ''VELOCIDAD
            'port.Write("v")
            't = port.ReadLine()
            'If Me.RIFLY.Checked = False Then
            '    Airspeedk.Value = t
            'Else
            '    If (t > tant) Then
            '        IFLY.Value = 207
            '    Else
            '        If (t <> tant) Then
            '            IFLY.Value = 208
            '        End If
            '    End If
            '    tant = t
            'End If

            'FSUIPCConnection.Process()

            ' ''ALTITUDE
            'port.Write("a")
            't = port.ReadLine()
            'Altitude.Value = t
            'If (t > 999) Then
            '    t = 999
            'End If
            'Altitude.Value = ((t * 100) * 65536) * (0.3048) '

            ' ''HEADING
            'port.Write("h")
            't = port.ReadLine()
            'Heading.Value = ((t * 65536) / (360))

            ' ''TIMON DE PROF
            ' ''port.Write("c")
            ' ''t = port.ReadLine()

            ' ''Timon.Value = (t * 100)

            ' ''nav/gps
            'port.Write("L")
            't = port.ReadLine()
            'navgps.Value = t



            ''f/d
            'port.Write("k")
            't = port.ReadLine()
            'If t = 0 Then

            '    If guarde = 0 Then
            '        veltiempo.Value = 1 * 256
            '        savename.Value = " GUARDADOCHOVA" & 0
            '        save.Value = 1
            '        guarde = 1
            '        FSUIPCConnection.Process()
            '    End If

            'Else
            '    veltiempo.Value = 8 * 256
            '    FSUIPCConnection.Process()
            '    guarde = 0
            'End If
            'fd.Value = 1


            ' '' spant = t
            ' '' End If
            If (vorloc.Value = 1 Or app.Value = 1) Then 'navgps.Value = 1 And
                port.Write("O") ' desactiva hsg si esta en gps y con vorloc
                hdg.Value = 0
                'Else
                '    'hdg sel auto boton
                '    port.Write("m")
                '    t = port.ReadLine()
                '    hdg.Value = t
            End If

            'If port1.IsOpen Then
            '    'course
            '    port1.Write("a")
            '    t = port1.ReadLine()
            '    Course.Value = t + 0 ' ((t * 65536) / (360))

            '    'altitudboton
            '    If fd.Value = 1 Then
            '        port1.Write("j")
            '        t = port1.ReadLine()
            '        althold.Value = t
            '    End If

            '    ' ''speed auto boton
            '    port1.Write("r")
            '    t = port1.ReadLine()

            '    If Me.RIFLY.Checked = True Then
            '        If t <> spant Then

            '            IFLY.Value = 206
            '            FSUIPCConnection.Process()
            '            spant = t

            '        End If

            '    Else
            '        If t = 1 Then
            '            AutoSpeed.Value = 1
            '        Else
            '            AutoSpeed.Value = 0
            '        End If

            '    End If
            '    '    FSUIPCConnection.Process()
            '    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '    'A/T ARM
            '    port1.Write("q")
            '    t = port1.ReadLine()
            '    If IFLY.Value <> 202 And IFLY.Value <> 203 Then
            '        If t = 1 Then
            '            If Me.RIFLY.Checked = False Then
            '                at.Value = 1
            '            Else

            '                IFLY.Value = 202
            '                FSUIPCConnection.Process()
            '            End If
            '        Else
            '            If Me.RIFLY.Checked = False Then
            '                at.Value = 0
            '            Else
            '                IFLY.Value = 203
            '            End If
            '        End If
            '        'FSUIPCConnection.Process()
            '        'atant = t
            '        'End If
            '    End If
            '    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '    port1.Write("m")
            '    t = port1.ReadLine()
            '    CMD.Value = t

            '    If Me.RIFLY.Checked = True Then
            '        'app
            'If fd.Value = 1 Then
            '    port1.Write("O")
            '    t = port1.ReadLine()

            '            If t = 1 Then
            '                IFLY.Value = 212
            '                vorloc.Value = 0
            '                port1.Write("s") 'apaga el vorloc
            '                FSUIPCConnection.Process()
            '            End If

            '        End If

            '    Else
            '        'app
            'If fd.Value = 1 Then
            '    port.Write("O")
            '    t = port.ReadLine()
            '    app.Value = t
            '    If app.Value = 1 Then
            '        vorloc.Value = 0
            '        port.Write("s") 'apaga el vorloc
            '        FSUIPCConnection.Process()
            '    End If

            'End If
            '    End If

            'If gscope.Value = 1 Then
            '    hdg.Value = 0
            'End If

            '    If Me.RIFLY.Checked = True Then

            'If fd.Value = 1 Then
            '            port1.Write("V")
            '            t = port1.ReadLine()
            '            If t = 1 Then
            '                IFLY.Value = 221
            '            End If
            '            If vorloc.Value = 1 Then
            '                app.Value = 0
            '                IFLY.Value = 212
            '            End If
            '            FSUIPCConnection.Process()
            '        End If
            '    Else
            '        'vorloc
            'If fd.Value = 1 Then
            '    port1.Write("V")
            '    t = port1.ReadLine()
            '    vorloc.Value = t
            '    If vorloc.Value = 1 And app.Value = 1 Then
            '        app.Value = 0
            '        FSUIPCConnection.Process()
            '    End If
            'End If
            '    End If
            'port1.Write("1")
            't = port1.ReadLine()
            'Gears.Value = t





            ' ''speed auto boton
            ''  port1.Write("r")
            ''    t = port1.ReadLine()

            ''   If Me.RIFLY.Checked = True Then
            ''   If t <> spant Then
            ''   IFLY.Value = 206
            ''   spant = t

            ''End If
            ''      AutoSpeed.Value = t
            ''     Else
            ''      If t = 1 Then
            ''  AutoSpeed.Value = 1
            '' IFLY.Value = 206
            ''     Else
            ''       AutoSpeed.Value = 0
            ''    End If

            ''    End If
            ''  Dim IFLYs As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H9400) ' Basic integer read example   
            ''  IFLYs.Value = 206

            ' FSUIPCConnection.Process()



            FSUIPCConnection.Process()
        End While

        port.Close()

        'If Me.RIFLY.Checked Then
        '    Proceso.Kill()
        'End If
        'End If
    End Sub
End Class

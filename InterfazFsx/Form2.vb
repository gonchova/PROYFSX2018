Imports System
Imports System.IO.Ports
Imports FSUIPC
Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Show()

    End Sub

    Public Sub Arranca()
        'Dim port = New SerialPort("COM10", 9600)
        Dim port2 = New SerialPort("COM3", 9600)

        Dim Throttle As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H88C) ' Basic integer read example
        Dim Throttle1 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H924) ' Basic integer read example
        Dim Throttle2 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H9BC) ' Basic integer read example
        Dim Throttle3 As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HA54) ' Basic integer read example


        port2.Open()
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
        Dim ARR As String() = Nothing
        Dim cadena As String = Nothing
        Dim cadenaant As String = Nothing

        Dim valor As Double

        While (True)

            'Dim strData As String = ""
            'Dim bRead, nRead As String

            'bRead = port2.BytesToRead
            'Dim cData(bRead - 1) As Byte

            'nRead = port.Read(cData, 0, bRead) 'Reading the Data

            ' ''  If AutoSpeed.Value = 0 Then
            ''Label2.Text = CStr(Gear1.Value) + "," + CStr(Gear2.Value) + "," + CStr(Gear3.Value)

            'VERDES

            Me.Refresh()
            If port2.BytesToRead > 0 Then

                cadena = port2.ReadLine()
                cadena = port2.ReadLine()
                If cadena <> "" Then
                    ARR = cadena.Split(",")
                    If ARR.Length = 2 Then
                        If IsNumeric(ARR(0)) And IsNumeric(ARR(1)) Then
                            If cadena <> cadenaant And cadena <> "" And ARR.Length = 2 Then
                                '     Form1.Label1.Text = cadena
                                cadenaant = cadena
                                Throttle.Value = (ARR(0)) * (16384) / 100
                                Throttle1.Value = (ARR(1)) * (16384) / 100
                                Label1.Text = ARR(0)
                            End If

                        End If
                    End If
                    'Gears.Value = CInt(ARR(16))


                    FSUIPCConnection.Process()
                End If
            End If
            port2.ReadExisting()

        End While

        port2.Close()
        Dim message As String = port2.ReadLine()
        'If Me.RIFLY.Checked Then
        '    Proceso.Kill()
        'End If
        'End If
    End Sub

    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Arranca()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Arranca()
    End Sub
End Class

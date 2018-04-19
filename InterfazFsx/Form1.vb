Imports System
Imports System.Threading

Public Class Form1

    Private MiThread As Thread


    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()
        BtnDetener.Enabled = False
    End Sub

    

    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click
        Dim proceso As New arranca

        MiThread = New Thread(New ThreadStart(AddressOf proceso.ProcesarFSX))

        MiThread.Start()
        BtnDetener.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetener.Click


        MiThread.Abort()
        BtnDetener.Enabled = False

    End Sub
End Class

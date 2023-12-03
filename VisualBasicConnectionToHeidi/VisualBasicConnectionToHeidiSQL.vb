Imports MySql.Data.MySqlClient

Imports System.Net

Imports System.Text.Encoding

Public Class Form1

    Dim publisher As New Sockets.UdpClient(0)
    Dim subscriber As New Sockets.UdpClient(2000)

    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "Trucopablo11"
    Dim database = "iot"
    Dim intentos As Integer = 0
    Dim bandera As Integer = 0
    Dim ciclos As Integer = 0
    Dim Dentro2 As String
    Dim Tipo As String
    Dim BanderaT As Integer = 0
    Dim BanderaH As Integer = 0
    Dim BanderaL As Integer = 0

    Dim Temp As String
    Dim Hum As String
    Dim Lu As String


    Dim cadenaConexion = "server=" & server & ";user=" & user & ";pwd=" & pwd & ";database=" & database & ";SslMode=none;"
    Dim myCon = New MySqlConnection(cadenaConexion)


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        publisher.Connect(TbTo.Text, TbPort.Text)
        Dim sendbytes() As Byte = ASCII.GetBytes(TBSend.Text)
        publisher.Send(sendbytes, sendbytes.Length)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        subscriber.Client.ReceiveTimeout = 5000
        subscriber.Client.Blocking = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        Try
            Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
            Dim rcvbytes() As Byte = subscriber.Receive(ep)
            TBRcv.Text = ASCII.GetString(rcvbytes)
            Dim Dentro As String = ASCII.GetString(rcvbytes)

            If Dentro = "T" Or bandera = 1 Then
                bandera = 1

                If Dentro = "T" Or BanderaT > 0 Then

                    If BanderaT = 2 Then
                        Dentro2 = Dentro
                    End If

                    If BanderaT = 1 Then
                        Temp = String.Concat(Dentro, Dentro2)
                    End If



                    If Dentro = "T" And BanderaT = 0 Then
                        BanderaT = 3
                    End If

                    BanderaT = BanderaT - 1

                End If

                If Dentro = "H" Or BanderaH > 0 Then

                    If BanderaH = 2 Then
                        Dentro2 = Dentro
                    End If

                    If BanderaH = 1 Then
                        Hum = String.Concat(Dentro, Dentro2)
                    End If

                    If Dentro = "H" And BanderaH = 0 Then
                        BanderaH = 3
                    End If

                    BanderaH = BanderaH - 1

                End If

                If Dentro = "L" Or BanderaL > 0 Then

                    If BanderaL = 2 Then
                        Dentro2 = Dentro
                    End If

                    If BanderaL = 1 Then
                        Lu = String.Concat(Dentro, Dentro2)
                        Dim quer = "insert into esp32 " &
        "(temp,humi,light) values " &
        "('" & Temp & "','" & Hum & "','" & Lu & "');"
                        Dim comando = New MySqlCommand(quer, myCon)
                        Try
                            Dim reader = comando.ExecuteReader()
                            reader.Close()

                        Catch ex As Exception
                            lblRes2.Text = ex.ToString

                        End Try
                    End If

                    If Dentro = "L" And BanderaL = 0 Then
                        BanderaL = 3
                    End If

                    BanderaL = BanderaL - 1

                End If

            End If






        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblRes_Click(sender As Object, e As EventArgs) Handles lblRes.Click



    End Sub


    Public Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConnectar.Click

        Try
            myCon.Open()
            lblRes.Text = "Conexion fue exitosa"

        Catch ex As Exception
            lblRes.Text = ex.ToString
        End Try
    End Sub




End Class

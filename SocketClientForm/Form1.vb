Public Class Form1
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim ipAddr As String = Me.txtIP.Text
        Dim port As Integer = 0
        If Not Integer.TryParse(Me.txtPort.Text, port) Then
            MsgBox("ポート番号変換エラー")
        End If
        Dim tcp As System.Net.Sockets.TcpClient = Nothing
        Dim stream As System.Net.Sockets.NetworkStream = Nothing

        Try
            tcp = New System.Net.Sockets.TcpClient(ipAddr, port)

            stream = tcp.GetStream

            stream.ReadTimeout = 5000
            stream.WriteTimeout = 5000

            Dim sendMsg As String = Me.txtCmd.Text

            Dim sendBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(sendMsg)
            stream.Write(sendBytes, 0, sendBytes.Length)

            Dim memStream As New System.IO.MemoryStream
            Dim recvBytes As Byte() = Nothing
            Dim recvSize As Integer = 0

            Do
                recvSize = stream.Read(recvBytes, 0, recvBytes.Length)

                If recvSize = 0 Then
                    Exit Do
                End If
                memStream.Write(recvBytes, 0, recvSize)
            Loop While stream.DataAvailable OrElse recvBytes(recvSize - 1) <> AscW(ControlChars.Lf)

            Dim recvMsg As String = System.Text.Encoding.ASCII.GetString(memStream.GetBuffer, 0, CInt(memStream.Length))
            memStream.Close()

            Me.txtRst.Text = recvMsg
        Catch ex As Exception
            Me.txtRst.Text = ex.Message & vbCrLf & ex.StackTrace
        Finally
            If stream IsNot Nothing Then stream.Close()
            If tcp IsNot Nothing Then tcp.Close()

        End Try






    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtIP.Clear()
        Me.txtPort.Clear()
        Me.txtCmd.Clear()
        Me.txtRst.Clear()
    End Sub
End Class

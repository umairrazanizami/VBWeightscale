Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Text
Imports System.Threading


'Module Program
'    <STAThread>
'    Public Sub Main()
'        Application.EnableVisualStyles()
'        Application.SetCompatibleTextRenderingDefault(False)
'        Application.Run(New Scales())
'    End Sub
'End Module


Public Class Scales
    Private WithEvents SerialPortWorker As New BackgroundWorker()
    Private buffer As New StringBuilder()





    Private Sub Scales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SerialPort1.PortName = "COM1"
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.DataBits = 8
        SerialPort1.StopBits = StopBits.One
        SerialPort1.ReadTimeout = 1000

        Try
            If Not SerialPort1.IsOpen Then
                SerialPort1.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening serial port: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End Try

        SerialPortWorker.WorkerSupportsCancellation = True
        SerialPortWorker.RunWorkerAsync()
    End Sub

    Private Sub SerialPortWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles SerialPortWorker.DoWork
        While Not SerialPortWorker.CancellationPending
            Try

                Dim receivedData As String = SerialPort1.ReadExisting()
                buffer.Append(receivedData)


                While buffer.ToString().Contains("=")
                    Dim separatorIndex As Integer = buffer.ToString().IndexOf("=")
                    Dim message As String = buffer.ToString().Substring(0, separatorIndex).Trim()


                    Dim rmessage As String = New String(message.Reverse().ToArray())

                    If message.StartsWith("=") Then
                        Dim weightValue As String = rmessage.Substring(1).Trim()
                        UpdateUIText(weightValue)

                        ' UpdateUIText("xyz")
                    Else
                        'My.Computer.Clipboard.SetText("some text")

                        Me.Invoke(Sub()
                                      Try
                                          ' Ensure that rmessage is not null before setting it as clipboard text
                                          If rmessage IsNot Nothing Then
                                              Clipboard.SetText(rmessage)
                                          Else
                                              ' Handle the case where rmessage is null
                                              UpdateUIText("Unexpected data format: rmessage is null")
                                          End If
                                      Catch ex As Exception
                                          ' Log or handle the exception
                                          UpdateUIText("Success")
                                      End Try
                                  End Sub)

                        'UpdateUIText(rmessage)

                    End If

                    buffer.Remove(0, separatorIndex + 1)
                End While
            Catch ex As TimeoutException

                UpdateUIText("Timeout exception: " & ex.Message)
            Catch ex As Exception

                UpdateUIText("Error reading weight: " & ex.Message)
            End Try

        End While
    End Sub

    Private Sub UpdateUIText(text As String)
        ' Update the UI with the specified text
        If txtScale.InvokeRequired Then
            ' If not on the UI thread, invoke the method on the UI thread
            txtScale.Invoke(Sub() UpdateUIText(text))
        Else
            ' Update the UI directly
            txtScale.Text = text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPortWorker.CancelAsync()
        SerialPort1.Close()
        Application.Exit()
    End Sub

    Private Sub Scales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SerialPortWorker.CancelAsync()
        SerialPort1.Close()
    End Sub



End Class

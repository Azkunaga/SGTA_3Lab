Imports System.Data.SqlClient
Public Class DatuAtzipena

    'atributuak Shared (singleton patroia): klasearen atributu dira
    Private Shared conSGTA_DB_Erabiltzaileak As SqlConnection
    Private Shared comSGTA_DB_Erabiltzaileak As SqlCommand
    'Private Shared readSGTA_DB_Erabiltzaileak As SqlDataReader

    'eraikitzaile pribatua (singleton patroia):
    Private Sub New()
    End Sub

    'Salbuespenak:
    Public Class Salbuespenak
        Public Class ErroreaKonektatzean
            Inherits ApplicationException 'aplikazio-salbuespenen klasea

            'eraikitzailea birdefinitu (gurasoarenaz baliatuz)
            Public Sub New _
            (Optional ByVal Mezua As String =
            "Errorea: Ezin izan da datu-basearekiko konexioa egin.")
                MyBase.New(Mezua) 'gurasoaren eraikitzaileari deituz
            End Sub
        End Class

        Public Class ErroreaDeskonektatzean
            Inherits ApplicationException 'aplikazio-salbuespenen klasea

            'eraikitzailea birdefinitu (gurasoarenaz baliatuz)
            Public Sub New _
            (Optional ByVal Mezua As String =
            "Errorea: Ezin izan da datu-basearekiko konexioa itxi.")
                MyBase.New(Mezua) 'gurasoaren eraikitzaileari deituz
            End Sub
        End Class

        Public Class ErroreaTxertatzean
            Inherits ApplicationException 'aplikazio-salbuespenen klasea

            'eraikitzailea birdefinitu (gurasoarenaz baliatuz)
            Public Sub New _
            (Optional ByVal Mezua As String =
            "Errorea: Ezin izan da datu-basean txertaketa egin.")
                MyBase.New(Mezua) 'gurasoaren eraikitzaileari deituz
            End Sub

        End Class

        Public Class ErroreaIrakurtzean
            Inherits ApplicationException 'aplikazio-salbuespenen klasea

            'eraikitzailea birdefinitu (gurasoarenaz baliatuz)
            Public Sub New _
            (Optional ByVal Mezua As String =
            "Errorea: Ezin izan da datu-basetik irakurketa egin.")
                MyBase.New(Mezua) 'gurasoaren eraikitzaileari deituz
            End Sub
        End Class

        Public Class ErroreaEguneratzean
            Inherits ApplicationException 'aplikazio-salbuespenen klasea

            'eraikitzailea birdefinitu (gurasoarenaz baliatuz)
            Public Sub New _
            (Optional ByVal Mezua As String =
            "Errorea: Ezin izan da datu-basea eguneratu.")
                MyBase.New(Mezua) 'gurasoaren eraikitzaileari deituz
            End Sub
        End Class


    End Class

    'metodoak Shared (singleton patroia):
    Public Shared Sub Konektatu()
        Dim strconSGTA_DB_Erabiltzaileak As String = "Server=tcp:sgta2022-aritzplazaola.database.windows.net,1433;Initial Catalog=sgta2022-aritzplazaola;Persist Security Info=False;User ID=sgta2022-aritzplazaola;Password=softGTA3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        Try
            conSGTA_DB_Erabiltzaileak = New SqlConnection(strconSGTA_DB_Erabiltzaileak)
            conSGTA_DB_Erabiltzaileak.Open()
        Catch ex As Exception
            Throw New Salbuespenak.ErroreaKonektatzean()
        End Try
    End Sub

    Public Shared Sub ItxiKonexioa()
        Try
            conSGTA_DB_Erabiltzaileak.Close()
        Catch ex As Exception
            Throw New Salbuespenak.ErroreaDeskonektatzean()

        End Try
    End Sub

    Public Shared Function ErabiltzaileaTxertatu(ByVal email As String, ByVal izena As String, ByVal abizena As String, ByVal galderaEzkutua As String, ByVal erantzuna As String, ByVal na As Integer, ByVal egiaztatzeZenbakia As Integer, ByVal lantaldeKodea As String, ByVal azpitaldeKodea As String, ByVal erabiltzaileMota As String, ByVal pasahitza As String) As Integer
        Dim sql As String = "INSERT INTO Erabiltzaileak(email, izena, abizena, galderaEzkutua, erantzuna, na, egiaztatzeZenbakia, egiaztatua, lantaldeKodea, azpitaldeKodea, erabiltzaileMota, pasahitza) VALUES('" & email & "', '" & izena & "', '" & abizena & "', '" & galderaEzkutua & "','" & erantzuna & "', '" & na & "', " & egiaztatzeZenbakia & ", @egiaztatua,'" & lantaldeKodea & "', '" & azpitaldeKodea & "','" & erabiltzaileMota & "', '" & pasahitza & "')"
        comSGTA_DB_Erabiltzaileak = New SqlCommand(sql, conSGTA_DB_Erabiltzaileak)
        comSGTA_DB_Erabiltzaileak.Parameters.AddWithValue("@egiaztatua", False)
        Try
            ErabiltzaileaTxertatu = comSGTA_DB_Erabiltzaileak.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Salbuespenak.ErroreaTxertatzean("Sql arazoa txertatzean")
        Catch ex As Exception
            Throw New Salbuespenak.ErroreaTxertatzean()
        End Try
    End Function

    Public Shared Function ErabiltzaileaLortu(ByVal email As String) As SqlDataReader
        Dim sql As String = "SELECT * FROM Erabiltzaileak WHERE email='" & email & "'"
        comSGTA_DB_Erabiltzaileak = New SqlCommand(sql, conSGTA_DB_Erabiltzaileak)
        Try
            Return comSGTA_DB_Erabiltzaileak.ExecuteReader
        Catch ex As SqlException
            Throw New Salbuespenak.ErroreaIrakurtzean("Sql arazoa select egitean")
        Catch ex As Exception
            Throw New Salbuespenak.ErroreaIrakurtzean()
        End Try
    End Function

    Public Shared Function ErabiltzaileaEgiaztatu(ByVal email As String) As Integer
        Dim sql As String = "UPDATE Erabiltzaileak SET egiaztatua=@egiaztatua WHERE email='" & email & "'"
        comSGTA_DB_Erabiltzaileak = New SqlCommand(sql, conSGTA_DB_Erabiltzaileak)
        comSGTA_DB_Erabiltzaileak.Parameters.AddWithValue("@egiaztatua", True)
        Try
            ErabiltzaileaEgiaztatu = comSGTA_DB_Erabiltzaileak.ExecuteNonQuery
        Catch ex As SqlException
            Throw New Salbuespenak.ErroreaEguneratzean("Sql arazoa eguneratzean")
        Catch ex As Exception
            Throw New Salbuespenak.ErroreaEguneratzean()
        End Try

    End Function

    Public Shared Function ErabiltzailearenPasahitzaAldatu(ByVal email As String, ByVal pasahitza As String) As Integer
        Dim sql As String = "UPDATE Erabiltzaileak SET pasahitza='" & pasahitza & "' WHERE email='" & email & "'"
        comSGTA_DB_Erabiltzaileak = New SqlCommand(sql, conSGTA_DB_Erabiltzaileak)
        Try
            ErabiltzailearenPasahitzaAldatu = comSGTA_DB_Erabiltzaileak.ExecuteNonQuery
        Catch ex As SqlException
            Throw New Salbuespenak.ErroreaEguneratzean("Sql arazoa pashaizta eguneratzean")
        Catch ex As Exception
            Throw New Salbuespenak.ErroreaEguneratzean()
        End Try
    End Function

    Public Shared Function IkasleaMatrikulatutakoIrakasgaienEgokitzaileaEskuratu(ByVal email As String) As SqlDataAdapter
        Dim sql As String = "SELECT DISTINCT irakasgaiKodea FROM KlasekoTaldeak WHERE kodea IN(SELECT taldeKodea FROM IkasleakTaldeak WHERE email='" & email & "')"

        comSGTA_DB_Erabiltzaileak = New SqlCommand(sql, conSGTA_DB_Erabiltzaileak)
        Dim adapter As New SqlDataAdapter With {
            .SelectCommand = comSGTA_DB_Erabiltzaileak
        }
        Dim dataSet As New DataSet()
        Try
            'Return-a SqlDataAdapter motakoa izan behar da
            adapter.Fill(dataSet)
            Return adapter
        Catch ex As SqlException
            Throw New Salbuespenak.ErroreaIrakurtzean("Sql arazoa select egitean")
        Catch ex As Exception
            Throw New Salbuespenak.ErroreaEguneratzean()
        End Try
    End Function

    Public Shared Function UstiapenekoLanGenerikoenEgokitzaileaEskuratu() As SqlDataAdapter
        Dim sql As String = "SELECT * FROM LanGenerikoak"
        comSGTA_DB_Erabiltzaileak = New SqlCommand(sql, conSGTA_DB_Erabiltzaileak)
        Dim adapter As New SqlDataAdapter With {
            .SelectCommand = comSGTA_DB_Erabiltzaileak
        }
        Dim dataSet As New DataSet()
        Try
            'Return-a SqlDataAdapter motakoa izan behar da
            adapter.Fill(dataSet)
            Return adapter
        Catch ex As SqlException
            Throw New Salbuespenak.ErroreaIrakurtzean("Sql arazoa select egitean")
        Catch ex As Exception
            Throw New Salbuespenak.ErroreaEguneratzean()
        End Try
    End Function
End Class
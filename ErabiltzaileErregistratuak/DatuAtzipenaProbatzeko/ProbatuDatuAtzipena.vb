Module ProbatuDatuAtzipena

    Sub Main()
        While True

            Console.WriteLine("Erabaki zer egin nahi duzun(0 idatzi bukatzeko):")
            Console.WriteLine("(1) DB-ra konektatu,
(2) DB-a itxi, 
(3) Erabiltzailea txertatu,
(4) Erabiltzailea lortu, 
(5) Erabiltzailea egiaztatu,
(6) Erabiltzailearen pasahitza aldatu")

            Dim num As Integer = Console.ReadLine()
            If num = 0 Then
                End
            End If
            Select Case num
                Case 1
                    Try
                        DatuAtzipenekoak.DatuAtzipena.Konektatu()
                        Console.WriteLine("Dena ondo joan da.")
                    Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaKonektatzean
                        Console.WriteLine(ex.Message)
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Case 2
                    Try
                        DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                        Console.WriteLine("Dena ondo joan da.")
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                        Console.ReadLine()
                    End Try
                Case 3
                    Try
                        Console.WriteLine("Sartu hurrengo datuak:")
                        Console.WriteLine("[email]              NVARCHAR (50):")
                        Dim email As String = Console.ReadLine
                        Console.WriteLine("[izena]              NVARCHAR (50):")
                        Dim izena As String = Console.ReadLine
                        Console.WriteLine("[abizena]            NVARCHAR (50):")
                        Dim abizena As String = Console.ReadLine
                        Console.WriteLine("[galderaEzkutua]     NVARCHAR (50):")
                        Dim galderaEzkutua As String = Console.ReadLine
                        Console.WriteLine("[erantzuna]          NVARCHAR (50):")
                        Dim erantzuna As String = Console.ReadLine
                        Console.WriteLine("[na]                 INT          :")
                        Dim na As Integer = Console.ReadLine
                        Console.WriteLine("[egiaztatzeZenbakia] INT          :")
                        Dim egiaztatzeZenbakia As Integer = Console.ReadLine
                        'Console.WriteLine(" [egiaztatua]         BIT         :")
                        'Dim egiaztatua As Boolean = Console.ReadLine
                        Console.WriteLine("[lantaldeKodea]      NVARCHAR (50):")
                        Dim lantaldeKodea As String = Console.ReadLine
                        Console.WriteLine("[azpitaldeKodea]     NVARCHAR (50):")
                        Dim azpitaldeKodea As String = Console.ReadLine
                        Console.WriteLine("[erabiltzaileMota]   NVARCHAR (50):")
                        Dim erabiltzaileMota As String = Console.ReadLine
                        Console.WriteLine("[pasahitza]          NVARCHAR (16):")
                        Dim pasahitza As String = Console.ReadLine
                        DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaTxertatu(email, izena, abizena, galderaEzkutua, erantzuna, na, egiaztatzeZenbakia, lantaldeKodea, azpitaldeKodea, erabiltzaileMota, pasahitza)
                        Console.WriteLine("Dena ondo joan da.")
                    Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaTxertatzean
                        Console.WriteLine(ex.Message)
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Case 4
                    Try
                        Console.WriteLine("Sartu erabiltzailearen emaila:")
                        Dim email As String = Console.ReadLine
                        DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(email)
                        Console.WriteLine("Dena ondo joan da.")
                    Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaTxertatzean
                        Console.WriteLine(ex.Message)
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Case 5
                    Try
                        Console.WriteLine("Sartu erabiltzailearen emaila:")
                        Dim email As String = Console.ReadLine
                        DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaEgiaztatu(email)
                        Console.WriteLine("Dena ondo joan da.")
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Case 6
                    Try
                        Console.WriteLine("Sartu erabiltzailearen emaila:")
                        Dim email As String = Console.ReadLine
                        Console.WriteLine("pasahitza berria:")
                        Dim pasahitza As String = Console.ReadLine
                        DatuAtzipenekoak.DatuAtzipena.ErabiltzailearenPasahitzaAldatu(email, pasahitza)
                        Console.WriteLine("Dena ondo joan da.")
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
            End Select
            Console.WriteLine()
        End While


    End Sub

End Module
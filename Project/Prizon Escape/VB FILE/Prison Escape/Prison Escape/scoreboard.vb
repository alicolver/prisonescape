Imports System
Imports System.IO
Imports System.Text

Public Class scoreboard

    Structure pe_player             'creates structure
        Dim position As Integer     'defines position as integer
        Dim playerName As String    'defines player name as string
        Dim playerTime As Integer   'defines player time as integer
        Dim difficulty As Char      'defines dificulty as char
    End Structure

    Private Sub scoreboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Bplayer(9999999) As pe_player   'defines Bplayer as  a high index array of structure pe_player
        Dim Iplayer(9999999) As pe_player   'defines Iplayer as  a high index array of structure pe_player
        Dim Eplayer(9999999) As pe_player   'defines Eplayer as  a high index array of structure pe_player

        Dim x As Integer = 0    'defines x as integer to be used for the file length
        Dim y As Integer = 0    'defines y as integer to be used for the file length
        Dim z As Integer = 0    'defines z as integer to be used for the file length

        BeginnerInput(Bplayer, x)               'Calls subprocedure that inputs beginner high scores
        Process(Bplayer, x)             'Calls subprocedure that processes and sorts beginner high scores
        BeginnerOutput(Bplayer, x)              'Calls subprocedure that outputs beginner high scores

        IntermediateInput(Iplayer, y)           'Calls subprocedure that inputs intermediate high scores
        Process(Iplayer, y)         'Calls subprocedure that processes and sorts intermediate high scores
        IntermediateOutput(Iplayer, y)          'Calls subprocedure that outputs intermediate high scores

        ExpertInput(Eplayer, z)                 'Calls subprocedure that inputs expert high score
        Process(Eplayer, z)               'Calls subprocedure that processes and sorts expert high scores
        ExpertOutput(Eplayer, z)                'Calls subprocedure that outputs expert high scores

    End Sub

    Private Sub BeginnerInput(ByRef player() As pe_player, ByRef x As Integer)

        Dim path As String = "C:\Users\acolv\Desktop\PROJECT\PROJECT\Project\BeginnerLeaderboard.csv"      'Sets path to be the file path

        Dim leaderboard As StreamReader = New StreamReader(path)        'defines local variable leaderboard as a newstreamreader

        Do While leaderboard.Peek() > -1                'loop until end of file
            leaderboard.ReadLine()                      'read file line
            x += 1                                      'increments value of x
        Loop

        leaderboard.Close()         'closes leaderboard

        FileOpen(1, path, OpenMode.Input)  'opens file with predefined file path

        For i = 1 To x          'loop until end of file
            Input(1, player(i).playerName)  'inputs player name
            Input(1, player(i).playerTime)  'inputs player time
            player(i).position = i          'sets position to be the index
        Next

        FileClose()

    End Sub

    Private Sub BeginnerOutput(ByRef player() As pe_player, ByVal x As Integer)

        For i = 1 To x
            lstBPositions.Items.Add(player(i).position) 'adds position to list box
            lstBNames.Items.Add(player(i).playerName)   'adds name to list box
            lstBTimes.Items.Add(player(i).playerTime)   'adds time to list box
        Next

    End Sub

    Private Sub IntermediateInput(ByRef player() As pe_player, ByRef x As Integer)

        Dim path As String = "C:\Users\acolv\Desktop\PROJECT\PROJECT\Project\IntermediateLeaderboard.csv"          'Sets path to be the file path

        Dim leaderboard As StreamReader = New StreamReader(path)    'defines local variable leaderboard as a newstreamreader

        Do While leaderboard.Peek() > -1        'loop until end of file
            leaderboard.ReadLine()              'read file line
            x += 1                              'increments x
        Loop

        leaderboard.Close() 'closes file

        FileOpen(1, path, OpenMode.Input)   'opens file with path predefined

        For i = 1 To x                      'loop until file end
            Input(1, player(i).playerName)  'input player name
            Input(1, player(i).playerTime)  'input player time
            player(i).position = i          'set player position to index
        Next

        FileClose() 'close file

    End Sub



    Private Sub IntermediateOutput(ByRef player() As pe_player, ByVal x As Integer)

        For i = 1 To x
            lstIPositions.Items.Add(player(i).position) 'adds position to list box
            lstINames.Items.Add(player(i).playerName)   'adds name to list box
            lstITimes.Items.Add(player(i).playerTime)   'adds time to list box
        Next

    End Sub

    Private Sub ExpertInput(ByRef player() As pe_player, ByRef x As Integer)

        Dim path As String = "C:\Users\acolv\Desktop\PROJECT\PROJECT\Project\ExpertLeaderboard.csv"            'Sets path to be the file path

        Dim leaderboard As StreamReader = New StreamReader(path)    'defines local variable leaderboard as a newstreamreader

        Do While leaderboard.Peek() > -1        'loop until end of file
            leaderboard.ReadLine()              'read file line
            x += 1                              'increments x
        Loop

        leaderboard.Close() 'closes file

        FileOpen(1, path, OpenMode.Input)   'opens file with path predefined

        For i = 1 To x      'loops until end of file
            Input(1, player(i).playerName)  'inputs player name
            Input(1, player(i).playerTime)  'inputs player time
            player(i).position = i          'sets player position to be index
        Next

        FileClose() 'closes file

    End Sub



    Private Sub ExpertOutput(ByRef player() As pe_player, ByVal x As Integer)

        For i = 1 To x
            lstEPositions.Items.Add(player(i).position) 'adds position to list box
            lstENames.Items.Add(player(i).playerName)   'adds name to list box
            lstETimes.Items.Add(player(i).playerTime)   'adds time to list box
        Next

    End Sub

    Private Sub Process(ByRef player() As pe_player, ByVal x As Integer)
        Dim i As Integer
        Dim j As Integer
        Dim temp As Object

        For i = 0 To x - 1          'loops through every index
            For j = i + 1 To x      'loops until index is at the end of file
                If player(i).playerTime > player(j).playerTime Then     'if the player1time>player2time then swap
                    temp = player(i)
                    player(i) = player(j)
                    player(j) = temp
                End If
            Next
        Next

        Dim k As Integer

        For k = 1 To x
            player(k).position = k      'sets position to be index
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Forms.Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnHow2Play_Click(sender As Object, e As EventArgs) Handles btnHow2Play.Click

        My.Forms.Instructions.Show()
        Me.Close()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        My.Forms.Start.Show()
        Me.Close()

    End Sub

End Class
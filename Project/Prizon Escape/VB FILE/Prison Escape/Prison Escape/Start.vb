Imports Prison_Escape.MineCell.MineCellView 'imports usercontrol 'minecell.minecellview' so that it can be refered to shorthand (ie as flag) instead of longhand (ie as Prison_Escape.MineCell.MineCellView.flag)
Public Class Start
    Dim cellSize As Integer = 40    'Size of each minecell
    Dim boardRows As Integer = 9    'Initial height of board
    Dim boardCols As Integer = 9    'Initial width of board
    Dim mineCount As Integer = 11   'Initial number of mines
    Dim seconds As Integer = 0      'Initial value of time taken to solve puzzle 
    Dim markedMines As Integer = 0  'number of sirens that have been flagged
    Dim finished As Boolean = False 'whether the game has completed (either click a mine, located all the mines or clicked all the "safe" spaces

    'Initialising 2D Array to act as a grid
    Dim mineField(9, 9) As MineCell

    'creating a structure to store the player data so it can be stored and sorted
    Structure pe_player             'creates structure prisonescape player
        Dim position As Integer     'leaderboard position
        Dim playerName As String    'name of player
        Dim playerTime As Integer   'time taken to complete game
        Dim difficulty As Char    'what difficulty they were playing (beginner, intermediate, expert)
    End Structure

    Dim player As pe_player 'defines player as the user defined structure pe_player

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'when the form loads go to sub procedure Buildboard()
        BuildBoard()
    End Sub

    Private Sub BuildBoard()    'defines sub procedure as buildboard

        finished = False    'sets the game over to false

        seconds = 0             'resets initial variables
        markedMines = 0
        DoLabels()              'updates the labels
        Timer1.Enabled = False  'turns the timer off

        lblMessage.Text = String.Empty  'clears the message label


        Me.Hide()   'hides the form until sirens have been placed

        'Loop through the rows and columns
        ReDim mineField(boardRows - 1, boardCols - 1)
        pnlMine.Controls.Clear()

        For Row As Integer = 0 To boardRows - 1          'Loop through the rows
            For Col As Integer = 0 To boardCols - 1      'Loop through the columns
                Dim C As New MineCell                    'defines c as a new mincell so that all the cells can be placed
                pnlMine.Controls.Add(C)                  'adds minecell to panel
                C.Left = cellSize * Col                  'sets location of cell (from left) to the cellsize times the column number
                C.Top = cellSize * Row                   'sets location of cell (from top) to the cellsize times the row number
                C.Width = cellSize                       'sets the width to be the predefined cellsize
                C.Height = cellSize                      'sets the height to be the predefined cellsize
                C.HasMine = False                        'the default value is for there to be no mine in a cell
                C.Number = 0
                C.x = Col                                'x coordinate to the column
                C.y = Row                                'y coordinate to the row
                mineField(Row, Col) = C
                AddHandler C.MouseClick, AddressOf MineClick
            Next
        Next

        'Generate Random mine Locations
        Dim RX As New Random
        For i As Integer = 1 To mineCount                   'loops through until predetermined number of mines have been placed
            Dim X As Integer = 0                            'sets x as (columns) a number equal to zero
            Dim Y As Integer = 0                            'sets y as (rows) a number equal to zero
            Do
                X = RX.Next(0, boardCols)                   'Generates random x coordinate
                Y = RX.Next(0, boardRows)                   'generates random y coordinate
            Loop Until Not mineField(Y, X).HasMine          'if it has a mine then this will be true
            mineField(Y, X).HasMine = True                  'sets the value of hasmine to true meaning that the siren location has been marked
            'mineField(Y, X).View = MineCell.MineCellView.Mine          'this shows Me where the mines are When i am testing
            'mineField(Y, X).ButtonColour = Color.Red                   'this changes the colour Of the squares where there are mines To red
        Next

        'Count the mines
        For Row As Integer = 0 To boardRows - 1                 'this procedure counts the number of mines adjacent to a square with numbers in it
            For Col As Integer = 0 To boardCols - 1
                If Not mineField(Row, Col).HasMine Then
                    For R As Integer = Row - 1 To Row + 1
                        For C As Integer = Col - 1 To Col + 1
                            If R >= 0 And R < boardRows And C >= 0 And C < boardCols And Not (Row = R And Col = R) Then
                                If mineField(R, C).HasMine Then         'if there is a mines
                                    mineField(Row, Col).Number += 1     'add one to the number in the square
                                End If
                            End If
                        Next
                    Next
                End If
                If mineField(Row, Col).Number = 0 Then
                    'mineField(Row, Col).View = MineCell.MineCellView.Number        'this shows me the numbers around the mines when testing
                    'mineField(Row, Col).ButtonColour = Color.Green                 'this changes the colour Of the cells With numbers In To green which Is useful When testing
                End If
            Next
        Next


        'Resize to fit
        Me.Width = boardCols * cellSize                     'changes the size of the form to the correct width
        Do Until Me.pnlMine.Width = boardCols * cellSize
            Me.Width += 1
        Loop

        Me.Height = boardRows * cellSize
        Do Until Me.pnlMine.Height = boardRows * cellSize   'changes the size of the form to the correct height
            Me.Height += 1
        Loop

        Me.Show()
    End Sub

    Private Sub startGame(Rows As Integer, Cols As Integer, ByVal Mines As Integer)
        boardRows = Rows
        boardCols = Cols
        mineCount = Mines
        BuildBoard()                'goes to buildBoard procedure
    End Sub

    Private Sub MineClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If finished Then Exit Sub

        Dim M As MineCell = sender
        Timer1.Enabled = True
        lblMessages.Text = "Game in Progress"       'once the timer is on the game is playing


        If e.Button = MouseButtons.Left Then                    'if the left button is clicked then the following applies;
            If M.HasMine Then                                   'if there is a  mine in the cell then 
                For Each MC As MineCell In mineField
                    If MC.HasMine Then MC.View = Mine 'shows all mines
                Next
                Timer1.Enabled = False                'the timer stops
                lblMessages.Text = "You have been caught!"  'the message updates to tell the user they have lost the game
                finished = True
            ElseIf M.Number > 0 Then                            'if there is a number then 
                M.View = Number                                 'show the number
                If gameOver() Then                              'if game finish criterea has been met then 
                    Timer1.Enabled = False                      'the timer stops
                    lblMessages.Text = "You have successfully escaped from prison"  'the message updates to tell the user they have won the game
                    finished = True                             'the game is now finished
                    export_times(player, boardCols)             'the export_times procedure is called
                End If
            ElseIf M.Number = 0 Then                            'if there are no mines adjacent then
                ShowBlanks(M)                                   'go to procedure showblanks until all the blanks have been cleared up to either the edge of the grid or a border of numbers
                If gameOver() Then                              'if this means they have beaten the game then 
                    Timer1.Enabled = False                      'the timer stops
                    lblMessages.Text = "You have successfully escaped from prison"  'the message updates to tell the user they have won the game
                    finished = True                             'the game is now finished
                    export_times(player, boardCols)             'the export_times procedure is now called
                End If
            End If



        ElseIf e.Button = MouseButtons.Right Then           'if the right mouse button is clicked
            Select Case M.View                              'selects to compare the current view of the cell
                Case Button                                 'if the cell is a button then
                    M.View = Flag                           'make it a flag
                    markedMines += 1                        'increase the number of marked mines
                    DoLabels()                              'update labels to show this
                Case Flag                                   'if the cell is a flag then
                    M.View = Question                       'make it a question mark
                    markedMines -= 1                        'reduce number of marked mines
                    DoLabels()                              'update labels to show this
                Case Else
                    M.View = Button                         'if it is currently a question make it a button
            End Select

        End If

    End Sub

    Private Sub ShowBlanks(M As MineCell)               'recursive algorithm to clear blank cells
        M.View = Number
        For R As Integer = M.y - 1 To M.y + 1           'for the rows one above and one below of the clicked box
            For C As Integer = M.x - 1 To M.x + 1       'for the columns one to the left and one to the right of the clicked box
                If R >= 0 And R < boardRows And C >= 0 And C < boardCols Then   'if cell is on board 
                    Dim MC As MineCell = mineField(R, C)                        'sets the value of mc as current minecell
                    If MC.View = Button Then                                    'if there is a button ie hasn't already been cleared
                        If MC.Number = 0 Then                                   'if the number underneath the button is zero ie there are no mines adjacent to cell
                            ShowBlanks(MC)                                      'then go to this procedure with this cell as the actual parameter - this will repeat until only cells with mines adjacent are left
                        Else
                            MC.View = Number                                    'if there is a number then show that number
                        End If
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        seconds += 1        'adds one to the number of seconds every second
        DoLabels()          'goes to the update labels procedure to update this
    End Sub

    Private Sub DoLabels()
        lblClock.Text = seconds.ToString                    'writes the current time value to label
        lblMines.Text = (mineCount - markedMines).ToString  'writes current number of sirens to label
    End Sub

    Private Function gameOver() As Boolean
        Dim TV As Boolean = True                                'set game over to be true
        For Each MC As MineCell In mineField                    'for every cell in grid
            If Not MC.HasMine And Not MC.View = Number Then     'if there isnot a mine or a number then
                TV = False                                      'set game over to be false
            End If
        Next
        Return TV
    End Function

    Private Sub BeginnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeginnerToolStripMenuItem.Click
        'starts game with 9 rows, 9 columns and 11 sirens

        startGame(9, 9, 11)

    End Sub

    Private Sub IntermediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntermediateToolStripMenuItem.Click
        'starts game with 16 rows, 16 columns and 40 sirens

        startGame(16, 16, 40)

    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        'starts game with 16 rows, 30 columns and 99 sirens

        startGame(16, 30, 99)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click, Button1.Click
        BuildBoard()
    End Sub

    Private Sub export_times(ByVal player As pe_player, ByVal boardCols As Integer)

        Select Case boardCols                   'this is to determine what difficulty the user was playing
            Case 9
                player.difficulty = "B"         'if there are 9 columns then beginner
            Case 16
                player.difficulty = "I"         'if there are 16 columns then intermediate
            Case 30
                player.difficulty = "E"         'if there are 30 columns then expert
        End Select

        player.playerName = InputBox("Please enter you name. Note it must be less than 20 characters to ensure it is properly displayed on the scoreboard")   'sets player name to be defined by the user
        If Len(player.playerName) > 20 Or Len(player.playerName) < 1 Then 'input validation
            MsgBox("Name must be less than 20 and more than 0 characters to ensure it is properly displayed on the scoreboard")
        End If
        player.playerTime = seconds                             'takes the time taken to complete the game from the timer

        Dim export As String
        Dim file As System.IO.StreamWriter

        Select Case player.difficulty                   'exports to different files depending on difficulty
            Case "B"
                file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\acolv\Desktop\PROJECT\PROJECT\Project\BeginnerLeaderboard.csv", True)   'open file with this path
                export = (player.playerName & ", " & player.playerTime)                                                                     'set export to be current player stats
                file.WriteLine(export)                                                                                                      'write current player stats to file
                file.Close()                                                                                                                'close the file
            Case "I"
                file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\acolv\Desktop\PROJECT\PROJECT\Project\IntermediateLeaderboard.csv", True)   'open file with this path
                export = (player.playerName & ", " & player.playerTime)                                                                         'set export to be current player stats
                file.WriteLine(export)                                                                                                          'write current player stats to file
                file.Close()                                                                                                                    'close the file
            Case "E"
                file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\acolv\Desktop\PROJECT\PROJECT\Project\ExpertLeaderboard.csv", True)     'open file with this path
                export = (player.playerName & ", " & player.playerTime)                                                                     'set export to be current player stats
                file.WriteLine(export)                                                                                                      'write current player stats to file
                file.Close()                                                                                                                'close the file
        End Select

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        My.Forms.Form1.Show()           'shows home screen
        Me.Close()                      'closes game from
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        My.Forms.Instructions.Show()    'opens the instructions
    End Sub

    Private Sub btnScoreboard_Click(sender As Object, e As EventArgs) Handles btnScoreboard.Click
        My.Forms.scoreboard.Show()      'opens the scoreboard
    End Sub

End Class
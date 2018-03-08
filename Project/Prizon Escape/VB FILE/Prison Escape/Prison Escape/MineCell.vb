Public Class MineCell

    'Enum for MineCell Views
    Public Enum MineCellView
        Button
        Mine
        Number
        Flag
        Question
    End Enum

    'Field Values
    Private mView As MineCellView
    Private mNumber As Integer
    Private mHasMine As Boolean
    Private myX As Integer
    Private myY As Integer
    Private mButtonColour As Color = Color.LightGray


    'Property Interfaces
    Public Property ButtonColour() As Color
        Get
            Return mButtonColour
        End Get
        Set(value As Color)
            mButtonColour = value
        End Set
    End Property


    Public Property HasMine() As Boolean
        Get
            Return mHasMine
        End Get
        Set(ByVal value As Boolean)
            mHasMine = value
        End Set
    End Property

    Public Property x() As Integer
        Get
            Return myX
        End Get
        Set(ByVal value As Integer)
            myX = value
        End Set
    End Property

    Public Property y() As Integer
        Get
            Return myY
        End Get
        Set(ByVal value As Integer)
            myY = value
        End Set
    End Property

    Public Property Number() As Integer
        Get
            Return mNumber
        End Get
        Set(value As Integer)       'Anytime a new number is required redraw is forced
            mNumber = value
            Me.Invalidate()
        End Set
    End Property

    Public Property View() As MineCellView
        Get
            Return mView
        End Get
        Set(value As MineCellView)
            mView = value
            Me.Invalidate()
        End Set
    End Property


    'The paint routine to draw all the different views
    Private Sub MineCell_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Select Case mView
            Case MineCellView.Button            'draws the button
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(mButtonColour)

                    'Special Points to shade
                    Dim TopLeft As New PointF(-1, -1)
                    Dim TopRight As New PointF(1, -1)
                    Dim BotLeft As New Point(-1, 1)
                    Dim BotRight As New Point(1, 1)

                    'lines for dark colour
                    Dim mPen As New Pen(Color.Gray, 0.3)
                    .DrawLine(mPen, BotRight, BotLeft)
                    .DrawLine(mPen, BotRight, TopRight)

                    'lines for light colour
                    mPen = New Pen(Color.White, 0.3)
                    .DrawLine(mPen, TopLeft, BotLeft)
                    .DrawLine(mPen, TopLeft, TopRight)

                End With

            Case MineCellView.Flag          'draws the flag - which in this case is a cop badge
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(Color.LightGray)

                    'Special Points to shade
                    Dim TopLeft As New PointF(-1, -1)
                    Dim TopRight As New PointF(1, -1)
                    Dim BotLeft As New Point(-1, 1)
                    Dim BotRight As New Point(1, 1)

                    'lines for dark colour
                    Dim mPen As New Pen(Color.Gray, 0.3)
                    .DrawLine(mPen, BotRight, BotLeft)
                    .DrawLine(mPen, BotRight, TopRight)

                    'lines for light colour
                    mPen = New Pen(Color.White, 0.3)
                    .DrawLine(mPen, TopLeft, BotLeft)
                    .DrawLine(mPen, TopLeft, TopRight)

                    'Draw Shield
                    Dim CRect As New RectangleF(-0.6, -0.6, 1.2, 1.2)
                    Dim CBrush As New SolidBrush(Color.Gold)
                    .FillEllipse(CBrush, CRect)
                    Dim TRect As New RectangleF(-0.6, -0.7, 1.2, 0.7)
                    .FillRectangle(CBrush, TRect)

                    'Write "cop"
                    Dim NBrush As New SolidBrush(Color.Black)
                    Dim myFont As New Font("Arial", 0.5, FontStyle.Bold, GraphicsUnit.World)
                    Dim SS As SizeF = .MeasureString("COP", myFont)
                    .DrawString("COP", myFont, NBrush, -SS.Width / 2, ((-SS.Height / 2) - 0.3))

                End With

            Case MineCellView.Mine          'draws mine which in this case is a cop shield
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(Color.WhiteSmoke)

                    'Draw Circle
                    Dim CRect As New RectangleF(-0.6, -0.6, 1.2, 1.2)
                    Dim CBrush As New SolidBrush(Color.Red)
                    .FillEllipse(CBrush, CRect)

                    'Draw Pegs
                    Dim IRad As Single = 0.5 'IRad is inside radius
                    Dim ORad As Single = 0.8 'ORad is outside radius
                    Dim PPen As New Pen(Color.Orange, 0.15)

                    PPen.EndCap = Drawing2D.LineCap.Round 'Make ends of light round

                    For ang As Single = 0 To 1.75 * Math.PI Step 0.25 * Math.PI
                        Dim Inner As New PointF(IRad * Math.Cos(ang), IRad * Math.Sin(ang))
                        Dim Outer As New PointF(ORad * Math.Cos(ang), ORad * Math.Sin(ang))
                        .DrawLine(PPen, Inner, Outer)
                    Next

                    'Write "!"
                    Dim NBrush As New SolidBrush(Color.White)
                    Dim myFont As New Font("Arial", 1.25, FontStyle.Bold, GraphicsUnit.World)
                    Dim SS As SizeF = .MeasureString("!", myFont)
                    .DrawString("!", myFont, NBrush, -SS.Width / 2, -SS.Height / 2)

                    'Draw Border
                    Dim BRect As New Rectangle(-1, -1, 2, 2)
                    Dim BPen As New Pen(Color.Gray, 0.05)
                    .DrawRectangle(BPen, BRect)

                End With
            Case MineCellView.Number
                Dim NColors() As Color = {Color.Blue, Color.Green, Color.Red,
                                          Color.Navy, Color.DarkGreen, Color.DarkRed,
                                          Color.Brown, Color.Black}


                With e.Graphics
                    'Set Scale
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(Color.WhiteSmoke)

                    If mNumber > 0 And mNumber <= 8 Then
                        'Draw a number
                        Dim NBrush As New SolidBrush(NColors(mNumber - 1))
                        Dim myFont As New Font("Arial", 1.5, FontStyle.Bold, GraphicsUnit.World)
                        Dim SS As SizeF = .MeasureString(mNumber.ToString, myFont)
                        .DrawString(mNumber.ToString, myFont, NBrush, -SS.Width / 2, -SS.Height / 2)
                    End If

                    'Draw Border
                    Dim BRect As New Rectangle(-1, -1, 2, 2)
                    Dim BPen As New Pen(Color.Gray, 0.05)
                    .DrawRectangle(BPen, BRect)

                End With

            Case MineCellView.Question
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(Color.LightGray)

                    'Draw question mark
                    Dim NBrush As New SolidBrush(Color.Black)
                    Dim myFont As New Font("Arial", 1.5, FontStyle.Bold, GraphicsUnit.World)
                    Dim SS As SizeF = .MeasureString("?", myFont)
                    .DrawString("?", myFont, NBrush, -SS.Width / 2, -SS.Height / 2)

                    'Special Points to shade
                    Dim TopLeft As New PointF(-1, -1)
                    Dim TopRight As New PointF(1, -1)
                    Dim BotLeft As New Point(-1, 1)
                    Dim BotRight As New Point(1, 1)

                    'lines for dark colour
                    Dim mPen As New Pen(Color.Gray, 0.3)
                    .DrawLine(mPen, BotRight, BotLeft)
                    .DrawLine(mPen, BotRight, TopRight)

                    'lines for light colour
                    mPen = New Pen(Color.White, 0.3)
                    .DrawLine(mPen, TopLeft, BotLeft)
                    .DrawLine(mPen, TopLeft, TopRight)

                End With

        End Select
    End Sub

End Class

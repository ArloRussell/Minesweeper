Public Class Form1
    Private rand As New Random
    Private Shared mineImg As Image = My.Resources.mine
    Private Shared badFlagImg As Image = My.Resources.wrongFlag
    Private totSafe As Integer
    Private totClicked As Integer
    Private xCount As Integer = 9
    Private yCount As Integer = 9
    Private mineCount As Integer = 10
    Private board As List(Of List(Of space))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBoard(xCount, yCount, mineCount)
    End Sub

    Private Sub LoadBoard(x As Integer, y As Integer, mine As Integer)
        PnlBoard.Controls.Clear()
        board = New List(Of List(Of space))
        Dim cellsize As Double = 50
        Dim counter As Integer
        Dim ev3 As Integer
        Dim count As Integer = 0
        PnlBoard.Width = x * 50
        PnlBoard.Height = y * 50

        Width = PnlBoard.Width + 50
        pnlTitle.Width = PnlBoard.Width
        LblTitle.Location = New Point((pnlTitle.Width / 2) - 122, 10)
        lblProTitle.Location = New Point(pnlTitle.Width - 94, 10)
        lblPro.Location = New Point(pnlTitle.Width - 94, 45)
        btnReset.Location = New Point((pnlTitle.Width / 2) - 34, 70)
        Height = PnlBoard.Height + 230


        lblMines.Text = mine.ToString
        lblPro.Text = "0%"
        totClicked = 0
        totSafe = 0
        For i As Integer = 0 To x - 1
            board.Add(New List(Of space))
            For j As Integer = 0 To y - 1

                'Dim open As Boolean = OpenClose()
                'If open Then
                '    ev3 += 1
                '
                'End If
                'If ev3 >= 3 Then
                '    If ev3 = 4 Then
                '        ev3 = 0
                '    End If
                '    open = False
                'End If
                'If counter = mine Then
                '    open = False
                'End If
                '
                'If open Then
                '    counter += 1
                'End If


                Dim cell As New space With {
                    .Location = New Point(cellsize * i, cellsize * j),
                    .Width = cellsize,
                    .Height = cellsize,
                    .Tag = count,
                    .Font = New Font("Harlow Solid Italic", 17.75, FontStyle.Italic)
                    }
                AddHandler cell.MouseUp, AddressOf FullHandler
                count += 1
                PnlBoard.Controls.Add(cell)
                board(i).Add(cell)


            Next
        Next
        totSafe = (x * y) - mine
        addMines(mine)
    End Sub

    Private Sub addMines(numOfMines As Integer)
        While numOfMines > 0
            Dim row As Integer = rand.Next(board.Count)
            Dim col As Integer = rand.Next(board(0).Count) 'this assumes there's at least one row (or col?)
            If Not board(row)(col).IsMine Then
                board(row)(col).IsMine = True
                numOfMines -= 1
            End If
        End While
    End Sub

    Private Sub FullHandler(sender As space, e As MouseEventArgs)
        Dim count As Integer
        If e.Button = MouseButtons.Right Then
            sender.IsFlagged = Not sender.IsFlagged
            Integer.TryParse(lblMines.Text, count)
            If sender.IsFlagged Then
                count -= 1
            ElseIf sender.IsRevealed = False Then
                count += 1
            End If
            lblMines.Text = count.ToString
        Else
            If sender.IsRevealed = False Then
                'Console.WriteLine("Beep")
                sender.IsRevealed = True
                If sender.IsMine Then
                    sender.BackgroundImage = mineImg
                    MsgBox("Game Over")
                    For Each m As space In PnlBoard.Controls
                        If m.IsMine AndAlso Not m.IsFlagged Then
                            m.BackgroundImage = mineImg
                        End If
                        If Not m.IsMine AndAlso m.IsFlagged Then
                            m.BackgroundImage = badFlagImg
                        End If
                    Next
                    MsgBox($"You cleared {lblPro.Text} of the board. {vbNewLine}Click okay to reset the board.")
                    LoadBoard(xCount, yCount, mineCount)
                Else
                    MineAround(sender)
                    totClicked += 1
                    lblPro.Text = (totClicked / totSafe).ToString("P0")
                End If
            End If
            If totClicked = totSafe Then
                For Each f As space In PnlBoard.Controls
                    If Not f.IsRevealed Then
                        f.IsFlagged = True
                    End If
                    lblMines.Text = 0
                    MsgBox("Yippee!")
                Next
            End If
        End If
    End Sub

    Private Sub MineAround(cell As space)
        Dim ogtag As Integer = cell.Tag
        Dim countOfMines As Integer = 0
        Dim checktags() As Integer = {ogtag - xCount - 1, ogtag - xCount, ogtag - xCount + 1, ogtag - 1, ogtag + 1, ogtag + xCount - 1, ogtag + xCount, ogtag + xCount + 1}
        For Each m As space In PnlBoard.Controls
            If checktags.Contains(m.Tag) AndAlso m.IsMine Then
                countOfMines += 1
            End If
        Next
        cell.ForeColor = Color.White
        cell.Text = countOfMines.ToString
        '? maybe ? if countOfMines is 0 then call minearound for all neighbor spaces 
        If countOfMines = 0 Then
            cell.Text = Nothing
            For Each m As space In PnlBoard.Controls
                If checktags.Contains(m.Tag) AndAlso m.IsRevealed = False Then
                    m.IsRevealed = True
                    totClicked += 1
                    lblPro.Text = (totClicked / totSafe).ToString("P0")
                    MineAround(m)
                End If
            Next
        End If
    End Sub

    Private Function OpenClose()
        Dim random As Integer = rand.Next(0, 2)

        If random = 1 Then
            Return True 'Is Mine
        Else
            Return False 'is Not Mine
        End If
    End Function

    Private Sub Beginner9910ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Beginner9910ToolStripMenuItem.Click
        xCount = 9
        yCount = 9
        mineCount = 10
        LoadBoard(xCount, yCount, mineCount)
    End Sub

    Private Sub Intermediate161640ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Intermediate161640ToolStripMenuItem.Click
        xCount = 16
        yCount = 16
        mineCount = 40
        LoadBoard(xCount, yCount, mineCount)
    End Sub

    Private Sub Expert301699ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Expert301699ToolStripMenuItem.Click
        xCount = 30
        yCount = 16
        mineCount = 99
        LoadBoard(xCount, yCount, mineCount)
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        LoadBoard(xCount, yCount, mineCount)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        LoadBoard(xCount, yCount, mineCount)
    End Sub

    Private Sub CheatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheatToolStripMenuItem.Click
        For i As Integer = 0 To board.Count - 1
            For j As Integer = 0 To board(i).Count - 1
                board(i)(j).Text = board(i)(j).IsMine
                If board(i)(j).IsMine Then
                    board(i)(j).ForeColor = Color.White
                    board(i)(j).BackColor = Color.Purple
                End If
            Next
        Next
    End Sub


End Class

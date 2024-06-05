Public Class space
    Inherits Button

    Private _isMine As Boolean
    Private _neighborMineCount As Integer
    Private _isRevealed As Boolean = False
    Private _isFlagged As Boolean
    Public clicked As Boolean = False
    Private Shared flagImg As Image = My.Resources.flag

    Public Sub New()
        BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Public Property IsMine As Boolean
        Get
            Return _isMine
        End Get
        Set(value As Boolean)
            _isMine = value
        End Set
    End Property

    Public Property NeighborMineCount As Integer
        Get
            Return _neighborMineCount
        End Get
        Set(value As Integer)
            _neighborMineCount = value
        End Set
    End Property

    Public Property IsRevealed As Boolean
        Get
            Return _isRevealed
        End Get
        Set(value As Boolean)
            If IsFlagged Then
                value = False
            End If
            _isRevealed = value
            If _isRevealed AndAlso Not IsMine Then
                BackColor = Color.Gray
                FlatStyle = FlatStyle.Flat
                Text = Nothing

            End If
        End Set
    End Property

    Public Property IsFlagged As Boolean
        Get
            Return _isFlagged
        End Get
        Set(value As Boolean)
            If IsRevealed Then
                value = False
            End If
            _isFlagged = value
            If _isFlagged Then
                BackgroundImage = flagImg
                Text = Nothing
            ElseIf Not IsRevealed AndAlso Not _isFlagged Then
                BackgroundImage = Nothing
                Text = Nothing
            End If
        End Set
    End Property


End Class

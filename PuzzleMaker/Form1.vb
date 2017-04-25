Imports System.IO

Public Class Form1
    Public strClipboard As String = ""
    Public clipboardContents As String = ""
    Public editingFrag As Boolean = True
    Public editingWord As Boolean = False
    Public editingClue As Boolean = False
    Public loadedWords As Boolean = False
    Public strPuzzleType As String = ""
    Public wordsThatWork As New List(Of String)
    Public wordCount As Integer = 0
    Public counter As Integer = 0
    Public numPuzzles As Integer = -1
    Public strFileName As String = ""
    Public Class PuzzString
        Public strPuzzle As String
        Public Sub New(strPuzzle As String)
            Me.strPuzzle = strPuzzle
        End Sub
        Public Sub setValue(strPuzzle As String)
            Me.strPuzzle = strPuzzle
        End Sub
    End Class

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Right
                If editingClue Or editingWord Then
                    Return False
                End If
                If txtFrag.Text.Length < 1 Then
                    MsgBox("Please enter a key fragment")
                    Return True
                End If
                If counter < wordsThatWork.Count - 1 Then
                    counter = counter + 1
                    txtWord.Text = wordsThatWork(counter)
                End If
                Return True
            Case Keys.Left
                If editingClue Or editingWord Then
                    Return False
                End If
                If txtFrag.Text.Length < 1 Then
                    MsgBox("Please enter a key fragment")
                    Return True
                End If
                If counter > 0 Then
                    counter = counter - 1
                    txtWord.Text = wordsThatWork(counter)
                End If
                Return True
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If Not strPuzzleType = "Theme" And Not loadedWords Then
            MsgBox("Please load words first")
            Return
        End If
        If editingFrag Then
            LoadWords()
            btnEnter.Focus()
            Return
        End If
        If txtFrag.Text.Length < 1 Then
            MsgBox("Please enter letters in the Fragment box")
            Return
        End If
        If txtClue.Text.Length < 3 Then
            MsgBox("Please enter a clue")
            Return
        End If
        If txtWord.Text.Length > 12 Then
            MsgBox("That word is more than 12 letters")
            Return
        End If
        If strPuzzleType.Length < 1 Then
            MsgBox("Select a Puzzle Type first...")
            Return
        End If
        If strPuzzleType = "Easy" Then
            If Not (txtWord.Text.Substring(0, txtFrag.Text.Length) = txtFrag.Text) Then
                MsgBox("Wrong placement of keyFrag in word!")
            End If
        Else
            If Not (txtWord.Text.Substring(0, txtFrag.Text.Length) = txtFrag.Text Or txtWord.Text.Substring(txtWord.Text.Length - txtFrag.Text.Length) = txtFrag.Text Or (txtWord.Text.IndexOf(txtFrag.Text) <> 1 And txtWord.Text.IndexOf(txtFrag.Text) <> txtWord.Text.Length - (txtFrag.Text.Length + 1))) Then
                MsgBox("Wrong placement of keyFrag in word!")
                Return
            End If
        End If
        'Dim outPath As String = "D:\FragMental Puzzles\puzzleStrings\" + strPuzzleType + "\" + txtFrag.Text + ".txt"
        'If Not File.Exists(outPath) Then
        '    File.Create(outPath).Dispose()
        'End If

        Try
            Dim sw As StreamWriter = File.AppendText(strFileName)
            Dim outString As String = txtWord.Text.ToLower.Trim + "|" + txtClue.Text.Trim
            sw.WriteLine(outString)
            sw.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        determineHighLowCount(txtWord.Text, txtFrag.Text)
        lblCount.Text = Convert.ToString(Convert.ToInt32(lblCount.Text) + txtWord.Text.Length - txtFrag.Text.Length)
        lblWords.Text = Convert.ToString(Convert.ToInt32(lblWords.Text) + 1)
        editingWord = False
        editingClue = False
        counter = counter + 1
        txtWord.Text = wordsThatWork(counter)
        txtClue.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        strClipboard = Clipboard.GetText()
        If Not (String.Equals(strClipboard, clipboardContents)) Then
            If (editingWord = False And Not String.Equals(strClipboard, clipboardContents)) Then
                txtClue.Text = strClipboard
                clipboardContents = strClipboard
            Else
                txtWord.Text = strClipboard.ToLower
            End If
        End If
    End Sub

    Private Sub txtWord_Click(sender As Object, e As EventArgs) Handles txtWord.Click
        editingWord = True
    End Sub
    Private Sub txtWord_LostFocus(sender As Object, e As EventArgs) Handles txtWord.LostFocus
        Clipboard.SetText(txtWord.Text)
        clipboardContents = txtWord.Text
        strClipboard = txtWord.Text
        editingWord = False
    End Sub
    Private Sub txtWord_GotFocus(sender As Object, e As EventArgs) Handles txtWord.GotFocus
        editingWord = True
    End Sub
    Private Sub txtWord_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged
        If txtWord.Text.Length > 0 Then
            Clipboard.SetText(txtWord.Text)
            clipboardContents = txtWord.Text
            strClipboard = txtWord.Text
            editingWord = False
        End If
    End Sub
    Private Sub txtClue_TextChanged(sender As Object, e As EventArgs) Handles txtClue.TextChanged
        If txtClue.Text.Length = 1 Then
            txtClue.Text = txtClue.Text.ToUpper()
            txtClue.Select(txtClue.Text.Length + 1, 0)
        End If
        If txtClue.Text.Length > 0 And Not editingClue Then
            Dim array() As Char = txtClue.Text
            array(0) = Char.ToUpper(array(0))
            Dim strNew As New String(array)
            txtClue.Text = strNew
        End If
        If Not editingClue Then
            txtClue.Select(txtClue.Text.Length, 0)
        End If
    End Sub
    Private Sub rbnEasy_CheckedChanged(sender As Object, e As EventArgs) Handles rbnEasy.CheckedChanged
        If rbnEasy.Checked = True Then
            strPuzzleType = "Easy"
        End If
    End Sub
    Private Sub rbnMedium_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMedium.CheckedChanged
        If rbnMedium.Checked = True Then
            strPuzzleType = "Medium"
        End If

    End Sub
    Private Sub rbnHard_CheckedChanged(sender As Object, e As EventArgs) Handles rbnHard.CheckedChanged
        If rbnHard.Checked = True Then
            strPuzzleType = "Hard"
        End If

    End Sub
    Private Sub rbnTheme_CheckedChanged(sender As Object, e As EventArgs) Handles rbnTheme.CheckedChanged
        If rbnTheme.Checked = True Then
            strPuzzleType = "Theme"
        End If

    End Sub
    Private Sub txtClue_Click(sender As Object, e As EventArgs) Handles txtClue.Click
        editingClue = True
    End Sub
    Private Sub txtClue_LostFocus(sender As Object, e As EventArgs) Handles txtClue.LostFocus
        editingClue = False
    End Sub
    Private Sub txtFrag_GotFocus(sender As Object, e As EventArgs) Handles txtFrag.GotFocus
        editingFrag = True
    End Sub
    Private Sub txtFrag_LostFocus(sender As Object, e As EventArgs) Handles txtFrag.LostFocus
        editingFrag = False
    End Sub
    Private Sub lblCount_Click(sender As Object, e As EventArgs) Handles lblCount.Click
        lblCount.Text = "0"
    End Sub
    Private Sub lblNumPuzzles_Click(sender As Object, e As EventArgs) Handles lblNumPuzzles.Click
        lblNumPuzzles.Text = Convert.ToString(Convert.ToInt32(lblNumPuzzles.Text) + 1)
    End Sub
    Private Sub lblNumPuzzles_DoubleClick(sender As Object, e As EventArgs) Handles lblNumPuzzles.DoubleClick
        lblNumPuzzles.Text = "0"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        strClipboard = Clipboard.GetText()
        clipboardContents = strClipboard
        Me.TopMost = True
    End Sub

    Private Sub btnLoadWords_Click(sender As Object, e As EventArgs) Handles btnLoadWords.Click
        If strPuzzleType.Length < 1 Then
            MsgBox("Select a Puzzle Type first...")
            Return
        End If
        LoadWords()
        If Not loadedWords Then
            loadedWords = True
        End If
    End Sub


    Public Function LoadWords()
        Dim filePath As String = "D:\FragMental Puzzles\material\wordlist.txt"
        Dim keyFrag As String = "" 'txtFrag.Text
        Dim c As Integer = 0
        'If File.Exists("D:\FragMental Puzzles\puzzleStrings\" + strPuzzleType + "\" + txtFrag.Text + ".txt") Then
        '    MsgBox("You already have a file with that name")
        '    Exit Function
        'End If
        wordsThatWork.Clear()
        lblCount.Text = "0"
        lblWords.Text = "0"
        lblMin.Text = "0"
        lblMax.Text = "0"
        counter = 0
        RandomizeFile("D:\FragMental Puzzles\material\wordlist.txt")
        Dim letters() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Do
            keyFrag = ""
            Dim rnd As New Random()
            Dim x = rnd.Next(1, 3)
            For j As Integer = 0 To x
                Dim y = rnd.Next(0, 26)
                keyFrag += letters(y)
            Next

            Try
                Dim sr As StreamReader = New StreamReader(filePath)
                Dim checkThisWord As String = ""

                Do While sr.Peek() >= 0
                    checkThisWord = sr.ReadLine()
                    checkThisWord = checkThisWord.Trim
                    If Not strPuzzleType = "Theme" Then
                        If checkThisWord.Length - keyFrag.Length > 1 Then
                            If checkThisWord.IndexOf(keyFrag) > -1 Then
                                If strPuzzleType = "Easy" Then
                                    If checkThisWord.Substring(0, keyFrag.Length) = keyFrag Then
                                        wordsThatWork.Add(New String(checkThisWord))
                                        c = c + 1
                                    End If
                                Else
                                    If checkThisWord.Substring(0, keyFrag.Length) = keyFrag Or checkThisWord.Substring(checkThisWord.Length - keyFrag.Length) = keyFrag Or (checkThisWord.IndexOf(keyFrag) <> 1 And checkThisWord.IndexOf(keyFrag) <> checkThisWord.Length - (keyFrag.Length + 1)) Then
                                        wordsThatWork.Add(New String(checkThisWord))
                                        c = c + 1
                                    End If
                                End If
                            End If
                        End If
                    End If
                Loop
                sr.Close()
            Catch err As Exception
                Console.WriteLine("The file could Not be read:    ")
                Console.WriteLine(err.Message)
            End Try

            If strPuzzleType = "Hard" Then
                Try
                    Dim sr As StreamReader = New StreamReader(filePath)
                    Dim count As Integer = 0
                    Dim word As String = ""

                    Do While sr.Peek() >= 0 And count < c
                        word = sr.ReadLine()
                        If word.IndexOf(keyFrag) < 0 Then
                            wordsThatWork.Add(New String(word))
                            count += 1
                        End If
                    Loop
                    sr.Close()
                Catch err As Exception
                    Console.WriteLine("The file could not be read:   ")
                    Console.WriteLine(err.Message)
                End Try
                wordsThatWork = Shuffle(wordsThatWork)
                c = 2 * c
            End If

        Loop Until c > 200

        txtFrag.Text = keyFrag
        lblHowMany.Text = c.ToString
        txtWord.Text = wordsThatWork(0)
        txtClue.Text = ""
        txtClue.Focus()
        numPuzzles += 1
        lblNumPuzzles.Text = Convert.ToString(numPuzzles)

        strFileName = "D:\FragMental Puzzles\puzzleStrings\" + strPuzzleType + "\" + txtFrag.Text + "_0.txt"
        Dim increment As Integer = 0
        While File.Exists(strFileName)
            increment += 1
            Dim strIncrement As String = CType(increment, String)
            strFileName = "D:\FragMental Puzzles\puzzleStrings\" + strPuzzleType + "\" + txtFrag.Text + "_" + strIncrement + ".txt"
        End While
        If Not File.Exists(strFileName) Then
            File.Create(strFileName).Dispose()
        End If

    End Function

    Public Function RandomizeFile(path)
        Dim puzzleString As String = ""
        Dim filePath As String = path
        Dim filePathout As String = "D:\FragMental Puzzles\material\wordlist.txt"
        Dim allLines As New List(Of PuzzString)
        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Do While sr.Peek() >= 0
                puzzleString = sr.ReadLine()
                allLines.Add(New PuzzString(puzzleString))
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        allLines = ShuffleList(allLines)

        Try
            Dim sw As StreamWriter = File.CreateText(filePathout)

            For Each line In allLines
                sw.WriteLine(line.strPuzzle)
            Next
            sw.Close()
        Catch ex As Exception
        End Try

        Return True

    End Function

    Public Function ShuffleList(datalist)

        Dim x As Integer
        Dim r As Random = New Random()
        Dim str As String

        For i As Integer = datalist.Count - 1 To 0 Step -1
            x = Math.Floor(r.NextDouble() * (i + 1)) 'r.Next(0, i)
            str = datalist(x).strPuzzle
            datalist(x).setValue(datalist(i).strPuzzle)
            datalist(i).setValue(str)
        Next i
        Return datalist

    End Function

    Public Function determineHighLowCount(theWord, theFrag)
        theWord = Replace(theWord, theFrag, "^",, 1)
        Dim totalNumFrags As Integer = 0
        Dim Rand As New Random()
        Dim num As Integer = 0
        Dim loopCount As Integer = 0
        Dim position As Integer
        Dim numFrags(0, 0 To 1) As Integer
        Dim lowEnd As Integer = 100
        Dim highEnd As Integer = 0

        Do
            totalNumFrags = 0
            If (theWord.IndexOf("^") = 0) Then 'at beginning of word:
                position = 0
            ElseIf (theWord.IndexOf("^") = theWord.Length - 1) Then 'at end of word:
                position = 1
            ElseIf (theWord.IndexOf("^") < 0) Then 'not in word:
                position = -1
            Else 'somewhere in the middle of the word:
                position = 2
            End If
            Console.WriteLine("starting...")

            Dim r As Integer = 0
            Dim s As Integer = 0

            Select Case position
                Case 2
                    Select Case theWord.IndexOf("^")
                        Case 2
                            numFrags(0, 0) = 1
                            totalNumFrags += 1
                            Select Case theWord.Length
                                Case 5, 6
                                    numFrags(0, 1) = 1
                                    totalNumFrags = totalNumFrags + 1
                                Case 7
                                    r = Rand.Next(1, 3)
                                    numFrags(0, 1) = r
                                    totalNumFrags = totalNumFrags + r
                                Case 8
                                    numFrags(0, 1) = 2
                                    totalNumFrags = totalNumFrags + 2
                                Case 9, 10
                                    r = Rand.Next(2, 4)
                                    numFrags(0, 1) = r
                                    totalNumFrags = totalNumFrags + r
                                Case 11
                                    r = Rand.Next(2, 5)
                                    numFrags(0, 1) = r
                                    totalNumFrags = totalNumFrags + r
                            End Select
                        Case 3
                            numFrags(0, 0) = 1
                            totalNumFrags += 1
                            Select Case theWord.Length
                                Case 6, 7
                                    numFrags(0, 1) = 1
                                    totalNumFrags = totalNumFrags + 1
                                Case 8
                                    r = Rand.Next(1, 3)
                                    numFrags(0, 1) = r
                                    totalNumFrags = totalNumFrags + r
                                Case 9
                                    numFrags(0, 1) = 2
                                    totalNumFrags = totalNumFrags + 2
                                Case 10, 11
                                    r = Rand.Next(2, 4)
                                    numFrags(0, 1) = r
                                    totalNumFrags = totalNumFrags + r
                            End Select
                        Case 4
                            Select Case theWord.Length
                                Case 7, 8
                                    numFrags(0, 1) = 1
                                    r = Rand.Next(1, 3)
                                    numFrags(0, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                                Case 9, 10
                                    r = Rand.Next(1, 3)
                                    s = Rand.Next(1, 3)
                                    numFrags(0, 0) = r
                                    numFrags(0, 1) = s
                                    totalNumFrags = totalNumFrags + r + s
                                Case 11
                                    r = Rand.Next(1, 3)
                                    s = Rand.Next(2, 4)
                                    numFrags(0, 0) = r
                                    numFrags(0, 1) = s
                                    totalNumFrags = totalNumFrags + r + s
                            End Select
                        Case 5
                            Select Case theWord.Length
                                Case 8, 9
                                    numFrags(0, 1) = 1
                                    numFrags(0, 0) = 2
                                    totalNumFrags = totalNumFrags + 3
                                Case 10
                                    r = Rand.Next(1, 3)
                                    numFrags(0, 0) = 2
                                    numFrags(0, 1) = r
                                    totalNumFrags = totalNumFrags + r + 2
                                Case 11
                                    numFrags(0, 0) = 2
                                    numFrags(0, 1) = 2
                                    totalNumFrags = totalNumFrags + 4
                            End Select
                        Case 6
                            Select Case theWord.Length
                                Case 9, 10
                                    numFrags(0, 1) = 1
                                    r = Rand.Next(2, 4)
                                    numFrags(0, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                                Case 11
                                    r = Rand.Next(2, 4)
                                    s = Rand.Next(1, 3)
                                    numFrags(0, 0) = r
                                    numFrags(0, 1) = s
                                    totalNumFrags = totalNumFrags + r + s
                            End Select
                        Case 7
                            Select Case theWord.Length
                                Case 10, 11
                                    numFrags(0, 1) = 1
                                    r = Rand.Next(2, 4)
                                    numFrags(0, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                            End Select

                        Case 8
                            Select Case theWord.Length
                                Case 10, 11
                                    numFrags(0, 1) = 1
                                    r = Rand.Next(2, 5)
                                    numFrags(0, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                            End Select
                    End Select
                Case 1, 0
                    Select Case theWord.Length
                        Case 3, 4
                            num = 1
                        Case 5
                            num = Rand.Next(1, 3)
                        Case 6
                            num = 2
                        Case 7, 8
                            num = Rand.Next(2, 4)
                        Case 9
                            num = Rand.Next(2, 5)
                        Case 10
                            num = Rand.Next(3, 5)
                        Case 11
                            num = Rand.Next(3, 6)
                    End Select
                    totalNumFrags = totalNumFrags + num
                Case -1
                    Select Case theWord.Length
                        Case 4, 5
                            num = 2
                        Case 6, 7
                            num = Rand.Next(2, 4)
                        Case 8
                            num = Rand.Next(2, 5)
                        Case 9
                            num = Rand.Next(3, 5)
                        Case 10, 11
                            num = Rand.Next(3, 6)
                        Case 12
                            num = Rand.Next(3, 7)
                    End Select
                    totalNumFrags = totalNumFrags + num
            End Select
            If loopCount = 199 Then
                MsgBox("Timed Out" + theWord)
                Exit Function
            End If
            Console.WriteLine(totalNumFrags)
            loopCount += 1
            lowEnd = If(totalNumFrags < lowEnd, totalNumFrags, lowEnd)
            highEnd = If(totalNumFrags > highEnd, totalNumFrags, highEnd)
        Loop Until loopCount = 100

        lblMin.Text = Convert.ToString(Convert.ToInt32(lblMin.Text) + lowEnd)
        lblMax.Text = Convert.ToString(Convert.ToInt32(lblMax.Text) + highEnd)
    End Function

    Function Shuffle(Of T)(collection As IEnumerable(Of T)) As List(Of T)
        Dim r As Random = New Random()
        Shuffle = collection.OrderBy(Function(a) r.Next()).ToList()
        Return Shuffle
    End Function

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Focus()
    End Sub
End Class

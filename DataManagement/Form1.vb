Imports System.Text
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1



    Private Sub debugBtn_Click(sender As Object, e As EventArgs) Handles debugBtn.Click
        MsgBox(fi)
    End Sub

    Dim myDataArray As New List(Of Integer)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myDataArray = New List(Of Integer)() From {31, 57, 54, 66, 40, 68, 42, 27, 70, 49, 67, 47, 36, 58, 50, 63, 55, 44, 71, 33, 38, 45, 57, 65, 58, 68, 51, 56, 53, 39, 45, 59, 66, 24, 64, 35, 47, 54, 60, 40, 52, 56, 67, 50, 46}
        'For design only
        lbl_dataSet.Text = vbCrLf & vbCrLf & "--------------- Click calculate! ----------------"
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBox_percentileInput.KeyPress, txtBox_input_classSize.KeyPress, txtBox_input_classInterval.KeyPress, txtBox_dataInput.KeyPress
        'Allow only digits (0-9), Backspace, and Enter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SortArray()
        myDataArray.Sort()
        lbl_dataSet.Text = String.Join(", ", myDataArray)
    End Sub

    Private Sub UpdateDisplay()
        lbl_dataSet.Text = String.Join(", ", myDataArray)
    End Sub

    'Data Set Buttons
    'Button for adding integer to my array
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim inputValue As Integer
        If Integer.TryParse(txtBox_dataInput.Text, inputValue) Then
            myDataArray.Add(inputValue)
            lbl_dataSet.Text = String.Join(", ", myDataArray)
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
        txtBox_dataInput.Text = ""
    End Sub

    'Shorcut button in keyboard
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_submit.PerformClick()
        End If
    End Sub

    'Button for clearing by my array
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the array?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            myDataArray.Clear()
            UpdateDisplay()
            UngrpDataCalculated = False
        Else
            MsgBox("Wew")
        End If
    End Sub

    'Button for clearing the last on the list of my array
    Private Sub btn_Undo_Click(sender As Object, e As EventArgs) Handles btn_Undo.Click
        If myDataArray.Count > 0 Then
            myDataArray.RemoveAt(myDataArray.Count - 1)
            UpdateDisplay()
        Else
            MessageBox.Show("There are no elements to undo.")
        End If
    End Sub
    'Data Set Buttons

    'Ungrouped Data Calculation
    Dim UngrpDataCalculated As Boolean
    Private Sub btn_ungrpCalcs_Click(sender As Object, e As EventArgs) Handles btn_ungrpCalcs.Click
        ungrpCalcs()
    End Sub

    Private Sub ungrpCalcs()
        If myDataArray.Count > 0 Then
            SortArray()

            Dim range As Integer = CalculateRange()
            Dim mean As Double = CalculateMean()
            Dim median As Double = CalculateMedian()
            Dim modeValues As String = CalculateMode()

            lbl_ungrpCalcs.Text = $"Range: {range}{Environment.NewLine}Mean: {mean}{Environment.NewLine}Median: {median}{Environment.NewLine}Mode: {modeValues}" & Environment.NewLine & "Sample Size (n): " & myDataArray.Count
            UngrpDataCalculated = True
        Else
            lbl_ungrpCalcs.Text = "No data available."
        End If
    End Sub

    Private Function CalculateRange() As Integer
        'It takes the value in the last list of array minus to the first list of array
        Return myDataArray(myDataArray.Count - 1) - myDataArray(0)
    End Function

    Private Function CalculateMean() As Double
        'Get the summation with the function within array and divide it with the count of the array to get the average
        If myDataArray.Count > 0 Then
            Return myDataArray.Sum() / myDataArray.Count
        Else
            Return 0
        End If
    End Function

    Private Function CalculateMedian() As Double
        'Get the median(IDK how)
        If myDataArray.Count > 0 Then
            Dim middleIndex As Integer = myDataArray.Count \ 2
            Return If(myDataArray.Count Mod 2 = 1, myDataArray(middleIndex), (myDataArray(middleIndex - 1) + myDataArray(middleIndex)) / 2.0)
        Else
            Return 0
        End If
    End Function

    Private Function CalculateMode() As String
        'Get the mode using Dictionary
        If myDataArray.Count > 0 Then
            Dim frequencyDict As New Dictionary(Of Integer, Integer)

            For Each value As Integer In myDataArray
                If frequencyDict.ContainsKey(value) Then
                    frequencyDict(value) += 1
                Else
                    frequencyDict(value) = 1
                End If
            Next

            Dim modes As List(Of Integer) = frequencyDict.Where(Function(kvp) kvp.Value = frequencyDict.Values.Max()).Select(Function(kvp) kvp.Key).ToList()

            If modes.Count = 1 Then
                Return modes(0).ToString()
            ElseIf modes.Count > 1 Then
                Return String.Join(", ", modes)
            Else
                Return "No mode found."
            End If
        Else
            Return String.Empty
        End If
    End Function
    'Ungrouped Data Calculation

    'Settings
    Private Sub radBtn_classInterval_CheckedChanged(sender As Object, e As EventArgs) Handles radBtn_classInterval.CheckedChanged
        txtBox_input_classSize.Enabled = False
        txtBox_input_classInterval.Enabled = True
        radBtn_classSize.Checked = False
    End Sub
    Private Sub radBtn_classSize_CheckedChanged(sender As Object, e As EventArgs) Handles radBtn_classSize.CheckedChanged
        txtBox_input_classInterval.Enabled = False
        txtBox_input_classSize.Enabled = True
        radBtn_classInterval.Checked = False
    End Sub

    'Class Interval
    Dim classInterval As Integer
    Dim lowerCLarray() As Integer
    Dim upperCLarray() As Integer
    Dim settingPicked As Boolean
    Sub calcsClassInterval()
        If CalculateRange() = 0 Then
            MsgBox("Small data!") 'Error Message
        Else
            If txtBox_input_classInterval.Text = "0" Or txtBox_input_classSize.Text = "0" Then
                MsgBox("Really?! Zero?!") 'Error Message
            Else
                settingPicked = False 'Initialize the settingPicked flag

                Dim range As Integer = CalculateRange()
                Dim roundedResult As Integer

                If radBtn_classInterval.Checked Then
                    If String.IsNullOrWhiteSpace(txtBox_input_classInterval.Text) Then
                        MsgBox("Input Class Interval") 'Error Message
                    Else
                        'Class Interval Setting
                        'settingPicked = True
                        classInterval = txtBox_input_classInterval.Text
                        roundedResult = CInt(Math.Round(range / classInterval, MidpointRounding.AwayFromZero)) - 1
                    End If
                ElseIf radBtn_classSize.Checked Then
                    If String.IsNullOrWhiteSpace(txtBox_input_classSize.Text) Then
                        MsgBox("Input Class Size") 'Error Message
                    Else
                        'Class Size Setting
                        'settingPicked = True
                        roundedResult = txtBox_input_classSize.Text - 1
                        classInterval = CInt(Math.Round(range / (roundedResult + 1), MidpointRounding.AwayFromZero))
                    End If
                Else
                    MsgBox("Pick one setting") 'Error Message
                End If

                'Initialize arrays
                ReDim lowerCLarray(classInterval)
                ReDim upperCLarray(classInterval)

                'Set the first element
                lowerCLarray(0) = myDataArray(0)
                upperCLarray(0) = lowerCLarray(0) + roundedResult

                'Calculate and set values for the remaining elements in the arrays
                For i As Integer = 1 To classInterval
                    lowerCLarray(i) = upperCLarray(i - 1) + 1
                    upperCLarray(i) = lowerCLarray(i) + roundedResult
                Next

                'Resize arrays
                While lowerCLarray(lowerCLarray.Length - 1) > myDataArray(myDataArray.Count - 1)
                    Array.Resize(lowerCLarray, lowerCLarray.Length - 1)
                    Array.Resize(upperCLarray, upperCLarray.Length - 1)
                End While

                ' Display the results in table
                lbl_LL.Text = String.Join(Environment.NewLine, lowerCLarray)
                lbl_LU.Text = String.Join(Environment.NewLine, upperCLarray)
            End If
        End If
    End Sub

    'Class Boundaries
    Dim lowerBoundary() As Double
    Dim upperBoundary() As Double
    Sub ClassBoundaries()
        'Intialize arrays
        ReDim lowerBoundary(classInterval)
        ReDim upperBoundary(classInterval)

        'Copying Arrays
        lowerBoundary(0) = lowerCLarray(0) - 0.5
        upperBoundary(0) = upperCLarray(0) + 0.5

        For i As Integer = 1 To lowerCLarray.Count - 1
            If i < lowerCLarray.Length AndAlso i < upperCLarray.Length Then
                lowerBoundary(i) = lowerCLarray(i) - 0.5
                upperBoundary(i) = upperCLarray(i) + 0.5
            End If
        Next

        'Resize for zeros
        Dim x As Boolean = True
        While x = True
            If lowerBoundary(lowerBoundary.Count - 1) = 0 Then
                Array.Resize(lowerBoundary, lowerBoundary.Count - 1)
                Array.Resize(upperBoundary, upperBoundary.Count - 1)
            Else
                x = False
            End If
        End While

        'Display the results in table
        lbl_LB.Text = String.Join(Environment.NewLine, lowerBoundary)
        lbl_UB.Text = String.Join(Environment.NewLine, upperBoundary)
    End Sub

    'Class Marks
    Dim clMarkarray() As Double
    Sub ClassMarks()
        'Initialize array
        ReDim clMarkarray(lowerCLarray.Count - 1)

        'Solving class mark from previous arrays
        clMarkarray(0) = (lowerBoundary(0) + upperBoundary(0)) / 2

        If lowerBoundary.Count > 1 Then
            For i As Integer = 1 To lowerCLarray.Count - 1
                clMarkarray(i) = (lowerBoundary(i) + upperBoundary(i)) / 2
            Next
        End If

        'Display the results in table
        lbl_classMark.Text = String.Join(Environment.NewLine, clMarkarray)
    End Sub

    'Frequency
    Dim frequencyArray() As Integer
    Sub Frequency()
        If clMarkarray.Any() Then
            If CalculateRange() = 0 Then
                MsgBox("Small Data") 'Error message
            Else
                ReDim frequencyArray(lowerCLarray.Count - 1)
                Dim frequencyDict As New Dictionary(Of Integer, Integer)

                'Calculate the frequency within class intervals
                For Each value As Integer In myDataArray
                    Dim classIntervalIndex As Integer = FindClassIntervalIndex(value)

                    If frequencyDict.ContainsKey(classIntervalIndex) Then
                        frequencyDict(classIntervalIndex) += 1
                    Else
                        frequencyDict(classIntervalIndex) = 1
                    End If
                Next

                'Copying value from dictionary to frequencyArray
                For Each kvp As KeyValuePair(Of Integer, Integer) In frequencyDict
                    If kvp.Key >= 0 AndAlso kvp.Key < frequencyArray.Length Then
                        frequencyArray(kvp.Key) = kvp.Value
                    End If
                Next

                'Display the results in table
                lbl_frequency.Text = String.Join(Environment.NewLine, frequencyArray)
            End If
        End If
    End Sub
    Private Function FindClassIntervalIndex(value As Integer) As Integer
        If lowerBoundary.Count > 1 Then
            For i As Integer = 0 To classInterval
                If value >= lowerCLarray(i) AndAlso value <= upperCLarray(i) Then
                    Return i
                End If
            Next
        End If

        Return -1
    End Function

    Dim gtCumulativeFreq() As Integer '>
    Dim lsCumulativeFreq() As Integer '<
    Sub CumulativeFrequency()
        If frequencyArray Is Nothing Then
            MsgBox("Nah") 'Error Message
        Else
            'Initialize arrays
            ReDim gtCumulativeFreq(lowerCLarray.Count - 1)
            ReDim lsCumulativeFreq(lowerCLarray.Count - 1)

            'Solving cumulative frequency using basic arithmetic
            gtCumulativeFreq(0) = frequencyArray(0)
            lsCumulativeFreq(0) = myDataArray.Count

            For i As Integer = 1 To gtCumulativeFreq.Count - 1
                gtCumulativeFreq(i) = gtCumulativeFreq(i - 1) + frequencyArray(i)
                lsCumulativeFreq(i) = lsCumulativeFreq(i - 1) - frequencyArray(i - 1)
            Next

            'Display the results in table
            lbl_gtCFrequency.Text = String.Join(Environment.NewLine, gtCumulativeFreq)
            lbl_ltCFrequency.Text = String.Join(Environment.NewLine, lsCumulativeFreq)
        End If
    End Sub

    'Getting the percentage of cumulative frequency
    Dim gtCumulativePerFreq() As Integer '>
    Dim lsCumulativePerFreq() As Integer '<

    Sub CumulativePercentFrequency()
        'Checking if the last array have value
        If lsCumulativeFreq.Any() And gtCumulativeFreq.Any() Then
            ReDim gtCumulativePerFreq(lowerCLarray.Count - 1)
            ReDim lsCumulativePerFreq(lowerCLarray.Count - 1)

            For i As Integer = 0 To gtCumulativePerFreq.Count - 1
                gtCumulativePerFreq(i) = (gtCumulativeFreq(i) / myDataArray.Count) * 100
                lsCumulativePerFreq(i) = (lsCumulativeFreq(i) / myDataArray.Count) * 100
            Next
            lbl_gtCPFrequency.Text = String.Join(Environment.NewLine, gtCumulativePerFreq)
            lbl_ltCPFrequency.Text = String.Join(Environment.NewLine, lsCumulativePerFreq)
        End If
    End Sub

    'Getting the percentage of frequency
    Dim RelFrequencyArray() As Double

    Sub RelativeFrequency()
        'Checking if the last arrays have value
        If gtCumulativePerFreq.Any() And lsCumulativePerFreq.Any() Then
            ReDim RelFrequencyArray(lowerCLarray.Count - 1)

            For i As Integer = 0 To RelFrequencyArray.Count - 1
                RelFrequencyArray(i) = (frequencyArray(i) / myDataArray.Count) * 100
            Next
            'Format it in two decimal places
            Dim formattedArray As String() = RelFrequencyArray.Select(Function(value) value.ToString("F2")).ToArray()
            lbl_RelativeFrequency.Text = String.Join(Environment.NewLine, formattedArray)
        End If
    End Sub

    'Grouped Data Calculation
    Sub grpDataCals()
        Dim frequencyClassMarkArray() As Double
        'Checking if the last array have value
        If RelFrequencyArray.Any() Then

            'Grouped Mean
            Dim groupMean As Double
            ReDim frequencyClassMarkArray(lowerCLarray.Count - 1)

            For i As Integer = 0 To frequencyClassMarkArray.Count - 1
                frequencyClassMarkArray(i) = clMarkarray(i) * frequencyArray(i)
            Next
            groupMean = frequencyClassMarkArray.Sum() / myDataArray.Count
            Dim formattedGroupMean As String = groupMean.ToString("F2")


            'Grouped Median
            Dim lmd As Double
            Dim fmd As Integer
            Dim n2 As Double
            Dim cfb As Integer
            Dim holder1 As Integer
            Dim classSize As Integer
            Dim groupMedian As Double

            n2 = myDataArray.Count / 2
            classSize = (upperCLarray(0) - lowerCLarray(0)) + 1

            For i As Integer = 0 To gtCumulativeFreq.Length - 1
                If i > 0 AndAlso gtCumulativeFreq(i) >= n2 Then
                    cfb = gtCumulativeFreq(i - 1)
                    Exit For
                End If
            Next

            For i As Integer = 0 To gtCumulativeFreq.Length - 1
                If gtCumulativeFreq(i) > n2 Then
                    holder1 = i
                    Exit For
                End If
            Next

            lmd = lowerBoundary(holder1)
            fmd = frequencyArray(holder1)

            groupMedian = lmd + ((n2 - cfb) / fmd) * classSize

            'Grouped Mode
            Dim highestFrequencyIndex As Integer = -1
            Dim fmo As Integer
            Dim f1 As Integer
            Dim f2 As Integer
            Dim lmo As Double
            Dim groupMode As Double

            If frequencyArray.Any() Then
                'Iterate through frequencyArray to find the index with the highest frequency
                For i As Integer = 0 To frequencyArray.Count - 1
                    If highestFrequencyIndex = -1 OrElse frequencyArray(i) > frequencyArray(highestFrequencyIndex) Then
                        highestFrequencyIndex = i
                    End If
                Next

                'Preventing array index out of bounds errors
                If highestFrequencyIndex >= 0 AndAlso highestFrequencyIndex < frequencyArray.Length Then
                    fmo = frequencyArray(highestFrequencyIndex)
                    If highestFrequencyIndex - 1 >= 0 Then
                        f1 = frequencyArray(highestFrequencyIndex - 1)
                    End If

                    If highestFrequencyIndex + 1 < frequencyArray.Length Then
                        f2 = frequencyArray(highestFrequencyIndex + 1)
                    End If

                    If highestFrequencyIndex < lowerBoundary.Length Then
                        lmo = lowerBoundary(highestFrequencyIndex)
                    End If
                End If


                groupMode = lmo + ((fmo - f1) / ((2 * fmo) - f1 - f2)) * classSize
            End If


            lbl_groupedDataCalcs.Text = $"Mean: {formattedGroupMean}{Environment.NewLine}Median:{groupMedian} {Environment.NewLine}Mode: {groupMode}{Environment.NewLine}"
        End If
    End Sub

    Dim grpCalcChecker As Boolean
    Private Sub btn_grpCalcs_Click(sender As Object, e As EventArgs) Handles btn_grpCalcs.Click
        If myDataArray.Any() Then
            ungrpCalcs()

            If settingPicked = True Then
                If Not String.IsNullOrEmpty(txtBox_input_classInterval.Text & txtBox_input_classSize.Text) Then
                    calcsClassInterval()
                    ClassBoundaries()
                    ClassMarks()
                    Frequency()
                    CumulativeFrequency()
                    CumulativePercentFrequency()
                    RelativeFrequency()
                    grpDataCals()
                    grpCalcChecker = True
                Else
                    MsgBox("Input Value!")
                End If
            Else
                MsgBox("Pick one setting!")
            End If
        Else
            MsgBox("No data!")
        End If
    End Sub

    Private Sub tmr_checker_Tick(sender As Object, e As EventArgs) Handles tmr_checker.Tick
        If radBtn_classInterval.Checked = True Or radBtn_classSize.Checked = True Then
            settingPicked = True
        Else
            settingPicked = False
        End If
    End Sub

    Dim percentile As Double
    Dim pi As Integer
    Dim li As Double
    Dim cfbi As Integer
    Dim fi As Integer
    Dim in100 As Double
    Private Sub btn_percentileCalc_Click(sender As Object, e As EventArgs) Handles btn_percentileCalc.Click
        If grpCalcChecker = True Then
            If txtBox_percentileInput.Text = "" Then
                MsgBox("Input value!")
            ElseIf txtBox_percentileInput.Text > 100 Then
                MsgBox("Too much!")
            Else
                pi = txtBox_percentileInput.Text

                in100 = (pi * myDataArray.Count) / 100

                For i As Integer = 0 To gtCumulativeFreq.Length - 1
                    If i > 0 AndAlso gtCumulativeFreq(i) >= in100 Then
                        cfbi = gtCumulativeFreq(i - 1)
                        fi = frequencyArray(i)
                        li = lowerBoundary(i)
                        Exit For
                    End If
                Next

                percentile = li + ((in100 - cfbi) / fi) * ((upperCLarray(0) - lowerCLarray(0)) + 1)
                lbl_percentileOutput.Text = "= " & percentile
            End If
        Else
            MsgBox("Calculate for grouped data first!")
        End If
    End Sub
End Class

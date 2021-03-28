Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub lblStdWeight_Click(sender As Object, e As EventArgs) Handles lblStdWeight.Click

    End Sub

    Private Sub btnCalculateStdWeight_Click(sender As Object, e As EventArgs) Handles btnCalculateStdWeight.Click
        Dim heightcm As Integer
        Dim standardWeight As Integer

        heightcm = txtHeight.Text

        standardWeight = (heightcm - 100) * 0.9

        lblStdWeightAns.Text = standardWeight

        Dim myFormat As String = "##0.00"

        lblStdWeightAns.Text = Format(standardWeight, myFormat)

    End Sub

    Private Sub btnCalculateBMI_Click(sender As Object, e As EventArgs) Handles btnCalculateBMI.Click
        Dim heightm As String
        Dim weight As String
        Dim BMI As Decimal

        heightm = txtHeightM.Text
        weight = txtWeight.Text

        BMI = weight / (heightm) ^ 2

        lblBMIAns.Text = BMI

        If BMI >= 30 Then
            MessageBox.Show("Obese", "BMI Categories")
        ElseIf BMI >= 25 AndAlso BMI < 29.9 Then
            MessageBox.Show("Overweight", "BMI Categories")
        ElseIf BMI >= 19 AndAlso BMI < 24.9 Then
            MessageBox.Show("Normal", "BMI Categories")
        ElseIf BMI < 18.9 Then
            MessageBox.Show("Underweight", "BMI Categories")
        End If

        Dim myFormat As String = "##0.00"

        lblBMIAns.Text = Format(BMI, myFormat)

    End Sub

    Private Sub btnCalculateHeightM_Click(sender As Object, e As EventArgs) Handles btnCalculateHeightM.Click
        Dim heightCm As String
        Dim heightM As String

        heightCm = txtHeightCmC.Text

        heightM = heightCm / 100

        lblHeightMCAns.Text = heightM



    End Sub

    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click

        Dim heightm As String
        Dim weight As String
        Dim BMI As Decimal

        heightm = txtHeightM.Text
        weight = txtWeight.Text

        BMI = weight / (heightm) ^ 2

        lblBMIAns.Text = BMI

        Select Case BMI
            Case Is >= 30
                MessageBox.Show("Obese", "BMI Categories")
            Case Is >= 25
                MessageBox.Show("Overweight", "BMI Categories")
            Case Is >= 19
                MessageBox.Show("Normal", "BMI Categories")
            Case Is <= 18
                MessageBox.Show("Underweight", "BMI Categories")
        End Select

        Dim myFormat As String = "##0.00"

        lblBMIAns.Text = Format(BMI, myFormat)

    End Sub
End Class

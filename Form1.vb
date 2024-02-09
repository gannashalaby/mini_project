Imports System.Linq.Expressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function IsDigit(ByVal c As Char) As Boolean
        Return Asc(c) >= Asc("0") AndAlso Asc(c) <= Asc("9")
    End Function
    Function IsAlphabet(ByVal c As Char) As Boolean
        Return (Asc(c) >= Asc("A") AndAlso Asc(c) <= Asc("Z")) OrElse (Asc(c) >= Asc("a") AndAlso Asc(c) <= Asc("z"))
    End Function

    Function IsWhiteSpace(ByVal c As Char) As Boolean
        Return c = " " OrElse c = Chr(13) OrElse c = Chr(10)
    End Function

    Function IsValidOperator(ByVal c As Char) As Boolean
        Return c = "+" OrElse c = "-" OrElse c = "*" OrElse c = "/" OrElse c = "="
    End Function

    Function IsDigitOrAlphabet(ByVal c As Char) As Boolean
        Return IsDigit(c) OrElse IsAlphabet(c)
    End Function

    Function ParseOperand(ByRef i As Integer, ByVal expression As String) As String
        Dim operand As String = ""

        While i < expression.Length AndAlso IsDigitOrAlphabet(expression(i))
            operand &= expression(i)
            i += 1
        End While

        Return operand
    End Function


    Function ParseOperator(ByRef i As Integer, ByVal expression As String) As Char
        If i < expression.Length AndAlso IsValidOperator(expression(i)) Then
            Dim oper As Char = expression(i)
            i += 1
            Return oper
        Else
            Throw New Exception("Invalid or missing operator.")
        End If
    End Function

    Sub SkipWhiteSpaces(ByRef i As Integer, ByVal expression As String)
        While i < expression.Length AndAlso IsWhiteSpace(expression(i))
            i += 1
        End While
    End Sub

    Private Sub btnParse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParse.Click
        Dim i As Integer = 0
        Dim expression As String = txtSentence.Text
        Dim token As String
        Dim tokenCount As Integer = 0

        lstResults.Items.Clear()

        SkipWhiteSpaces(i, expression)

        While i < expression.Length
            If IsDigitOrAlphabet(expression(i)) Then
                token = ParseOperand(i, expression)
                tokenCount += 1
                lstResults.Items.Add("Token no" & tokenCount.ToString() & ": " & token)
            ElseIf IsValidOperator(expression(i)) Then
                token = ParseOperator(i, expression)
                tokenCount += 1
                lstResults.Items.Add("Token no" & tokenCount.ToString() & ": " & token)
            ElseIf IsWhiteSpace(expression(i)) Then
                SkipWhiteSpaces(i, expression)
                Continue While
            Else
                token = expression(i)
                tokenCount += 1
                lstResults.Items.Add("Token no" & tokenCount.ToString() & ": " & token)
                i += 1
            End If
        End While

        lstResults.Items.Add("Number of tokens: " & tokenCount)
    End Sub

    Private Function IsValidExpression(ByVal expression As String) As Boolean
        Dim i As Integer = 0
        Dim valid As Boolean = True

        Try
            SkipWhiteSpaces(i, expression)

            If i < expression.Length AndAlso IsDigitOrAlphabet(expression(i)) Then
                ParseOperand(i, expression)
            Else
                Return False
            End If

            While i < expression.Length
                SkipWhiteSpaces(i, expression)

                If i < expression.Length AndAlso IsValidOperator(expression(i)) Then
                    ParseOperator(i, expression)
                Else
                    Return False
                End If

                SkipWhiteSpaces(i, expression)

                If i < expression.Length AndAlso IsDigitOrAlphabet(expression(i)) Then
                    ParseOperand(i, expression)
                Else
                    Return False
                End If
            End While

        Catch ex As Exception
            valid = False
        End Try

        Return valid
    End Function

    Private Sub btnParse2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParse2.Click
        Dim expression = txtSentence.Text
        Dim result As String

        If IsValidExpression(expression) Then
            result = "Valid"
        Else
            result = "Invalid"
        End If

        lstResults.Items.Clear()
        lstResults.Items.Add(result)
    End Sub
End Class
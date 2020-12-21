Module Module1

    Sub Main()
        Dim list As New List(Of String)
        list.Add("stringa1")
        list.Add("stringa2")
        list.Add("stringa3")
        list.Add("Stringa1")
        list.Add("Stringa2")

        Dim strings As IEnumerable(Of String)
        strings = list.Where(Function(str) str.Contains("2"))
        'Immediate Window
        '    ? list.Where(Function(str) str.Contains("2"))
        '    {System.Linq.Enumerable.WhereListIterator(Of String)}
        '        (0): "stringa2"
        '        (1): "Stringa2"
        '    ? list.Where(Function(str) str.Contains("S"))
        '    {System.Linq.Enumerable.WhereListIterator(Of String)}
        '        (0): "Stringa1"
        '        (1): "Stringa2"

        For Each s In strings
            Debug.WriteLine(s)
        Next
    End Sub

End Module


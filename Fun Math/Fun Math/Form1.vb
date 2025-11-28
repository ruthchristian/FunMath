Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Math
Imports Ivi.Visa.Interop
Imports System.Runtime.InteropService
Imports Microsoft.Office.Tools.Excel
Imports System.Drawing.Text
Imports System.Threading
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core

Public Class Form1
    Dim ExcelDataFileName, CSVDataFileName As String
    Dim oSheet As Excel.Worksheet
    Dim oExcel As Excel.Application
    Dim oBook As Excel.Workbook
    Dim oBooks As Excel.Workbooks
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim xAxis As Excel.Axis
    Dim yaxis As Excel.Axis
    Dim oChart As Excel.Chart
    Dim oSeries As Excel.Series
    Dim X, Y, Z As Single
    Dim Lx, Ly, Ca, Ci, xx, yy As Single


    Private Sub Circle_CheckedChanged(sender As Object, e As EventArgs) Handles Circle.CheckedChanged
        TXTB2.Visible = True
        L1.Visible = True
    End Sub

    Private Sub Cardioid_CheckedChanged(sender As Object, e As EventArgs) Handles Cardioid.CheckedChanged
        TXTB2.Visible = True
        L1.Visible = True
    End Sub

    Private Sub Limacon_CheckedChanged(sender As Object, e As EventArgs) Handles Limacon.CheckedChanged
        TXTB2.Visible = True
        TXTB3.Visible = True
        L1.Visible = True
        L2.Visible = True
    End Sub

    Sub BTN_Click(sender As Object, e As EventArgs) Handles BTN.Click

        ExcelDataFileName = TXTB1.Text

        X = 0
        Y = 0
        Z = 0
        Dim xAxis As Excel.Axis
        Dim yaxis As Excel.Axis
        Dim oChart As Excel.Chart
        Dim oSeries As Excel.Series

        CSVDataFileName = ExcelDataFileName & ".csv"
        FileOpen(2, CSVDataFileName, OpenMode.Output)

        oExcel = New Excel.Application
        oBook = oExcel.Workbooks.Add(misValue)
        oSheet = oBook.Sheets("sheet1")

        oExcel.Visible = True
        oBooks = oExcel.Workbooks

        oSheet.Range("J3").Select()
        oBook.ActiveSheet.Shapes.AddChart.Select()

        oBook.ActiveChart.ChartType = Excel.XlChartType.xlXYScatterSmoothNoMarkers
        oBook.ActiveChart.SeriesCollection.NewSeries()

        oBook.ActiveChart.SeriesCollection(1).XValues = "=Sheet1!$A$1:$A$11"
        oBook.ActiveChart.SeriesCollection(1).Values = "=Sheet1!$B$1:$B$11"

        If Limacon.Checked = True Then
            Limacon1()
        End If
        If Circle.Checked = True Then
            Circle1()
        End If
        If Cardioid.Checked = True Then
            Cardioid1()
        End If

        oBook.SaveAs(Filename:=ExcelDataFileName & ".xlsx")
        CSVDataFileName = ExcelDataFileName & ".csv"

        oBook.ActiveChart.Legend.Delete()

        yaxis = CType(oBook.ActiveChart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
        xAxis = CType(oBook.ActiveChart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
        xAxis.HasTitle = True
        xAxis.AxisTitle.Text = "Wavelength (nm)"
        yaxis.HasTitle = True
        yaxis.AxisTitle.Text = "Intensity"

        oChart = oBook.ActiveChart
    End Sub

    Sub Limacon1()
        xx = Val(TXTB2.Text)
        yy = Val(TXTB3.Text)


        While X <= 10

            X = X + 1
            Y = Y + 1
            Z = Z + (3.14159 / 5)
            Lx = ((xx * Cos(Z)) + (yy * Cos(Z) * Sin(Z)))
            Ly = ((xx * Sin(Z)) + (yy * Sin(Z) * Sin(Z)))
            oSheet.Range("A" & X).Value = Lx
            oSheet.Range("B" & X).Value = Ly

        End While

    End Sub

    Sub Circle1()
        xx = Val(TXTB2.Text)


        While X <= 10

            X = X + 1
            Y = Y + 1
            Z = Z + (3.14159 / 5)
            Lx = xx * Cos(Z)
            Ly = xx * Sin(Z)

            oSheet.Range("A" & X).Value = Lx
            oSheet.Range("B" & X).Value = Ly

        End While
    End Sub

    Sub Cardioid1()
        xx = Val(TXTB2.Text)

        While X <= 10

            X = X + 1
            Y = Y + 1
            Z = Z + (3.14159 / 5)
            Lx = ((xx * Cos(Z)) + (xx * Cos(Z) * Sin(Z)))
            Ly = ((xx * Sin(Z)) + (xx * Sin(Z) * Sin(Z)))
            oSheet.Range("A" & X).Value = Lx
            oSheet.Range("B" & X).Value = Ly

        End While


    End Sub

End Class

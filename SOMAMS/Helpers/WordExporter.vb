' Aliases make every type unambiguous, even if the project imports
' Microsoft.Office.Interop.Word or other namespaces with the same names.
Imports Ox = DocumentFormat.OpenXml
Imports OxPkg = DocumentFormat.OpenXml.Packaging
Imports W = DocumentFormat.OpenXml.Wordprocessing

''' <summary>
''' Exports a DataTable to a .docx file as a real Word table.
''' Uses the Open XML SDK (NuGet) so Microsoft Word does NOT need to be installed.
''' </summary>
Public Module WordExporter

    ''' <summary>Asks where to save, then exports. Returns True when a file was saved.</summary>
    Public Function ExportWithDialog(table As System.Data.DataTable, title As String, defaultName As String) As Boolean
        If table Is Nothing OrElse table.Rows.Count = 0 Then
            System.Windows.Forms.MessageBox.Show("There is no data to export.", "SOMAMS",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
            Return False
        End If

        Using sfd As New System.Windows.Forms.SaveFileDialog()
            sfd.Filter = "Word Document (*.docx)|*.docx"
            sfd.FileName = defaultName & "_" & Date.Now.ToString("yyyyMMdd")
            If sfd.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return False
            Try
                Save(table, title, sfd.FileName)
            Catch ex As System.IO.IOException
                System.Windows.Forms.MessageBox.Show("Could not save the file. Close it in Word first and try again." & vbCrLf & ex.Message,
                    "SOMAMS", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
                Return False
            End Try
            System.Windows.Forms.MessageBox.Show("Exported successfully!", "SOMAMS",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
            Return True
        End Using
    End Function

    ''' <summary>Copies the visible columns/rows of a DataGridView into a DataTable.</summary>
    Public Function FromGrid(grid As System.Windows.Forms.DataGridView) As System.Data.DataTable
        Dim dt As New System.Data.DataTable()
        Dim cols As New List(Of System.Windows.Forms.DataGridViewColumn)
        For Each c As System.Windows.Forms.DataGridViewColumn In grid.Columns
            If c.Visible Then
                dt.Columns.Add(c.HeaderText)
                cols.Add(c)
            End If
        Next
        For Each r As System.Windows.Forms.DataGridViewRow In grid.Rows
            If r.IsNewRow Then Continue For
            Dim vals As New List(Of Object)
            For Each c As System.Windows.Forms.DataGridViewColumn In cols
                vals.Add(r.Cells(c.Index).Value)
            Next
            dt.Rows.Add(vals.ToArray())
        Next
        Return dt
    End Function

    Public Sub Save(table As System.Data.DataTable, title As String, path As String)
        Using doc As OxPkg.WordprocessingDocument = OxPkg.WordprocessingDocument.Create(path, Ox.WordprocessingDocumentType.Document)
            Dim main As OxPkg.MainDocumentPart = doc.AddMainDocumentPart()
            main.Document = New W.Document()
            Dim body As New W.Body()
            main.Document.AppendChild(body)

            ' Title
            Dim titleProps As New W.RunProperties(New W.Bold(), New W.FontSize() With {.Val = "32"})
            Dim titleRun As New W.Run(titleProps, New W.Text(title))
            Dim titlePara As New W.Paragraph(
                New W.ParagraphProperties(New W.Justification() With {.Val = W.JustificationValues.Center}),
                titleRun)
            body.AppendChild(titlePara)

            body.AppendChild(New W.Paragraph(New W.Run(New W.Text("Generated: " & Date.Now.ToString("MMMM d, yyyy h:mm tt")))))
            body.AppendChild(New W.Paragraph(New W.Run(New W.Text(""))))

            ' Table
            Dim tbl As New W.Table()
            Dim borders As New W.TableBorders(
                New W.TopBorder() With {.Val = W.BorderValues.Single, .Size = 4UI},
                New W.BottomBorder() With {.Val = W.BorderValues.Single, .Size = 4UI},
                New W.LeftBorder() With {.Val = W.BorderValues.Single, .Size = 4UI},
                New W.RightBorder() With {.Val = W.BorderValues.Single, .Size = 4UI},
                New W.InsideHorizontalBorder() With {.Val = W.BorderValues.Single, .Size = 4UI},
                New W.InsideVerticalBorder() With {.Val = W.BorderValues.Single, .Size = 4UI})
            tbl.AppendChild(New W.TableProperties(borders))

            Dim headerRow As New W.TableRow()
            For Each col As System.Data.DataColumn In table.Columns
                headerRow.AppendChild(MakeCell(col.ColumnName, True))
            Next
            tbl.AppendChild(headerRow)

            For Each row As System.Data.DataRow In table.Rows
                Dim tr As New W.TableRow()
                For Each col As System.Data.DataColumn In table.Columns
                    tr.AppendChild(MakeCell(FormatValue(row(col)), False))
                Next
                tbl.AppendChild(tr)
            Next

            body.AppendChild(tbl)
            main.Document.Save()
        End Using
    End Sub

    Private Function MakeCell(text As String, isHeader As Boolean) As W.TableCell
        Dim rp As New W.RunProperties()
        If isHeader Then rp.AppendChild(New W.Bold())

        Dim props As New W.TableCellProperties()
        If isHeader Then
            props.AppendChild(New W.Shading() With {
                .Val = W.ShadingPatternValues.Clear,
                .Color = "auto",
                .Fill = "87CEEB"})
        End If

        Dim t As New W.Text(text)
        t.Space = Ox.SpaceProcessingModeValues.Preserve
        Return New W.TableCell(props, New W.Paragraph(New W.Run(rp, t)))
    End Function

    Private Function FormatValue(v As Object) As String
        If v Is Nothing OrElse IsDBNull(v) Then Return ""
        If TypeOf v Is Date Then Return CDate(v).ToString("MMM d, yyyy")
        If TypeOf v Is Boolean Then Return If(CBool(v), "Present", "Absent")
        Return v.ToString()
    End Function
End Module
﻿Imports Microsoft.Reporting.WinForms
Imports projek_uas.PembelianBahanDataSet
Imports projek_uas.PembelianBahanDataSetTableAdapters

Public Class laporanpembelianbahan
    Private Sub laporanpembelianbahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New PembelianBahanDataSet
        Dim adapter As New PembelianBahanTableAdapter()
        adapter.Fill(dataset.PembelianBahan)

        ReportViewer1.LocalReport.ReportEmbeddedResource = "projek_uas.reportpembelianbahan.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dataset.Tables(0)))

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        menuutama.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        login.Show()
    End Sub
End Class
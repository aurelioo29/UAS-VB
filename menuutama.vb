﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class menuutama
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggunaToolStripMenuItem.Click
        Me.Close()
        masterpengguna.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Me.Close()
        mastermenu.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Me.Close()
        mastersupplier.Show()
    End Sub
    '=====================TRANSAKSI=====================
    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Me.Close()
        transaksipenjualan.Show()
    End Sub

    Private Sub PembelianPeralatanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianPeralatanToolStripMenuItem.Click
        Me.Close()
        transaksipembelianperalatan.Show()
    End Sub

    Private Sub PembelianBahanBakuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianBahanBakuToolStripMenuItem.Click
        Me.Close()
        transaksipembelianbahan.Show()
    End Sub

    Private Sub PemakaianBahanBakuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaianBahanBakuToolStripMenuItem.Click
        Me.Close()
        transaksipemakainbahan.Show()
    End Sub
    '=====================LAPORAN=====================
    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        Me.Close()
        laporanpenjualan.Show()
    End Sub

    Private Sub PembelianPeralatanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianPeralatanToolStripMenuItem1.Click
        Me.Close()
        laporanpembelianperalatan.Show()
    End Sub

    Private Sub PembelianBahanBakuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianBahanBakuToolStripMenuItem1.Click
        Me.Close()
        laporanpembelianbahan.Show()
    End Sub

    Private Sub PemakaianBahanBakuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PemakaianBahanBakuToolStripMenuItem1.Click
        Me.Close()
        laporanpemakaianbahan.Show()
    End Sub
End Class
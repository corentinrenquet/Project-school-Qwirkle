﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_jeu))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_abandonner = New System.Windows.Forms.Button()
        Me.btn_recommencer = New System.Windows.Forms.Button()
        Me.btn_aide = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_confirmer = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.picBox6 = New System.Windows.Forms.PictureBox()
        Me.picBox5 = New System.Windows.Forms.PictureBox()
        Me.picBox4 = New System.Windows.Forms.PictureBox()
        Me.picBox3 = New System.Windows.Forms.PictureBox()
        Me.picBox2 = New System.Windows.Forms.PictureBox()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.grille_1_1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.pannelj1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_j1_nom = New System.Windows.Forms.Label()
        Me.lbl_j1_score = New System.Windows.Forms.Label()
        Me.pannelj2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_j2_nom = New System.Windows.Forms.Label()
        Me.lbl_j2_score = New System.Windows.Forms.Label()
        Me.pannelj3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_j3_nom = New System.Windows.Forms.Label()
        Me.lbl_j3_score = New System.Windows.Forms.Label()
        Me.pannelj4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_j4_nom = New System.Windows.Forms.Label()
        Me.lbl_j4_score = New System.Windows.Forms.Label()
        Me.panel_tour = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_tourJoueur = New System.Windows.Forms.Label()
        Me.panel_pioche = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_pioche = New System.Windows.Forms.Label()
        Me.picBox_pioche = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.grille_1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.pannelj1.SuspendLayout()
        Me.pannelj2.SuspendLayout()
        Me.pannelj3.SuspendLayout()
        Me.pannelj4.SuspendLayout()
        Me.panel_tour.SuspendLayout()
        Me.panel_pioche.SuspendLayout()
        CType(Me.picBox_pioche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.Qwirkle.My.Resources.Resources.arriere
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.panel_tour, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.panel_pioche, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1264, 733)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_abandonner, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_recommencer, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_aide, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_annuler, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_confirmer, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(246, 580)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btn_abandonner
        '
        Me.btn_abandonner.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_abandonner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_abandonner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abandonner.ForeColor = System.Drawing.Color.Black
        Me.btn_abandonner.Location = New System.Drawing.Point(3, 291)
        Me.btn_abandonner.Name = "btn_abandonner"
        Me.btn_abandonner.Size = New System.Drawing.Size(240, 66)
        Me.btn_abandonner.TabIndex = 4
        Me.btn_abandonner.Text = "Abandonner"
        Me.btn_abandonner.UseVisualStyleBackColor = False
        '
        'btn_recommencer
        '
        Me.btn_recommencer.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_recommencer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_recommencer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_recommencer.ForeColor = System.Drawing.Color.Black
        Me.btn_recommencer.Location = New System.Drawing.Point(3, 219)
        Me.btn_recommencer.Name = "btn_recommencer"
        Me.btn_recommencer.Size = New System.Drawing.Size(240, 66)
        Me.btn_recommencer.TabIndex = 3
        Me.btn_recommencer.Text = "Recommencer"
        Me.btn_recommencer.UseVisualStyleBackColor = False
        '
        'btn_aide
        '
        Me.btn_aide.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_aide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aide.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aide.ForeColor = System.Drawing.Color.Black
        Me.btn_aide.Location = New System.Drawing.Point(3, 147)
        Me.btn_aide.Name = "btn_aide"
        Me.btn_aide.Size = New System.Drawing.Size(240, 66)
        Me.btn_aide.TabIndex = 2
        Me.btn_aide.Text = "Aide"
        Me.btn_aide.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_annuler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.Color.Black
        Me.btn_annuler.Location = New System.Drawing.Point(3, 75)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(240, 66)
        Me.btn_annuler.TabIndex = 1
        Me.btn_annuler.Text = "Annuler(tab de fin pour tests)"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'btn_confirmer
        '
        Me.btn_confirmer.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_confirmer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_confirmer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmer.ForeColor = System.Drawing.Color.Black
        Me.btn_confirmer.Location = New System.Drawing.Point(3, 3)
        Me.btn_confirmer.Name = "btn_confirmer"
        Me.btn_confirmer.Size = New System.Drawing.Size(240, 66)
        Me.btn_confirmer.TabIndex = 0
        Me.btn_confirmer.Text = "Confirmer"
        Me.btn_confirmer.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.Controls.Add(Me.picBox6, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox5, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox4, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox3, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(255, 589)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(752, 141)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'picBox6
        '
        Me.picBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox6.Image = CType(resources.GetObject("picBox6.Image"), System.Drawing.Image)
        Me.picBox6.Location = New System.Drawing.Point(628, 3)
        Me.picBox6.Name = "picBox6"
        Me.picBox6.Size = New System.Drawing.Size(121, 135)
        Me.picBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox6.TabIndex = 5
        Me.picBox6.TabStop = False
        '
        'picBox5
        '
        Me.picBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox5.Image = CType(resources.GetObject("picBox5.Image"), System.Drawing.Image)
        Me.picBox5.Location = New System.Drawing.Point(503, 3)
        Me.picBox5.Name = "picBox5"
        Me.picBox5.Size = New System.Drawing.Size(119, 135)
        Me.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox5.TabIndex = 4
        Me.picBox5.TabStop = False
        '
        'picBox4
        '
        Me.picBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox4.Image = CType(resources.GetObject("picBox4.Image"), System.Drawing.Image)
        Me.picBox4.Location = New System.Drawing.Point(378, 3)
        Me.picBox4.Name = "picBox4"
        Me.picBox4.Size = New System.Drawing.Size(119, 135)
        Me.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox4.TabIndex = 3
        Me.picBox4.TabStop = False
        '
        'picBox3
        '
        Me.picBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox3.Image = CType(resources.GetObject("picBox3.Image"), System.Drawing.Image)
        Me.picBox3.Location = New System.Drawing.Point(253, 3)
        Me.picBox3.Name = "picBox3"
        Me.picBox3.Size = New System.Drawing.Size(119, 135)
        Me.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox3.TabIndex = 2
        Me.picBox3.TabStop = False
        '
        'picBox2
        '
        Me.picBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox2.Image = CType(resources.GetObject("picBox2.Image"), System.Drawing.Image)
        Me.picBox2.Location = New System.Drawing.Point(128, 3)
        Me.picBox2.Name = "picBox2"
        Me.picBox2.Size = New System.Drawing.Size(119, 135)
        Me.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox2.TabIndex = 1
        Me.picBox2.TabStop = False
        '
        'picBox1
        '
        Me.picBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox1.Image = CType(resources.GetObject("picBox1.Image"), System.Drawing.Image)
        Me.picBox1.Location = New System.Drawing.Point(3, 3)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(119, 135)
        Me.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox1.TabIndex = 0
        Me.picBox1.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 30
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.Controls.Add(Me.grille_1_1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(255, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 30
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(752, 580)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'grille_1_1
        '
        Me.grille_1_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grille_1_1.Location = New System.Drawing.Point(4, 4)
        Me.grille_1_1.Name = "grille_1_1"
        Me.grille_1_1.Size = New System.Drawing.Size(18, 12)
        Me.grille_1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.grille_1_1.TabIndex = 0
        Me.grille_1_1.TabStop = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1013, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.39815!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.60185!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(248, 580)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 125)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.8255!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.1745!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(242, 289)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.pannelj1, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.pannelj2, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.pannelj3, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.pannelj4, 0, 3)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(4, 73)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 4
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(234, 212)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'pannelj1
        '
        Me.pannelj1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pannelj1.ColumnCount = 2
        Me.pannelj1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj1.Controls.Add(Me.lbl_j1_nom, 0, 0)
        Me.pannelj1.Controls.Add(Me.lbl_j1_score, 1, 0)
        Me.pannelj1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj1.Location = New System.Drawing.Point(3, 3)
        Me.pannelj1.Name = "pannelj1"
        Me.pannelj1.RowCount = 1
        Me.pannelj1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj1.Size = New System.Drawing.Size(228, 47)
        Me.pannelj1.TabIndex = 0
        '
        'lbl_j1_nom
        '
        Me.lbl_j1_nom.AutoSize = True
        Me.lbl_j1_nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_j1_nom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_j1_nom.Location = New System.Drawing.Point(1, 1)
        Me.lbl_j1_nom.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_j1_nom.Name = "lbl_j1_nom"
        Me.lbl_j1_nom.Size = New System.Drawing.Size(112, 45)
        Me.lbl_j1_nom.TabIndex = 0
        Me.lbl_j1_nom.Text = "NOM J1"
        Me.lbl_j1_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_j1_score
        '
        Me.lbl_j1_score.AutoSize = True
        Me.lbl_j1_score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_j1_score.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_j1_score.Location = New System.Drawing.Point(117, 1)
        Me.lbl_j1_score.Name = "lbl_j1_score"
        Me.lbl_j1_score.Size = New System.Drawing.Size(107, 45)
        Me.lbl_j1_score.TabIndex = 1
        Me.lbl_j1_score.Text = "SCORE J1"
        Me.lbl_j1_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pannelj2
        '
        Me.pannelj2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pannelj2.ColumnCount = 2
        Me.pannelj2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj2.Controls.Add(Me.lbl_j2_nom, 0, 0)
        Me.pannelj2.Controls.Add(Me.lbl_j2_score, 1, 0)
        Me.pannelj2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj2.Location = New System.Drawing.Point(3, 56)
        Me.pannelj2.Name = "pannelj2"
        Me.pannelj2.RowCount = 1
        Me.pannelj2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj2.Size = New System.Drawing.Size(228, 47)
        Me.pannelj2.TabIndex = 1
        '
        'lbl_j2_nom
        '
        Me.lbl_j2_nom.AutoSize = True
        Me.lbl_j2_nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_j2_nom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_j2_nom.Location = New System.Drawing.Point(1, 1)
        Me.lbl_j2_nom.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_j2_nom.Name = "lbl_j2_nom"
        Me.lbl_j2_nom.Size = New System.Drawing.Size(112, 45)
        Me.lbl_j2_nom.TabIndex = 0
        Me.lbl_j2_nom.Text = "NOM J2"
        Me.lbl_j2_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_j2_score
        '
        Me.lbl_j2_score.AutoSize = True
        Me.lbl_j2_score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_j2_score.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_j2_score.Location = New System.Drawing.Point(117, 1)
        Me.lbl_j2_score.Name = "lbl_j2_score"
        Me.lbl_j2_score.Size = New System.Drawing.Size(107, 45)
        Me.lbl_j2_score.TabIndex = 1
        Me.lbl_j2_score.Text = "SCORE J2"
        Me.lbl_j2_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pannelj3
        '
        Me.pannelj3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pannelj3.ColumnCount = 2
        Me.pannelj3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj3.Controls.Add(Me.lbl_j3_nom, 0, 0)
        Me.pannelj3.Controls.Add(Me.lbl_j3_score, 1, 0)
        Me.pannelj3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj3.Location = New System.Drawing.Point(3, 109)
        Me.pannelj3.Name = "pannelj3"
        Me.pannelj3.RowCount = 1
        Me.pannelj3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj3.Size = New System.Drawing.Size(228, 47)
        Me.pannelj3.TabIndex = 2
        '
        'lbl_j3_nom
        '
        Me.lbl_j3_nom.AutoSize = True
        Me.lbl_j3_nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_j3_nom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_j3_nom.Location = New System.Drawing.Point(1, 1)
        Me.lbl_j3_nom.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_j3_nom.Name = "lbl_j3_nom"
        Me.lbl_j3_nom.Size = New System.Drawing.Size(112, 45)
        Me.lbl_j3_nom.TabIndex = 0
        Me.lbl_j3_nom.Text = "NOM J3"
        Me.lbl_j3_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_j3_score
        '
        Me.lbl_j3_score.AutoSize = True
        Me.lbl_j3_score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_j3_score.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_j3_score.Location = New System.Drawing.Point(117, 1)
        Me.lbl_j3_score.Name = "lbl_j3_score"
        Me.lbl_j3_score.Size = New System.Drawing.Size(107, 45)
        Me.lbl_j3_score.TabIndex = 1
        Me.lbl_j3_score.Text = "SCORE J3"
        Me.lbl_j3_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pannelj4
        '
        Me.pannelj4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pannelj4.ColumnCount = 2
        Me.pannelj4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj4.Controls.Add(Me.lbl_j4_nom, 0, 0)
        Me.pannelj4.Controls.Add(Me.lbl_j4_score, 1, 0)
        Me.pannelj4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj4.Location = New System.Drawing.Point(3, 162)
        Me.pannelj4.Name = "pannelj4"
        Me.pannelj4.RowCount = 1
        Me.pannelj4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj4.Size = New System.Drawing.Size(228, 47)
        Me.pannelj4.TabIndex = 3
        '
        'lbl_j4_nom
        '
        Me.lbl_j4_nom.AutoSize = True
        Me.lbl_j4_nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_j4_nom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_j4_nom.Location = New System.Drawing.Point(1, 1)
        Me.lbl_j4_nom.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_j4_nom.Name = "lbl_j4_nom"
        Me.lbl_j4_nom.Size = New System.Drawing.Size(112, 45)
        Me.lbl_j4_nom.TabIndex = 0
        Me.lbl_j4_nom.Text = "NOM J4"
        Me.lbl_j4_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_j4_score
        '
        Me.lbl_j4_score.AutoSize = True
        Me.lbl_j4_score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_j4_score.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_j4_score.Location = New System.Drawing.Point(117, 1)
        Me.lbl_j4_score.Name = "lbl_j4_score"
        Me.lbl_j4_score.Size = New System.Drawing.Size(107, 45)
        Me.lbl_j4_score.TabIndex = 1
        Me.lbl_j4_score.Text = "SCORE J4"
        Me.lbl_j4_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel_tour
        '
        Me.panel_tour.ColumnCount = 1
        Me.panel_tour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panel_tour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panel_tour.Controls.Add(Me.lbl_tourJoueur, 0, 0)
        Me.panel_tour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_tour.Location = New System.Drawing.Point(1013, 589)
        Me.panel_tour.Name = "panel_tour"
        Me.panel_tour.RowCount = 1
        Me.panel_tour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panel_tour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.panel_tour.Size = New System.Drawing.Size(248, 141)
        Me.panel_tour.TabIndex = 8
        '
        'lbl_tourJoueur
        '
        Me.lbl_tourJoueur.AutoEllipsis = True
        Me.lbl_tourJoueur.AutoSize = True
        Me.lbl_tourJoueur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_tourJoueur.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tourJoueur.Location = New System.Drawing.Point(3, 0)
        Me.lbl_tourJoueur.Margin = New System.Windows.Forms.Padding(3, 0, 3, 100)
        Me.lbl_tourJoueur.Name = "lbl_tourJoueur"
        Me.lbl_tourJoueur.Size = New System.Drawing.Size(242, 41)
        Me.lbl_tourJoueur.TabIndex = 0
        Me.lbl_tourJoueur.Text = "Tour de "
        '
        'panel_pioche
        '
        Me.panel_pioche.ColumnCount = 2
        Me.panel_pioche.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panel_pioche.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panel_pioche.Controls.Add(Me.lbl_pioche, 0, 0)
        Me.panel_pioche.Controls.Add(Me.picBox_pioche, 1, 0)
        Me.panel_pioche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_pioche.Location = New System.Drawing.Point(3, 589)
        Me.panel_pioche.Name = "panel_pioche"
        Me.panel_pioche.RowCount = 1
        Me.panel_pioche.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panel_pioche.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.panel_pioche.Size = New System.Drawing.Size(246, 141)
        Me.panel_pioche.TabIndex = 9
        '
        'lbl_pioche
        '
        Me.lbl_pioche.AutoSize = True
        Me.lbl_pioche.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pioche.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pioche.Location = New System.Drawing.Point(50, 0)
        Me.lbl_pioche.Margin = New System.Windows.Forms.Padding(50, 0, 3, 0)
        Me.lbl_pioche.Name = "lbl_pioche"
        Me.lbl_pioche.Size = New System.Drawing.Size(69, 25)
        Me.lbl_pioche.TabIndex = 0
        Me.lbl_pioche.Text = "Pioche"
        Me.lbl_pioche.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picBox_pioche
        '
        Me.picBox_pioche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox_pioche.Image = Global.Qwirkle.My.Resources.Resources.CarreBleu
        Me.picBox_pioche.Location = New System.Drawing.Point(126, 3)
        Me.picBox_pioche.Name = "picBox_pioche"
        Me.picBox_pioche.Size = New System.Drawing.Size(117, 135)
        Me.picBox_pioche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox_pioche.TabIndex = 1
        Me.picBox_pioche.TabStop = False
        '
        'frm_jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 733)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_jeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.grille_1_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.pannelj1.ResumeLayout(False)
        Me.pannelj1.PerformLayout()
        Me.pannelj2.ResumeLayout(False)
        Me.pannelj2.PerformLayout()
        Me.pannelj3.ResumeLayout(False)
        Me.pannelj3.PerformLayout()
        Me.pannelj4.ResumeLayout(False)
        Me.pannelj4.PerformLayout()
        Me.panel_tour.ResumeLayout(False)
        Me.panel_tour.PerformLayout()
        Me.panel_pioche.ResumeLayout(False)
        Me.panel_pioche.PerformLayout()
        CType(Me.picBox_pioche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_abandonner As Button
    Friend WithEvents btn_recommencer As Button
    Friend WithEvents btn_aide As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_confirmer As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents picBox6 As PictureBox
    Friend WithEvents picBox5 As PictureBox
    Friend WithEvents picBox4 As PictureBox
    Friend WithEvents picBox3 As PictureBox
    Friend WithEvents picBox2 As PictureBox
    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents pannelj1 As TableLayoutPanel
    Friend WithEvents pannelj2 As TableLayoutPanel
    Friend WithEvents pannelj3 As TableLayoutPanel
    Friend WithEvents pannelj4 As TableLayoutPanel
    Friend WithEvents lbl_j1_nom As Label
    Friend WithEvents lbl_j1_score As Label
    Friend WithEvents lbl_j2_nom As Label
    Friend WithEvents lbl_j2_score As Label
    Friend WithEvents lbl_j3_nom As Label
    Friend WithEvents lbl_j3_score As Label
    Friend WithEvents lbl_j4_nom As Label
    Friend WithEvents lbl_j4_score As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents grille_1_1 As PictureBox
    Friend WithEvents panel_tour As TableLayoutPanel
    Friend WithEvents lbl_tourJoueur As Label
    Friend WithEvents panel_pioche As TableLayoutPanel
    Friend WithEvents lbl_pioche As Label
    Friend WithEvents picBox_pioche As PictureBox
End Class

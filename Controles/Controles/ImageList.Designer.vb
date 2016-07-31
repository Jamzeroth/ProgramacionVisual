<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageList))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "3d_bars-2560x1440.jpg")
        Me.ImageList1.Images.SetKeyName(1, "377068-sepik.jpg")
        Me.ImageList1.Images.SetKeyName(2, "9606353_xl.jpg")
        Me.ImageList1.Images.SetKeyName(3, "19767362_l.jpg")
        Me.ImageList1.Images.SetKeyName(4, "abstract-cubes-minimalistic-shapes-simple-background-2794845-1920x1200.png")
        Me.ImageList1.Images.SetKeyName(5, "AE0.jpg")
        Me.ImageList1.Images.SetKeyName(6, "amazing-surreal-hunger-wide-hd-wallpaper-for-desktop-image-free-download.jpg")
        Me.ImageList1.Images.SetKeyName(7, "barco-en-una-botella-10655.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Best-Wallpapers_Pack4-5.jpg")
        Me.ImageList1.Images.SetKeyName(9, "bodyBg3.jpg")
        Me.ImageList1.Images.SetKeyName(10, "cityscapes_day_buildings_surreal_desktop_2800x1600_wallpaper-440430.jpg")
        Me.ImageList1.Images.SetKeyName(11, "Color-Retro-Wallpaper-Images.jpg")
        Me.ImageList1.Images.SetKeyName(12, "ewfwef.png")
        Me.ImageList1.Images.SetKeyName(13, "fantasy_architecture_surreal_art_cities_cthulhus_city_impossible_desktop_1600x120" & _
        "0_hd-wallpaper-1243452.jpg")
        Me.ImageList1.Images.SetKeyName(14, "fsdfsdf.jpg")
        Me.ImageList1.Images.SetKeyName(15, "fy4DrQe.jpg")
        Me.ImageList1.Images.SetKeyName(16, "last_rays_2560x1440.jpg")
        Me.ImageList1.Images.SetKeyName(17, "Lightbulbs-bulb-graphic-hd-wallpaper-of-3d-graphic-1800x2880.jpg")
        Me.ImageList1.Images.SetKeyName(18, "maintenanceBg.jpg")
        Me.ImageList1.Images.SetKeyName(19, "minimalist_metal_wallpaper_by_malkowitch-d5k14s4.jpg")
        Me.ImageList1.Images.SetKeyName(20, "new-wallpaper-16.jpg")
        Me.ImageList1.Images.SetKeyName(21, "no_mans_sky_game.jpg")
        Me.ImageList1.Images.SetKeyName(22, "TBH_Still_014.jpg")
        Me.ImageList1.Images.SetKeyName(23, "urefwefl.jpg")
        Me.ImageList1.Images.SetKeyName(24, "wallpaper_21.jpg")
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Button1
        '
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(100, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ImageList"
        Me.Text = "ImageList"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
